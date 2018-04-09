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
using BizDev.DTO;

namespace BizDev.Forms
{
    public partial class ProspectLogEditForm : Form
    {
        int idProspect, idProspectLog;
        string note;
        DateTime date;

        ProspectProvider prospectProvider = new ProspectProvider();
        ProspectLogProvider prospectLogProvider = new ProspectLogProvider();

        public ProspectLogEditForm(int _idProspect)
        {
            idProspect = _idProspect;
            
            InitializeComponent();
        }

        private void Save()
        {
            note = TxtNote.Text.Trim();

            if (note.Length<2)
            {
                MessageBox.Show("Annotation trop courte", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Prospect prospect = prospectProvider.GetProspectById(idProspect);

                /* Création de l'annotation */
                ProspectLog prospectLog = new ProspectLog
                {
                    Date = DateTime.Now,
                    Note = note,
                    CreatedAt = DateTime.Now,
                    ProspectId = idProspect
                };

                prospectLogProvider.Create(prospect, prospectLog);

                Close();
            }
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
