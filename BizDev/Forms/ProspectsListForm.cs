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
        //Form owner;

        public ProspectsListForm(int _idRetour=0)
        {
            //owner = _owner;
            idRetour = _idRetour;

            InitializeComponent();

            // placement du form dans le coin sup/gauche
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);
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
                idRetour = 0;
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
                Width = 400
            };
            nomCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn adresseCol = new DataGridViewTextBoxColumn
            {
                Name = "ADRESSE",
                HeaderText = "Adresse du prospect",
                Width = 450
            };
            adresseCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn datePremierContactCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_PREMIERCONTACT",
                HeaderText = "Contact",
                Width = 100
            };
            datePremierContactCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            datePremierContactCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateConversionCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_CONVERSION",
                HeaderText = "Conversion",
                Width = 100
            };
            dateConversionCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateConversionCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn dateAbandonCol = new DataGridViewTextBoxColumn
            {
                Name = "DATE_ABANDON",
                HeaderText = "Abandon",
                Width = 100
            };
            dateAbandonCol.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dateAbandonCol.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            /* Création des colonnes */
            DgvProspects.Columns.Add(idCol);
            DgvProspects.Columns.Add(nomCol);
            DgvProspects.Columns.Add(adresseCol);
            DgvProspects.Columns.Add(datePremierContactCol);
            DgvProspects.Columns.Add(dateConversionCol);
            DgvProspects.Columns.Add(dateAbandonCol);

            /* Ajout des lignes */
            for (int i = 0; i < list.Count; i++)
            {
                int number = DgvProspects.Rows.Add();

                int id = list[i].Id;
                string nom = list[i].Nom.Trim();
                string adresse = list[i].Adresse + " " + list[i].Complement + list[i].CodePostal + " " + list[i].Ville.Trim();
                DateTime datePremierContact = list[i].DatePremierContact;
                string strDatePremierContact = string.Empty;
                if (datePremierContact == DateTime.Parse("30/12/1899"))
                    strDatePremierContact = string.Empty;
                else
                    strDatePremierContact = datePremierContact.ToShortDateString();

                DateTime dateConversion = list[i].DateConversion;
                string strDateConversion = string.Empty;
                if (dateConversion == DateTime.Parse("30/12/1899"))
                    strDateConversion = string.Empty;
                else
                    strDateConversion = dateConversion.ToShortDateString();

                DateTime dateAbandon = list[i].DateAbandon;
                string strDateAbandon = string.Empty;
                if (dateAbandon == DateTime.Parse("30/12/1899"))
                    strDateAbandon = string.Empty;
                else
                    strDateAbandon = dateAbandon.ToShortDateString();

                DgvProspects.Rows[number].Cells[0].Value = id.ToString("00000");
                DgvProspects.Rows[number].Cells[1].Value = nom;
                DgvProspects.Rows[number].Cells[2].Value = adresse;
                DgvProspects.Rows[number].Cells[3].Value = strDatePremierContact;
                DgvProspects.Rows[number].Cells[4].Value = strDateConversion;
                DgvProspects.Rows[number].Cells[5].Value = strDateAbandon;

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
            if (DgvProspects.RowCount > 0)
            {
                idRetour = int.Parse(DgvProspects.CurrentRow.Cells[0].Value.ToString());
                new ProspectEditForm(this, true, idRetour).ShowDialog();
                
            }
            
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

        private void DgvProspects_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewProspect();
        }

        #endregion


    }
}
