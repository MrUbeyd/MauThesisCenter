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
    public partial class frmAddNewThesis : Form
    {
        public frmAddNewThesis()
        {
            InitializeComponent();
        }
        SqlCommands conn = new SqlCommands();
        private void frmAddNewThesis_Load(object sender, EventArgs e)
        {
            //university combobox fill process...
            SqlCommand cmd = new SqlCommand("select (UNI_NAME) from TBL_UNIVERSITY;", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUniversity.Items.Add(dr[0]);
            }
            conn.connection().Close();

            //language combobox fill process...
            SqlCommand cmdLang = new SqlCommand("select (LANG_NAME) from TBL_LANGUAGE", conn.connection());
            SqlDataReader drLang = cmdLang.ExecuteReader();
            while (drLang.Read())
            {
                cmbLanguage.Items.Add(drLang[0]);
            }
            conn.connection().Close();

            //type combobox fill process...
            SqlCommand cmdType = new SqlCommand("select (TYPE_NAME) from TBL_TYPE", conn.connection());
            SqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                cmbType.Items.Add(drType[0]);
            }
            conn.connection().Close();

            //topic combobox fill process...
            /*
            SqlCommand cmdTopic = new SqlCommand("select (TOPIC_NAME) from TBL_TOPICS;", conn.connection());
            SqlDataReader drTopic = cmdTopic.ExecuteReader();
            while (drTopic.Read())
            {
                cmbTopic.Items.Add(drTopic[0]);
            }
            conn.connection().Close();
            */
        }

        private void cmbUniversity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //institute combobox fill process...
            cmbInstitute.Items.Clear();
            SqlCommand cmdIns = new SqlCommand("select (INS_NAME) from TBL_INSTITUTE inner join TBL_UNIVERSITY AS UNI on UNI.UNI_ID=TBL_INSTITUTE.UNI_ID where UNI_NAME like '" + cmbUniversity.Text + "';", conn.connection());
            SqlDataReader drIns = cmdIns.ExecuteReader();
            while (drIns.Read())
            {
                cmbInstitute.Items.Add(drIns[0]);
            }
            conn.connection().Close();
        }

        private void cmbInstitute_MouseClick(object sender, MouseEventArgs e)
        {
            cmbInstitute.Text = "";
        }
        
        private void btnAddThesis_Click(object sender, EventArgs e)
        {
            //neccesary places and coSupervisor filled
            if (txtAuthorName.Text != "" && cmbUniversity.Text != "" && cmbInstitute.Text != "" && cmbLanguage.Text != "" && cmbType.Text != "" && txtTitle.Text != "" && txtSupervisor.Text != "" && txtYear.Text != "" && txtNumberOP.Text != "" && rtxtAbstract.Text != "" && txtCoSupervisor.Text != "")
            {
                
                //author record adding to database
                SqlCommand cmdAuthor = new SqlCommand("IF NOT EXISTS(SELECT Author_NAME FROM TBL_AUTHOR WHERE Author_NAME LIKE '"+txtAuthorName.Text+"') BEGIN INSERT INTO TBL_AUTHOR(Author_NAME) VALUES('"+txtAuthorName.Text+"') END", conn.connection()); 
                cmdAuthor.ExecuteNonQuery();
                conn.connection().Close();
                    
   
                //thesis record adding to database
                string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                SqlCommand cmdThesis = new SqlCommand("INSERT INTO TBL_THESIS(Author_ID, UNI_ID, INS_ID, LANG_ID, TYPE_ID, SUP_NAME,COSUP_NAME, TITLE, ABSTRACT, YEAR, SUB_DATE, NUMBER_OF_PAGES) VALUES((SELECT Author_ID FROM TBL_AUTHOR WHERE Author_NAME LIKE '" + txtAuthorName.Text + "'), (SELECT UNI_ID FROM TBL_UNIVERSITY WHERE UNI_NAME LIKE '" + cmbUniversity.Text + "'),(SELECT INS_ID FROM TBL_INSTITUTE INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID = TBL_INSTITUTE.UNI_ID WHERE INS_NAME LIKE '" + cmbInstitute.Text + "' AND UNI_NAME LIKE '" + cmbUniversity.Text + "'),(SELECT LANG_ID FROM TBL_LANGUAGE WHERE LANG_NAME LIKE '" + cmbLanguage.Text + "'),(SELECT TYPE_ID FROM TBL_TYPE WHERE TYPE_NAME LIKE '" + cmbType.Text + "'),'"+txtSupervisor.Text+"', '"+txtCoSupervisor.Text+"'  ,'" + txtTitle.Text + "','" + rtxtAbstract.Text + "'," + txtYear.Text + ",'" + date + "'," + txtNumberOP.Text + ")", conn.connection());
                cmdThesis.ExecuteNonQuery();
                conn.connection().Close();

                //supervisor record adding to database
                //SqlCommand cmdSup = new SqlCommand("IF NOT EXISTS (SELECT SUPERVISER_NAME FROM TBL_SUPERVISORS WHERE SUPERVISER_NAME LIKE '"+txtSupervisor.Text+"')BEGIN INSERT INTO TBL_SUPERVISORS (SUPERVISER_NAME,THESIS_NO) VALUES ('" + txtSupervisor.Text + "', (SELECT THESIS_NO FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID WHERE Author_NAME LIKE '" + txtAuthorName.Text + "')) END", conn.connection());
                //cmdSup.ExecuteNonQuery();
                //conn.connection().Close();

                //coSupervisor record adding to database
                /*SqlCommand cmdCoSup = new SqlCommand("INSERT INTO TBL_SUPERVISORS (SUPERVISER_NAME,THESIS_NO) VALUES ('" + txtCoSupervisor.Text + "', (SELECT THESIS_NO FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID WHERE Author_NAME LIKE '" + txtAuthorName.Text + "'))", conn.connection());
                cmdCoSup.ExecuteNonQuery();
                conn.connection().Close();
                */

                //topic record adding to database
                SqlCommand cmdTopic = new SqlCommand("INSERT INTO TBL_TOPICS (TOPIC_NAME,THESIS_NO) VALUES ('" + cmbTopic.Text + "', (SELECT TOP(1) THESIS_NO FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID WHERE Author_NAME LIKE '" + txtAuthorName.Text + "' ORDER BY THESIS_NO DESC)) ", conn.connection());
                cmdTopic.ExecuteNonQuery();
                conn.connection().Close();

                MessageBox.Show("Thesis record succesfully added with CoSupervisor.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //neccesary places filled
            else if (txtAuthorName.Text != "" && cmbUniversity.Text != "" && cmbInstitute.Text != "" && cmbLanguage.Text != "" && cmbType.Text != "" && txtTitle.Text != "" && txtSupervisor.Text != "" && txtYear.Text != "" && txtNumberOP.Text != "" && rtxtAbstract.Text != "")
            {
                //author record adding to database
                SqlCommand cmdAuthor = new SqlCommand("IF NOT EXISTS(SELECT Author_NAME FROM TBL_AUTHOR WHERE Author_NAME LIKE '" + txtAuthorName.Text + "') BEGIN INSERT INTO TBL_AUTHOR(Author_NAME) VALUES('" + txtAuthorName.Text + "') END", conn.connection());
                cmdAuthor.ExecuteNonQuery();
                conn.connection().Close();

                //thesis record adding to database
                string date = DateTime.UtcNow.ToString("yyyy-MM-dd");
                SqlCommand cmdThesis =new SqlCommand("INSERT INTO TBL_THESIS(Author_ID, UNI_ID, INS_ID, LANG_ID, TYPE_ID, SUP_NAME, TITLE, ABSTRACT, YEAR, SUB_DATE, NUMBER_OF_PAGES) VALUES((SELECT Author_ID FROM TBL_AUTHOR WHERE Author_NAME LIKE '" + txtAuthorName.Text + "'), (SELECT UNI_ID FROM TBL_UNIVERSITY WHERE UNI_NAME LIKE '" + cmbUniversity.Text + "'),(SELECT INS_ID FROM TBL_INSTITUTE INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID = TBL_INSTITUTE.UNI_ID WHERE INS_NAME LIKE '" + cmbInstitute.Text + "' AND UNI_NAME LIKE '" + cmbUniversity.Text + "'),(SELECT LANG_ID FROM TBL_LANGUAGE WHERE LANG_NAME LIKE '" + cmbLanguage.Text + "'),(SELECT TYPE_ID FROM TBL_TYPE WHERE TYPE_NAME LIKE '" + cmbType.Text + "'),'" + txtSupervisor.Text + "' , '" + txtTitle.Text + "','" + rtxtAbstract.Text + "'," + txtYear.Text + ",'" + date + "'," + txtNumberOP.Text + ")", conn.connection());
                cmdThesis.ExecuteNonQuery();
                conn.connection().Close();



                //topic record adding to database
                SqlCommand cmdTopic = new SqlCommand("INSERT INTO TBL_TOPICS (TOPIC_NAME,THESIS_NO) VALUES ('"+cmbTopic.Text+"', (SELECT TOP(1) THESIS_NO FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID WHERE Author_NAME LIKE '"+txtAuthorName.Text+"' ORDER BY THESIS_NO DESC)) ", conn.connection());
                cmdTopic.ExecuteNonQuery();
                conn.connection().Close();

                MessageBox.Show("Thesis record succesfully added.", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            //neccesary places not filled error
            else
            {
                MessageBox.Show("Neccesary places must be fill...", "MAU Thesis Center", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
