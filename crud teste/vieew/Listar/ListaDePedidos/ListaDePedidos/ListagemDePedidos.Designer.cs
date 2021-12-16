
namespace crud_teste.vieew.ListaDePedidos
{
    partial class ListagemDePedidos
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
            this.ListarPedidos = new System.Windows.Forms.DataGridView();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeColaborador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesAPrazo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDeDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NumeroDePedidos = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Cliente = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.gbPesquisarPorData = new System.Windows.Forms.GroupBox();
            this.chkPesquisarPorData = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txtLucro = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txttotalLiquido = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtTotalGasto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtDesconto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.txtTotalBruto = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbPrecoBruto = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPesquisarPorData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListarPedidos
            // 
            this.ListarPedidos.BackgroundColor = System.Drawing.Color.DimGray;
            this.ListarPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListarPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListarPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenda,
            this.NomeCliente,
            this.NomeColaborador,
            this.TipoDeVenda,
            this.mesesAPrazo,
            this.TotalBruto,
            this.TotalDeDesconto,
            this.TotalLiquido,
            this.QuantidadeUnitario,
            this.QuantidadeTotal,
            this.DiaDaVenda});
            this.ListarPedidos.Location = new System.Drawing.Point(12, 125);
            this.ListarPedidos.Name = "ListarPedidos";
            this.ListarPedidos.ReadOnly = true;
            this.ListarPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarPedidos.Size = new System.Drawing.Size(1226, 276);
            this.ListarPedidos.TabIndex = 0;
            this.ListarPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListarPedidos_CellDoubleClick);
            // 
            // IdVenda
            // 
            this.IdVenda.HeaderText = "IdVenda";
            this.IdVenda.Name = "IdVenda";
            this.IdVenda.ReadOnly = true;
            // 
            // NomeCliente
            // 
            this.NomeCliente.HeaderText = "Nome Do Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.ReadOnly = true;
            // 
            // NomeColaborador
            // 
            this.NomeColaborador.HeaderText = "Nome Do Colaborador";
            this.NomeColaborador.Name = "NomeColaborador";
            this.NomeColaborador.ReadOnly = true;
            // 
            // TipoDeVenda
            // 
            this.TipoDeVenda.HeaderText = "Tipo De Venda";
            this.TipoDeVenda.Name = "TipoDeVenda";
            this.TipoDeVenda.ReadOnly = true;
            // 
            // mesesAPrazo
            // 
            this.mesesAPrazo.HeaderText = "Meses A Prazo";
            this.mesesAPrazo.Name = "mesesAPrazo";
            this.mesesAPrazo.ReadOnly = true;
            // 
            // TotalBruto
            // 
            this.TotalBruto.HeaderText = "Total Bruto";
            this.TotalBruto.Name = "TotalBruto";
            this.TotalBruto.ReadOnly = true;
            // 
            // TotalDeDesconto
            // 
            this.TotalDeDesconto.HeaderText = "Total De Desconto";
            this.TotalDeDesconto.Name = "TotalDeDesconto";
            this.TotalDeDesconto.ReadOnly = true;
            // 
            // TotalLiquido
            // 
            this.TotalLiquido.HeaderText = "Total Liquido";
            this.TotalLiquido.Name = "TotalLiquido";
            this.TotalLiquido.ReadOnly = true;
            // 
            // QuantidadeUnitario
            // 
            this.QuantidadeUnitario.HeaderText = "Quantidade Unitario";
            this.QuantidadeUnitario.Name = "QuantidadeUnitario";
            this.QuantidadeUnitario.ReadOnly = true;
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.HeaderText = "Quantidade Total";
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            this.QuantidadeTotal.ReadOnly = true;
            // 
            // DiaDaVenda
            // 
            this.DiaDaVenda.HeaderText = "Dia Da Venda";
            this.DiaDaVenda.Name = "DiaDaVenda";
            this.DiaDaVenda.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numeros de Pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Bruto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Total Liquido (receita):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(899, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Gasto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(899, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lucro:";
            // 
            // NumeroDePedidos
            // 
            this.NumeroDePedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroDePedidos.Location = new System.Drawing.Point(132, 25);
            this.NumeroDePedidos.Name = "NumeroDePedidos";
            this.NumeroDePedidos.ReadOnly = true;
            this.NumeroDePedidos.Size = new System.Drawing.Size(272, 20);
            this.NumeroDePedidos.TabIndex = 18;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(9, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 90);
            this.button1.TabIndex = 25;
            this.button1.Text = "Relatorio dos Produtos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLucro);
            this.groupBox1.Controls.Add(this.txttotalLiquido);
            this.groupBox1.Controls.Add(this.txtTotalGasto);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.txtTotalBruto);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NumeroDePedidos);
            this.groupBox1.Location = new System.Drawing.Point(15, 479);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 182);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Lucro";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(362, 84);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(160, 90);
            this.button4.TabIndex = 29;
            this.button4.Text = "Gerar Relatório Excel";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantidade.Location = new System.Drawing.Point(700, 135);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(183, 20);
            this.txtQuantidade.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(577, 139);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Quantidades Vendidas:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(184, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 90);
            this.button3.TabIndex = 26;
            this.button3.Text = "Relatorio dos Clientes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Colaborador";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(19, 70);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 28;
            this.Cliente.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Data Entre: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "e";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(442, 59);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 34;
            this.txtProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProduto_KeyPress);
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(253, 59);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtColaborador.TabIndex = 35;
            this.txtColaborador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColaborador_KeyPress);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(64, 59);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 36;
            this.txtCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCliente_KeyPress);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(1063, 40);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 68);
            this.button2.TabIndex = 39;
            this.button2.Text = "Pesquisar a venda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(76, 26);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(100, 20);
            this.dtpDataInicial.TabIndex = 40;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(201, 26);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(100, 20);
            this.dtpDataFinal.TabIndex = 41;
            // 
            // gbPesquisarPorData
            // 
            this.gbPesquisarPorData.Controls.Add(this.label10);
            this.gbPesquisarPorData.Controls.Add(this.dtpDataFinal);
            this.gbPesquisarPorData.Controls.Add(this.label8);
            this.gbPesquisarPorData.Controls.Add(this.dtpDataInicial);
            this.gbPesquisarPorData.Location = new System.Drawing.Point(717, 40);
            this.gbPesquisarPorData.Name = "gbPesquisarPorData";
            this.gbPesquisarPorData.Size = new System.Drawing.Size(319, 68);
            this.gbPesquisarPorData.TabIndex = 42;
            this.gbPesquisarPorData.TabStop = false;
            this.gbPesquisarPorData.Text = "Pesquisar Por Data";
            // 
            // chkPesquisarPorData
            // 
            this.chkPesquisarPorData.AutoSize = true;
            this.chkPesquisarPorData.Location = new System.Drawing.Point(566, 68);
            this.chkPesquisarPorData.Name = "chkPesquisarPorData";
            this.chkPesquisarPorData.Size = new System.Drawing.Size(117, 17);
            this.chkPesquisarPorData.TabIndex = 43;
            this.chkPesquisarPorData.Text = "Pesquisar Por Data";
            this.chkPesquisarPorData.UseVisualStyleBackColor = true;
            this.chkPesquisarPorData.CheckedChanged += new System.EventHandler(this.chkPesquisarPorData_CheckedChanged);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(120, 88);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 31);
            this.button5.TabIndex = 46;
            this.button5.Text = "🔎";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(309, 88);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 31);
            this.button6.TabIndex = 47;
            this.button6.Text = "🔎";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(498, 88);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 31);
            this.button7.TabIndex = 48;
            this.button7.Text = "🔎";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txtLucro
            // 
            this.txtLucro.ForeColor = System.Drawing.Color.Black;
            this.txtLucro.Location = new System.Drawing.Point(1018, 135);
            this.txtLucro.MaxLength = 15;
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.Negative = System.Drawing.Color.Red;
            this.txtLucro.Positive = System.Drawing.Color.Green;
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(203, 20);
            this.txtLucro.StyleText = true;
            this.txtLucro.TabIndex = 34;
            this.txtLucro.Text = "0,00";
            this.txtLucro.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtLucro.Zero = System.Drawing.Color.Black;
            // 
            // txttotalLiquido
            // 
            this.txttotalLiquido.Location = new System.Drawing.Point(1018, 80);
            this.txttotalLiquido.MaxLength = 15;
            this.txttotalLiquido.Name = "txttotalLiquido";
            this.txttotalLiquido.Negative = System.Drawing.Color.Red;
            this.txttotalLiquido.Positive = System.Drawing.Color.Green;
            this.txttotalLiquido.ReadOnly = true;
            this.txttotalLiquido.Size = new System.Drawing.Size(203, 20);
            this.txttotalLiquido.StyleText = false;
            this.txttotalLiquido.TabIndex = 33;
            this.txttotalLiquido.Text = "0,00";
            this.txttotalLiquido.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txttotalLiquido.Zero = System.Drawing.Color.Black;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.Location = new System.Drawing.Point(1018, 25);
            this.txtTotalGasto.MaxLength = 15;
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.Negative = System.Drawing.Color.Red;
            this.txtTotalGasto.Positive = System.Drawing.Color.Green;
            this.txtTotalGasto.ReadOnly = true;
            this.txtTotalGasto.Size = new System.Drawing.Size(203, 20);
            this.txtTotalGasto.StyleText = false;
            this.txtTotalGasto.TabIndex = 32;
            this.txtTotalGasto.Text = "0,00";
            this.txtTotalGasto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtTotalGasto.Zero = System.Drawing.Color.Black;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(700, 80);
            this.txtDesconto.MaxLength = 15;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Negative = System.Drawing.Color.Red;
            this.txtDesconto.Positive = System.Drawing.Color.Green;
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(183, 20);
            this.txtDesconto.StyleText = false;
            this.txtDesconto.TabIndex = 31;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtDesconto.Zero = System.Drawing.Color.Black;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Location = new System.Drawing.Point(700, 25);
            this.txtTotalBruto.MaxLength = 15;
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.Negative = System.Drawing.Color.Red;
            this.txtTotalBruto.Positive = System.Drawing.Color.Green;
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(183, 20);
            this.txtTotalBruto.StyleText = false;
            this.txtTotalBruto.TabIndex = 30;
            this.txtTotalBruto.Text = "0,00";
            this.txtTotalBruto.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.txtTotalBruto.Zero = System.Drawing.Color.Black;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.rbPrecoBruto);
            this.groupBox2.Location = new System.Drawing.Point(976, 417);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 56);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcular Lucro Por";
            // 
            // rbPrecoBruto
            // 
            this.rbPrecoBruto.AutoSize = true;
            this.rbPrecoBruto.Location = new System.Drawing.Point(16, 26);
            this.rbPrecoBruto.Name = "rbPrecoBruto";
            this.rbPrecoBruto.Size = new System.Drawing.Size(81, 17);
            this.rbPrecoBruto.TabIndex = 0;
            this.rbPrecoBruto.Text = "Preço Bruto";
            this.rbPrecoBruto.UseVisualStyleBackColor = true;
            this.rbPrecoBruto.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(161, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(90, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Preço Liquido";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // ListagemDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 676);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.chkPesquisarPorData);
            this.Controls.Add(this.gbPesquisarPorData);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListarPedidos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListagemDePedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListagemDePedidos";
            this.Load += new System.EventHandler(this.ListagemDePedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListarPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPesquisarPorData.ResumeLayout(false);
            this.gbPesquisarPorData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListarPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumeroDePedidos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeColaborador;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesAPrazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDeDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDaVenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Cliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.TextBox txtColaborador;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox gbPesquisarPorData;
        private System.Windows.Forms.CheckBox chkPesquisarPorData;
        private System.Windows.Forms.Button button4;
        private Config.Custom_Controls.MoneyTextBox txtTotalBruto;
        private Config.Custom_Controls.MoneyTextBox txtLucro;
        private Config.Custom_Controls.MoneyTextBox txttotalLiquido;
        private Config.Custom_Controls.MoneyTextBox txtTotalGasto;
        private Config.Custom_Controls.MoneyTextBox txtDesconto;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbPrecoBruto;
    }
}