
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
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtTotalGasto = new System.Windows.Forms.TextBox();
            this.txttotalLiquido = new System.Windows.Forms.TextBox();
            this.txtLucro = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListarPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numeros de Pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Bruto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "total Liquido(receita)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(936, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Gasto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(964, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lucro:";
            // 
            // NumeroDePedidos
            // 
            this.NumeroDePedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroDePedidos.Location = new System.Drawing.Point(132, 28);
            this.NumeroDePedidos.Name = "NumeroDePedidos";
            this.NumeroDePedidos.ReadOnly = true;
            this.NumeroDePedidos.Size = new System.Drawing.Size(189, 20);
            this.NumeroDePedidos.TabIndex = 18;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBruto.Location = new System.Drawing.Point(549, 29);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(217, 20);
            this.txtTotalBruto.TabIndex = 19;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(549, 94);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(217, 20);
            this.txtDesconto.TabIndex = 20;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGasto.Location = new System.Drawing.Point(1018, 29);
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.ReadOnly = true;
            this.txtTotalGasto.Size = new System.Drawing.Size(203, 20);
            this.txtTotalGasto.TabIndex = 21;
            // 
            // txttotalLiquido
            // 
            this.txttotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalLiquido.Location = new System.Drawing.Point(1018, 93);
            this.txttotalLiquido.Name = "txttotalLiquido";
            this.txttotalLiquido.ReadOnly = true;
            this.txttotalLiquido.Size = new System.Drawing.Size(203, 20);
            this.txttotalLiquido.TabIndex = 22;
            // 
            // txtLucro
            // 
            this.txtLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucro.Location = new System.Drawing.Point(1018, 154);
            this.txtLucro.Name = "txtLucro";
            this.txtLucro.ReadOnly = true;
            this.txtLucro.Size = new System.Drawing.Size(203, 20);
            this.txtLucro.TabIndex = 23;
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(9, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 76);
            this.button1.TabIndex = 25;
            this.button1.Text = "Relatorio dos Produtos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLucro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txttotalLiquido);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTotalGasto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTotalBruto);
            this.groupBox1.Controls.Add(this.NumeroDePedidos);
            this.groupBox1.Location = new System.Drawing.Point(15, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1227, 192);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Lucro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Colaborador";
            // 
            // Cliente
            // 
            this.Cliente.AutoSize = true;
            this.Cliente.Location = new System.Drawing.Point(54, 69);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(39, 13);
            this.Cliente.TabIndex = 28;
            this.Cliente.Text = "Cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Produto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(595, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Data Entre: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(802, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "e";
            // 
            // txtProduto
            // 
            this.txtProduto.Location = new System.Drawing.Point(477, 66);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(100, 20);
            this.txtProduto.TabIndex = 34;
            // 
            // txtColaborador
            // 
            this.txtColaborador.Location = new System.Drawing.Point(288, 66);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.Size = new System.Drawing.Size(100, 20);
            this.txtColaborador.TabIndex = 35;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(99, 66);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(100, 20);
            this.txtCliente.TabIndex = 36;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(970, 40);
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
            this.dtpDataInicial.Location = new System.Drawing.Point(679, 66);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(117, 20);
            this.dtpDataInicial.TabIndex = 40;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(836, 66);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(117, 20);
            this.dtpDataFinal.TabIndex = 41;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(261, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 76);
            this.button3.TabIndex = 26;
            this.button3.Text = "Relatorio dos Clientes";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ListagemDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 616);
            this.Controls.Add(this.dtpDataFinal);
            this.Controls.Add(this.dtpDataInicial);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(this.txtProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
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
            ((System.ComponentModel.ISupportInitialize)(this.ListarPedidos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.TextBox txtTotalGasto;
        private System.Windows.Forms.TextBox txttotalLiquido;
        private System.Windows.Forms.TextBox txtLucro;
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
    }
}