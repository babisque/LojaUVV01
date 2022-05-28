namespace Loja.Telas
{
    partial class TelaEntrada
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lsbxProdutos = new MaterialSkin.Controls.MaterialListBox();
            this.lsbxPedidos = new MaterialSkin.Controls.MaterialListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtQtd = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.lblTotal = new MaterialSkin.Controls.MaterialLabel();
            this.btnFinalizarPedido = new MaterialSkin.Controls.MaterialButton();
            this.btnListaPedidos = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(6, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(65, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Produtos";
            // 
            // lsbxProdutos
            // 
            this.lsbxProdutos.BackColor = System.Drawing.Color.White;
            this.lsbxProdutos.BorderColor = System.Drawing.Color.LightGray;
            this.lsbxProdutos.Depth = 0;
            this.lsbxProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsbxProdutos.Location = new System.Drawing.Point(7, 129);
            this.lsbxProdutos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsbxProdutos.Name = "lsbxProdutos";
            this.lsbxProdutos.SelectedIndex = -1;
            this.lsbxProdutos.SelectedItem = null;
            this.lsbxProdutos.Size = new System.Drawing.Size(252, 315);
            this.lsbxProdutos.TabIndex = 2;
            this.lsbxProdutos.DoubleClick += new System.EventHandler(this.lsbxProdutos_DoubleClick);
            // 
            // lsbxPedidos
            // 
            this.lsbxPedidos.BackColor = System.Drawing.Color.White;
            this.lsbxPedidos.BorderColor = System.Drawing.Color.LightGray;
            this.lsbxPedidos.Depth = 0;
            this.lsbxPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsbxPedidos.Location = new System.Drawing.Point(440, 128);
            this.lsbxPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsbxPedidos.Name = "lsbxPedidos";
            this.lsbxPedidos.SelectedIndex = -1;
            this.lsbxPedidos.SelectedItem = null;
            this.lsbxPedidos.Size = new System.Drawing.Size(252, 316);
            this.lsbxPedidos.TabIndex = 3;
            this.lsbxPedidos.DoubleClick += new System.EventHandler(this.lsbxPedidos_DoubleClick);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(437, 106);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(61, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Carrinho";
            // 
            // txtQtd
            // 
            this.txtQtd.AnimateReadOnly = false;
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQtd.Depth = 0;
            this.txtQtd.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtQtd.LeadingIcon = null;
            this.txtQtd.Location = new System.Drawing.Point(273, 155);
            this.txtQtd.MaxLength = 50;
            this.txtQtd.MouseState = MaterialSkin.MouseState.OUT;
            this.txtQtd.Multiline = false;
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(152, 50);
            this.txtQtd.TabIndex = 5;
            this.txtQtd.Text = "";
            this.txtQtd.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(306, 133);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Quantidade";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Depth = 0;
            this.lblTotal.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblTotal.Location = new System.Drawing.Point(752, 355);
            this.lblTotal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(64, 19);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "ooooooo";
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFinalizarPedido.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnFinalizarPedido.Depth = 0;
            this.btnFinalizarPedido.HighEmphasis = true;
            this.btnFinalizarPedido.Icon = null;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(755, 128);
            this.btnFinalizarPedido.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFinalizarPedido.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnFinalizarPedido.Size = new System.Drawing.Size(149, 36);
            this.btnFinalizarPedido.TabIndex = 8;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFinalizarPedido.UseAccentColor = false;
            this.btnFinalizarPedido.UseVisualStyleBackColor = true;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnListaPedidos
            // 
            this.btnListaPedidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnListaPedidos.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnListaPedidos.Depth = 0;
            this.btnListaPedidos.HighEmphasis = true;
            this.btnListaPedidos.Icon = null;
            this.btnListaPedidos.Location = new System.Drawing.Point(756, 176);
            this.btnListaPedidos.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnListaPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnListaPedidos.Name = "btnListaPedidos";
            this.btnListaPedidos.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnListaPedidos.Size = new System.Drawing.Size(147, 36);
            this.btnListaPedidos.TabIndex = 9;
            this.btnListaPedidos.Text = "Lista de pedidos";
            this.btnListaPedidos.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnListaPedidos.UseAccentColor = false;
            this.btnListaPedidos.UseVisualStyleBackColor = true;
            this.btnListaPedidos.Click += new System.EventHandler(this.btnListaPedidos_Click);
            // 
            // TelaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.btnListaPedidos);
            this.Controls.Add(this.btnFinalizarPedido);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.txtQtd);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lsbxPedidos);
            this.Controls.Add(this.lsbxProdutos);
            this.Controls.Add(this.materialLabel1);
            this.Name = "TelaEntrada";
            this.Text = "Interface";
            this.Load += new System.EventHandler(this.TelaEntrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialListBox lsbxProdutos;
        private MaterialSkin.Controls.MaterialListBox lsbxPedidos;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txtQtd;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel lblTotal;
        private MaterialSkin.Controls.MaterialButton btnFinalizarPedido;
        private MaterialSkin.Controls.MaterialButton btnListaPedidos;
    }
}