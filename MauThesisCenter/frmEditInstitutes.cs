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
    public partial class frmEditInstitutes : Form
    {
        public frmEditInstitutes()
        {
            InitializeComponent();
        }

        //the function loads data to dataGrid
        private void loadDataToDG()
        {
            //institutes data load to dataGrid
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT INS_ID AS ID,INS_NAME AS INS, TBL_UNIVERSITY.UNI_NAME AS UNI FROM TBL_INSTITUTE INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_INSTITUTE.UNI_ID ORDER BY TBL_UNIVERSITY.UNI_ID", conn.connection());
            dt.Clear();
            da.Fill(dt);
            dtEditInstitutes.DataSource = dt;
            conn.connection().Close();
        }

        SqlCommands conn = new SqlCommands();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_INSTITUTE(INS_NAME,UNI_ID) VALUES ('"+txtInstituteName.Text+"', (SELECT UNI_ID FROM TBL_UNIVERSITY WHERE UNI_NAME LIKE '"+cmbUniversity.Text+"'))", conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtInstituteName.Text + " succesfully added.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataToDG();
        }

        private void frmEditInstitutes_Load(object sender, EventArgs e)
        {

            loadDataToDG();

            //university combobox fill process...
            SqlCommand cmd = new SqlCommand("select (UNI_NAME) from TBL_UNIVERSITY;", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUniversity.Items.Add(dr[0]);
            }
            conn.connection().Close();


        }
        int selectedIndex;
        int selectedId;

        private void dtEditInstitutes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            //transfer the name from selected cell
            selectedIndex = dtEditInstitutes.SelectedCells[0].RowIndex;
            txtInstituteName.Text = dtEditInstitutes.Rows[selectedIndex].Cells[1].Value.ToString();

            //take id from selected cell
            Int32.TryParse(dtEditInstitutes.Rows[selectedIndex].Cells[0].Value.ToString(), out selectedId);

        }

        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_INSTITUTE SET INS_NAME ='" + txtInstituteName.Text + "' WHERE INS_ID =" + selectedId, conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtInstituteName.Text + " succesfully changed.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();


        }

        private int ifExists;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //control the institute if exists or not 
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM TBL_THESIS WHERE INS_ID=" + selectedId, conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ifExists = (int)dr[0];
            }
            conn.connection().Close();

            //ifExists==0 so that institute not using
            if (ifExists == 0)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBL_INSTITUTE WHERE INS_ID=" + selectedId, conn.connection());
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("INS succesfully deleted.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.connection().Close();

                loadDataToDG();
            }
            if (ifExists != 0)
            {
                MessageBox.Show("INS can not deleted, Some theses use this INS", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
