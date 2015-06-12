namespace DMS_070_WinForms_Cours
{
    partial class Win_070_AccesBD_Fiches
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_Numero = new System.Windows.Forms.Label();
            this.txt_Numero = new System.Windows.Forms.TextBox();
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Titre.Location = new System.Drawing.Point(37, 35);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(450, 26);
            this.lbl_Titre.TabIndex = 0;
            this.lbl_Titre.Text = "Accéder à la base de donnée manuellement: ";
            // 
            // lbl_Numero
            // 
            this.lbl_Numero.AutoSize = true;
            this.lbl_Numero.Location = new System.Drawing.Point(39, 124);
            this.lbl_Numero.Name = "lbl_Numero";
            this.lbl_Numero.Size = new System.Drawing.Size(92, 13);
            this.lbl_Numero.TabIndex = 1;
            this.lbl_Numero.Text = "Numero employé: ";
            // 
            // txt_Numero
            // 
            this.txt_Numero.Location = new System.Drawing.Point(276, 124);
            this.txt_Numero.MaxLength = 20;
            this.txt_Numero.Name = "txt_Numero";
            this.txt_Numero.Size = new System.Drawing.Size(211, 20);
            this.txt_Numero.TabIndex = 3;
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(191, 191);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(148, 23);
            this.btn_Rechercher.TabIndex = 4;
            this.btn_Rechercher.Text = "Rechercher";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(42, 295);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_Nom.TabIndex = 5;
            this.lbl_Nom.Text = "Nom";
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(45, 393);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_Prenom.TabIndex = 6;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(276, 295);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(211, 20);
            this.txt_Nom.TabIndex = 7;
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(276, 386);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(211, 20);
            this.txt_Prenom.TabIndex = 8;
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(191, 458);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(148, 23);
            this.btn_Quitter.TabIndex = 9;
            this.btn_Quitter.Text = "&Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // Win_070_AccesBD_Fiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 493);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.txt_Numero);
            this.Controls.Add(this.lbl_Numero);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "Win_070_AccesBD_Fiches";
            this.Text = "Win_070_AccesBD_Fiches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_Numero;
        private System.Windows.Forms.TextBox txt_Numero;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.Button btn_Quitter;
    }
}