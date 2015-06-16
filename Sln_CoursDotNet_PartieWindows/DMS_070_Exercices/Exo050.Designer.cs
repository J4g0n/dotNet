namespace DMS_070_Exercices
{
    partial class Exo050
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
            this.pbox_Photo = new System.Windows.Forms.PictureBox();
            this.lst_Noms = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbox_Photo
            // 
            this.pbox_Photo.Location = new System.Drawing.Point(425, 38);
            this.pbox_Photo.Name = "pbox_Photo";
            this.pbox_Photo.Size = new System.Drawing.Size(184, 264);
            this.pbox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_Photo.TabIndex = 0;
            this.pbox_Photo.TabStop = false;
            // 
            // lst_Noms
            // 
            this.lst_Noms.FormattingEnabled = true;
            this.lst_Noms.Items.AddRange(new object[] {
            "simon",
            "clément",
            "amélie",
            "laetitia",
            "jean",
            "johnny"});
            this.lst_Noms.Location = new System.Drawing.Point(42, 38);
            this.lst_Noms.Name = "lst_Noms";
            this.lst_Noms.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_Noms.Size = new System.Drawing.Size(206, 264);
            this.lst_Noms.TabIndex = 1;
            this.lst_Noms.SelectedIndexChanged += new System.EventHandler(this.lst_Noms_SelectedIndexChanged);
            // 
            // Exo050
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 366);
            this.Controls.Add(this.lst_Noms);
            this.Controls.Add(this.pbox_Photo);
            this.Name = "Exo050";
            this.Load += new System.EventHandler(this.Exo050_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_Photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_Photo;
        private System.Windows.Forms.ListBox lst_Noms;
    }
}