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
    public partial class frmEditType : Form
    {
        public frmEditType()
        {
            InitializeComponent();
        }

        //the function loads data to dataGrid
        private void loadDataToDG()
        {
            //load type data to dataGrid 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT TYPE_ID AS ID,TYPE_NAME AS TYPE FROM TBL_TYPE ORDER BY TYPE_ID", conn.connection());
            dt.Clear();
            da.Fill(dt);
            dtEditType.DataSource = dt;
            conn.connection().Close();
        }
        SqlCommands conn = new SqlCommands();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_TYPE(TYPE_NAME) VALUES ('" + txtTypeName.Text + "')", conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtTypeName.Text + " succesfully added.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataToDG();
            
        }

        private void frmEditType_Load(object sender, EventArgs e)
        {
            loadDataToDG();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_TYPE SET TYPE_NAME ='" + txtTypeName.Text + "' WHERE TYPE_ID =" + selectedId, conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtTypeName.Text + " succesfully changed.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();

        }

        int selectedIndex;
        int selectedId;
        private void dtEditType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transfer the name from selected cell
            selectedIndex = dtEditType.SelectedCells[0].RowIndex;
            txtTypeName.Text = dtEditType.Rows[selectedIndex].Cells[1].Value.ToString();

            //take id from selected cell
            Int32.TryParse(dtEditType.Rows[selectedIndex].Cells[0].Value.ToString(), out selectedId);
        }

        private int ifExists;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM TBL_THESIS WHERE TYPE_ID=" + selectedId, conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ifExists = (int)dr[0];
            }
            conn.connection().Close();


            if (ifExists == 0)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBL_TYPE WHERE TYPE_ID=" + selectedId, conn.connection());
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Type succesfully deleted.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.connection().Close();

                loadDataToDG();
            }
            if (ifExists != 0)
            {
                MessageBox.Show("Type can not deleted, Some theses use this Type", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
