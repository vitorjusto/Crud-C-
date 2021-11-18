
namespace crud_teste.vieew
{
    partial class CadastroDePedidos
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
            this.components = new System.ComponentModel.Container();
            this.NomeCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeDoColaborador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FormaDePagamento = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PrecoBruto = new System.Windows.Forms.TextBox();
            this.QuantidadeRestante = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PrecoUnitario = new System.Windows.Forms.TextBox();
            this.QuantidadeEmEstoque = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Quantidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PrecoLiquido = new System.Windows.Forms.TextBox();
            this.Desconto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeDoProduto = new System.Windows.Forms.TextBox();
            this.DescontoAVista = new System.Windows.Forms.TextBox();
            this.labeledit = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LimiteDeCompraaPraso = new System.Windows.Forms.TextBox();
            this.labelLimite = new System.Windows.Forms.Label();
            this.TotalLiquido = new System.Windows.Forms.TextBox();
            this.TotalDesconto = new System.Windows.Forms.TextBox();
            this.TotalBruto = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.QuantidadeTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.QuantidadeUnitario = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NomeCliente
            // 
            this.NomeCliente.Location = new System.Drawing.Point(167, 40);
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            this.NomeCliente.Size = new System.Drawing.Size(334, 20);
            this.NomeCliente.TabIndex = 0;
            this.NomeCliente.TextChanged += new System.EventHandler(this.NomeCliente_TextChanged);
            this.NomeCliente.DoubleClick += new System.EventHandler(this.NomeCliente_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome do Cliente: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome Do Colaborador:";
            // 
            // NomeDoColaborador
            // 
            this.NomeDoColaborador.Location = new System.Drawing.Point(167, 90);
            this.NomeDoColaborador.Name = "NomeDoColaborador";
            this.NomeDoColaborador.ReadOnly = true;
            this.NomeDoColaborador.Size = new System.Drawing.Size(334, 20);
            this.NomeDoColaborador.TabIndex = 3;
            this.NomeDoColaborador.DoubleClick += new System.EventHandler(this.NomeDoColaborador_DoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(560, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Forma de Pagamento";
            // 
            // FormaDePagamento
            // 
            this.FormaDePagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaDePagamento.FormattingEnabled = true;
            this.FormaDePagamento.Items.AddRange(new object[] {
            "A vista",
            "A Prazo",
            "Cartão De Credito",
            "Cheque",
            "Vale"});
            this.FormaDePagamento.Location = new System.Drawing.Point(674, 36);
            this.FormaDePagamento.Name = "FormaDePagamento";
            this.FormaDePagamento.Size = new System.Drawing.Size(100, 21);
            this.FormaDePagamento.TabIndex = 6;
            this.FormaDePagamento.TextChanged += new System.EventHandler(this.FormaDePagamento_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PrecoBruto);
            this.groupBox1.Controls.Add(this.QuantidadeRestante);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.PrecoUnitario);
            this.groupBox1.Controls.Add(this.QuantidadeEmEstoque);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Quantidade);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PrecoLiquido);
            this.groupBox1.Controls.Add(this.Desconto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.NomeDoProduto);
            this.groupBox1.Location = new System.Drawing.Point(27, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1002, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produto";
            // 
            // PrecoBruto
            // 
            this.PrecoBruto.Location = new System.Drawing.Point(471, 65);
            this.PrecoBruto.Name = "PrecoBruto";
            this.PrecoBruto.ReadOnly = true;
            this.PrecoBruto.Size = new System.Drawing.Size(100, 20);
            this.PrecoBruto.TabIndex = 26;
            // 
            // QuantidadeRestante
            // 
            this.QuantidadeRestante.Location = new System.Drawing.Point(160, 158);
            this.QuantidadeRestante.Name = "QuantidadeRestante";
            this.QuantidadeRestante.ReadOnly = true;
            this.QuantidadeRestante.Size = new System.Drawing.Size(197, 20);
            this.QuantidadeRestante.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(28, 161);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(114, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Quantidade Restante: ";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(378, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Preço Bruto: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(378, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Preço Unitário:";
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.Location = new System.Drawing.Point(471, 33);
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            this.PrecoUnitario.Size = new System.Drawing.Size(100, 20);
            this.PrecoUnitario.TabIndex = 22;
            // 
            // QuantidadeEmEstoque
            // 
            this.QuantidadeEmEstoque.Location = new System.Drawing.Point(160, 116);
            this.QuantidadeEmEstoque.Name = "QuantidadeEmEstoque";
            this.QuantidadeEmEstoque.ReadOnly = true;
            this.QuantidadeEmEstoque.Size = new System.Drawing.Size(197, 20);
            this.QuantidadeEmEstoque.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Quantidade em estoque:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(814, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(165, 72);
            this.button1.TabIndex = 17;
            this.button1.Text = "Adicionar no carrinho";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Quantidade
            // 
            this.Quantidade.Location = new System.Drawing.Point(160, 72);
            this.Quantidade.MaxLength = 32000;
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Size = new System.Drawing.Size(197, 20);
            this.Quantidade.TabIndex = 19;
            this.Quantidade.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.Quantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Preço Liquido:";
            // 
            // PrecoLiquido
            // 
            this.PrecoLiquido.Location = new System.Drawing.Point(471, 161);
            this.PrecoLiquido.Name = "PrecoLiquido";
            this.PrecoLiquido.ReadOnly = true;
            this.PrecoLiquido.Size = new System.Drawing.Size(100, 20);
            this.PrecoLiquido.TabIndex = 13;
            // 
            // Desconto
            // 
            this.Desconto.Location = new System.Drawing.Point(471, 116);
            this.Desconto.Name = "Desconto";
            this.Desconto.Size = new System.Drawing.Size(100, 20);
            this.Desconto.TabIndex = 12;
            this.Desconto.TextChanged += new System.EventHandler(this.Desconto_TextChanged);
            this.Desconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Desconto_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(378, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Desconto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome Do Produto";
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.Location = new System.Drawing.Point(160, 33);
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            this.NomeDoProduto.Size = new System.Drawing.Size(197, 20);
            this.NomeDoProduto.TabIndex = 7;
            this.NomeDoProduto.TextChanged += new System.EventHandler(this.NomeDoProduto_TextChanged);
            this.NomeDoProduto.DoubleClick += new System.EventHandler(this.NomeDoProduto_DoubleClick);
            // 
            // DescontoAVista
            // 
            this.DescontoAVista.Location = new System.Drawing.Point(674, 79);
            this.DescontoAVista.Name = "DescontoAVista";
            this.DescontoAVista.Size = new System.Drawing.Size(100, 20);
            this.DescontoAVista.TabIndex = 16;
            this.DescontoAVista.Visible = false;
            this.DescontoAVista.TextChanged += new System.EventHandler(this.DescontoAVista_TextChanged);
            this.DescontoAVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescontoAVista_KeyPress);
            // 
            // labeledit
            // 
            this.labeledit.AutoSize = true;
            this.labeledit.Location = new System.Drawing.Point(560, 82);
            this.labeledit.Name = "labeledit";
            this.labeledit.Size = new System.Drawing.Size(91, 13);
            this.labeledit.TabIndex = 15;
            this.labeledit.Text = "Desconto a Vista:";
            this.labeledit.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.LimiteDeCompraaPraso);
            this.groupBox2.Controls.Add(this.labelLimite);
            this.groupBox2.Controls.Add(this.TotalLiquido);
            this.groupBox2.Controls.Add(this.TotalDesconto);
            this.groupBox2.Controls.Add(this.TotalBruto);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.FormaDePagamento);
            this.groupBox2.Controls.Add(this.DescontoAVista);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.labeledit);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.textBox8);
            this.groupBox2.Controls.Add(this.QuantidadeTotal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.QuantidadeUnitario);
            this.groupBox2.Location = new System.Drawing.Point(27, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1002, 163);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Carrinho";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(814, 11);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 65);
            this.button3.TabIndex = 15;
            this.button3.Text = "Cancelar pedido";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(814, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 68);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cadastrar Pedido";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LimiteDeCompraaPraso
            // 
            this.LimiteDeCompraaPraso.Location = new System.Drawing.Point(674, 126);
            this.LimiteDeCompraaPraso.Name = "LimiteDeCompraaPraso";
            this.LimiteDeCompraaPraso.ReadOnly = true;
            this.LimiteDeCompraaPraso.Size = new System.Drawing.Size(100, 20);
            this.LimiteDeCompraaPraso.TabIndex = 13;
            this.LimiteDeCompraaPraso.Visible = false;
            // 
            // labelLimite
            // 
            this.labelLimite.AutoSize = true;
            this.labelLimite.Location = new System.Drawing.Point(522, 133);
            this.labelLimite.Name = "labelLimite";
            this.labelLimite.Size = new System.Drawing.Size(132, 13);
            this.labelLimite.TabIndex = 12;
            this.labelLimite.Text = "Limite De Compra a Prazo:";
            this.labelLimite.Visible = false;
            // 
            // TotalLiquido
            // 
            this.TotalLiquido.Location = new System.Drawing.Point(415, 127);
            this.TotalLiquido.Name = "TotalLiquido";
            this.TotalLiquido.ReadOnly = true;
            this.TotalLiquido.Size = new System.Drawing.Size(100, 20);
            this.TotalLiquido.TabIndex = 11;
            this.TotalLiquido.TextChanged += new System.EventHandler(this.TotalLiquido_TextChanged);
            // 
            // TotalDesconto
            // 
            this.TotalDesconto.Location = new System.Drawing.Point(415, 79);
            this.TotalDesconto.Name = "TotalDesconto";
            this.TotalDesconto.ReadOnly = true;
            this.TotalDesconto.Size = new System.Drawing.Size(100, 20);
            this.TotalDesconto.TabIndex = 10;
            // 
            // TotalBruto
            // 
            this.TotalBruto.Location = new System.Drawing.Point(415, 37);
            this.TotalBruto.Name = "TotalBruto";
            this.TotalBruto.ReadOnly = true;
            this.TotalBruto.Size = new System.Drawing.Size(100, 20);
            this.TotalBruto.TabIndex = 9;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(297, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(71, 13);
            this.label18.TabIndex = 8;
            this.label18.Text = "Total Liquido:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(297, 82);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "Total Desconto:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(306, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "Total Bruto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Items:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(160, 127);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 4;
            this.textBox8.Click += new System.EventHandler(this.textBox8_Click);
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.Location = new System.Drawing.Point(160, 79);
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            this.QuantidadeTotal.ReadOnly = true;
            this.QuantidadeTotal.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeTotal.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Quantidade Total:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Quantidade unitário:";
            // 
            // QuantidadeUnitario
            // 
            this.QuantidadeUnitario.Location = new System.Drawing.Point(160, 34);
            this.QuantidadeUnitario.Name = "QuantidadeUnitario";
            this.QuantidadeUnitario.ReadOnly = true;
            this.QuantidadeUnitario.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeUnitario.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1051, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // CadastroDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 547);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NomeDoColaborador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeCliente);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CadastroDePedidos";
            this.Text = "CadastroDePedidos";
            this.Load += new System.EventHandler(this.CadastroDePedidos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeDoColaborador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FormaDePagamento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DescontoAVista;
        private System.Windows.Forms.Label labeledit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PrecoLiquido;
        private System.Windows.Forms.TextBox Desconto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeDoProduto;
        private System.Windows.Forms.TextBox QuantidadeEmEstoque;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Quantidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PrecoUnitario;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox LimiteDeCompraaPraso;
        private System.Windows.Forms.Label labelLimite;
        private System.Windows.Forms.TextBox TotalLiquido;
        private System.Windows.Forms.TextBox TotalDesconto;
        private System.Windows.Forms.TextBox TotalBruto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox QuantidadeTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox QuantidadeUnitario;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox QuantidadeRestante;
        private System.Windows.Forms.TextBox PrecoBruto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
    }
}