using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace LojaUVV.App
{
    public class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; }
        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataPedido { get; set; }
        public decimal ValorProduto { get; set; }
        public string Descricao { get; set; }
        public decimal ValorTotal { get; set; }

        public static int globalId;
        
        public Pedido(string produto, int quantidade, string dataPedido, decimal valorProduto, string descricao, Cliente cliente)
        {
            Cliente = cliente;
            Produto = produto;
            Quantidade = quantidade;
            CultureInfo cultura = CultureInfo.CreateSpecificCulture("pt-BR");
            DataPedido = DateTime.Parse(dataPedido, cultura);
            ValorProduto = valorProduto;
            Descricao = descricao;
            ValorTotal = PrecoTotal(valorProduto, quantidade);
            Id = Interlocked.Increment(ref globalId);

        }

        public override string ToString() => $"{Id}, {Produto}, {Quantidade}, {DataPedido}, {ValorProduto}, {Descricao}";

        private decimal PrecoTotal(decimal valorProduto, int quantidade)
        {
            return valorProduto * quantidade;
        }
    }
}
