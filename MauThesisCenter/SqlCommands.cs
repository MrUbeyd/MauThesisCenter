using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MauThesisCenter
{
    class SqlCommands
    {
        public SqlConnection connection()
        {
            SqlConnection connect = new SqlConnection("Data Source=MSI\\SQLEXPRESS;Initial Catalog=MauThesisC;Integrated Security=True");
            connect.Open();
            return connect;
        }

    }
}
