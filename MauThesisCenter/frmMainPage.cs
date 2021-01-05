using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MauThesisCenter
{
    public partial class frmMainPage : Form
    {
        public frmMainPage()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            toSearch();
            
            
        }

        
        private void btnAddThesis_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            frmAddNewThesis frmToAddNewThesis = new frmAddNewThesis() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frmToAddNewThesis);
            frmToAddNewThesis.Show();
        }

        private void btnLastThesis_Click(object sender, EventArgs e)
        {
            //this.Hide();
            this.pContainer.Controls.Clear();
            frmLastTheses frmNew = new frmLastTheses() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frmNew);
            frmNew.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //frmSearch frmToSearch = new frmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //this.pContainer.Controls.Add(frmToSearch);
            //frmToSearch.Show();
            toSearch();
        }

        // Go to Search screen 
        public void toSearch()
        {
            this.pContainer.Controls.Clear();
            frmSearch frmToSearch = new frmSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frmToSearch);
            frmToSearch.Show();

        }

        private void btnDetailedSearch_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            frmDetailedSearch frmToDetailedSearch = new frmDetailedSearch() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frmToDetailedSearch);
            frmToDetailedSearch.Show();
        }

        private void btnUpdateEditData_Click(object sender, EventArgs e)
        {
            this.pContainer.Controls.Clear();
            frmUpdateEditData frmToUpdateEditData = new frmUpdateEditData() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pContainer.Controls.Add(frmToUpdateEditData);
            frmToUpdateEditData.Show();
        }

        SqlCommands conn = new SqlCommands();
        private void btnAuthorLogin_Click(object sender, EventArgs e)
        {
            //Control Author is exists or not 
            SqlCommand cmd = new SqlCommand("select (Author_ID) from TBL_AUTHOR where (Author_NAME='" + txtAuthorName.Text + "')", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //author exists...

                this.pContainer.Controls.Clear();
                frmAuthorLogin frmToAuthorLogin = new frmAuthorLogin() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };

                //transfer the author name to frmAuthorLogin
                frmToAuthorLogin.authorName = txtAuthorName.Text;

                this.pContainer.Controls.Add(frmToAuthorLogin);
                frmToAuthorLogin.Show();
            }
            else
            {
                //author not exists...
                MessageBox.Show("Wrong Author Name\n Please enter Author name consider capital word...","MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.connection().Close();
        }
    }
}
