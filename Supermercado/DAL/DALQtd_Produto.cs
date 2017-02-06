using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Supermercado.DAL
{
    public class DALQtd_Produto
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Qtd_Produto> Select(List<Modelo.Qtd_Produto> produtos)
        {
            return produtos;
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<Modelo.Qtd_Produto> Update(List<Modelo.Qtd_Produto> produtos, int index, int quantidade)
        {
            produtos[index].quantidadeNoPedido = quantidade;
            produtos[index].valorTotal = produtos[index].valorUnitario * quantidade;
            return produtos;
        }
    }
}