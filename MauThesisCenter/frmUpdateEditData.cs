using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MauThesisCenter
{
    public partial class frmUpdateEditData : Form
    {
        public frmUpdateEditData()
        {
            InitializeComponent();
        }

        private void btnUniversities_Click(object sender, EventArgs e)
        {
            frmEditUni frmToEditUni = new frmEditUni();
            frmToEditUni.Show();
        }

        private void btnInstitutes_Click(object sender, EventArgs e)
        {
            frmEditInstitutes frmToEditIns = new frmEditInstitutes();
            frmToEditIns.Show();
        }

        private void btnLanguages_Click(object sender, EventArgs e)
        {
            frmEditLanguages frmToEditLanguages = new frmEditLanguages();
            frmToEditLanguages.Show();
        }

        private void btnTypes_Click(object sender, EventArgs e)
        {
            frmEditType frmToEditTypes = new frmEditType();
            frmToEditTypes.Show();

        }

        

        private void frmUpdateEditData_Load(object sender, EventArgs e)
        {

        }
    }
}
