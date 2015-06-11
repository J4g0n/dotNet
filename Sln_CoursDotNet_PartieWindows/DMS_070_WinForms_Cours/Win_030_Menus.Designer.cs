namespace DMS_070_WinForms_Cours
{
    partial class Win_030_Menus
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Quitter = new System.Windows.Forms.ToolStripMenuItem();
            this.formationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Gerer = new System.Windows.Forms.ToolStripMenuItem();
            this.opt_Imprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.formationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_Quitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // opt_Quitter
            // 
            this.opt_Quitter.Name = "opt_Quitter";
            this.opt_Quitter.Size = new System.Drawing.Size(152, 22);
            this.opt_Quitter.Text = "&Quitter";
            this.opt_Quitter.Click += new System.EventHandler(this.opt_Quitter_Click);
            // 
            // formationToolStripMenuItem
            // 
            this.formationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opt_Gerer,
            this.opt_Imprimer});
            this.formationToolStripMenuItem.Name = "formationToolStripMenuItem";
            this.formationToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.formationToolStripMenuItem.Text = "F&ormation";
            this.formationToolStripMenuItem.Click += new System.EventHandler(this.formationToolStripMenuItem_Click);
            // 
            // opt_Gerer
            // 
            this.opt_Gerer.Name = "opt_Gerer";
            this.opt_Gerer.Size = new System.Drawing.Size(158, 22);
            this.opt_Gerer.Text = "&Gérer formation";
            this.opt_Gerer.Click += new System.EventHandler(this.opt_Gerer_Click);
            // 
            // opt_Imprimer
            // 
            this.opt_Imprimer.Name = "opt_Imprimer";
            this.opt_Imprimer.Size = new System.Drawing.Size(158, 22);
            this.opt_Imprimer.Text = "&Imprimer";
            this.opt_Imprimer.Click += new System.EventHandler(this.opt_Imprimer_Click);
            // 
            // Win_030_Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Win_030_Menus";
            this.Text = "Win_030_Menus";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opt_Quitter;
        private System.Windows.Forms.ToolStripMenuItem formationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opt_Gerer;
        private System.Windows.Forms.ToolStripMenuItem opt_Imprimer;
    }
}