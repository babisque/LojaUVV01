using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.App
{
    internal class Estagiario : Funcionario, IAutenticavel
    {
        public Estagiario(string nome, string matricula, string senha) : base(nome, matricula, senha)
        {
        }
               

        public bool Autenticar(string senha) => Senha == senha;

        public override decimal CalculaDesconto(decimal valorTotalCompra)
        {
            return valorTotalCompra -= (valorTotalCompra * 0.05m); 
        }
    }
}
