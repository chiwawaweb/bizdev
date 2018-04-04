using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.DAL;
using BizDev.DTO;
using BizDev.Library;

namespace BizDev.Forms
{
    public partial class ProspectsListForm : Form
    {
        int idRetour;

        Utils utils = new Utils();
        ProspectProvider prospectProvider = new ProspectProvider();
        Form owner;

        public ProspectsListForm(Form _owner, int _idRetour=0)
        {
            owner = _owner;
            idRetour = _idRetour;

            InitializeComponent();
        }

        public void RefreshData(int _idRetour = 0, bool firstLine = false)
        {
            if (_idRetour != 0)
            {
                idRetour = _idRetour;
            }

            List<Prospect> list;
            list = prospectProvider.Search(utils.RemoveDiacritics(string.Empty));

            if (firstLine == true)
            {
                _idRetour = 0;
            }

            CreateTable(list);
        }

        private void CreateTable(List<Prospect> list)
        {
            DgvProspects.Rows.Clear();
            DgvProspects.Columns.Clear();
            DgvProspects.DefaultCellStyle.Font = new Font("Consolas", 10);

            /* Mise en forme */
            DataGridViewTextBoxColumn idCol = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "#",
                Width = 60,
                Visible = true
            };
            idCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            idCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn nomCol = new DataGridViewTextBoxColumn
            {
                Name = "NOM",
                HeaderText = "Nom du prospect",
                Width = 300
            };
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adresseCol = new DataGridViewTextBoxColumn
            {
                Name = "ADRESSE",
                HeaderText = "Adresse du prospect",
                Width = 400
            };
            adresseCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn datePremierContact = new DataGridViewTextBoxColumn
            {
                Name = "DATE_PREMIERCONTACT",
                HeaderText = "Contact",
                Width = 100
            };
            datePremierContact.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datePremierContact.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateConversion = new DataGridViewTextBoxColumn
            {
                Name = "DATE_CONVERSION",
                HeaderText = "Conversion",
                Width = 100
            };
            dateConversion.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateConversion.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateAbandon = new DataGridViewTextBoxColumn
            {
                Name = "DATE_ABANDON",
                HeaderText = "Abandon",
                Width = 100
            };
            dateAbandon.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateAbandon.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            /* Création des colonnes */
            DgvProspects.Columns.Add(idCol);
            DgvProspects.Columns.Add(nomCol);
            DgvProspects.Columns.Add(adresseCol);
            DgvProspects.Columns.Add(datePremierContact);
            DgvProspects.Columns.Add(dateConversion);
            DgvProspects.Columns.Add(dateAbandon);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = DgvProspects.Rows.Add();

                int id = list[i].Id;
                string nom = list[i].Nom.Trim();
                string adresse = list[i].Adresse + " " + list[i].Complement + list[i].CodePostal + " " + list[i].Ville.Trim();
                DateTime dateContact = list[i].DatePremierContact;

                DgvProspects.Rows[number].Cells[0].Value = id.ToString("00000");
                DgvProspects.Rows[number].Cells[1].Value = nom;
                DgvProspects.Rows[number].Cells[2].Value = adresse;
                DgvProspects.Rows[number].Cells[3].Value = dateContact.ToShortDateString();
                DgvProspects.Rows[number].Cells[4].Value = dateConversion;
                DgvProspects.Rows[number].Cells[5].Value = dateAbandon;

                /* Sélection du client par idRetour */
                if (list[i].Id == idRetour)
                {
                    DgvProspects.Rows[number].Cells[1].Selected = true;
                }
            }
        }

        private void NewProspect()
        {
            new ProspectEditForm(this, false).ShowDialog();
        }

        private void ViewProspect()
        {
            new ProspectEditForm(this, true).ShowDialog();
        }

        #region Gestion des événements

        private void TbnNew_Click(object sender, EventArgs e)
        {
            NewProspect();
        }

        private void TbnView_Click(object sender, EventArgs e)
        {
            ViewProspect();
        }

        private void ProspectsListForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        #endregion


    }
}
