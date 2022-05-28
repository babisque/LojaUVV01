using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loja.App;

namespace Loja.Telas
{
    public partial class ListaPedidos : MaterialForm
    {
        List<Pedido> Pedidos;

        public ListaPedidos(List<Pedido> pedidos)
        {
            InitializeComponent();
            Pedidos = pedidos;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void ListaPedidos_Load(object sender, EventArgs e)
        {
            foreach (var item in Pedidos)
            {
                lsbxPedidos.AddItem(item.ToString());
            }
        }
    }
}
