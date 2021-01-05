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
    public partial class frmEditLanguages : Form
    {
        public frmEditLanguages()
        {
            InitializeComponent();
        }

        //the function loads data to dataGrid
        private void loadDataToDG()
        {
            //load language data to dataGrid 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT LANG_ID AS ID,LANG_NAME AS LANGUAGE FROM TBL_LANGUAGE ORDER BY LANG_ID", conn.connection());
            dt.Clear();
            da.Fill(dt);
            dtEditLanguages.DataSource = dt;
            conn.connection().Close();
        }

        SqlCommands conn = new SqlCommands();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO TBL_LANGUAGE(LANG_NAME) VALUES ('"+txtLanguageName.Text+"')", conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtLanguageName.Text + " succesfully added.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadDataToDG();
        }

        int selectedIndex;
        int selectedId;
        private void dtEditLanguages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //transfer the name from selected cell
            selectedIndex = dtEditLanguages.SelectedCells[0].RowIndex;
            txtLanguageName.Text = dtEditLanguages.Rows[selectedIndex].Cells[1].Value.ToString();

            //take id from selected cell
            Int32.TryParse(dtEditLanguages.Rows[selectedIndex].Cells[0].Value.ToString(), out selectedId);
        }

        private void frmEditLanguages_Load(object sender, EventArgs e)
        {

            loadDataToDG();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE TBL_LANGUAGE SET LANG_NAME ='" + txtLanguageName.Text + "' WHERE LANG_ID =" + selectedId, conn.connection());
            cmd.ExecuteNonQuery();
            conn.connection().Close();
            MessageBox.Show(txtLanguageName.Text + " succesfully changed.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();


        }

        private int ifExists;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT (*) FROM TBL_THESIS WHERE LANG_ID=" + selectedId, conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                ifExists = (int)dr[0];
            }
            conn.connection().Close();


            if (ifExists == 0)
            {
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM TBL_LANGUAGE WHERE LANG_ID=" + selectedId, conn.connection());
                cmdDelete.ExecuteNonQuery();
                MessageBox.Show("Language succesfully deleted.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.connection().Close();

                loadDataToDG();
            }
            if (ifExists != 0)
            {
                MessageBox.Show("Language can not deleted, Some theses use this Language", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
