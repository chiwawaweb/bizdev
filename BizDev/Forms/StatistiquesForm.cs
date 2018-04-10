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
        double T30New, T30Contacts, T30Conversions, T30Abandons;
        double P30New, P30Contacts, P30Conversions, P30Abandons;
        double T365New, T365Contacts, T365Conversions, T365Abandons;
        double P365New, P365Contacts, P365Conversions, P365Abandons;

        ProspectProvider prospectProvider = new ProspectProvider();

        public StatistiquesForm()
        {
            InitializeComponent();
        }

        private void CalculDonnees()
        {
            TNew = prospectProvider.TNew(0);
            PNew = 100;
            T30New = prospectProvider.TNew(-1);
            P30New = (T30New / TNew) * 100;
            T365New = prospectProvider.TNew(-12);
            P365New = (T365New / TNew) * 100;
            TContacts = prospectProvider.TContacts(0);
            PContacts = (TContacts / TNew) * 100;
            T30Contacts = prospectProvider.TContacts(-1);
            P30Contacts = (T30Contacts / TContacts) * 100;
            T365Contacts = prospectProvider.TContacts(-12);
            P365Contacts = (T365Contacts / TContacts) * 100;
            TConversions = prospectProvider.TConversions(0);
            PConversions = (TConversions / TNew) * 100;
            T30Conversions = prospectProvider.TConversions(-1);
            P30Conversions = (T30Conversions / TConversions) * 100;
            T365Conversions = prospectProvider.TConversions(-12);
            P365Conversions = (T365Conversions / TConversions) * 100;
            TAbandons = prospectProvider.TAbandons(0);
            PAbandons = (TAbandons / TNew) * 100;
            T30Abandons = prospectProvider.TAbandons(-1);
            P30Abandons = (T30Abandons / TNew) * 100;
            T365Abandons = prospectProvider.TAbandons(-12);
            P365Abandons = (T365Abandons / TNew) * 100;
        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = TNew.ToString();
            TxtPNew.Text = PNew.ToString("0.00") + " %";
            TxtT30New.Text = T30New.ToString();
            TxtP30New.Text = P30New.ToString("0.00") + " %";
            TxtT365New.Text = T365New.ToString();
            TxtP365New.Text = P365New.ToString("0.00") + " %";
            TxtTContacts.Text = TContacts.ToString();
            TxtPContacts.Text = PContacts.ToString("0.00") + " %";
            TxtT30Contacts.Text = T30Contacts.ToString();
            TxtP30Contacts.Text = P30Contacts.ToString("0.00") + " %";
            TxtT365Contacts.Text = T365Contacts.ToString();
            TxtP365Contacts.Text = P365Contacts.ToString("0.00") + " %";
            TxtTConversions.Text = TConversions.ToString();
            TxtPConversions.Text = PConversions.ToString("0.00") + " %";
            TxtT30Conversions.Text = T30Conversions.ToString();
            TxtP30Conversions.Text = P30Conversions.ToString("0.00") + " %";
            TxtT365Conversions.Text = T365Conversions.ToString();
            TxtP365Conversions.Text = P365Conversions.ToString("0.00") + " %";
            TxtTAbandons.Text = TAbandons.ToString();
            TxtPAbandons.Text = PAbandons.ToString("0.00") + " %";
            TxtT30Abandons.Text = T30Abandons.ToString();
            TxtP30Abandons.Text = P30Abandons.ToString("0.00") + " %";
            TxtT365Abandons.Text = T365Abandons.ToString();
            TxtP365Abandons.Text = P365Abandons.ToString("0.00") + " %";
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
