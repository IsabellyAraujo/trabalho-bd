using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
namespace Supermercado.DAL
{
    public class DALProduto
    {
        string connectionString = "";
        private object id;

        public DALProduto()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SupermercadoConnectionString"].ConnectionString;
        }
        //Modelo Tarefa LISTAR 
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Produto> SelectOne (string id)
        {
            Modelo.Produto aProduto;
            List<Modelo.Produto> aListProduto = new List<Modelo.Produto>();

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select id, codigoDoProduto, descricaoDoProduto, quantidadeNoPedido, quantidadeEmEstoque, valorUnitario from Produtos where id = @id", conn);
            cmd.Parameters.AddWithValue("@id", id);

            SqlDataReader dr = cmd.ExecuteReader();

           if (dr.HasRows)
            {
                while (dr.Read())
                {
                    aProduto = new Modelo.Produto(
                            Convert.ToInt32(dr["id"]),
                            Convert.ToInt32(dr["codigoDoProduto"]),
                            (dr["descricaoDoProduto"].ToString()),
                            Convert.ToInt32(dr["quantidadeNoPedido"]),
                            Convert.ToInt32(dr["quantidadeEmEstoque"]),
                            Convert.(dr["valorUnitario"])
                            );
                }
            }

           dr.Close();
           conn.Close();
           return aListProduto;
        }
    }
}