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
    public partial class FormVerifCompte : Form
    {
        public FormVerifCompte(List<client> maListeClient)
        {
            InitializeComponent();
            bsClient.DataSource = maListeClient;
            lblNomClient.Text = "Nom du client :" + ((client)bsClient.Current).nomClient;
            lblPrenomClient.Text = "Prénom du client : " + ((client)bsClient.Current).prenomClient;
            lblEmailClient.Text = "Email du client : " + ((client)bsClient.Current).emailClient;
            lblDateNaissanceClient.Text = "Date de naissancde : " + Convert.ToString(((client)bsClient.Current).dateNaissance);
            lblDateAboClient.Text = "Date abonnement : " + Convert.ToString(((client)bsClient.Current).dateAbonnementClient);
            lblLoginClient.Text = "Login du client : " + ((client)bsClient.Current).login;
            lblMDPClient.Text = "Mot de passe : " + ((client)bsClient.Current).pwd;
            lblActifClient.Text = "Compte actif : " + Convert.ToString(((client)bsClient.Current).actif);
        }

        private void bsClient_CurrentChanged(object sender, EventArgs e)
        {
            lblNomClient.Text = "Nom du client :" +((client)bsClient.Current).nomClient;
            lblPrenomClient.Text = "Prénom du client : " +((client)bsClient.Current).prenomClient;
            lblEmailClient.Text = "Email du client : " +((client)bsClient.Current).emailClient;
            lblDateNaissanceClient.Text = "Date de naissancde : " +Convert.ToString(((client)bsClient.Current).dateNaissance);
            lblDateAboClient.Text = "Date abonnement : " +Convert.ToString(((client)bsClient.Current).dateAbonnementClient);
            lblLoginClient.Text = "Login du client : " +((client)bsClient.Current).login;
            lblMDPClient.Text = "Mot de passe : " +((client)bsClient.Current).pwd;
            lblActifClient.Text = "Compte actif : " +Convert.ToString(((client)bsClient.Current).actif);
        }

        private void FormVerifCompte_Load(object sender, EventArgs e)
        {
            
        }
    }
}
