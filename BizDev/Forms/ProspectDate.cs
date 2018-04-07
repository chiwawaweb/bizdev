using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizDev.Forms
{
    public partial class ProspectDate : Form
    {
        int id;
        string type;


        public ProspectDate(int _id, string _type)
        {
            id = _id;
            type = _type;

            InitializeComponent();
        }

        #region Gestion des événements



        #endregion

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void ChkDelDate_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
