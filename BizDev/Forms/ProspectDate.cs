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
        string type;
        bool premierContact, conversion, abandon;
        DateTime datePremierContact, dateConversion, dateAbandon;

        Prospect prospect; 

        ProspectProvider prospectProvider = new ProspectProvider();

        public ProspectDate(int _id, string _type)
        {
            idProspect = _id;
            type = _type;

            InitializeComponent();

            switch (type)
            {
                case "P":
                    Text = "Prise de contact";
                    break;

                case "C":
                    Text = "Conversion";
                    break;

                case "A":
                    Text = "Abandon";
                    break;
            }

            RecupereInfos();
        }

        private void RecupereInfos()
        {
            prospect = prospectProvider.GetProspectById(idProspect);

            premierContact = prospect.PremierContact;
            datePremierContact = prospect.DatePremierContact;
            conversion = prospect.Conversion;
            dateConversion = prospect.DateConversion;
            abandon = prospect.Abandon;
            dateAbandon = prospect.DateAbandon;


        }

        #region Gestion des événements

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChkDelDate_CheckedChanged(object sender, EventArgs e)
        {

        }

        #endregion


    }
}
