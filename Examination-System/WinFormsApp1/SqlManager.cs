﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public class SqlManager
    {
        public SqlConnection sqlConnection()
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IVPEDOC;Initial Catalog=ExaminationSystem;Integrated Security=True");
            connection.Open();
            return connection;
        }


        /*public void sqlConnection(string connection)
        {
            SqlConnection sqlConnection = new SqlConnection(connection);
            sqlConnection.Open();
        }*/
    }
}
