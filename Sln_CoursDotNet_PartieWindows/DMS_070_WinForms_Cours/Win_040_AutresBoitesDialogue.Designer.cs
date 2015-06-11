namespace DMS_070_WinForms_Cours
{
    partial class Win_040_AutresBoitesDialogue
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
            this.btn_SelecteurFichier = new System.Windows.Forms.Button();
            this.btn_ChoisirCouleur = new System.Windows.Forms.Button();
            this.img_Article = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Couleur = new System.Windows.Forms.Label();
            this.SelecteurFichier = new System.Windows.Forms.OpenFileDialog();
            this.SelecteurCouleur = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.img_Article)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SelecteurFichier
            // 
            this.btn_SelecteurFichier.Location = new System.Drawing.Point(76, 60);
            this.btn_SelecteurFichier.Name = "btn_SelecteurFichier";
            this.btn_SelecteurFichier.Size = new System.Drawing.Size(124, 23);
            this.btn_SelecteurFichier.TabIndex = 0;
            this.btn_SelecteurFichier.Text = "Choisir une image";
            this.btn_SelecteurFichier.UseVisualStyleBackColor = true;
            this.btn_SelecteurFichier.Click += new System.EventHandler(this.btn_SelecteurFichier_Click);
            // 
            // btn_ChoisirCouleur
            // 
            this.btn_ChoisirCouleur.Location = new System.Drawing.Point(76, 230);
            this.btn_ChoisirCouleur.Name = "btn_ChoisirCouleur";
            this.btn_ChoisirCouleur.Size = new System.Drawing.Size(124, 23);
            this.btn_ChoisirCouleur.TabIndex = 1;
            this.btn_ChoisirCouleur.Text = "Choisir une couleur";
            this.btn_ChoisirCouleur.UseVisualStyleBackColor = true;
            this.btn_ChoisirCouleur.Click += new System.EventHandler(this.btn_ChoisirCouleur_Click);
            // 
            // img_Article
            // 
            this.img_Article.Location = new System.Drawing.Point(246, 22);
            this.img_Article.Name = "img_Article";
            this.img_Article.Size = new System.Drawing.Size(240, 186);
            this.img_Article.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_Article.TabIndex = 2;
            this.img_Article.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lbl_Couleur
            // 
            this.lbl_Couleur.AutoSize = true;
            this.lbl_Couleur.Location = new System.Drawing.Point(243, 214);
            this.lbl_Couleur.MaximumSize = new System.Drawing.Size(100, 100);
            this.lbl_Couleur.MinimumSize = new System.Drawing.Size(100, 100);
            this.lbl_Couleur.Name = "lbl_Couleur";
            this.lbl_Couleur.Size = new System.Drawing.Size(100, 100);
            this.lbl_Couleur.TabIndex = 4;
            // 
            // SelecteurFichier
            // 
            this.SelecteurFichier.FileName = "openFileDialog1";
            // 
            // Win_040_AutresBoitesDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.lbl_Couleur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.img_Article);
            this.Controls.Add(this.btn_ChoisirCouleur);
            this.Controls.Add(this.btn_SelecteurFichier);
            this.Name = "Win_040_AutresBoitesDialogue";
            this.Text = "Win_040_AutresBoitesDialogue";
            this.Load += new System.EventHandler(this.Win_040_AutresBoitesDialogue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Article)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SelecteurFichier;
        private System.Windows.Forms.Button btn_ChoisirCouleur;
        private System.Windows.Forms.PictureBox img_Article;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Couleur;
        private System.Windows.Forms.OpenFileDialog SelecteurFichier;
        private System.Windows.Forms.ColorDialog SelecteurCouleur;
    }
}