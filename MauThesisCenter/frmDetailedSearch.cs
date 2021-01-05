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
    public partial class frmDetailedSearch : Form
    {
        public frmDetailedSearch()
        {
            InitializeComponent();
        }
        
        SqlCommands conn = new SqlCommands();
        
        //public string uniName;
        private void frmDetailedSearch_Load(object sender, EventArgs e)
        {
            //university combobox fill process...
            SqlCommand cmd = new SqlCommand("select (UNI_NAME) from TBL_UNIVERSITY;", conn.connection());
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbUniversity.Items.Add(dr[0]);
            }
            conn.connection().Close();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbUniversity.Text = "";
            cmbInstitute.Text = "";
            txtThesisNO.Text = "";
            txtYear.Text = "";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //only UNI
            if (cmbUniversity.Text != "" && cmbInstitute.Text == "" && txtYear.Text == "" && txtThesisNO.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //only Year
            if (cmbUniversity.Text == "" && cmbInstitute.Text == "" && txtYear.Text != "" && txtThesisNO.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_THESIS.YEAR  = '" + txtYear.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //only Thesis NO
            if (cmbUniversity.Text == "" && cmbInstitute.Text == "" && txtYear.Text == "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_THESIS.THESIS_NO  = '" + txtThesisNO.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //UNI + INSTITUTE
            if (cmbUniversity.Text != "" && cmbInstitute.Text != "" && txtYear.Text == "" && txtThesisNO.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' AND TBL_INSTITUTE.INS_NAME LIKE '" + cmbInstitute.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            // YEAR + Thesis NO
            if (cmbUniversity.Text == "" && cmbInstitute.Text == "" && txtYear.Text != "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_THESIS.YEAR = " + txtYear.Text + " AND TBL_THESIS.THESIS_NO = " + txtThesisNO.Text + " ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            // YEAR + UNI
            if (cmbUniversity.Text != "" && cmbInstitute.Text == "" && txtYear.Text != "" && txtThesisNO.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_THESIS.YEAR = " + txtYear.Text + " AND TBL_UNIVERSITY.UNI_NAME = '" + cmbUniversity.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            // THESIS NO + UNI
            if (cmbUniversity.Text != "" && cmbInstitute.Text == "" && txtYear.Text == "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_THESIS.THESIS_NO = " + txtThesisNO.Text + " AND TBL_UNIVERSITY.UNI_NAME = '" + cmbUniversity.Text + "' ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }

            //UNI + INSTITUTE + Year
            if (cmbUniversity.Text != "" && cmbInstitute.Text != "" && txtYear.Text != "" && txtThesisNO.Text == "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' AND TBL_INSTITUTE.INS_NAME LIKE '" + cmbInstitute.Text + "' AND TBL_THESIS.YEAR = " + txtYear.Text + " ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //UNI + INSTITUTE + Thesis NO
            if (cmbUniversity.Text != "" && cmbInstitute.Text != "" && txtYear.Text == "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' AND TBL_INSTITUTE.INS_NAME LIKE '" + cmbInstitute.Text + "' AND TBL_THESIS.THESIS_NO = " + txtThesisNO.Text + " ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //UNI + YEAR + Thesis NO
            if (cmbUniversity.Text != "" && cmbInstitute.Text == "" && txtYear.Text != "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' AND TBL_THESIS.YEAR = " + txtYear.Text + " AND TBL_THESIS.THESIS_NO = " + txtThesisNO.Text + " ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
            //UNI + YEAR + Thesis NO + INS
            if (cmbUniversity.Text != "" && cmbInstitute.Text != "" && txtYear.Text != "" && txtThesisNO.Text != "")
            {
                //load thesis data to dataGrid 
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME AS AUTHOR, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME AS TYPE, TBL_TOPICS.TOPIC_NAME AS TOPIC FROM TBL_THESIS INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_UNIVERSITY ON TBL_UNIVERSITY.UNI_ID=TBL_THESIS.UNI_ID INNER JOIN TBL_INSTITUTE ON TBL_INSTITUTE.INS_ID=TBL_THESIS.INS_ID WHERE TBL_UNIVERSITY.UNI_NAME LIKE '" + cmbUniversity.Text + "' AND TBL_THESIS.YEAR = " + txtYear.Text + " AND TBL_THESIS.THESIS_NO = " + txtThesisNO.Text + " AND TBL_INSTITUTE.INS_NAME LIKE '" + cmbInstitute.Text + "'ORDER BY TBL_THESIS.THESIS_NO", conn.connection());
                dt.Clear();
                da.Fill(dt);
                dtDetailedSearch.DataSource = dt;
                conn.connection().Close();
            }
        }
    }
}
