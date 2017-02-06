using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermercado.Modelo
{
    public class Qtd_Produto
    {
        private int codigo;
        public int codigoDoProduto
        {
            get { return codigo; }
        }

        private string descricao;
        public string descricaoDoProduto
        {
            get { return descricao; }
        }

        private double valor;
        public double valorUnitario
        {
            get { return valor; }
        }

        private int quantidade;
        public int quantidadeNoPedido
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        private int valort;
        public int valorTotal
        {
            get { return valort; }
            set { valort = value; }
        }
        public Qtd_Produto(int acodigo, string adescricao, double avalor, int aquantidade)
        {
            this.codigo = acodigo;
            this.descricao = adescricao;
            this.valor = avalor;
            this.quantidade = aquantidade;
            this.valorTotal = avalor * aquantidade;
        }

        //public override bool Equals(object obj)
        //{
        //    if (obj == null) return false;
        //    Qtd_Produto other = obj as Qtd_Produto;
        //    if (other == null) return false;
        //    return other.codigo == this.codigo;
        //}

        //public override int GetHashCode()
        //{
        //    return codigo.GetHashCode();
        //}

    }
}