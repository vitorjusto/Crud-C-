
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
            this.Estoque = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CodigoDeBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomeDoProduto = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.btnAtivo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAtivo = new System.Windows.Forms.TextBox();
            this.PrecoDeVenda = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.PrecoDeCusto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Fabricante
            // 
            this.Fabricante.Location = new System.Drawing.Point(116, 210);
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.Size = new System.Drawing.Size(669, 20);
            this.Fabricante.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Fabricante: ";
            // 
            // Estoque
            // 
            this.Estoque.Location = new System.Drawing.Point(116, 170);
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(669, 20);
            this.Estoque.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Estoque: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Preco De Custo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Preço De Venda:";
            // 
            // CodigoDeBarras
            // 
            this.CodigoDeBarras.Location = new System.Drawing.Point(117, 90);
            this.CodigoDeBarras.MaxLength = 15;
            this.CodigoDeBarras.Name = "CodigoDeBarras";
            this.CodigoDeBarras.Size = new System.Drawing.Size(674, 20);
            this.CodigoDeBarras.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 94);
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
            this.NomeDoProduto.Location = new System.Drawing.Point(116, 50);
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.Size = new System.Drawing.Size(675, 20);
            this.NomeDoProduto.TabIndex = 1;
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
            // BotaoSalvar
            // 
            this.BotaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotaoSalvar.Location = new System.Drawing.Point(18, 325);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(259, 79);
            this.BotaoSalvar.TabIndex = 7;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = false;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // btnAtivo
            // 
            this.btnAtivo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAtivo.Location = new System.Drawing.Point(553, 325);
            this.btnAtivo.Name = "btnAtivo";
            this.btnAtivo.Size = new System.Drawing.Size(232, 79);
            this.btnAtivo.TabIndex = 8;
            this.btnAtivo.Text = "Inativar";
            this.btnAtivo.UseVisualStyleBackColor = false;
            this.btnAtivo.Click += new System.EventHandler(this.btnAtivo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 71;
            this.label4.Text = "Status: ";
            // 
            // txtAtivo
            // 
            this.txtAtivo.Location = new System.Drawing.Point(599, 281);
            this.txtAtivo.Name = "txtAtivo";
            this.txtAtivo.ReadOnly = true;
            this.txtAtivo.Size = new System.Drawing.Size(186, 20);
            this.txtAtivo.TabIndex = 72;
            this.txtAtivo.TabStop = false;
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.Location = new System.Drawing.Point(117, 130);
            this.PrecoDeVenda.MaxLength = 15;
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            this.PrecoDeVenda.Negative = System.Drawing.Color.Red;
            this.PrecoDeVenda.Positive = System.Drawing.Color.Green;
            this.PrecoDeVenda.Size = new System.Drawing.Size(100, 20);
            this.PrecoDeVenda.StyleText = false;
            this.PrecoDeVenda.TabIndex = 3;
            this.PrecoDeVenda.Zero = System.Drawing.Color.Black;
            // 
            // PrecoDeCusto
            // 
            this.PrecoDeCusto.Location = new System.Drawing.Point(359, 130);
            this.PrecoDeCusto.MaxLength = 15;
            this.PrecoDeCusto.Name = "PrecoDeCusto";
            this.PrecoDeCusto.Negative = System.Drawing.Color.Red;
            this.PrecoDeCusto.Positive = System.Drawing.Color.Green;
            this.PrecoDeCusto.Size = new System.Drawing.Size(100, 20);
            this.PrecoDeCusto.StyleText = false;
            this.PrecoDeCusto.TabIndex = 4;
            this.PrecoDeCusto.Zero = System.Drawing.Color.Black;
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.PrecoDeCusto);
            this.Controls.Add(this.PrecoDeVenda);
            this.Controls.Add(this.txtAtivo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAtivo);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.Fabricante);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Estoque);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CodigoDeBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeDoProduto);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ConsultarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarProduto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fabricante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Estoque;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CodigoDeBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NomeDoProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Button btnAtivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAtivo;
        private Config.Custom_Controls.MoneyTextBox PrecoDeVenda;
        private Config.Custom_Controls.MoneyTextBox PrecoDeCusto;
    }
}