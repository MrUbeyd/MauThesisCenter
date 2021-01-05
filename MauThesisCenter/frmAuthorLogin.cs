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
    public partial class frmAuthorLogin : Form
    {
        public frmAuthorLogin()
        {
            InitializeComponent();
        }
        public string authorName;
        public int authorID;
        SqlCommands conn = new SqlCommands();
        int selectedIndex;
        int selectedId;

        //the function loads data to dataGrid
        private void loadDataToDG()
        {
            //load thesis data to dataGrid where author name= authorName
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("select * from TBL_THESIS where Author_ID=" + authorID, conn.connection());
            SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC, TBL_THESIS.SUP_NAME AS SUPERVISOR, TBL_THESIS.COSUP_NAME AS COSUPERVISOR, TBL_THESIS.SUB_DATE AS SUBDATE FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_AUTHOR.Author_ID=" + authorID + " ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
            da.Fill(dt);
            dtPublishedTheses.DataSource = dt;
            conn.connection().Close();
        }
        private void dtPublishedTheses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dtPublishedTheses.SelectedCells[0].RowIndex;
            //take id from selected cell
            Int32.TryParse(dtPublishedTheses.Rows[selectedIndex].Cells[0].Value.ToString(), out selectedId);

            //load topic data to dataGrid which for selected thesis 
            DataTable dtTopic = new DataTable();
            SqlDataAdapter daTopic = new SqlDataAdapter("SELECT TOPIC_NAME AS TOPICS FROM TBL_TOPICS WHERE THESIS_NO=" + selectedId, conn.connection());
            daTopic.Fill(dtTopic);
            dtThesisTopics.DataSource = dtTopic;
            conn.connection().Close();

            //load keyword data to dataGrid which for selected thesis 
            DataTable dtKeywords = new DataTable();
            SqlDataAdapter daKeywords = new SqlDataAdapter("SELECT KEYWORD_NAME AS KEYWORDS FROM TBL_KEYWORDS WHERE THESIS_NO=" + selectedId, conn.connection());
            daKeywords.Fill(dtKeywords);
            dtThesisKeywords.DataSource = dtKeywords;
            conn.connection().Close();
        }
        private void frmAuthorLogin_Load(object sender, EventArgs e)
        {
            lblAuthorName.Text = authorName;
            //find author id
            SqlCommand cmd = new SqlCommand("select (Author_ID) from TBL_AUTHOR where (Author_NAME='"+authorName+"')", conn.connection());
            //cmd.Parameters.AddWithValue("@p1", authorName);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                authorID = (int)dr[0];
            }
            conn.connection().Close();

            loadDataToDG();

            /*
            DataTable dtTopic = new DataTable(); 
            SqlDataAdapter daTopic = new SqlDataAdapter("SELECT TOPIC_NAME,THESIS_NO FROM TBL_TOPICS WHERE THESIS_NO="+selectedId, conn.connection());
            daTopic.Fill(dtTopic);
            dtThesisTopics.DataSource = dtTopic;
            conn.connection().Close();
            */


        }

        private void btnAddKeyword_Click(object sender, EventArgs e)
        {
            //keyword record adding to database
            SqlCommand cmdKeyword = new SqlCommand("INSERT INTO TBL_KEYWORDS (KEYWORD_NAME,THESIS_NO) VALUES ('" + txtAddKeyword.Text + "'," + selectedId + ")", conn.connection());
            cmdKeyword.ExecuteNonQuery();
            conn.connection().Close();

            MessageBox.Show("Keyword succesfully added to Thesis_NO=" + selectedId, "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();
        }

        private void btnAddTopic_Click(object sender, EventArgs e)
        {
            //topic record adding to database
            SqlCommand cmdTopic = new SqlCommand("INSERT INTO TBL_TOPICS (TOPIC_NAME,THESIS_NO) VALUES ('"+cmbAddTopic.Text+"',"+selectedId+")", conn.connection());
            cmdTopic.ExecuteNonQuery();
            conn.connection().Close();

            MessageBox.Show("Topic succesfully added to Thesis_NO="+selectedId, "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();
        }

        private void btnThesisDelete_Click(object sender, EventArgs e)
        {
            //topic record delete from database
            SqlCommand cmdTopic = new SqlCommand("DELETE FROM TBL_TOPICS WHERE THESIS_NO="+selectedId, conn.connection());
            cmdTopic.ExecuteNonQuery();
            conn.connection().Close();

            //keyword record delete from database
            SqlCommand cmdKeyword = new SqlCommand("DELETE FROM TBL_KEYWORDS WHERE THESIS_NO=" + selectedId, conn.connection());
            cmdKeyword.ExecuteNonQuery();
            conn.connection().Close();

            //Thesis record delete from database
            SqlCommand cmdThesisDel = new SqlCommand("DELETE FROM TBL_THESIS WHERE THESIS_NO=" + selectedId, conn.connection());
            cmdThesisDel.ExecuteNonQuery();
            conn.connection().Close();

            MessageBox.Show("Thesis NO:"+ selectedId+" succesfully deleted.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadDataToDG();
        }
    }
}
