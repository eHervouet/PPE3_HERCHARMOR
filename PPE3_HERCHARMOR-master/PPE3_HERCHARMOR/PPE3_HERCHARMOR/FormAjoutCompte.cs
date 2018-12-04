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
    public partial class FormAjoutCompte : Form
    {
        formAccueil accueil = new formAccueil();
        public FormAjoutCompte()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormAjoutCompte_Load(object sender, EventArgs e)
        {
            tbNomClient.Text = "";
            tbPrenomClient.Text = "";
            tbLoginClient.Text = "";
            tbPWDClient.Text = "";
            tbEmailClient.Text = "";
            dtpDateAbonnement.Value = DateTime.Now;
            dtpDateNaissance.Text = "01/01/1980";
            numEtatClient.Value = 0;
        }

        private void btnAjoutCompte_Click(object sender, EventArgs e)
        {
            string NomClient = tbNomClient.Text;
            string PrenomClient = tbPrenomClient.Text;
            string LoginClient = tbLoginClient.Text;
            string PWDClient = tbPWDClient.Text;
            string EmailClient = tbEmailClient.Text;
            DateTime DateAboClient = dtpDateAbonnement.Value;
            DateTime DateNaissanceClient = dtpDateNaissance.Value;
            int EtatCompteClient = Convert.ToInt32(numEtatClient.Value);

            accueil.ajouterCompte(NomClient, PrenomClient, LoginClient, PWDClient, EmailClient, DateAboClient, DateNaissanceClient, EtatCompteClient);
        }
    }
}
