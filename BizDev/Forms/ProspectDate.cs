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

namespace BizDev.Forms
{
    public partial class ProspectDate : Form
    {
        int idProspect;
        string type, nom;
        bool newState, premierContact, conversion, abandon;
        string datePremierContact, dateConversion, dateAbandon;
        //Nullable<DateTime> newDate = null;
        string newDate="";

        Prospect prospect;
        ProspectEditForm owner;

        ProspectProvider prospectProvider = new ProspectProvider();

        private void ProspectDate_FormClosed(object sender, FormClosedEventArgs e)
        {
            owner.MajDates();
        }

        public ProspectDate(ProspectEditForm _owner, int _id, string _type)
        {
            owner = _owner;
            idProspect = _id;
            type = _type;

            InitializeComponent();

            RecupereInfos();

            Text = nom;
        }

        private void RecupereInfos()
        {
            prospect = prospectProvider.GetProspectById(idProspect);

            nom = prospect.Nom;
            datePremierContact = prospect.DatePremierContact;
            dateConversion = prospect.DateConversion;
            dateAbandon = prospect.DateAbandon;

            /* Affiche les données */
            switch (type)
            {
                case "P":
                    LblLegende.Text = "Date de prise de contact";
                    if (datePremierContact != string.Empty)
                    {
                        DtpDate.Value = Convert.ToDateTime(datePremierContact);
                        ChkDelDate.Visible = true;
                    }
                    else
                    {
                        DtpDate.Value = DateTime.Now;
                        ChkDelDate.Visible = false;
                    }

                    break;

                case "C":
                    LblLegende.Text = "Date de conversion";
                    if (dateConversion != string.Empty)
                    {
                        DtpDate.Value = Convert.ToDateTime(dateConversion);
                        ChkDelDate.Visible = true;
                    }
                    else
                    {
                        DtpDate.Value = DateTime.Now;
                        ChkDelDate.Visible = false;
                    }
                    break;

                case "A":
                    LblLegende.Text = "Date d'abandon";
                    if (dateAbandon != string.Empty)
                    {
                        DtpDate.Value = Convert.ToDateTime(dateAbandon);
                        ChkDelDate.Visible = true;
                    }
                    else
                    {
                        DtpDate.Value = DateTime.Now;
                        ChkDelDate.Visible = false;
                    }
                    break;
            }
        }

        private void Save()
        {
            /* Récupération des données */
            if (ChkDelDate.Checked != true)
            {
                newDate = DtpDate.Value.ToShortDateString();
                newState = true;
            }
            else
            {
                newDate = string.Empty;
                newState = false;
            }

            switch (type)
            {
                case "P":
                    datePremierContact = newDate;
                    premierContact = newState;
                    break;

                case "C":
                    dateConversion = newDate;
                    conversion = newState;
                    break;

                case "A":
                    dateAbandon = newDate;
                    abandon = newState;
                    break;
            }

            UpdateDatabase();

            Close();
        }

        private void UpdateDatabase()
        {
            Prospect prospect = prospectProvider.GetProspectById(idProspect);

            prospect.DatePremierContact = datePremierContact;
            prospect.DateConversion = dateConversion;
            prospect.DateAbandon = dateAbandon;

            prospectProvider.Update(prospect);
        }

        #region Gestion des événements

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkDelDate_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDelDate.Checked==true)
            {
                DtpDate.Enabled = false;
            }
            else
            {
                DtpDate.Enabled = true;
            }
        }

        #endregion


    }
}
