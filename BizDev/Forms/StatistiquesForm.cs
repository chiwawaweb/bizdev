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
        ProspectProvider prospectProvider = new ProspectProvider();

        public StatistiquesForm()
        {
            InitializeComponent();


        }

        private void AfficheDonnees()
        {
            TxtTNew.Text = prospectProvider.CountAll().ToString();
            TxtPNew.Text = "100 %";
            TxtTContacts.Text = prospectProvider.TContacts().ToString();
        }

        private void StatistiquesForm_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            e.Graphics.DrawLine(pen, 20, 10, 300, 100);
        }

        private void StatistiquesForm_Load(object sender, EventArgs e)
        {
            AfficheDonnees();
        }
    }
}
