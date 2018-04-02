using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.DTO;
using BizDev.Library;

namespace BizDev.Forms
{
    public partial class ProspectEditForm : Form
    {
        Utils utils = new Utils();

        public ProspectEditForm()
        {
            InitializeComponent();

            /* Combobox catégories */
            var dsCat = new List<ProspectCategorie>();
            foreach (ProspectCategorie pays in utils.GetAllProspectCategories().OrderBy(o => o.Nom))
            {
                dsCat.Add(pays);
            }
            CbxCategorie.DataSource = dsCat;
            CbxCategorie.DisplayMember = "Fullname";
        }

        private void AjouterCategorie()
        {
            LsbCategories.Items.Add(CbxCategorie.Text);
        }

        private void SupprimerCategorie()
        {
            LsbCategories.Items.Remove(LsbCategories.SelectedItem);
        }

        #region Gestion des événements

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            AjouterCategorie();
        }

        #endregion

        private void BtnDelCategorie_Click(object sender, EventArgs e)
        {
            SupprimerCategorie();
        }
    }
}
