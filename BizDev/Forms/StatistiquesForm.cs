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

        ProspectProvider prospectProvider = new ProspectProvider();

        public StatistiquesForm()
        {
            InitializeComponent();


        }

        private void CalculDonnees()
        {
            TNew = prospectProvider.CountAll();
            PNew = 100;
            TContacts = prospectProvider.TContacts();
            T30Contacts = prospectProvider.T30Contacts();
            PContacts = (TContacts / TNew)*100;
            TConversions = prospectProvider.TConversions();
            PConversions = (TConversions / TNew) * 100;
            TAbandons = prospectProvider.TAbandons();
            PAbandons = (TAbandons / TNew) * 100;
        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = TNew.ToString();
            TxtPNew.Text = PNew.ToString("0.00") + " %";
            TxtTContacts.Text = TContacts.ToString();
            TxtPContacts.Text = PContacts.ToString("0.00") + " %";
            TxtTConversions.Text = TContacts.ToString();
            TxtPConversions.Text = PConversions.ToString("0.00") + " %";
            TxtTAbandons.Text = TAbandons.ToString();
            TxtPAbandons.Text = PAbandons.ToString("0.00") + " %";
            TxtT30Contacts.Text = T30Contacts.ToString();
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
