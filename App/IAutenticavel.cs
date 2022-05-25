using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaUVV.App
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha);
               
    }
}
