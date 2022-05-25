using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaUVV.App;
namespace LojaUVV.Repositorio
{
    internal class RepositorioPedidos
    {
        public static List<Pedido> InicializadorPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            {
                pedidos.Add(new Pedido("Memória RAM", 2, "20/05/2022", 500, "memoria pika", new Cliente("Rodrigo", "123.456.789-10")));
                pedidos.Add(new Pedido("CPU", 3, "20/05/2022", 1000, "CPU pika", new Cliente("Kawan", "078.265.178-08")));

                return pedidos;
            }

       }
       
      

        
        


    }
}
