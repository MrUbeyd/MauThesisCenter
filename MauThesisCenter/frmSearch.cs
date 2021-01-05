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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        SqlCommands conn = new SqlCommands();
        private void frmSearch_Load(object sender, EventArgs e)
        {
            //when form loads combobox must fill from database 

            //language combobox fill process...
            SqlCommand cmd = new SqlCommand("select (LANG_NAME) from TBL_LANGUAGE", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbLanguage.Items.Add(dr[0]);
            }
            conn.connection().Close();

            //Type combobox fill process...
            SqlCommand cmdType = new SqlCommand("select (TYPE_NAME) from TBL_TYPE", conn.connection());
            SqlDataReader drType = cmdType.ExecuteReader();
            while (drType.Read())
            {
                cmbType.Items.Add(drType[0]);
            }
            conn.connection().Close();



        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            cmbType.Text = "";
            cmbSearchArea.Text = "";
            cmbLanguage.Text = "";

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //search all area all type all language
            if (txtSearch.Text != "" && cmbLanguage.Text == "" && cmbType.Text == "" && cmbSearchArea.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE (TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.COSUP_NAME LIKE '%" + txtSearch.Text + "%' OR	TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%') ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();
            }
            //search area==Author 
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Author" && cmbLanguage.Text == "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%'  ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Supervisor 
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Supervisor" && cmbLanguage.Text == "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.COSUP_NAME LIKE '%" + txtSearch.Text + "%' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Topic 
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Topic" && cmbLanguage.Text == "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Title 
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Title" && cmbLanguage.Text == "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Abstract 
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Abstract" && cmbLanguage.Text == "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Author + type!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Author" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Supervisor + type!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Supervisor" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Topic + type!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Topic" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Title + type!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Title" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Abstract + type!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Abstract" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Author + language!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Author" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Supervisor + language!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Supervisor" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Topic + language!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Topic" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Title + language!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Title" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==Abstract + language!=NULL
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Abstract" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }

            //search area==author +language+type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Author" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==supervisor +language+type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Supervisor" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==topic +language+type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Topic" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==title +language+type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Title" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //search area==abstract +language+type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "Abstract" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%' AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //  ONLY language
            if (txtSearch.Text != "" && cmbSearchArea.Text == "" && cmbLanguage.Text != "" && cmbType.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE (TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%') AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //  ONLY type
            if (txtSearch.Text != "" && cmbSearchArea.Text == "" && cmbLanguage.Text == "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE (TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%') AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }
            //  type + language
            if (txtSearch.Text != "" && cmbSearchArea.Text == "" && cmbLanguage.Text != "" && cmbType.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_THESIS.Author_ID=TBL_AUTHOR.Author_ID INNER JOIN TBL_TYPE ON TBL_THESIS.TYPE_ID=TBL_TYPE.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_THESIS.THESIS_NO=TBL_TOPICS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID WHERE (TBL_AUTHOR.Author_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.SUP_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_TOPICS.TOPIC_NAME LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.TITLE LIKE '%" + txtSearch.Text + "%' OR TBL_THESIS.ABSTRACT LIKE '%" + txtSearch.Text + "%') AND TBL_LANGUAGE.LANG_NAME LIKE '" + cmbLanguage.Text + "' AND TBL_TYPE.TYPE_NAME LIKE '" + cmbType.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtSearch.DataSource = dt;
                conn.connection().Close();

            }

        }
    }
}
