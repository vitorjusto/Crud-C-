
namespace crud_teste.vieew.TelaDeVenda
{
    partial class AlterarProdutoDoCarrinho
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidadeRestante = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNomeDoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPrecoUnitario = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtPrecoBruto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtDesconto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtPrecoLiquido = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrecoLiquido);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtPrecoBruto);
            this.groupBox1.Controls.Add(this.txtPrecoUnitario);
            this.groupBox1.Controls.Add(this.txtQuantidadeRestante);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtQuantidadeEmEstoque);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNomeDoProduto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // txtQuantidadeRestante
            // 
            this.txtQuantidadeRestante.Location = new System.Drawing.Point(160, 180);
            this.txtQuantidadeRestante.Name = "txtQuantidadeRestante";
            this.txtQuantidadeRestante.ReadOnly = true;
            this.txtQuantidadeRestante.Size = new System.Drawing.Size(197, 20);
            this.txtQuantidadeRestante.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 184);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Quantidade Restante: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preço Bruto: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Preço Unitário:";
            // 
            // txtQuantidadeEmEstoque
            // 
            this.txtQuantidadeEmEstoque.Location = new System.Drawing.Point(160, 130);
            this.txtQuantidadeEmEstoque.Name = "txtQuantidadeEmEstoque";
            this.txtQuantidadeEmEstoque.ReadOnly = true;
            this.txtQuantidadeEmEstoque.Size = new System.Drawing.Size(197, 20);
            this.txtQuantidadeEmEstoque.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantidade em estoque:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(160, 80);
            this.txtQuantidade.MaxLength = 14;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(197, 20);
            this.txtQuantidade.TabIndex = 19;
            this.txtQuantidade.TextChanged += new System.EventHandler(this.txtQuantidade_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantidade:";
            // 
            // txtNomeDoProduto
            // 
            this.txtNomeDoProduto.Location = new System.Drawing.Point(160, 30);
            this.txtNomeDoProduto.Multiline = true;
            this.txtNomeDoProduto.Name = "txtNomeDoProduto";
            this.txtNomeDoProduto.ReadOnly = true;
            this.txtNomeDoProduto.Size = new System.Drawing.Size(197, 19);
            this.txtNomeDoProduto.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço Liquido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Do Produto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(481, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 81);
            this.button1.TabIndex = 17;
            this.button1.Text = "Alterar no carrinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(471, 30);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Negative = System.Drawing.Color.Red;
            this.txtPrecoUnitario.Positive = System.Drawing.Color.Green;
            this.txtPrecoUnitario.ReadOnly = true;
            this.txtPrecoUnitario.Size = new System.Drawing.Size(124, 20);
            this.txtPrecoUnitario.StyleText = false;
            this.txtPrecoUnitario.TabIndex = 27;
            this.txtPrecoUnitario.Zero = System.Drawing.Color.Black;
            // 
            // txtPrecoBruto
            // 
            this.txtPrecoBruto.Location = new System.Drawing.Point(471, 80);
            this.txtPrecoBruto.Name = "txtPrecoBruto";
            this.txtPrecoBruto.Negative = System.Drawing.Color.Red;
            this.txtPrecoBruto.Positive = System.Drawing.Color.Green;
            this.txtPrecoBruto.ReadOnly = true;
            this.txtPrecoBruto.Size = new System.Drawing.Size(124, 20);
            this.txtPrecoBruto.StyleText = false;
            this.txtPrecoBruto.TabIndex = 28;
            this.txtPrecoBruto.Zero = System.Drawing.Color.Black;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(471, 130);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Negative = System.Drawing.Color.Red;
            this.txtDesconto.Positive = System.Drawing.Color.Green;
            this.txtDesconto.Size = new System.Drawing.Size(124, 20);
            this.txtDesconto.StyleText = false;
            this.txtDesconto.TabIndex = 29;
            this.txtDesconto.Zero = System.Drawing.Color.Black;
            // 
            // txtPrecoLiquido
            // 
            this.txtPrecoLiquido.Location = new System.Drawing.Point(471, 180);
            this.txtPrecoLiquido.Name = "txtPrecoLiquido";
            this.txtPrecoLiquido.Negative = System.Drawing.Color.Red;
            this.txtPrecoLiquido.Positive = System.Drawing.Color.Green;
            this.txtPrecoLiquido.ReadOnly = true;
            this.txtPrecoLiquido.Size = new System.Drawing.Size(124, 20);
            this.txtPrecoLiquido.StyleText = false;
            this.txtPrecoLiquido.TabIndex = 30;
            this.txtPrecoLiquido.Zero = System.Drawing.Color.Black;
            // 
            // AlterarProdutoDoCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 381);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "AlterarProdutoDoCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterarProdutoDoCarrinho";
            this.Load += new System.EventHandler(this.AlterarProdutoDoCarrinho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantidadeRestante;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantidadeEmEstoque;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNomeDoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private Config.Custom_Controls.MoneyTextBox txtPrecoLiquido;
        private Config.Custom_Controls.MoneyTextBox txtDesconto;
        private Config.Custom_Controls.MoneyTextBox txtPrecoBruto;
        private Config.Custom_Controls.MoneyTextBox txtPrecoUnitario;
    }
}