
namespace Calculatrice
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMultiplier = new System.Windows.Forms.Button();
            this.buttonMoins = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonDiviser = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.fondE = new System.Windows.Forms.Button();
            this.affichageSaisie = new System.Windows.Forms.Label();
            this.affichageResultat = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMultiplier
            // 
            this.buttonMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiplier.Location = new System.Drawing.Point(12, 192);
            this.buttonMultiplier.Name = "buttonMultiplier";
            this.buttonMultiplier.Size = new System.Drawing.Size(85, 43);
            this.buttonMultiplier.TabIndex = 2;
            this.buttonMultiplier.Text = "x";
            this.buttonMultiplier.UseVisualStyleBackColor = true;
            this.buttonMultiplier.Click += new System.EventHandler(this.button10_Click);
            // 
            // buttonMoins
            // 
            this.buttonMoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoins.Location = new System.Drawing.Point(12, 241);
            this.buttonMoins.Name = "buttonMoins";
            this.buttonMoins.Size = new System.Drawing.Size(85, 43);
            this.buttonMoins.TabIndex = 3;
            this.buttonMoins.Text = "-";
            this.buttonMoins.UseVisualStyleBackColor = true;
            this.buttonMoins.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlus.Location = new System.Drawing.Point(12, 290);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(85, 43);
            this.buttonPlus.TabIndex = 4;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonDiviser
            // 
            this.buttonDiviser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDiviser.Location = new System.Drawing.Point(12, 143);
            this.buttonDiviser.Name = "buttonDiviser";
            this.buttonDiviser.Size = new System.Drawing.Size(85, 43);
            this.buttonDiviser.TabIndex = 2;
            this.buttonDiviser.Text = "/";
            this.buttonDiviser.UseVisualStyleBackColor = true;
            this.buttonDiviser.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResult.Location = new System.Drawing.Point(146, 373);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(283, 56);
            this.buttonResult.TabIndex = 5;
            this.buttonResult.Text = "Resultat";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.button14_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(12, 373);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(128, 56);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.button15_Click);
            // 
            // fondE
            // 
            this.fondE.Enabled = false;
            this.fondE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.fondE.Location = new System.Drawing.Point(23, 21);
            this.fondE.Name = "fondE";
            this.fondE.Size = new System.Drawing.Size(377, 101);
            this.fondE.TabIndex = 7;
            this.fondE.UseVisualStyleBackColor = true;
            this.fondE.Click += new System.EventHandler(this.fondE_Click);
            // 
            // affichageSaisie
            // 
            this.affichageSaisie.AutoSize = true;
            this.affichageSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affichageSaisie.Location = new System.Drawing.Point(35, 31);
            this.affichageSaisie.Name = "affichageSaisie";
            this.affichageSaisie.Size = new System.Drawing.Size(16, 17);
            this.affichageSaisie.TabIndex = 8;
            this.affichageSaisie.Text = "0";
            this.affichageSaisie.Click += new System.EventHandler(this.affichageSaisie_Click);
            // 
            // affichageResultat
            // 
            this.affichageResultat.AutoSize = true;
            this.affichageResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.affichageResultat.Location = new System.Drawing.Point(61, 72);
            this.affichageResultat.Name = "affichageResultat";
            this.affichageResultat.Size = new System.Drawing.Size(36, 39);
            this.affichageResultat.TabIndex = 9;
            this.affichageResultat.Text = "0";
            this.affichageResultat.Click += new System.EventHandler(this.CalculResultat_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(215, 251);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 55);
            this.button2.TabIndex = 10;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(306, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 55);
            this.button3.TabIndex = 11;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(121, 190);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 55);
            this.button4.TabIndex = 12;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(215, 190);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 55);
            this.button5.TabIndex = 13;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(306, 190);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(85, 55);
            this.button6.TabIndex = 14;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(121, 129);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(85, 55);
            this.button7.TabIndex = 15;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(215, 129);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(85, 55);
            this.button8.TabIndex = 16;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(306, 129);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(85, 55);
            this.button9.TabIndex = 17;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(215, 312);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(85, 55);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 441);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.affichageResultat);
            this.Controls.Add(this.affichageSaisie);
            this.Controls.Add(this.fondE);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.buttonDiviser);
            this.Controls.Add(this.buttonMultiplier);
            this.Controls.Add(this.buttonMoins);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMultiplier;
        private System.Windows.Forms.Button buttonMoins;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonDiviser;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button fondE;
        private System.Windows.Forms.Label affichageSaisie;
        private System.Windows.Forms.Label affichageResultat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
    }
}

