using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermercado.Modelo
{
    public class itensVenda
    {
        public class itensVenda
        {
            private int id;
            public int Id
            {
                get { return id; }
            }

            private int id_venda;
            public int id_Venda
            {
                get { return id_venda; }
                set { id_venda = value; }
            }

            private int produtoCodigo;
            public int ProdutoCodigo
            {
                get { return produtoCodigo; }
                set { produtoCodigo = value; }
            }

            private int quantidade;
            public int quantidadeNoPedido
            {
                get { return quantidade; }
                set { quantidade = value; }
            }

            private double produtovalor;
            public double ProdutoValor
            {
                get { return produtovalor; }
                set { produtovalor = value; }
            }

            public itensVenda(int aid, int aid_venda, int aprodutoCodigo, int aquantidade, double aprodutovalor)
            {
                this.id = aid;
                this.id_venda = aid_venda;
                this.produtoCodigo = aprodutoCodigo;
                this.quantidade = aquantidade;
                this.produtovalor = aprodutovalor;
            }
        }
    }
}
