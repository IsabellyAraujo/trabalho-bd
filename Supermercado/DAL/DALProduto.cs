//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Configuration;
//using System.ComponentModel;
//namespace Supermercado.DAL
//{
//    public class DALProduto
//    {
//        string connectionString = "";

//        public DALProduto()
//        {
//            connectionString = ConfigurationManager.ConnectionStrings["SupermercadoConnectionString"].ConnectionString;
//        }
//        //Modelo Tarefa LISTAR 
//        [DataObjectMethod(DataObjectMethodType.Select)]
//        public List<Modelo.Produto> 
//        {
//            Modelo.Produto aProduto;
//            List<Modelo.Produto> aListProduto = new List<Modelo.Produto>();
            
//            SqlConnection conn = new SqlConnection(connectionString);
//            conn.Open();

//            SqlCommand cmd = new SqlCommand("Select id, codigoDoProduto, descricaoDoProduto, quantidade, valorUnitario from Produto", conn);
//            cmd.Parameters.AddWithValue("@quantidade", quantidade);
//            SqlDataReader dr = cmd.ExecuteReader();

//            if (dr.HasRows)
//            {
//                while (dr.Read())
//                {
//                        aTarefa = new Modelo.Tarefa(
//                            Convert.ToInt32(dr["id"]),
//                            dr["descricao"].ToString(),
//                            Convert.ToBoolean(dr["cumprida"]),
//                            Convert.ToBoolean(dr["prioritaria"]),
//                            Convert.ToDateTime(dr["horarioDeEnvio"]),
//                            dr["usuario_id"].ToString());                    
//                    aListTarefa.Add(aTarefa);
     
//                }
//            }

//            dr.Close();
//            conn.Close();

//            return aListTarefa;
//        }
//    }
//}