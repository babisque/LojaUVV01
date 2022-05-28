using Loja.Repositorio;
using Loja.App;
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
using Loja.Telas;


namespace Loja
{
    public partial class Form1 : MaterialForm
    {
        List<Funcionario> funcionarios = RepositorioFuncionarios.InicializadorFuncionarios();
        Funcionario funcVerificado = null;

        public Form1()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan800, Primary.Cyan900, Primary.Cyan500, Accent.Cyan200, TextShade.WHITE);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Autenticar())
            {
                TelaEntrada telaEntrada = new TelaEntrada(funcVerificado);
                telaEntrada.ShowDialog();
            }
            else
            {
                lblMesage.Text = "Credenciais incorretas";
            }
        }

        private bool Autenticar()
        {
            foreach (var funcionario in funcionarios)
            {
                if (funcionario.Matricula == txtMatricula.Text && funcionario.Senha == txtSenha.Text)
                {
                    funcVerificado = funcionario;
                    return true;
                }
            }

            return false;
        }
    }
}
