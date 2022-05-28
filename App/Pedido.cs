using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.App
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Data { get; set; }
        public Funcionario Funcionario { get; set; }
        public ICollection<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }

        public Pedido(Funcionario funcionario, List<Produto> produtos, decimal valorTotal)
        {
            CultureInfo cultura = CultureInfo.CreateSpecificCulture("pt-BR");
            Data = DateTime.Now.ToString("dd/MM/yyyy", cultura);
            Funcionario = funcionario;
            Produtos = produtos;
            ValorTotal = valorTotal;
        }

        public override string ToString() => $"{Data}, {Funcionario.Nome}, R$ {ValorTotal}";
    }
}
