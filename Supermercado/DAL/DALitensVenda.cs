using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace Supermercado.DAL
{
    public class DALitensVenda
    {
        string connectionString = "";

        public DALitensVenda()
        {
            connectionString = ConfigurationManager.ConnectionStrings["MercadoConnectionString"].ConnectionString;
        }

       

    }
}