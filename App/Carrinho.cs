using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace Loja.App
{
    public class Carrinho
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorProduto { get; set; }
        public decimal ValorTotal { get; set; }

        public static int globalId;
        
        public Carrinho(Produto produto, int quantidade, decimal valorProduto)
        {
            Produto = produto;
            Quantidade = quantidade;
            ValorProduto = valorProduto;
            ValorTotal = PrecoTotal(valorProduto, quantidade);
            Id = Interlocked.Increment(ref globalId);
        }

        public override string ToString() => $"{Produto.Nome}, {Quantidade}, {ValorProduto * Quantidade}";

        private decimal PrecoTotal(decimal valorProduto, int quantidade)
        {
            return valorProduto * quantidade;
        }
    }
}
