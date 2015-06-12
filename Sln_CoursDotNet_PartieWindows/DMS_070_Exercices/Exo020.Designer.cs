namespace DMS_070_Exercices
{
    partial class Exo020
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
            this.lbl_NomMachine = new System.Windows.Forms.Label();
            this.lbl_AddressIP = new System.Windows.Forms.Label();
            this.lbl_User = new System.Windows.Forms.Label();
            this.lbl_NomReseau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_NomMachine
            // 
            this.lbl_NomMachine.AutoSize = true;
            this.lbl_NomMachine.Location = new System.Drawing.Point(13, 13);
            this.lbl_NomMachine.Name = "lbl_NomMachine";
            this.lbl_NomMachine.Size = new System.Drawing.Size(0, 13);
            this.lbl_NomMachine.TabIndex = 0;
            // 
            // lbl_AddressIP
            // 
            this.lbl_AddressIP.AutoSize = true;
            this.lbl_AddressIP.Location = new System.Drawing.Point(12, 78);
            this.lbl_AddressIP.Name = "lbl_AddressIP";
            this.lbl_AddressIP.Size = new System.Drawing.Size(0, 13);
            this.lbl_AddressIP.TabIndex = 1;
            // 
            // lbl_User
            // 
            this.lbl_User.AutoSize = true;
            this.lbl_User.Location = new System.Drawing.Point(13, 152);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(0, 13);
            this.lbl_User.TabIndex = 2;
            // 
            // lbl_NomReseau
            // 
            this.lbl_NomReseau.AutoSize = true;
            this.lbl_NomReseau.Location = new System.Drawing.Point(12, 226);
            this.lbl_NomReseau.Name = "lbl_NomReseau";
            this.lbl_NomReseau.Size = new System.Drawing.Size(0, 13);
            this.lbl_NomReseau.TabIndex = 3;
            // 
            // Exo020
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbl_NomReseau);
            this.Controls.Add(this.lbl_User);
            this.Controls.Add(this.lbl_AddressIP);
            this.Controls.Add(this.lbl_NomMachine);
            this.Name = "Exo020";
            this.Text = "Exo020";
            this.Load += new System.EventHandler(this.Exo020_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_NomMachine;
        private System.Windows.Forms.Label lbl_AddressIP;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.Label lbl_NomReseau;
    }
}