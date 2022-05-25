using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaUVV
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }

        private int globalId;

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            CPF = cpf;
            ClienteId = Interlocked.Increment(ref globalId);

        }


    }
}