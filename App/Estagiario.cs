using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaUVV.App
{
    internal class Estagiario : Funcionario, IAutenticavel
    {
        public string Senha { get; private set; }

        public Estagiario(string nome, string matricula, string senha) : base(nome, matricula)
        {
            Senha = senha;
        }
               

        public bool Autenticar(string senha) => Senha == senha;

        public override decimal CalculaDesconto(decimal valorTotalCompra)
        {
            return valorTotalCompra -= (valorTotalCompra * 0.05m); 
        }
    }
}
