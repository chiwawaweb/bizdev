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
        int idProspect;
        string nom, adresse, complement, codePostal, ville, pays, tel, gsm, fax, email, web, nbEmployes, notes;
        bool view;
        DateTime dateConversion, datePremierContact, dateAbandon;

        ProspectsListForm owner;

        Utils utils = new Utils();

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
            /* Récuperation des données */
            nom = utils.RemoveDiacritics(TxtNom.Text.ToUpper().Trim());
            adresse = utils.RemoveDiacritics(TxtAdresse.Text.ToUpper().Trim());
            complement = utils.RemoveDiacritics(TxtComplement.Text.ToUpper().Trim());
            codePostal = utils.RemoveDiacritics(TxtCodePostal.Text.ToUpper().Trim());
            ville = utils.RemoveDiacritics(TxtVille.Text.ToUpper().Trim());
            pays = utils.RemoveDiacritics(CbxPays.Text.ToUpper().Trim());
            tel = utils.RemoveDiacritics(TxtTel.Text.ToUpper().Trim());
            gsm = utils.RemoveDiacritics(TxtGsm.Text.ToUpper().Trim());
            fax = utils.RemoveDiacritics(TxtFax.Text.ToUpper().Trim());
            email = utils.RemoveDiacritics(TxtEmail.Text.ToLower().Trim());
            web = utils.RemoveDiacritics(TxtWeb.Text.ToLower().Trim());
            nbEmployes = utils.RemoveDiacritics(TxtNbEmployes.Text.ToLower().Trim());

            /* Vérification des données */
            bool erreurs = false;
            string errMsg = "Votre saisie comporte des erreurs : \n\n";

            

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

        private void TxtNom_Validating(object sender, CancelEventArgs e)
        {
            nom = utils.RemoveDiacritics(TxtNom.Text.Trim().ToUpper());

            if (nom.Length < 2)
                ErrorProvider.SetError(TxtNom, "Nom trop court");
            else
                ErrorProvider.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            Save();
        }

        #endregion

    }
}
