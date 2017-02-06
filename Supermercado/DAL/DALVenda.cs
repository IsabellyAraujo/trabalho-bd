using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace Supermercado.DAL
{
    public class DALVenda
    { 
        string connectionString = "";

        public DALVenda()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SupermercadoConnectionString"].ConnectionString; 
        }

    }
}