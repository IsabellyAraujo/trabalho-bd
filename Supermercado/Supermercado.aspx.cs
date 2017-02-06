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
            if (e.CommandName == "Adicionar_carrinho")
            {
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    int codigo = Convert.ToInt32(GridViewProduto.Rows[index].Cells[0].Text);

                }

            }
        }
    }
}