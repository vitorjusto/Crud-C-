
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
            ((System.ComponentModel.ISupportInitialize)(this.ListarPedidos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListarPedidos
            // 
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
            this.QuantidadeTotal});
            this.ListarPedidos.Location = new System.Drawing.Point(12, 44);
            this.ListarPedidos.Name = "ListarPedidos";
            this.ListarPedidos.ReadOnly = true;
            this.ListarPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListarPedidos.Size = new System.Drawing.Size(1044, 276);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numeros de Pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total Bruto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 424);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Total Desconto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(734, 424);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "total Liquido(receita)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total Gasto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(799, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Lucro:";
            // 
            // NumeroDePedidos
            // 
            this.NumeroDePedidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroDePedidos.Location = new System.Drawing.Point(149, 356);
            this.NumeroDePedidos.Name = "NumeroDePedidos";
            this.NumeroDePedidos.ReadOnly = true;
            this.NumeroDePedidos.Size = new System.Drawing.Size(189, 20);
            this.NumeroDePedidos.TabIndex = 18;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalBruto.Location = new System.Drawing.Point(464, 356);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(217, 20);
            this.txtTotalBruto.TabIndex = 19;
            // 
            // txtDesconto
            // 
            this.txtDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDesconto.Location = new System.Drawing.Point(464, 421);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(217, 20);
            this.txtDesconto.TabIndex = 20;
            // 
            // txtTotalGasto
            // 
            this.txtTotalGasto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalGasto.Location = new System.Drawing.Point(853, 357);
            this.txtTotalGasto.Name = "txtTotalGasto";
            this.txtTotalGasto.ReadOnly = true;
            this.txtTotalGasto.Size = new System.Drawing.Size(203, 20);
            this.txtTotalGasto.TabIndex = 21;
            // 
            // txttotalLiquido
            // 
            this.txttotalLiquido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttotalLiquido.Location = new System.Drawing.Point(853, 421);
            this.txttotalLiquido.Name = "txttotalLiquido";
            this.txttotalLiquido.ReadOnly = true;
            this.txttotalLiquido.Size = new System.Drawing.Size(203, 20);
            this.txttotalLiquido.TabIndex = 22;
            // 
            // txtLucro
            // 
            this.txtLucro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLucro.Location = new System.Drawing.Point(853, 482);
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
            this.menuStrip1.Size = new System.Drawing.Size(1069, 24);
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
            // ListagemDePedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 514);
            this.Controls.Add(this.txtLucro);
            this.Controls.Add(this.txttotalLiquido);
            this.Controls.Add(this.txtTotalGasto);
            this.Controls.Add(this.txtDesconto);
            this.Controls.Add(this.txtTotalBruto);
            this.Controls.Add(this.NumeroDePedidos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}