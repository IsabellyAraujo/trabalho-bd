using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermercado.Modelo
{
    public class Produtos
    {
     

        
        private int codigo;
        public int codigoDoProduto
        {
            get {return codigo;}
         }
        
        private string descricao;
        public string descricaoDoProduto
        { 
            get {return descricao;}
        }

         private double valor;
        public double valorUnitario
        {
            get {return valor;}
        }

        public Produtos(int acodigo, string adescricao, double avalor)
        {
            this.codigo = acodigo;
            this.descricao = adescricao;
            this.valor = avalor;
        }
    }
}