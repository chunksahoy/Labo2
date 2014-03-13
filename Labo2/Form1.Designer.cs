namespace Labo2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTN_Calculate = new System.Windows.Forms.Button();
            this.TB_Average = new System.Windows.Forms.Label();
            this.BTN_Ecart = new System.Windows.Forms.Label();
            this.TB_Value = new System.Windows.Forms.Label();
            this.TB_Result = new System.Windows.Forms.Label();
            this.TB_Moyenne = new System.Windows.Forms.TextBox();
            this.TB_Ecart = new System.Windows.Forms.TextBox();
            this.TB_Resultat = new System.Windows.Forms.TextBox();
            this.CB_Choix = new System.Windows.Forms.ComboBox();
            this.LBL_Valeur = new System.Windows.Forms.Label();
            this.TB_ValeurA = new System.Windows.Forms.TextBox();
            this.TB_ValeurB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTN_Calculate
            // 
            this.BTN_Calculate.Location = new System.Drawing.Point(230, 62);
            this.BTN_Calculate.Name = "BTN_Calculate";
            this.BTN_Calculate.Size = new System.Drawing.Size(100, 49);
            this.BTN_Calculate.TabIndex = 1;
            this.BTN_Calculate.Text = "Calculer";
            this.BTN_Calculate.UseVisualStyleBackColor = true;
            this.BTN_Calculate.Click += new System.EventHandler(this.BTN_Calculate_Click);
            // 
            // TB_Average
            // 
            this.TB_Average.AutoSize = true;
            this.TB_Average.Location = new System.Drawing.Point(20, 15);
            this.TB_Average.Name = "TB_Average";
            this.TB_Average.Size = new System.Drawing.Size(54, 13);
            this.TB_Average.TabIndex = 2;
            this.TB_Average.Text = "Moyenne:";
            // 
            // BTN_Ecart
            // 
            this.BTN_Ecart.AutoSize = true;
            this.BTN_Ecart.Location = new System.Drawing.Point(12, 41);
            this.BTN_Ecart.Name = "BTN_Ecart";
            this.BTN_Ecart.Size = new System.Drawing.Size(62, 13);
            this.BTN_Ecart.TabIndex = 2;
            this.BTN_Ecart.Text = "Écart-Type:";
            // 
            // TB_Value
            // 
            this.TB_Value.AutoSize = true;
            this.TB_Value.Location = new System.Drawing.Point(38, 67);
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.Size = new System.Drawing.Size(36, 13);
            this.TB_Value.TabIndex = 2;
            this.TB_Value.Text = "Choix:";
            // 
            // TB_Result
            // 
            this.TB_Result.AutoSize = true;
            this.TB_Result.Location = new System.Drawing.Point(25, 94);
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(49, 13);
            this.TB_Result.TabIndex = 2;
            this.TB_Result.Text = "Résultat:";
            // 
            // TB_Moyenne
            // 
            this.TB_Moyenne.Location = new System.Drawing.Point(80, 12);
            this.TB_Moyenne.Name = "TB_Moyenne";
            this.TB_Moyenne.Size = new System.Drawing.Size(61, 20);
            this.TB_Moyenne.TabIndex = 3;
            // 
            // TB_Ecart
            // 
            this.TB_Ecart.Location = new System.Drawing.Point(80, 38);
            this.TB_Ecart.Name = "TB_Ecart";
            this.TB_Ecart.Size = new System.Drawing.Size(61, 20);
            this.TB_Ecart.TabIndex = 3;
            // 
            // TB_Resultat
            // 
            this.TB_Resultat.Location = new System.Drawing.Point(80, 91);
            this.TB_Resultat.Name = "TB_Resultat";
            this.TB_Resultat.Size = new System.Drawing.Size(121, 20);
            this.TB_Resultat.TabIndex = 3;
            // 
            // CB_Choix
            // 
            this.CB_Choix.FormattingEnabled = true;
            this.CB_Choix.Location = new System.Drawing.Point(80, 64);
            this.CB_Choix.Name = "CB_Choix";
            this.CB_Choix.Size = new System.Drawing.Size(121, 21);
            this.CB_Choix.TabIndex = 4;
            // 
            // LBL_Valeur
            // 
            this.LBL_Valeur.AutoSize = true;
            this.LBL_Valeur.Location = new System.Drawing.Point(192, 15);
            this.LBL_Valeur.Name = "LBL_Valeur";
            this.LBL_Valeur.Size = new System.Drawing.Size(50, 13);
            this.LBL_Valeur.TabIndex = 2;
            this.LBL_Valeur.Text = "Valeur A:";
            // 
            // TB_ValeurA
            // 
            this.TB_ValeurA.Location = new System.Drawing.Point(248, 12);
            this.TB_ValeurA.Name = "TB_ValeurA";
            this.TB_ValeurA.Size = new System.Drawing.Size(61, 20);
            this.TB_ValeurA.TabIndex = 3;
            // 
            // TB_ValeurB
            // 
            this.TB_ValeurB.Location = new System.Drawing.Point(248, 38);
            this.TB_ValeurB.Name = "TB_ValeurB";
            this.TB_ValeurB.Size = new System.Drawing.Size(61, 20);
            this.TB_ValeurB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valeur B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 127);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_ValeurB);
            this.Controls.Add(this.CB_Choix);
            this.Controls.Add(this.TB_Resultat);
            this.Controls.Add(this.TB_ValeurA);
            this.Controls.Add(this.TB_Ecart);
            this.Controls.Add(this.TB_Moyenne);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.LBL_Valeur);
            this.Controls.Add(this.TB_Value);
            this.Controls.Add(this.BTN_Ecart);
            this.Controls.Add(this.TB_Average);
            this.Controls.Add(this.BTN_Calculate);
            this.Name = "Form1";
            this.Text = "Forme normale";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Calculate;
        private System.Windows.Forms.Label TB_Average;
        private System.Windows.Forms.Label BTN_Ecart;
        private System.Windows.Forms.Label TB_Value;
        private System.Windows.Forms.Label TB_Result;
        private System.Windows.Forms.TextBox TB_Moyenne;
        private System.Windows.Forms.TextBox TB_Ecart;
        private System.Windows.Forms.TextBox TB_Resultat;
        private System.Windows.Forms.ComboBox CB_Choix;
        private System.Windows.Forms.Label LBL_Valeur;
        private System.Windows.Forms.TextBox TB_ValeurA;
        private System.Windows.Forms.TextBox TB_ValeurB;
        private System.Windows.Forms.Label label1;
    }
}

