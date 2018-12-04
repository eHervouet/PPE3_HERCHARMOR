using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE3_HERCHARMOR
{
    public partial class FormValidationCompte : Form
    {
        formAccueil accueil = new formAccueil();

        public FormValidationCompte(List<client> uneListe)
        {
            InitializeComponent();
            bsClient.DataSource = uneListe;
            cbCompteNonValide.ValueMember = "idClient";
            cbCompteNonValide.DisplayMember = "nomEntier";
            cbCompteNonValide.DataSource = bsClient;
            cbCompteNonValide.SelectedIndex = -1;
        }

        private void FormValidationCompte_Load(object sender, EventArgs e)
        {
            lblNomClient.Text = "";
            lblPrenomClient.Text = "";            
            lblEmailClient.Text = "";
            lblDateNaissanceClient.Text = "";
            lblDateAboClient.Text = "";
            lblLoginClient.Text = "";
            lblMDPClient.Text = "";
            lblActifClient.Text = "";
            btnValidation.Visible = false;
        }

        private void cbCompteNonValide_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choix = cbCompteNonValide.SelectedIndex;

            List<client> listeClient = accueil.listeDesclient();

            if(choix != -1)
            {
                changeInformation(listeClient[choix]);
            }     
        }

        public void changeInformation(client unClient)
        {
            btnValidation.Visible = false;
            lblNomClient.Text = unClient.nomClient;
            lblPrenomClient.Text = unClient.prenomClient;
            lblEmailClient.Text = unClient.emailClient;
            lblDateNaissanceClient.Text = unClient.dateNaissance.ToString();
            lblDateAboClient.Text = unClient.dateAbonnementClient.ToString();
            lblLoginClient.Text = unClient.login;
            lblMDPClient.Text = unClient.pwd;
            if (unClient.actif == 0)
            {
                lblActifClient.Text = "Non actif";
                btnValidation.Visible = true;
            }
            else
            if (unClient.actif == 1)
            {
                lblActifClient.Text = "Compte actif";
            }
            else
            {
                lblActifClient.Text = "Le compte est fermer";
                btnValidation.Visible = true;
            }
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            int compteValider = cbCompteNonValide.SelectedIndex;

            List<client> listeClient = accueil.listeDesclient();

            accueil.validerCompte(listeClient[compteValider]);

            btnValidation.Visible = false;
            this.Close();
        }
    }
}
