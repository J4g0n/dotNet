namespace DMS_070_WinForms_Cours
{
    partial class Win_010_Bienvenue
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
            this.btn_Bienvenue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bienvenue
            // 
            this.btn_Bienvenue.Location = new System.Drawing.Point(37, 28);
            this.btn_Bienvenue.Name = "btn_Bienvenue";
            this.btn_Bienvenue.Size = new System.Drawing.Size(75, 23);
            this.btn_Bienvenue.TabIndex = 0;
            this.btn_Bienvenue.Text = "Bienvenue";
            this.btn_Bienvenue.UseVisualStyleBackColor = true;
            this.btn_Bienvenue.Click += new System.EventHandler(this.btn_Bienvenue_Click);
            // 
            // Win_010_Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 238);
            this.Controls.Add(this.btn_Bienvenue);
            this.Name = "Win_010_Bienvenue";
            this.Text = "Bienvenue";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bienvenue;
    }
}

