
namespace crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos
{
    partial class RelatorioDosProdutos
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
            this.txtMenosVendido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMenosLucrativoTotal = new System.Windows.Forms.TextBox();
            this.txtMenosVendidaTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMenosLucrativo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaisVendido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaisLucrativo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaisLucrativoTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaisVendidaTotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LucroEmDinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LucroEmPorcento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCusto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridRelatorioDeProduto = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRelatorioDeProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMenosVendido
            // 
            this.txtMenosVendido.Location = new System.Drawing.Point(149, 85);
            this.txtMenosVendido.Name = "txtMenosVendido";
            this.txtMenosVendido.ReadOnly = true;
            this.txtMenosVendido.Size = new System.Drawing.Size(100, 20);
            this.txtMenosVendido.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Quantidade Vendida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Lucro Total: ";
            // 
            // txtMenosLucrativoTotal
            // 
            this.txtMenosLucrativoTotal.Location = new System.Drawing.Point(417, 32);
            this.txtMenosLucrativoTotal.Name = "txtMenosLucrativoTotal";
            this.txtMenosLucrativoTotal.ReadOnly = true;
            this.txtMenosLucrativoTotal.Size = new System.Drawing.Size(91, 20);
            this.txtMenosLucrativoTotal.TabIndex = 14;
            // 
            // txtMenosVendidaTotal
            // 
            this.txtMenosVendidaTotal.Location = new System.Drawing.Point(417, 85);
            this.txtMenosVendidaTotal.Name = "txtMenosVendidaTotal";
            this.txtMenosVendidaTotal.ReadOnly = true;
            this.txtMenosVendidaTotal.Size = new System.Drawing.Size(91, 20);
            this.txtMenosVendidaTotal.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtMenosVendido);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMenosLucrativo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMenosLucrativoTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtMenosVendidaTotal);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(563, 419);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 135);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos Menos Lucrativos";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(573, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 135);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // txtMenosLucrativo
            // 
            this.txtMenosLucrativo.Location = new System.Drawing.Point(149, 31);
            this.txtMenosLucrativo.Name = "txtMenosLucrativo";
            this.txtMenosLucrativo.ReadOnly = true;
            this.txtMenosLucrativo.Size = new System.Drawing.Size(100, 20);
            this.txtMenosLucrativo.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Produto Menos Vendido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Produto Menos Lucrativo:";
            // 
            // txtMaisVendido
            // 
            this.txtMaisVendido.Location = new System.Drawing.Point(149, 86);
            this.txtMaisVendido.Name = "txtMaisVendido";
            this.txtMaisVendido.ReadOnly = true;
            this.txtMaisVendido.Size = new System.Drawing.Size(100, 20);
            this.txtMaisVendido.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade Vendida";
            // 
            // txtMaisLucrativo
            // 
            this.txtMaisLucrativo.Location = new System.Drawing.Point(149, 32);
            this.txtMaisLucrativo.Name = "txtMaisLucrativo";
            this.txtMaisLucrativo.ReadOnly = true;
            this.txtMaisLucrativo.Size = new System.Drawing.Size(100, 20);
            this.txtMaisLucrativo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lucro Total: ";
            // 
            // txtMaisLucrativoTotal
            // 
            this.txtMaisLucrativoTotal.Location = new System.Drawing.Point(417, 33);
            this.txtMaisLucrativoTotal.Name = "txtMaisLucrativoTotal";
            this.txtMaisLucrativoTotal.ReadOnly = true;
            this.txtMaisLucrativoTotal.Size = new System.Drawing.Size(94, 20);
            this.txtMaisLucrativoTotal.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produto Mais Vendido";
            // 
            // txtMaisVendidaTotal
            // 
            this.txtMaisVendidaTotal.Location = new System.Drawing.Point(417, 86);
            this.txtMaisVendidaTotal.Name = "txtMaisVendidaTotal";
            this.txtMaisVendidaTotal.ReadOnly = true;
            this.txtMaisVendidaTotal.Size = new System.Drawing.Size(94, 20);
            this.txtMaisVendidaTotal.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaisVendido);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaisLucrativo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaisLucrativoTotal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaisVendidaTotal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 419);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produtos Lucrativos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Produto Mais Lucrativo";
            // 
            // LucroEmDinheiro
            // 
            this.LucroEmDinheiro.HeaderText = "Lucro (R$)";
            this.LucroEmDinheiro.Name = "LucroEmDinheiro";
            // 
            // LucroEmPorcento
            // 
            this.LucroEmPorcento.HeaderText = "Lucro (%)";
            this.LucroEmPorcento.Name = "LucroEmPorcento";
            // 
            // PrecoVenda
            // 
            this.PrecoVenda.HeaderText = "Total Preco De Venda";
            this.PrecoVenda.Name = "PrecoVenda";
            // 
            // TotalCusto
            // 
            this.TotalCusto.HeaderText = "Total De Custo";
            this.TotalCusto.Name = "TotalCusto";
            // 
            // TotalLiquido
            // 
            this.TotalLiquido.HeaderText = "Total Liquido";
            this.TotalLiquido.Name = "TotalLiquido";
            // 
            // TotalDesconto
            // 
            this.TotalDesconto.HeaderText = "Total De Desconto";
            this.TotalDesconto.Name = "TotalDesconto";
            // 
            // TotalBruto
            // 
            this.TotalBruto.HeaderText = "Total Bruto";
            this.TotalBruto.Name = "TotalBruto";
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // nomeProduto
            // 
            this.nomeProduto.HeaderText = "Nome Do Produto";
            this.nomeProduto.Name = "nomeProduto";
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "Id Do Produto";
            this.IdProduto.Name = "IdProduto";
            // 
            // DataGridRelatorioDeProduto
            // 
            this.DataGridRelatorioDeProduto.AllowUserToAddRows = false;
            this.DataGridRelatorioDeProduto.AllowUserToDeleteRows = false;
            this.DataGridRelatorioDeProduto.AllowUserToResizeColumns = false;
            this.DataGridRelatorioDeProduto.AllowUserToResizeRows = false;
            this.DataGridRelatorioDeProduto.BackgroundColor = System.Drawing.Color.White;
            this.DataGridRelatorioDeProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridRelatorioDeProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.nomeProduto,
            this.Quantidade,
            this.TotalBruto,
            this.TotalDesconto,
            this.TotalLiquido,
            this.TotalCusto,
            this.PrecoVenda,
            this.LucroEmPorcento,
            this.LucroEmDinheiro});
            this.DataGridRelatorioDeProduto.Location = new System.Drawing.Point(31, 39);
            this.DataGridRelatorioDeProduto.Name = "DataGridRelatorioDeProduto";
            this.DataGridRelatorioDeProduto.ReadOnly = true;
            this.DataGridRelatorioDeProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridRelatorioDeProduto.Size = new System.Drawing.Size(1058, 327);
            this.DataGridRelatorioDeProduto.TabIndex = 12;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1124, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(31, 383);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(110, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Listar Com Inativo";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(180, 383);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(158, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Considerar Inativo No Lucro";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // RelatorioDosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 561);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.DataGridRelatorioDeProduto);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RelatorioDosProdutos";
            this.Text = "RelatorioDosProdutos";
            this.Load += new System.EventHandler(this.RelatorioDosProdutos_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridRelatorioDeProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMenosVendido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMenosLucrativoTotal;
        private System.Windows.Forms.TextBox txtMenosVendidaTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMenosLucrativo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaisVendido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaisLucrativo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaisLucrativoTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaisVendidaTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroEmDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn LucroEmPorcento;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCusto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridView DataGridRelatorioDeProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}