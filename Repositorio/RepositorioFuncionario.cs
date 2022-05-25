using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaUVV.App;

namespace LojaUVV.Repositorio
{
    internal class RepositorioFuncionario
    {
        public static List<Funcionario> InicializadorPedidos()
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
