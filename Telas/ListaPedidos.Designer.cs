namespace Loja.Telas
{
    partial class ListaPedidos
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
            this.lsbxPedidos = new MaterialSkin.Controls.MaterialListBox();
            this.SuspendLayout();
            // 
            // lsbxPedidos
            // 
            this.lsbxPedidos.BackColor = System.Drawing.Color.White;
            this.lsbxPedidos.BorderColor = System.Drawing.Color.LightGray;
            this.lsbxPedidos.Depth = 0;
            this.lsbxPedidos.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lsbxPedidos.Location = new System.Drawing.Point(6, 145);
            this.lsbxPedidos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lsbxPedidos.Name = "lsbxPedidos";
            this.lsbxPedidos.SelectedIndex = -1;
            this.lsbxPedidos.SelectedItem = null;
            this.lsbxPedidos.Size = new System.Drawing.Size(788, 467);
            this.lsbxPedidos.TabIndex = 0;
            // 
            // ListaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 618);
            this.Controls.Add(this.lsbxPedidos);
            this.Name = "ListaPedidos";
            this.Text = "ListaPedidos";
            this.Load += new System.EventHandler(this.ListaPedidos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialListBox lsbxPedidos;
    }
}