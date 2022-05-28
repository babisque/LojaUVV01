using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.App;

namespace Loja.Repositorio
{
    internal class RepositorioFuncionarios
    {
        public static List<Funcionario> InicializadorFuncionarios()
        {
            List<Funcionario> funcionarios = new List<Funcionario>();
            {
                funcionarios.Add(new Gerente("Rodrigo Babisque", "123", "2501"));
                funcionarios.Add(new Gerente("Kawan Mendes", "345", "2807"));
                funcionarios.Add(new Estagiario("Lucas Nunes", "567", "3009"));

                return funcionarios;
            }
        }
    }
}
