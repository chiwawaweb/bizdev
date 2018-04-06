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
using BizDev.DAL;
using BizDev.Library;

namespace BizDev.Forms
{
    public partial class ProspectEditForm : Form
    {
        int idProspect;
        string nom, adresse, complement, codePostal, ville, pays, tel, gsm, fax, email, web, nbEmployes, notes;
        bool view, premierContact, conversion, abandon;
        DateTime dateConversion, datePremierContact, dateAbandon, createdAt, updatedAt;

        

        ProspectsListForm owner;
        Prospect prospect;

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();

        public ProspectEditForm(ProspectsListForm _owner, bool _view, int _idProspect=0)
        {
            idProspect = _idProspect;
            view = _view;
            owner = _owner;

            FormClosed += new FormClosedEventHandler(ProspectEditForm_FormClosed);

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
            country.Nom = string.Empty;
            var dsPays = new List<Pays>();
            dsPays.Add(country);
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

        

       

        private void NewMode()
        {
            Text = "Nouveau prospect";
            TabControl.TabPages.Remove(TabJournal);   
        }
        
        private void ViewMode()
        {
            /* Modification des contrôles */
            BtnSave.Visible = false;
            BtnCancel.Visible = false;
            BtnClose.Visible = true;
            BtnAddCategorie.Visible = false;
            BtnDelCategorie.Visible = false;
            CbxCategorie.Enabled = false;
            LsbCategories.Enabled = false;
            TxtNom.ReadOnly = true;
            TxtNom.BackColor = Color.LightGray;
            TxtNom.TabStop = false;
            TxtAdresse.ReadOnly = true;
            TxtAdresse.BackColor = Color.LightGray;
            TxtAdresse.TabStop = false;
            TxtComplement.ReadOnly = true;
            TxtComplement.BackColor = Color.LightGray;
            TxtComplement.TabStop = false;
            TxtCodePostal.ReadOnly = true;
            TxtCodePostal.BackColor = Color.LightGray;
            TxtCodePostal.TabStop = false;
            TxtVille.ReadOnly = true;
            TxtVille.BackColor = Color.LightGray;
            TxtVille.TabStop = false;
            CbxPays.Enabled = false;
            CbxPays.BackColor = Color.LightGray;
            CbxPays.TabStop = false;
            TxtTel.ReadOnly = true;
            TxtTel.BackColor = Color.LightGray;
            TxtTel.TabStop = false;
            TxtGsm.ReadOnly = true;
            TxtGsm.BackColor = Color.LightGray;
            TxtGsm.TabStop = false;
            TxtFax.ReadOnly = true;
            TxtFax.BackColor = Color.LightGray;
            TxtFax.TabStop = false;
            TxtEmail.ReadOnly = true;
            TxtEmail.BackColor = Color.LightGray;
            TxtEmail.TabStop = false;
            TxtWeb.ReadOnly = true;
            TxtWeb.BackColor = Color.LightGray;
            TxtWeb.TabStop = false;
            TxtNbEmployes.ReadOnly = true;
            TxtNbEmployes.BackColor = Color.LightGray;
            TxtNbEmployes.TabStop = false;
            TxtNotes.ReadOnly = true;
            TxtNotes.BackColor = Color.LightGray;
            TxtNotes.TabStop = false;

            /* Récupération des données */
            prospect = prospectProvider.GetProspectById(idProspect);

            nom = prospect.Nom;
            adresse = prospect.Adresse;
            complement = prospect.Complement;
            codePostal = prospect.CodePostal;
            ville = prospect.Ville;
            pays = prospect.Pays;
            tel = prospect.Tel;
            gsm = prospect.Gsm;
            fax = prospect.Fax;
            email = prospect.Email;
            web = prospect.Web;
            notes = prospect.Notes;
            createdAt = prospect.CreatedAt;
            updatedAt = prospect.UpdatedAt;

            /* Affichage des données */
            TxtNom.Text = nom;
            TxtAdresse.Text = adresse;
            TxtComplement.Text = complement;
            TxtCodePostal.Text = codePostal;
            TxtVille.Text = ville;
            CbxPays.Text = pays;

            Text = "Visualisation du prospect : " + nom;

            
        }

        public void DrawRectangleRectangle(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create rectangle.
            Rectangle rect = new Rectangle(0, 0, 200, 200);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect);
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
            premierContact = ChkPremierContact.Checked;
            datePremierContact = DtpPremierContact.Value;
            conversion = ChkConversion.Checked;
            dateConversion = DtpConversion.Value;
            abandon = ChkAbandon.Checked;
            dateAbandon = DtpAbandon.Value;

            /* Vérification des données */
            bool erreurs = false;
            
            ErrorProvider.Clear();

            if (nom.Length<2)
            {
                erreurs = true;
                ErrorProvider.SetError(TxtNom, "Nom trop court");
            }

            if (utils.IsEmailValid(email)==false)
            {
                erreurs = true;
                ErrorProvider.SetError(TxtEmail, "Email incorrect");
            }

            if (pays.Length<2)
            {
                erreurs = true;
                ErrorProvider.SetError(CbxPays, "Pays obligatoire");
            }

            if (LsbCategories.Items.Count<1)
            {
                erreurs = true;
                ErrorProvider.SetError(CbxCategorie, "Sélectionner au moins une catégorie");
            }

            


            /* Contrôle si erreurs */
            if (erreurs == false)
            {
                /* Aucune erreur, on continue */
                using (Context context = new Context())
                {
                    if (view == true)
                    {
                        UpdateDatabase();
                    }
                    else
                    {
                        AddDatabase();
                    }
                    Close();
                }
            }



        }

        private void AddDatabase()
        {
            Prospect prospect = new Prospect
            {
                Nom = nom,
                Adresse = adresse,
                Complement = complement,
                CodePostal = codePostal,
                Ville = ville,
                Pays = pays,
                Tel = tel,
                Gsm = gsm,
                Fax = fax,
                Email = email,
                Web = web,
                NbEmployes = nbEmployes,
                Notes = notes,
                CreatedAt = createdAt

            };

            prospectProvider.Create(prospect);
            idProspect = prospect.Id;
        }

        private void UpdateDatabase()
        {
            Prospect prospect = prospectProvider.GetProspectById(idProspect);

            prospect.Nom = nom;
            prospect.Adresse = adresse;
            prospect.Complement = complement;
            prospect.CodePostal = codePostal;
            prospect.Ville = ville;
            prospect.Pays = pays;
            prospect.Tel = tel;
            prospect.Gsm = gsm;
            prospect.Fax = fax;
            prospect.Email = email;
            prospect.Web = web;
            prospect.NbEmployes = nbEmployes;
            prospect.Notes = notes;
            prospect.PremierContact = premierContact;
            prospect.DatePremierContact = datePremierContact;
            prospect.Conversion = conversion;
            prospect.DateConversion = dateConversion;
            prospect.Abandon = abandon;
            prospect.DateAbandon = dateAbandon;
            prospect.UpdatedAt = DateTime.Now;

            prospectProvider.Update(prospect);
        }

        #region Gestion des événements

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProspectEditForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.RefreshData(idProspect);
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
           
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            
            Save();
        }

        #endregion

    }
}
