using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labo2
{
    public partial class Form1 : Form
    {

        private double moyenne = 0;
        private double ecart = 0;
        private double valeurA = 0;
        private double valeurB = 0;
        private double resultat = 0;
        private const double EPSILON = 0.01;
        private const double COTE_MAX = 4.0;

        public Form1()
        {
            InitializeComponent();
        }

        private List<List<double>> tab = new List<List<double>>();
        private string FileName = "Loi_normale.txt";
        private const int TABWIDTH = 11;

        #region "ReadFrom File"

        private void ReadFile(string url)
        {
            try
            {
                tab.Clear();
                string[] lines = System.IO.File.ReadAllLines(url);
                foreach (string line in lines)
                {
                    List<double> temp = new List<double>();
                    string[] tokens = line.Split(';');
                    for(int i = 0; i < TABWIDTH; ++i)
                    {
                        temp.Add(Double.Parse(tokens[i], System.Globalization.CultureInfo.InvariantCulture));
                    }
                    tab.Add(temp);
                }
                this.Refresh();
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        #endregion
        //parcoure la liste de probabilités et retourne la valeur appropriée
        private double ParcourirLoiNormale(double nb)
        {
            double probabilite = 0;

            for (int i = 0; i < tab.Count; ++i)
            {
                if (nb - tab[i][0] < 0.09 || nb - tab[i][0] <= 0)
                {
                    for (int j = 1; j < tab[i].Count; ++j)
                    {
                        if (nb - (tab[i][0] + (j * 0.01)) <= EPSILON)
                        {
                            return tab[i][j];
                        }
                    }
                }
            }
            return probabilite;
        }

        //calcul de la probabilité
        private void Calculer()
        {
            double cote1 = 0.0;
            double cote2 = 0.0;
            moyenne = Double.Parse(TB_Moyenne.Text);
            ecart = Double.Parse(TB_Ecart.Text);
            valeurA = Double.Parse(TB_ValeurA.Text);

            if (TB_ValeurB.Text != "")
            {
                valeurB = Double.Parse(TB_ValeurB.Text);
                cote2 = Math.Abs((valeurB - moyenne) / ecart);
            }

            cote1 = Math.Round(Math.Abs((valeurA - moyenne) / ecart), 2);


            if (cote1 > COTE_MAX || cote2 > COTE_MAX)
            {
                throw new Exception("La cote Z est beaucoup trop élevée!");
            }
            switch (CB_Choix.SelectedIndex)
            {
                case 0:
                    if (valeurA < moyenne)
                    {
                        resultat = 1 - ParcourirLoiNormale(cote1);
                    }
                    else
                    {
                        resultat = ParcourirLoiNormale(cote1);
                    }
                    break;
                case 1:
                    if (valeurA < moyenne)
                    {
                        resultat = ParcourirLoiNormale(cote1);
                    }
                    else
                    {
                        resultat = 1 - ParcourirLoiNormale(cote1);
                    }
                    break;
                case 2:
                    if (moyenne < valeurA && valeurA < valeurB)
                    {
                        resultat = ParcourirLoiNormale(cote2) - ParcourirLoiNormale(cote1);

                    }
                    if (valeurA < valeurB && valeurB < moyenne)
                    {
                        resultat = (1 - ParcourirLoiNormale(cote2)) - (1 - ParcourirLoiNormale(cote1));

                    }
                    if (valeurA < moyenne && moyenne < valeurB)
                    {
                        resultat = (1 - ParcourirLoiNormale(cote2)) - ParcourirLoiNormale(cote1);
                    }
                    break;
            }
            TB_Resultat.Text = (resultat*100).ToString() + "%";
        }
        private void InitialiserChoix()
        {
            CB_Choix.Items.Add("P(x > a)");
            CB_Choix.Items.Add("P(x < a)");
            CB_Choix.Items.Add("P(a < x < b)");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile(FileName);
            InitialiserChoix();
        }

        private void BTN_Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                Calculer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
