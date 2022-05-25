using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaUVV.App
{
    internal class Gerente : Funcionario, IAutenticavel
    {
        private string Senha { get; set; }
        public Gerente(string nome, string matricula, string senha) : base(nome, matricula)
        {
            Senha = senha;
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
