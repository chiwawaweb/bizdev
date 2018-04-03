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
        int idProspect, nbEmployes;
        string nom, adresse, complement, codePostal, ville, pays, tel, gsm, faw, email, web, notes;
        bool view;
        DateTime dateConversion;

        ProspectsListForm owner;

        public ProspectEditForm(ProspectsListForm _owner, bool _view, int _idProspect=0)
        {
            idProspect = _idProspect;
            view = _view;
            owner = _owner;

            InitializeComponent();

            /* Combobox catégories */
            ProspectCategorie prospectCategorie = new ProspectCategorie();
            var dsCat = new List<ProspectCategorie>();
            foreach (ProspectCategorie categorie in prospectCategorie.GetAllProspectCategories().OrderBy(o => o.Nom))
            {
                dsCat.Add(categorie);
            }
            CbxCategorie.DataSource = dsCat;
            CbxCategorie.DisplayMember = "Fullname";

            /* Combobox pays */
            Pays country = new Pays();
            var dsPays = new List<Pays>();
            foreach (Pays pays in country.GetAllPays().OrderBy(o => o.Nom))
            {
                dsPays.Add(pays);
            }
            CbxPays.DataSource = dsPays;
            CbxPays.DisplayMember = "Fullname";

            switch (view)
            {
                case false:
                    NewMode();
                    break;

                case true:
                    ViewMode();
                    break;
            }
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void NewMode()
        {
            Text = "Nouveau prospect";
        }
        
        private void ViewMode()
        {
            Text = "Visualisation du prospect : ";
        }

        private void Save()
        {
            /* Recuperation des donnees */

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAddCategorie_Click(object sender, EventArgs e)
        {
            AjouterCategorie();
        }

        private void BtnDelCategorie_Click(object sender, EventArgs e)
        {
            SupprimerCategorie();
        }


        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
