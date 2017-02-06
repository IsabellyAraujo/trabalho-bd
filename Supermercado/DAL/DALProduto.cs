using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Supermercado.Modelo;
namespace Supermercado.DAL
{
    public class DALProduto
    {
       string connectionString = "";

        public DALProduto()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SupermercadoConnectionString"].ConnectionString;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produtos> SelectTodos()
        {
            Modelo.Produtos aProduto;
            List<Modelo.Produtos> aListProdutos = new List<Modelo.Produtos>();
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand comm = con.CreateCommand();
            comm.CommandText = "Select * from Produtos";

            System.Data.SqlClient.SqlDataReader dr = comm.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProduto = new Modelo.Produtos(Convert.ToInt32(dr[0]), dr[1] as string, Convert.ToDouble(dr[2]));
                    aListProdutos.Add(aProduto);
                }
            }

            dr.Close();
            con.Close();
            return aListProdutos;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public Modelo.Produtos SelectId(int codigo)
        {
            Modelo.Produtos aProduto;
            System.Data.SqlClient.SqlConnection con= new System.Data.SqlClient.SqlConnection(connectionString);
            con.Open();

            System.Data.SqlClient.SqlCommand comm = con.CreateCommand();
            comm.CommandText = "Select * from Produtos where codigo = @codigo";
            comm.Parameters.AddWithValue("@codigo", codigo);

            System.Data.SqlClient.SqlDataReader dr = comm.ExecuteReader();
            dr.Read();

            aProduto = new Modelo.Produtos(Convert.ToInt32(dr[0]), dr[1] as string, Convert.ToDouble(dr[2]));

            dr.Close();
            con.Close();

            return aProduto;
        }

        
    }
}