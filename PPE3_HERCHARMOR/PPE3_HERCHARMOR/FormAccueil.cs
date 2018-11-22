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
    }
}
