namespace DMS_070_Exercices
{
    partial class Exo040
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
            this.btn_OuvrirExcel = new System.Windows.Forms.Button();
            this.txt_Notes = new System.Windows.Forms.TextBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_OuvrirExcel
            // 
            this.btn_OuvrirExcel.Location = new System.Drawing.Point(102, 39);
            this.btn_OuvrirExcel.Name = "btn_OuvrirExcel";
            this.btn_OuvrirExcel.Size = new System.Drawing.Size(75, 23);
            this.btn_OuvrirExcel.TabIndex = 0;
            this.btn_OuvrirExcel.Text = "Ouvrir excel";
            this.btn_OuvrirExcel.UseVisualStyleBackColor = true;
            this.btn_OuvrirExcel.Click += new System.EventHandler(this.btn_OuvrirExcel_Click);
            // 
            // txt_Notes
            // 
            this.txt_Notes.Location = new System.Drawing.Point(102, 99);
            this.txt_Notes.Name = "txt_Notes";
            this.txt_Notes.Size = new System.Drawing.Size(100, 20);
            this.txt_Notes.TabIndex = 1;
            this.txt_Notes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Notes_KeyPress);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(102, 164);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_Enregistrer.TabIndex = 2;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // Exo040
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.txt_Notes);
            this.Controls.Add(this.btn_OuvrirExcel);
            this.Name = "Exo040";
            this.Text = "Exo040";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_OuvrirExcel;
        private System.Windows.Forms.TextBox txt_Notes;
        private System.Windows.Forms.Button btn_Enregistrer;
    }
}