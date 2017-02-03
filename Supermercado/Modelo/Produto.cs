using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermercado.Modelo
{
    public class Produto
    {
      

        public int id { get; set; }
        public int codigoDoProduto { get; set; }
        public string descricaoDoProduto { get; set; }
        public int quantidadeNoPedido { get; set; }
        public int quantidadeEmEstoque { get; set; }
        public float valorUnitario { get; set; }

        public Produto()
        {
            this.id = 0;
            this.codigoDoProduto = 0;
            this.descricaoDoProduto = "";
            this.quantidadeNoPedido = 0;
            this.quantidadeEmEstoque = 0;
            this.valorUnitario = 0;
        }

        public Produto(int aid, int acodigoDoProduto, string adescricaoDoProduto, int aquantidadeNoPedido, int aquantidadeEmEstoque, float avalorUnitario)
        {
            this.id = aid;
            this.codigoDoProduto = acodigoDoProduto;
            this.descricaoDoProduto = adescricaoDoProduto;
            this.quantidadeNoPedido = aquantidadeNoPedido;
            this.quantidadeEmEstoque = aquantidadeEmEstoque;
            this.valorUnitario = avalorUnitario;
        }

    }
}