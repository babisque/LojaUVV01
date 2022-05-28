using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.App
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }

        protected Funcionario(string nome, string matricula, string senha)
        {
            Nome = nome;
            Matricula = matricula;
            Senha = senha;
        }

        public abstract decimal CalculaDesconto(decimal valorTotalCompra);
        
    }
}
