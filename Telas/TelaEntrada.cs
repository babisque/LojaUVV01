using Loja.App;
using Loja.Repositorio;
using LojaUVV.Repositorio;
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

namespace Loja.Telas
{
    public partial class TelaEntrada : MaterialForm
    {
        List<Produto> produtos = RepositorioProdutos.InicializadorProduto();
        List<Carrinho> carrinho = RepositorioCarrinho.InicializadorCarrinho();
        List<Pedido> pedidos = RepositorioPedidos.InicializadorPedido();
        List<Produto> produtosCompra = RepositorioProdutosCarrinho.InicializadorProdutosCarrinho();
        decimal total = 0.00m;
        Funcionario FuncionarioVerificado;

        public TelaEntrada(Funcionario funcionario)
        {
            InitializeComponent();
            FuncionarioVerificado = funcionario;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void TelaEntrada_Load(object sender, EventArgs e)
        {
            lsbxProdutos.Clear();
            lsbxPedidos.Clear();

            foreach (Produto produto in produtos)
            {
                lsbxProdutos.AddItem(produto.ToString());
            }

            foreach (Carrinho pedido in carrinho)
            {
                lsbxPedidos.AddItem(pedido.ToString());
            }

            txtQtd.Text = String.Empty;
            txtQtd.Focus();
            lblTotal.Text = $"Total: R$ {total}";
        }

        private void lsbxProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtQtd.Text) || int.Parse(txtQtd.Text) == 0)
            {
                MessageBox.Show("Quantidade inválida.");
                return;
            }

            var produto = produtos[lsbxProdutos.SelectedIndex];
            var quantidade = int.Parse(txtQtd.Text);

            if (VerificaQuantidade(produto, quantidade))
            {
                MessageBox.Show("Quantidade em estoque indisponível.");
                return;
            }

            carrinho.Add(new Carrinho(produto, quantidade, produto.Preco));
            produto.Quantidade -= quantidade;
            total += FuncionarioVerificado.CalculaDesconto(produto.Preco * quantidade);
            TelaEntrada_Load(sender, e);
        }

        private bool VerificaQuantidade(Produto produto, int quantidade)
        {
            if (quantidade > produto.Quantidade)
            {
                return true;
            }

            return false;
        }

        private void lsbxPedidos_DoubleClick(object sender, EventArgs e)
        {
            var carrinhoItem = carrinho[lsbxPedidos.SelectedIndex];
            var itemEstoque = carrinho[lsbxPedidos.SelectedIndex].Produto;
            Produto produto = produtos[produtos.FindIndex(p => p.Equals(itemEstoque))];

            carrinho.Remove(carrinhoItem);
            produto.Quantidade += carrinhoItem.Quantidade;
            total -= produto.Preco * carrinhoItem.Quantidade;
            TelaEntrada_Load(sender, e);
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            foreach (var item in carrinho)
            {
                produtosCompra.Add(item.Produto);
            }
            carrinho.Clear();            

            var pedido = new Pedido(FuncionarioVerificado, produtosCompra, total);
            total = 0.00m;
            pedidos.Add(pedido);
            TelaEntrada_Load(sender, e);
        }

        private void btnListaPedidos_Click(object sender, EventArgs e)
        {
            ListaPedidos tela = new ListaPedidos(pedidos);
            tela.ShowDialog();
        }
    }
}
