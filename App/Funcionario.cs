using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaUVV.App
{
    public abstract class Funcionario
    {
        protected Funcionario(string nome, string matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }

        private string Nome { get; set; }
        private string Matricula { get; set; }
        
        public abstract decimal CalculaDesconto(decimal valorTotalCompra);
        
    }
}
