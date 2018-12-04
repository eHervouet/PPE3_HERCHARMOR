using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PPE3_HERCHARMOR
{
    public partial class formAccueil : Form
    {
        PPE3_BDD maConnexion;
        public formAccueil()
        {
            InitializeComponent();
            maConnexion = new PPE3_BDD();
        }

        private void formAccueil_Load(object sender, EventArgs e)
        {

        }

        private void TSMItemValidationCompte_Click(object sender, EventArgs e)
        {
            FormValidationCompte ValidationCompte = new FormValidationCompte(listeDesclient());
            ValidationCompte.Show();
        }
        public List<client> listeDesclient()
        {
            return maConnexion.client.ToList();
        }

        private void TSMItemQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void validerCompte(client unClient)
        {
            maConnexion.client.Find(unClient.idClient).actif = 1;
            maConnexion.SaveChanges();
        }
        public void fermerCompte(client unClient)
        {
            maConnexion.client.Find(unClient.idClient).actif = 2;
            maConnexion.SaveChanges();
        }

        private void TSMItemFermetureCompte_Click_1(object sender, EventArgs e)
        {
            FormFermetureCompte FermetureCompte = new FormFermetureCompte(listeDesclient());
            FermetureCompte.Show();
        }

        private void TSMItemAjoutCompte_Click(object sender, EventArgs e)
        {
            FormAjoutCompte AjoutCompte = new FormAjoutCompte();
            AjoutCompte.Show();
        }

        public void ajouterCompte(string unNomClient, string unPrenomClient, string unLoginClient, string unMDPClient, string unEmailClient, DateTime uneDateAboClient, DateTime uneDateNaissanceClient, int unNumEtatClient)
        {
            client monClient = new client();
            monClient.nomClient = unNomClient;
            monClient.prenomClient = unPrenomClient;
            monClient.emailClient = unEmailClient;
            monClient.login = unLoginClient;
            monClient.pwd = unMDPClient;
            monClient.dateNaissance = uneDateNaissanceClient;
            monClient.dateAbonnementClient = uneDateAboClient;
            monClient.actif = unNumEtatClient;

            maConnexion.client.Add(monClient);
            maConnexion.SaveChanges();
        }

        private void TSMItemVerificationCompte_Click(object sender, EventArgs e)
        {
            FormVerifCompte VerifCompte = new FormVerifCompte(listeDesclient());
            VerifCompte.Show();
        }
    }
}
