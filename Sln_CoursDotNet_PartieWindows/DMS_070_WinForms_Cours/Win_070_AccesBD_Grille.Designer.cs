namespace DMS_070_WinForms_Cours
{
    partial class Win_070_AccesBD_Grille
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
            this.btn_Rechercher = new System.Windows.Forms.Button();
            this.grid_Customers = new System.Windows.Forms.DataGridView();
            this.codeClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raisonSociale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Titre.Location = new System.Drawing.Point(66, 20);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(520, 26);
            this.lbl_Titre.TabIndex = 1;
            this.lbl_Titre.Text = "Accéder à la base de donnée manuellement - Grille: ";
            // 
            // btn_Rechercher
            // 
            this.btn_Rechercher.Location = new System.Drawing.Point(503, 92);
            this.btn_Rechercher.Name = "btn_Rechercher";
            this.btn_Rechercher.Size = new System.Drawing.Size(115, 54);
            this.btn_Rechercher.TabIndex = 2;
            this.btn_Rechercher.Text = "Rechercher des clients et ses commandes";
            this.btn_Rechercher.UseVisualStyleBackColor = true;
            this.btn_Rechercher.Click += new System.EventHandler(this.btn_Rechercher_Click);
            // 
            // grid_Customers
            // 
            this.grid_Customers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Customers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeClient,
            this.raisonSociale,
            this.ville,
            this.pays});
            this.grid_Customers.Location = new System.Drawing.Point(34, 92);
            this.grid_Customers.Name = "grid_Customers";
            this.grid_Customers.Size = new System.Drawing.Size(453, 150);
            this.grid_Customers.TabIndex = 3;
            // 
            // codeClient
            // 
            this.codeClient.HeaderText = "Code client";
            this.codeClient.Name = "codeClient";
            this.codeClient.ReadOnly = true;
            // 
            // raisonSociale
            // 
            this.raisonSociale.HeaderText = "Raison sociale";
            this.raisonSociale.Name = "raisonSociale";
            this.raisonSociale.ReadOnly = true;
            // 
            // ville
            // 
            this.ville.HeaderText = "Ville";
            this.ville.Name = "ville";
            this.ville.ReadOnly = true;
            // 
            // pays
            // 
            this.pays.HeaderText = "Pays";
            this.pays.Name = "pays";
            this.pays.ReadOnly = true;
            // 
            // Win_070_AccesBD_Grille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 524);
            this.Controls.Add(this.grid_Customers);
            this.Controls.Add(this.btn_Rechercher);
            this.Controls.Add(this.lbl_Titre);
            this.Name = "Win_070_AccesBD_Grille";
            this.Text = "Win_070_AccesBD_Grille";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Customers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Button btn_Rechercher;
        private System.Windows.Forms.DataGridView grid_Customers;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn raisonSociale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn pays;
    }
}