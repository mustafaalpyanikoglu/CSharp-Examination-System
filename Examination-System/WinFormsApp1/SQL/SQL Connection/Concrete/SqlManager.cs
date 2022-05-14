using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    public class SqlManager:ISqlService
    {
        public SqlConnection sqlConnection() //Sql'i her seferinde tek tek bağlamak yerine bir class oluşturduk ve bunu çağırıyoruz
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-IVPEDOC;Initial Catalog=ExaminationSystem;Integrated Security=True");
            connection.Open();
            return connection;
        }
    }
}
