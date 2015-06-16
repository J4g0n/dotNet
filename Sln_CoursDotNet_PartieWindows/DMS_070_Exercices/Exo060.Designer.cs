namespace DMS_070_Exercices
{
    partial class Exo060
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
            this.lst_Personnes = new System.Windows.Forms.ListBox();
            this.pbox_Photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // lst_Personnes
            // 
            this.lst_Personnes.FormattingEnabled = true;
            this.lst_Personnes.Location = new System.Drawing.Point(12, 55);
            this.lst_Personnes.Name = "lst_Personnes";
            this.lst_Personnes.Size = new System.Drawing.Size(120, 186);
            this.lst_Personnes.TabIndex = 0;
            this.lst_Personnes.SelectedIndexChanged += new System.EventHandler(this.lst_Personnes_SelectedIndexChanged);
            // 
            // pbox_Photo
            // 
            this.pbox_Photo.Location = new System.Drawing.Point(217, 55);
            this.pbox_Photo.Name = "pbox_Photo";
            this.pbox_Photo.Size = new System.Drawing.Size(127, 186);
            this.pbox_Photo.TabIndex = 1;
            this.pbox_Photo.TabStop = false;
            // 
            // Exo060
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 262);
            this.Controls.Add(this.pbox_Photo);
            this.Controls.Add(this.lst_Personnes);
            this.Name = "Exo060";
            this.Text = "Exo060";
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_Personnes;
        private System.Windows.Forms.PictureBox pbox_Photo;
    }
}