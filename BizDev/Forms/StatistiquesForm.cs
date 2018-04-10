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

namespace BizDev.Forms
{
    public partial class StatistiquesForm : Form
    {
        double TNew, TContacts, TConversions, TAbandons;
        double PNew, PContacts, PConversions, PAbandons;
        double TM1New, TM1Contacts, TM1Conversions, TM1Abandons;
        double PM1New, PM1Contacts, PM1Conversions, PM1Abandons;
        double TM3New, TM3Contacts, TM3Conversions, TM3Abandons;
        double PM3New;
        double TM6New, TM6Contacts, TM6Conversions, TM6Abandons;

        double TM9New, TM9Contacts, TM9Conversions, TM9Abandons;

        double TM12New, TM12Contacts, TM12Conversions, TM12Abandons;
        double PM12New, PM12Contacts, PM12Conversions, PM12Abandons;

        ProspectProvider prospectProvider = new ProspectProvider();

        public StatistiquesForm()
        {
            InitializeComponent();
        }

        private void CalculDonnees()
        {
            TNew = prospectProvider.TNew(0);
            PNew = 100;
            TM1New = prospectProvider.TNew(-1);
            PM1New = (TM1New / TNew) * 100;
            TM12New = prospectProvider.TNew(-12);
            PM12New = (TM12New / TNew) * 100;
            TContacts = prospectProvider.TContacts(0);
            PContacts = (TContacts / TNew) * 100;
            TM1Contacts = prospectProvider.TContacts(-1);
            PM1Contacts = (TM1Contacts / TContacts) * 100;
            TM12Contacts = prospectProvider.TContacts(-12);
            PM12Contacts = (TM12Contacts / TContacts) * 100;
            TConversions = prospectProvider.TConversions(0);
            PConversions = (TConversions / TNew) * 100;
            TM1Conversions = prospectProvider.TConversions(-1);
            PM1Conversions = (TM1Conversions / TConversions) * 100;
            TM12Conversions = prospectProvider.TConversions(-12);
            PM12Conversions = (TM12Conversions / TConversions) * 100;
            TAbandons = prospectProvider.TAbandons(0);
            PAbandons = (TAbandons / TNew) * 100;
            TM1Abandons = prospectProvider.TAbandons(-1);
            PM1Abandons = (TM1Abandons / TNew) * 100;
            TM12Abandons = prospectProvider.TAbandons(-12);
            PM12Abandons = (TM12Abandons / TNew) * 100;
        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = TNew.ToString();
            TxtPNew.Text = PNew.ToString("0.00") + " %";
            TxtM1New.Text = TM1New.ToString();
            TxtP30New.Text = PM1New.ToString("0.00") + " %";
            TxtT365New.Text = TM12New.ToString();
            TxtP365New.Text = PM12New.ToString("0.00") + " %";
            TxtTContacts.Text = TContacts.ToString();
            TxtPContacts.Text = PContacts.ToString("0.00") + " %";
            TxtM1Contacts.Text = TM1Contacts.ToString();
            TxtP30Contacts.Text = PM1Contacts.ToString("0.00") + " %";
            TxtT365Contacts.Text = TM12Contacts.ToString();
            TxtP365Contacts.Text = PM12Contacts.ToString("0.00") + " %";
            TxtTConversions.Text = TConversions.ToString();
            TxtPConversions.Text = PConversions.ToString("0.00") + " %";
            TxtM1Conversions.Text = TM1Conversions.ToString();
            TxtP30Conversions.Text = PM1Conversions.ToString("0.00") + " %";
            TxtT365Conversions.Text = TM12Conversions.ToString();
            TxtP365Conversions.Text = PM12Conversions.ToString("0.00") + " %";
            TxtTAbandons.Text = TAbandons.ToString();
            TxtPAbandons.Text = PAbandons.ToString("0.00") + " %";
            TxtM1Abandons.Text = TM1Abandons.ToString();
            TxtP30Abandons.Text = PM1Abandons.ToString("0.00") + " %";
            TxtT365Abandons.Text = TM12Abandons.ToString();
            TxtP365Abandons.Text = PM12Abandons.ToString("0.00") + " %";
        }

        private void StatistiquesForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 178));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }

        private void StatistiquesForm_Load(object sender, EventArgs e)
        {
            CalculDonnees();
            AfficheDonnees();
        }

        #region Gestion des événements

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
    }
}
