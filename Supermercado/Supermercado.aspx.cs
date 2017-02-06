using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Supermercado
{
    public partial class Supermercado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridViewProduto_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Verifica se o comando é "Editar"
            if (e.CommandName == "Adicionar_carrinho")
            {
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int codigo = Convert.ToInt32(GridViewProduto.Rows[index].Cells[0].Text);

                    //Modelo.Produtos item = DALProduto.SelectId(codigo);
                    //Modelo.Qtd_Produto itemCarrinho = new Modelo.Qtd_Produto(item.codigo, item.Nome, item.Valor, 1);

                    //List<Modelo.ProdutoQtd> itensCarrinho = (List<Modelo.ProdutoQtd>)Session["Salvar"];
                    //if (!itensCarrinho.Contains(itemCarrinho)) { itensCarrinho.Add(itemCarrinho); }
                }

            }
        }
    }
}