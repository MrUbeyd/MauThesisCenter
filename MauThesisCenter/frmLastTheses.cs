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
    public partial class frmLastTheses : Form
    {
        public frmLastTheses()
        {
            InitializeComponent();
        }
        
        
        
        SqlConnection conn = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MauThesisC;Integrated Security=True");

        private void frmLastTheses_Load(object sender, EventArgs e)
        {
            
            dtLastTheses.DataSource = printLastTheses();
            
        }

        private object printLastTheses()
        {
            DataTable dtLastTheses = new DataTable();
            using (conn)
            {
                //tezleri cekerken author name uniname vs de cekmeliyiz !!!
                using(SqlCommand command = new SqlCommand("SELECT TBL_THESIS.THESIS_NO, TBL_AUTHOR.Author_NAME, TBL_THESIS.YEAR, TBL_THESIS.TITLE, TBL_THESIS.ABSTRACT, TBL_TYPE.TYPE_NAME, TBL_TOPICS.TOPIC_NAME, TBL_LANGUAGE.LANG_NAME, TBL_THESIS.SUP_NAME, TBL_THESIS.COSUP_NAME, TBL_THESIS.SUB_DATE, TBL_THESIS.NUMBER_OF_PAGES FROM TBL_THESIS INNER JOIN TBL_TYPE ON TBL_TYPE.TYPE_ID=TBL_THESIS.TYPE_ID INNER JOIN TBL_AUTHOR ON TBL_AUTHOR.Author_ID=TBL_THESIS.Author_ID INNER JOIN TBL_TOPICS ON TBL_TOPICS.THESIS_NO=TBL_THESIS.THESIS_NO INNER JOIN TBL_LANGUAGE ON TBL_LANGUAGE.LANG_ID=TBL_THESIS.LANG_ID ORDER BY THESIS_NO DESC", conn))
                {
                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dtLastTheses.Load(reader);
                    conn.Close();
                }
            }

            return dtLastTheses;
        }

        
    }
}
