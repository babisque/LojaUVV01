using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.App
{
    internal class Gerente : Funcionario, IAutenticavel
    {
        public Gerente(string nome, string matricula, string senha) : base(nome, matricula, senha)
        {
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        public override decimal CalculaDesconto(decimal valorTotalCompra)
        {

            return valorTotalCompra -= (valorTotalCompra*0.1m);

        }
    }
}
