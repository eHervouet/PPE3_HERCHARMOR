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
    public partial class FormFermetureCompte : Form
    {
        formAccueil accueil = new formAccueil();
        public FormFermetureCompte(List<client> uneListe)
        {
            InitializeComponent();
            bsClient.DataSource = uneListe;
            cbFermetureCompte.ValueMember = "idClient";
            cbFermetureCompte.DisplayMember = "nomEntier";
            cbFermetureCompte.DataSource = bsClient;
            cbFermetureCompte.SelectedIndex = -1;
        }

        private void FormSuppressionCompte_Load(object sender, EventArgs e)
        {
            lblNomClient.Text = "";
            lblPrenomClient.Text = "";
            lblEmailClient.Text = "";
            lblDateNaissanceClient.Text = "";
            lblDateAboClient.Text = "";
            lblLoginClient.Text = "";
            lblMDPClient.Text = "";
            lblActifClient.Text = "";
            btnFermerCompte.Visible = false;
        }

        private void cbCompteSuppression_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choix = cbFermetureCompte.SelectedIndex;

            List<client> listeClient = accueil.listeDesclient();

            if (choix != -1)
            {
                changeInformation(listeClient[choix]);
            }
        }
        public void changeInformation(client unClient)
        {
            btnFermerCompte.Visible = true;
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
            }
            else
            if(unClient.actif == 1)
            {
                lblActifClient.Text = "Compte actif";
            }
            else
            {
                lblActifClient.Text = "Le compte est fermer";
                btnFermerCompte.Visible = false;
            }

        }

        private void btnFermerCompte_Click(object sender, EventArgs e)
        {
            int compteFermer = cbFermetureCompte.SelectedIndex;

            List<client> listeClient = accueil.listeDesclient();

            accueil.fermerCompte(listeClient[compteFermer]);

            btnFermerCompte.Visible = false;
            this.Close();
        }
    }
}
