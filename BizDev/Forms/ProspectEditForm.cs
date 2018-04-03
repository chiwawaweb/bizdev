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
            foreach (ProspectCategorie categorie in utils.GetAllProspectCategories().OrderBy(o => o.Nom))
            {
                dsCat.Add(categorie);
            }
            CbxCategorie.DataSource = dsCat;
            CbxCategorie.DisplayMember = "Fullname";

            /* Combobos pays */
            Pays country = new Pays();
            var dsPays = new List<Pays>();
            foreach (Pays pays in country.GetAllPays().OrderBy(o => o.Nom))
            {
                dsPays.Add(pays);
            }
            CbxPays.DataSource = dsPays;
            CbxPays.DisplayMember = "Fullname";
        }

        private void AjouterCategorie()
        {
            
            bool categorieExiste=false;
            foreach (string categorie in LsbCategories.Items)
            {
                if (categorie == CbxCategorie.Text)
                {
                    categorieExiste = true;
                }
                
            }

            if (categorieExiste==false)
            {
                LsbCategories.Items.Add(CbxCategorie.Text);
            }
            LsbCategories.Sorted = true;

        }

        private void SupprimerCategorie()
        {
            LsbCategories.Items.Remove(LsbCategories.SelectedItem);
        }

        #region Gestion des événements



        private void BtnDelCategorie_Click(object sender, EventArgs e)
        {
            SupprimerCategorie();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            AjouterCategorie();
        }


        #endregion


    }
}
