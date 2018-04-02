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

        }

        #region Gestion des événements

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            AjouterCategorie();
        }

        #endregion
    }
}
