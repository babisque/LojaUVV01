using Loja.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Repositorio
{
    public class RepositorioProdutos
    {
        public static List<Produto> InicializadorProduto()
        {
            List<Produto> produtos = new List<Produto>();
            {
                produtos.Add(new Produto("Teclado", 08, 120.00m));
                produtos.Add(new Produto("Mouse Bungee", 4, 70.00m));
                produtos.Add(new Produto("Mouse", 27, 65.00m));
                produtos.Add(new Produto("Teclado", 30, 80.00m));
                produtos.Add(new Produto("Notebook", 2, 3500.59m));
                produtos.Add(new Produto("Celular", 19, 1500.70m));
                produtos.Add(new Produto("Tablete", 20, 980.00m));
                produtos.Add(new Produto("Projetor", 2, 174.50m));
                produtos.Add(new Produto("SSD", 13, 250.79m));
                produtos.Add(new Produto("Gabinete", 7, 200.00m));
                produtos.Add(new Produto("Processador", 17, 378.99m));

                return produtos;
            }
        }
    }
}
