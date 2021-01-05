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
    public partial class frmEditUni : Form
    {
        public frmEditUni()
        {
            InitializeComponent();
        }

        //the function loads data to dataGrid
        private void loadDataToDG()
        {
            //load UNI data to dataGrid 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT UNI_ID AS ID,UNI_NAME AS UNI FROM TBL_UNIVERSITY ORDER BY UNI_ID", conn.connection());
            dt.Clear();
            da.Fill(dt);
            dtEditUni.DataSource = dt;
            conn.connection().Close();
        }

        SqlCommands conn = new SqlCommands();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TBL_UNIVERSITY (UNI_NAME) values (@p1)", conn.connection());
            cmd.Parameters.AddWithValue("@p1", txtUniversityName.Text);
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtUniversityName.Text+" succesfully added.","MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();
        }
        int selectedIndex;
        int selectedId;
        
        private void dtEditUni_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transfer the name from selected cell
            selectedIndex = dtEditUni.SelectedCells[0].RowIndex;
            txtUniversityName.Text = dtEditUni.Rows[selectedIndex].Cells[1].Value.ToString();

            //take id from selected cell
            Int32.TryParse(dtEditUni.Rows[selectedIndex].Cells[0].Value.ToString(),out selectedId);


            
        }
        
        private void frmEditUni_Load(object sender, EventArgs e)
        {
            loadDataToDG();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_UNIVERSITY SET UNI_NAME ='"+txtUniversityName.Text+"' WHERE UNI_ID ="+selectedId, conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtUniversityName.Text + " succesfully changed.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();
        }

        private int ifExists;
        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM TBL_THESIS WHERE UNI_ID=" + selectedId  , conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ifExists = (int)dr[0];
            }
            conn.connection().Close();
            

            if (ifExists == 0)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBL_UNIVERSITY WHERE UNI_ID="+selectedId, conn.connection());
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("UNI succesfully deleted.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.connection().Close();

                loadDataToDG();
            }
            if(ifExists!=0)
            {
                MessageBox.Show("UNI can not deleted, Some theses use this UNI", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
