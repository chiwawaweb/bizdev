using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BizDev.Library;
using BizDev.DAL;

namespace BizDev.Forms
{
    public partial class ProspectLogEditForm : Form
    {
        int idProspect;

        public ProspectLogEditForm(int _idProspect)
        {
            idProspect = _idProspect;
            
            InitializeComponent();
        }

        private void Save()
        {

        }

        #region Gestion des événements

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        #endregion


    }
}
