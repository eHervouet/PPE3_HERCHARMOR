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

        }

        private void cbCompteNonValide_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
