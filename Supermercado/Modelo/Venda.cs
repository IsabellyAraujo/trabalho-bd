using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supermercado.Modelo
{
    public class Venda
    {
        private int id;
        public int Id
        {
            get { return id; }
        }

        private DateTime dataDeVenda;
        public DateTime dataVenda
        {
            get { return dataDeVenda; }
        }

        private double valorTotal;
        public double ValorTotal
        {
            get { return valorTotal; }
        }
        private string nomeCliente;
        public string nome
        {
            get { return nomeCliente; }
            set { nomeCliente = value; }
        }

        public Venda(int aid, DateTime adataVenda, double avalorTotal, string anome)
        {
            this.id = aid;
            this.dataVenda = adataVenda;
            this.valorTotal = avalorTotal;
            this.nome = anome;
        }
    }
}