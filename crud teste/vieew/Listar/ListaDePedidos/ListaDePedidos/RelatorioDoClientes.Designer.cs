
namespace crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos
{
    partial class RelatorioDoClientes
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
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRelatorioDosClientes = new System.Windows.Forms.DataGridView();
            this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadetotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDescontoavista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LimiteRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteFiel = new System.Windows.Forms.TextBox();
            this.txtMaximoDeVenda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtclientemaiscompra = new System.Windows.Forms.TextBox();
            this.txtClienteMaisLucrativo = new System.Windows.Forms.TextBox();
            this.txtClienteMaisLucrativoValor = new System.Windows.Forms.TextBox();
            this.txtClienteMaisCompraQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMenosVendido = new System.Windows.Forms.TextBox();
            this.txtMenosLucrativo = new System.Windows.Forms.TextBox();
            this.txtMenosLucrativoValor = new System.Windows.Forms.TextBox();
            this.txtMenosVendidoQuantidade = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbListarInativo = new System.Windows.Forms.CheckBox();
            this.cbConsiderarInativo = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dtpDataInicial = new System.Windows.Forms.DateTimePicker();
            this.dtpDataFinal = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cobTipo = new System.Windows.Forms.ComboBox();
            this.cobCrescente = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDosClientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1076, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // dgvRelatorioDosClientes
            // 
            this.dgvRelatorioDosClientes.AllowUserToAddRows = false;
            this.dgvRelatorioDosClientes.AllowUserToDeleteRows = false;
            this.dgvRelatorioDosClientes.AllowUserToResizeColumns = false;
            this.dgvRelatorioDosClientes.AllowUserToResizeRows = false;
            this.dgvRelatorioDosClientes.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvRelatorioDosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorioDosClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcliente,
            this.nome,
            this.Quantidade,
            this.quantidadetotal,
            this.TotalBruto,
            this.Desconto,
            this.TotalDescontoavista,
            this.totalLiquido,
            this.LimiteRestante});
            this.dgvRelatorioDosClientes.Location = new System.Drawing.Point(12, 256);
            this.dgvRelatorioDosClientes.Name = "dgvRelatorioDosClientes";
            this.dgvRelatorioDosClientes.Size = new System.Drawing.Size(1046, 215);
            this.dgvRelatorioDosClientes.TabIndex = 1;
            // 
            // idcliente
            // 
            this.idcliente.HeaderText = "Id do Cliente";
            this.idcliente.Name = "idcliente";
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade de Venda";
            this.Quantidade.Name = "Quantidade";
            // 
            // quantidadetotal
            // 
            this.quantidadetotal.HeaderText = "Quantidade De Produtos Vendidos";
            this.quantidadetotal.Name = "quantidadetotal";
            // 
            // TotalBruto
            // 
            this.TotalBruto.HeaderText = "Total Bruto";
            this.TotalBruto.Name = "TotalBruto";
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            // 
            // TotalDescontoavista
            // 
            this.TotalDescontoavista.HeaderText = "Total Desconto a Vista";
            this.TotalDescontoavista.Name = "TotalDescontoavista";
            // 
            // totalLiquido
            // 
            this.totalLiquido.HeaderText = "Total Liquido";
            this.totalLiquido.Name = "totalLiquido";
            // 
            // LimiteRestante
            // 
            this.LimiteRestante.HeaderText = "Limite Restante de Compra a Prazo";
            this.LimiteRestante.Name = "LimiteRestante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClienteFiel);
            this.groupBox1.Controls.Add(this.txtMaximoDeVenda);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtclientemaiscompra);
            this.groupBox1.Controls.Add(this.txtClienteMaisLucrativo);
            this.groupBox1.Controls.Add(this.txtClienteMaisLucrativoValor);
            this.groupBox1.Controls.Add(this.txtClienteMaisCompraQuantidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 511);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Melhores Clientes";
            // 
            // txtClienteFiel
            // 
            this.txtClienteFiel.Location = new System.Drawing.Point(159, 132);
            this.txtClienteFiel.Name = "txtClienteFiel";
            this.txtClienteFiel.ReadOnly = true;
            this.txtClienteFiel.Size = new System.Drawing.Size(100, 20);
            this.txtClienteFiel.TabIndex = 11;
            // 
            // txtMaximoDeVenda
            // 
            this.txtMaximoDeVenda.Location = new System.Drawing.Point(421, 132);
            this.txtMaximoDeVenda.Name = "txtMaximoDeVenda";
            this.txtMaximoDeVenda.ReadOnly = true;
            this.txtMaximoDeVenda.Size = new System.Drawing.Size(61, 20);
            this.txtMaximoDeVenda.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cliente Fiel: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Quantidade de Vendas:";
            // 
            // txtclientemaiscompra
            // 
            this.txtclientemaiscompra.Location = new System.Drawing.Point(159, 81);
            this.txtclientemaiscompra.Name = "txtclientemaiscompra";
            this.txtclientemaiscompra.ReadOnly = true;
            this.txtclientemaiscompra.Size = new System.Drawing.Size(100, 20);
            this.txtclientemaiscompra.TabIndex = 7;
            // 
            // txtClienteMaisLucrativo
            // 
            this.txtClienteMaisLucrativo.Location = new System.Drawing.Point(159, 31);
            this.txtClienteMaisLucrativo.Name = "txtClienteMaisLucrativo";
            this.txtClienteMaisLucrativo.ReadOnly = true;
            this.txtClienteMaisLucrativo.Size = new System.Drawing.Size(100, 20);
            this.txtClienteMaisLucrativo.TabIndex = 6;
            // 
            // txtClienteMaisLucrativoValor
            // 
            this.txtClienteMaisLucrativoValor.Location = new System.Drawing.Point(377, 31);
            this.txtClienteMaisLucrativoValor.Name = "txtClienteMaisLucrativoValor";
            this.txtClienteMaisLucrativoValor.ReadOnly = true;
            this.txtClienteMaisLucrativoValor.Size = new System.Drawing.Size(105, 20);
            this.txtClienteMaisLucrativoValor.TabIndex = 5;
            // 
            // txtClienteMaisCompraQuantidade
            // 
            this.txtClienteMaisCompraQuantidade.Location = new System.Drawing.Point(377, 81);
            this.txtClienteMaisCompraQuantidade.Name = "txtClienteMaisCompraQuantidade";
            this.txtClienteMaisCompraQuantidade.ReadOnly = true;
            this.txtClienteMaisCompraQuantidade.Size = new System.Drawing.Size(105, 20);
            this.txtClienteMaisCompraQuantidade.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cliente que comprou mais:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente Mais Lucrativo:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMenosVendido);
            this.groupBox2.Controls.Add(this.txtMenosLucrativo);
            this.groupBox2.Controls.Add(this.txtMenosLucrativoValor);
            this.groupBox2.Controls.Add(this.txtMenosVendidoQuantidade);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(531, 511);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 161);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Piores Clientes";
            // 
            // txtMenosVendido
            // 
            this.txtMenosVendido.Location = new System.Drawing.Point(159, 81);
            this.txtMenosVendido.Name = "txtMenosVendido";
            this.txtMenosVendido.ReadOnly = true;
            this.txtMenosVendido.Size = new System.Drawing.Size(100, 20);
            this.txtMenosVendido.TabIndex = 7;
            // 
            // txtMenosLucrativo
            // 
            this.txtMenosLucrativo.Location = new System.Drawing.Point(159, 31);
            this.txtMenosLucrativo.Name = "txtMenosLucrativo";
            this.txtMenosLucrativo.ReadOnly = true;
            this.txtMenosLucrativo.Size = new System.Drawing.Size(100, 20);
            this.txtMenosLucrativo.TabIndex = 6;
            // 
            // txtMenosLucrativoValor
            // 
            this.txtMenosLucrativoValor.Location = new System.Drawing.Point(377, 31);
            this.txtMenosLucrativoValor.Name = "txtMenosLucrativoValor";
            this.txtMenosLucrativoValor.ReadOnly = true;
            this.txtMenosLucrativoValor.Size = new System.Drawing.Size(81, 20);
            this.txtMenosLucrativoValor.TabIndex = 5;
            // 
            // txtMenosVendidoQuantidade
            // 
            this.txtMenosVendidoQuantidade.Location = new System.Drawing.Point(377, 81);
            this.txtMenosVendidoQuantidade.Name = "txtMenosVendidoQuantidade";
            this.txtMenosVendidoQuantidade.ReadOnly = true;
            this.txtMenosVendidoQuantidade.Size = new System.Drawing.Size(81, 20);
            this.txtMenosVendidoQuantidade.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Cliente que comprou menos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Quantidade:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Valor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cliente Menos Lucrativo:";
            // 
            // cbListarInativo
            // 
            this.cbListarInativo.AutoSize = true;
            this.cbListarInativo.Location = new System.Drawing.Point(12, 484);
            this.cbListarInativo.Name = "cbListarInativo";
            this.cbListarInativo.Size = new System.Drawing.Size(110, 17);
            this.cbListarInativo.TabIndex = 9;
            this.cbListarInativo.Text = "Listar Com Inativo";
            this.cbListarInativo.UseVisualStyleBackColor = true;
            this.cbListarInativo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbConsiderarInativo
            // 
            this.cbConsiderarInativo.AutoSize = true;
            this.cbConsiderarInativo.Location = new System.Drawing.Point(171, 484);
            this.cbConsiderarInativo.Name = "cbConsiderarInativo";
            this.cbConsiderarInativo.Size = new System.Drawing.Size(166, 17);
            this.cbConsiderarInativo.TabIndex = 10;
            this.cbConsiderarInativo.Text = "Considerar Inativo No Cálculo";
            this.cbConsiderarInativo.UseVisualStyleBackColor = true;
            this.cbConsiderarInativo.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(516, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Data Final: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Data Inicial: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Cliente: ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(54, 45);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(150, 20);
            this.txtCliente.TabIndex = 14;
            // 
            // dtpDataInicial
            // 
            this.dtpDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicial.Location = new System.Drawing.Point(299, 45);
            this.dtpDataInicial.Name = "dtpDataInicial";
            this.dtpDataInicial.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInicial.TabIndex = 15;
            // 
            // dtpDataFinal
            // 
            this.dtpDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFinal.Location = new System.Drawing.Point(614, 45);
            this.dtpDataFinal.Name = "dtpDataFinal";
            this.dtpDataFinal.Size = new System.Drawing.Size(200, 20);
            this.dtpDataFinal.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(853, 111);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 68);
            this.button2.TabIndex = 40;
            this.button2.Text = "Pesquisar o Cliente";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cobCrescente);
            this.groupBox3.Controls.Add(this.cobTipo);
            this.groupBox3.Controls.Add(this.txtCliente);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dtpDataFinal);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.dtpDataInicial);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(12, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1046, 195);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // cobTipo
            // 
            this.cobTipo.FormattingEnabled = true;
            this.cobTipo.Items.AddRange(new object[] {
            "Nenhum",
            "Quantidade",
            "Total Desconto",
            "Total Lucro"});
            this.cobTipo.Location = new System.Drawing.Point(81, 111);
            this.cobTipo.Name = "cobTipo";
            this.cobTipo.Size = new System.Drawing.Size(102, 21);
            this.cobTipo.TabIndex = 41;
            this.cobTipo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // cobCrescente
            // 
            this.cobCrescente.FormattingEnabled = true;
            this.cobCrescente.Items.AddRange(new object[] {
            "Crescente",
            "Decrescente"});
            this.cobCrescente.Location = new System.Drawing.Point(203, 111);
            this.cobCrescente.Name = "cobCrescente";
            this.cobCrescente.Size = new System.Drawing.Size(97, 21);
            this.cobCrescente.TabIndex = 42;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 114);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 43;
            this.label14.Text = "Ordenar por: ";
            // 
            // RelatorioDoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbConsiderarInativo);
            this.Controls.Add(this.cbListarInativo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvRelatorioDosClientes);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RelatorioDoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RelatorioDoClientes";
            this.Load += new System.EventHandler(this.RelatorioDoClientes_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorioDosClientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvRelatorioDosClientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtclientemaiscompra;
        private System.Windows.Forms.TextBox txtClienteMaisLucrativo;
        private System.Windows.Forms.TextBox txtClienteMaisLucrativoValor;
        private System.Windows.Forms.TextBox txtClienteMaisCompraQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMenosVendido;
        private System.Windows.Forms.TextBox txtMenosLucrativo;
        private System.Windows.Forms.TextBox txtMenosLucrativoValor;
        private System.Windows.Forms.TextBox txtMenosVendidoQuantidade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbListarInativo;
        private System.Windows.Forms.CheckBox cbConsiderarInativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadetotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDescontoavista;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn LimiteRestante;
        private System.Windows.Forms.TextBox txtClienteFiel;
        private System.Windows.Forms.TextBox txtMaximoDeVenda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DateTimePicker dtpDataInicial;
        private System.Windows.Forms.DateTimePicker dtpDataFinal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cobTipo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cobCrescente;
    }
}