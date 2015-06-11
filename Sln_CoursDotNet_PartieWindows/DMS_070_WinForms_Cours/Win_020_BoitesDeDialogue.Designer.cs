namespace DMS_070_WinForms_Cours
{
    partial class Win_020_BoitesDeDialogue
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
            this.btn_Messages = new System.Windows.Forms.Button();
            this.btn_Quitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Messages
            // 
            this.btn_Messages.Location = new System.Drawing.Point(77, 65);
            this.btn_Messages.Name = "btn_Messages";
            this.btn_Messages.Size = new System.Drawing.Size(148, 23);
            this.btn_Messages.TabIndex = 0;
            this.btn_Messages.Text = "Boites de dialogue";
            this.btn_Messages.UseVisualStyleBackColor = true;
            this.btn_Messages.Click += new System.EventHandler(this.btn_Messages_Click);
            // 
            // btn_Quitter
            // 
            this.btn_Quitter.Location = new System.Drawing.Point(108, 109);
            this.btn_Quitter.Name = "btn_Quitter";
            this.btn_Quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_Quitter.TabIndex = 1;
            this.btn_Quitter.Text = "&Quitter";
            this.btn_Quitter.UseVisualStyleBackColor = true;
            this.btn_Quitter.Click += new System.EventHandler(this.btn_Quitter_Click);
            // 
            // Win_020_BoitesDeDialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Quitter);
            this.Controls.Add(this.btn_Messages);
            this.Name = "Win_020_BoitesDeDialogue";
            this.Text = "Win_020_BoitesDeDialogue";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Messages;
        private System.Windows.Forms.Button btn_Quitter;
    }
}