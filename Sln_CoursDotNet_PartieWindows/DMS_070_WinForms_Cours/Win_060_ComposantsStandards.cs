using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_WinForms_Cours
{
    public partial class Win_060_ComposantsStandards : Form
    {
        public Win_060_ComposantsStandards()
        {
            InitializeComponent();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            // on récupère les données saisies
            string sexe = "";
            if (radio_Masculin.Checked) 
                sexe = radio_Masculin.Text;
            else
                sexe = radio_Feminin.Text;

            List<string> loisirs = new List<string>();
            if (chk_Sport.Checked) loisirs.Add(chk_Sport.Text);
            if (chk_Voyages.Checked) loisirs.Add(chk_Voyages.Text);
            if (chk_Sorties.Checked) loisirs.Add(chk_Sorties.Text);

            string situation = cmb_SituationFamiliale.SelectedItem.ToString();

            MessageBox.Show(
                "Personne saisie : " +
                txt_Nom.Text + " " + txt_Prenom.Text + " " + sexe + " " + situation);
        }

        private void Win_060_ComposantsStandards_Load(object sender, EventArgs e)
        {
            // callback après la construction de la fenetre en memoire par le constructeur
            // on initialise les composants ici avant l'affichage
            txt_Nom.Text = "";
            txt_Prenom.Text = "";
            radio_Feminin.Checked = true;
            radio_Masculin.Checked = false;
            chk_Sport.Checked = false;
            chk_Sorties.Checked = false;
            chk_Voyages.Checked = false;
            cmb_SituationFamiliale.Items.Add("Divorcé(e)");
        }
    }
}
