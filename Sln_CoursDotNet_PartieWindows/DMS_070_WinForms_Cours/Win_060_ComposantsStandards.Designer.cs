namespace DMS_070_WinForms_Cours
{
    partial class Win_060_ComposantsStandards
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
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.radio_Masculin = new System.Windows.Forms.RadioButton();
            this.radio_Feminin = new System.Windows.Forms.RadioButton();
            this.grp_Sexe = new System.Windows.Forms.GroupBox();
            this.grp_Loisirs = new System.Windows.Forms.GroupBox();
            this.chk_Sport = new System.Windows.Forms.CheckBox();
            this.chk_Voyages = new System.Windows.Forms.CheckBox();
            this.chk_Sorties = new System.Windows.Forms.CheckBox();
            this.cmb_SituationFamiliale = new System.Windows.Forms.ComboBox();
            this.lbl_SituationFamiliale = new System.Windows.Forms.Label();
            this.btn_Valider = new System.Windows.Forms.Button();
            this.grp_Sexe.SuspendLayout();
            this.grp_Loisirs.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(297, 39);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(146, 20);
            this.txt_Nom.TabIndex = 0;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Location = new System.Drawing.Point(71, 46);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_Nom.TabIndex = 1;
            this.lbl_Nom.Text = "Nom";
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Location = new System.Drawing.Point(297, 97);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(146, 20);
            this.txt_Prenom.TabIndex = 2;
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Location = new System.Drawing.Point(71, 104);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_Prenom.TabIndex = 3;
            this.lbl_Prenom.Text = "Prénom";
            // 
            // radio_Masculin
            // 
            this.radio_Masculin.AutoSize = true;
            this.radio_Masculin.Location = new System.Drawing.Point(20, 29);
            this.radio_Masculin.Name = "radio_Masculin";
            this.radio_Masculin.Size = new System.Drawing.Size(67, 17);
            this.radio_Masculin.TabIndex = 4;
            this.radio_Masculin.TabStop = true;
            this.radio_Masculin.Text = "Masculin";
            this.radio_Masculin.UseVisualStyleBackColor = true;
            // 
            // radio_Feminin
            // 
            this.radio_Feminin.AutoSize = true;
            this.radio_Feminin.Location = new System.Drawing.Point(20, 63);
            this.radio_Feminin.Name = "radio_Feminin";
            this.radio_Feminin.Size = new System.Drawing.Size(61, 17);
            this.radio_Feminin.TabIndex = 5;
            this.radio_Feminin.TabStop = true;
            this.radio_Feminin.Text = "Féminin";
            this.radio_Feminin.UseVisualStyleBackColor = true;
            // 
            // grp_Sexe
            // 
            this.grp_Sexe.Controls.Add(this.radio_Masculin);
            this.grp_Sexe.Controls.Add(this.radio_Feminin);
            this.grp_Sexe.Location = new System.Drawing.Point(74, 174);
            this.grp_Sexe.Name = "grp_Sexe";
            this.grp_Sexe.Size = new System.Drawing.Size(133, 100);
            this.grp_Sexe.TabIndex = 6;
            this.grp_Sexe.TabStop = false;
            this.grp_Sexe.Text = "Sexe";
            // 
            // grp_Loisirs
            // 
            this.grp_Loisirs.Controls.Add(this.chk_Sorties);
            this.grp_Loisirs.Controls.Add(this.chk_Voyages);
            this.grp_Loisirs.Controls.Add(this.chk_Sport);
            this.grp_Loisirs.Location = new System.Drawing.Point(297, 174);
            this.grp_Loisirs.Name = "grp_Loisirs";
            this.grp_Loisirs.Size = new System.Drawing.Size(146, 121);
            this.grp_Loisirs.TabIndex = 7;
            this.grp_Loisirs.TabStop = false;
            this.grp_Loisirs.Text = "Loisirs";
            // 
            // chk_Sport
            // 
            this.chk_Sport.AutoSize = true;
            this.chk_Sport.Location = new System.Drawing.Point(24, 29);
            this.chk_Sport.Name = "chk_Sport";
            this.chk_Sport.Size = new System.Drawing.Size(51, 17);
            this.chk_Sport.TabIndex = 0;
            this.chk_Sport.Text = "Sport";
            this.chk_Sport.UseVisualStyleBackColor = true;
            // 
            // chk_Voyages
            // 
            this.chk_Voyages.AutoSize = true;
            this.chk_Voyages.Location = new System.Drawing.Point(24, 64);
            this.chk_Voyages.Name = "chk_Voyages";
            this.chk_Voyages.Size = new System.Drawing.Size(67, 17);
            this.chk_Voyages.TabIndex = 1;
            this.chk_Voyages.Text = "Voyages";
            this.chk_Voyages.UseVisualStyleBackColor = true;
            // 
            // chk_Sorties
            // 
            this.chk_Sorties.AutoSize = true;
            this.chk_Sorties.Location = new System.Drawing.Point(24, 98);
            this.chk_Sorties.Name = "chk_Sorties";
            this.chk_Sorties.Size = new System.Drawing.Size(58, 17);
            this.chk_Sorties.TabIndex = 2;
            this.chk_Sorties.Text = "Sorties";
            this.chk_Sorties.UseVisualStyleBackColor = true;
            // 
            // cmb_SituationFamiliale
            // 
            this.cmb_SituationFamiliale.FormattingEnabled = true;
            this.cmb_SituationFamiliale.Items.AddRange(new object[] {
            "Célibataire",
            "Marié(e)",
            "Pacsé(e)"});
            this.cmb_SituationFamiliale.Location = new System.Drawing.Point(74, 354);
            this.cmb_SituationFamiliale.Name = "cmb_SituationFamiliale";
            this.cmb_SituationFamiliale.Size = new System.Drawing.Size(197, 21);
            this.cmb_SituationFamiliale.TabIndex = 8;
            // 
            // lbl_SituationFamiliale
            // 
            this.lbl_SituationFamiliale.AutoSize = true;
            this.lbl_SituationFamiliale.Location = new System.Drawing.Point(74, 335);
            this.lbl_SituationFamiliale.Name = "lbl_SituationFamiliale";
            this.lbl_SituationFamiliale.Size = new System.Drawing.Size(88, 13);
            this.lbl_SituationFamiliale.TabIndex = 9;
            this.lbl_SituationFamiliale.Text = "Situation familiale";
            // 
            // btn_Valider
            // 
            this.btn_Valider.Location = new System.Drawing.Point(368, 433);
            this.btn_Valider.Name = "btn_Valider";
            this.btn_Valider.Size = new System.Drawing.Size(75, 23);
            this.btn_Valider.TabIndex = 10;
            this.btn_Valider.Text = "Valider";
            this.btn_Valider.UseVisualStyleBackColor = true;
            this.btn_Valider.Click += new System.EventHandler(this.btn_Valider_Click);
            // 
            // Win_060_ComposantsStandards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 483);
            this.Controls.Add(this.btn_Valider);
            this.Controls.Add(this.lbl_SituationFamiliale);
            this.Controls.Add(this.cmb_SituationFamiliale);
            this.Controls.Add(this.grp_Loisirs);
            this.Controls.Add(this.grp_Sexe);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txt_Nom);
            this.Name = "Win_060_ComposantsStandards";
            this.Text = "Win_060_Composant";
            this.Load += new System.EventHandler(this.Win_060_ComposantsStandards_Load);
            this.grp_Sexe.ResumeLayout(false);
            this.grp_Sexe.PerformLayout();
            this.grp_Loisirs.ResumeLayout(false);
            this.grp_Loisirs.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.RadioButton radio_Masculin;
        private System.Windows.Forms.RadioButton radio_Feminin;
        private System.Windows.Forms.GroupBox grp_Sexe;
        private System.Windows.Forms.GroupBox grp_Loisirs;
        private System.Windows.Forms.CheckBox chk_Sorties;
        private System.Windows.Forms.CheckBox chk_Voyages;
        private System.Windows.Forms.CheckBox chk_Sport;
        private System.Windows.Forms.ComboBox cmb_SituationFamiliale;
        private System.Windows.Forms.Label lbl_SituationFamiliale;
        private System.Windows.Forms.Button btn_Valider;
    }
}