﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    interface ISqlService
    {
        //Sql ile bağlantı kurmamızı sağlar
        public SqlConnection sqlConnection();
    }
}
