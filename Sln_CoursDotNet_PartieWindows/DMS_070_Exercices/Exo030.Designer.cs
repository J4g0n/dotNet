namespace DMS_070_Exercices
{
    partial class Exo030
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
            this.cmb_Entrees = new System.Windows.Forms.ComboBox();
            this.cmb_Desserts = new System.Windows.Forms.ComboBox();
            this.cmb_Plats = new System.Windows.Forms.ComboBox();
            this.lst_Menu = new System.Windows.Forms.ListView();
            this.Menu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cmb_Entrees
            // 
            this.cmb_Entrees.FormattingEnabled = true;
            this.cmb_Entrees.Items.AddRange(new object[] {
            "Carottes rapées",
            "Tomates au basilic",
            "Raviolis chinois",
            "Salade de chou"});
            this.cmb_Entrees.Location = new System.Drawing.Point(62, 74);
            this.cmb_Entrees.Name = "cmb_Entrees";
            this.cmb_Entrees.Size = new System.Drawing.Size(121, 21);
            this.cmb_Entrees.TabIndex = 0;
            this.cmb_Entrees.SelectedIndexChanged += new System.EventHandler(this.cmb_Entrees_SelectedIndexChanged);
            // 
            // cmb_Desserts
            // 
            this.cmb_Desserts.FormattingEnabled = true;
            this.cmb_Desserts.Items.AddRange(new object[] {
            "Banana split",
            "Poire Belle Hélène"});
            this.cmb_Desserts.Location = new System.Drawing.Point(62, 290);
            this.cmb_Desserts.Name = "cmb_Desserts";
            this.cmb_Desserts.Size = new System.Drawing.Size(121, 21);
            this.cmb_Desserts.TabIndex = 1;
            this.cmb_Desserts.SelectedIndexChanged += new System.EventHandler(this.cmb_Desserts_SelectedIndexChanged);
            // 
            // cmb_Plats
            // 
            this.cmb_Plats.FormattingEnabled = true;
            this.cmb_Plats.Items.AddRange(new object[] {
            "Raclette",
            "Sushis",
            "Falafels",
            "Boeuf bourguignon"});
            this.cmb_Plats.Location = new System.Drawing.Point(62, 174);
            this.cmb_Plats.Name = "cmb_Plats";
            this.cmb_Plats.Size = new System.Drawing.Size(121, 21);
            this.cmb_Plats.TabIndex = 2;
            this.cmb_Plats.SelectedIndexChanged += new System.EventHandler(this.cmb_Plats_SelectedIndexChanged);
            // 
            // lst_Menu
            // 
            this.lst_Menu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Menu});
            this.lst_Menu.Location = new System.Drawing.Point(291, 74);
            this.lst_Menu.Name = "lst_Menu";
            this.lst_Menu.Size = new System.Drawing.Size(151, 237);
            this.lst_Menu.TabIndex = 3;
            this.lst_Menu.UseCompatibleStateImageBehavior = false;
            this.lst_Menu.View = System.Windows.Forms.View.List;
            // 
            // Exo030
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 462);
            this.Controls.Add(this.lst_Menu);
            this.Controls.Add(this.cmb_Plats);
            this.Controls.Add(this.cmb_Desserts);
            this.Controls.Add(this.cmb_Entrees);
            this.Name = "Exo030";
            this.Text = "Exo030";
            this.Load += new System.EventHandler(this.Exo030_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Entrees;
        private System.Windows.Forms.ComboBox cmb_Desserts;
        private System.Windows.Forms.ComboBox cmb_Plats;
        private System.Windows.Forms.ListView lst_Menu;
        private System.Windows.Forms.ColumnHeader Menu;
    }
}