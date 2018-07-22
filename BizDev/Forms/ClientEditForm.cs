using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class ClientEditForm : Form
    {
        public ClientEditForm()
        {
            InitializeComponent();
        }

        private void VerifPartners()
        {
            if (RbtStandard.Checked == true)
            {
                CbxEntreprise.Text = string.Empty;
                CbxEntreprise.Enabled = false;
            }
            else
            {
                CbxEntreprise.Enabled = true;
            }
        }

        #region Gestion des événements

        private void RbtStandard_CheckedChanged(object sender, EventArgs e)
        {
            VerifPartners();
        }

        private void RbtPartners_CheckedChanged(object sender, EventArgs e)
        {
            VerifPartners();
        }

        #endregion

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
