
namespace crud_teste.vieew
{
    partial class FrmProduto
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NomeDoProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Estoque = new System.Windows.Forms.TextBox();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Fabricante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PrecoDeVenda = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.PrecoDeCusto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.Location = new System.Drawing.Point(113, 50);
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.Size = new System.Drawing.Size(660, 20);
            this.NomeDoProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome Do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo De Barras: ";
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.Location = new System.Drawing.Point(114, 90);
            this.CodigoDeBarras.MaxLength = 15;
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.Size = new System.Drawing.Size(659, 20);
            this.CodigoDeBarras.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Preço De Venda:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(257, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preco De Custo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Estoque: ";
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(113, 170);
            this.Estoque.MaxLength = 14;
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(359, 20);
            this.Estoque.TabIndex = 12;
            this.Estoque.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Estoque_KeyPress);
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Location = new System.Drawing.Point(554, 172);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(50, 17);
            this.Ativo.TabIndex = 14;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fabricante: ";
            // 
            // Fabricante
            // 
            this.Fabricante.Location = new System.Drawing.Point(113, 210);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(660, 20);
            this.Fabricante.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(15, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 78);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.Location = new System.Drawing.Point(114, 130);
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            this.PrecoDeVenda.Negative = System.Drawing.Color.Red;
            this.PrecoDeVenda.Positive = System.Drawing.Color.Green;
            this.PrecoDeVenda.Size = new System.Drawing.Size(125, 20);
            this.PrecoDeVenda.StyleText = false;
            this.PrecoDeVenda.TabIndex = 49;
            this.PrecoDeVenda.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.PrecoDeVenda.Zero = System.Drawing.Color.Black;
            // 
            // PrecoDeCusto
            // 
            this.PrecoDeCusto.Location = new System.Drawing.Point(348, 130);
            this.PrecoDeCusto.Name = "PrecoDeCusto";
            this.PrecoDeCusto.Negative = System.Drawing.Color.Red;
            this.PrecoDeCusto.Positive = System.Drawing.Color.Green;
            this.PrecoDeCusto.Size = new System.Drawing.Size(124, 20);
            this.PrecoDeCusto.StyleText = false;
            this.PrecoDeCusto.TabIndex = 50;
            this.PrecoDeCusto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.PrecoDeCusto.Zero = System.Drawing.Color.Black;
            // 
            // FrmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.PrecoDeCusto);
            this.Controls.Add(this.PrecoDeVenda);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigoDeBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeDoProduto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProduto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.TextBox NomeDoProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CodigoDeBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Estoque;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Fabricante;
        private System.Windows.Forms.Button button1;
        private Config.Custom_Controls.MoneyTextBox PrecoDeVenda;
        private Config.Custom_Controls.MoneyTextBox PrecoDeCusto;
    }
}