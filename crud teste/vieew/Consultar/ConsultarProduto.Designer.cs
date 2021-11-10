
namespace crud_teste.vieew.Consultar
{
    partial class ConsultarProduto
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
            this.Fabricante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Ativo = new System.Windows.Forms.CheckBox();
            this.Estoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrecoDeCusto = new System.Windows.Forms.TextBox();
            this.DescontoAVista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrecoDeVenda = new System.Windows.Forms.TextBox();
            this.CodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeDoProduto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Excluir = new System.Windows.Forms.Button();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fabricante
            // 
            this.Fabricante.Location = new System.Drawing.Point(116, 269);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(669, 20);
            this.Fabricante.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fabricante: ";
            // 
            // Ativo
            // 
            this.Ativo.AutoSize = true;
            this.Ativo.Location = new System.Drawing.Point(425, 216);
            this.Ativo.Name = "Ativo";
            this.Ativo.Size = new System.Drawing.Size(50, 17);
            this.Ativo.TabIndex = 30;
            this.Ativo.Text = "Ativo";
            this.Ativo.UseVisualStyleBackColor = true;
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(116, 213);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(238, 20);
            this.Estoque.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estoque: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Preco De Custo:";
            // 
            // PrecoDeCusto
            // 
            this.PrecoDeCusto.Location = new System.Drawing.Point(375, 158);
            this.PrecoDeCusto.Name = "PrecoDeCusto";
            this.PrecoDeCusto.Size = new System.Drawing.Size(100, 20);
            this.PrecoDeCusto.TabIndex = 26;
            // 
            // DescontoAVista
            // 
            this.DescontoAVista.Location = new System.Drawing.Point(685, 158);
            this.DescontoAVista.Name = "DescontoAVista";
            this.DescontoAVista.Size = new System.Drawing.Size(106, 20);
            this.DescontoAVista.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Desconto A Vista:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Preço De Venda:";
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.Location = new System.Drawing.Point(117, 158);
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            this.PrecoDeVenda.Size = new System.Drawing.Size(100, 20);
            this.PrecoDeVenda.TabIndex = 22;
            this.PrecoDeVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PrecoDeVenda_KeyPress);
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.Location = new System.Drawing.Point(117, 104);
            this.CodigoDeBarras.MaxLength = 15;
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.Size = new System.Drawing.Size(674, 20);
            this.CodigoDeBarras.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Codigo De Barras: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nome Do Produto:";
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.Location = new System.Drawing.Point(116, 51);
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.Size = new System.Drawing.Size(675, 20);
            this.NomeDoProduto.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Red;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Excluir.Location = new System.Drawing.Point(526, 342);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(259, 79);
            this.Excluir.TabIndex = 69;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotaoSalvar.Location = new System.Drawing.Point(18, 342);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(259, 79);
            this.BotaoSalvar.TabIndex = 68;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = false;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ativo);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PrecoDeCusto);
            this.Controls.Add(this.DescontoAVista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PrecoDeVenda);
            this.Controls.Add(this.CodigoDeBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeDoProduto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConsultarProduto";
            this.Text = "ConsultarProduto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fabricante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox Ativo;
        private System.Windows.Forms.TextBox Estoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrecoDeCusto;
        private System.Windows.Forms.TextBox DescontoAVista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PrecoDeVenda;
        private System.Windows.Forms.TextBox CodigoDeBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeDoProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.Button BotaoSalvar;
    }
}