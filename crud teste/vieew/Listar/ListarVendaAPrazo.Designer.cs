
namespace crud_teste.vieew.Listar
{
    partial class ListarVendaAPrazo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbInativo = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxinstrucao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.dgvedasaprazo = new System.Windows.Forms.DataGridView();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeDeMezes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorPorMes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesesrestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidaderestantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PagarVariosMeses = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvedasaprazo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbInativo
            // 
            this.cbInativo.AutoSize = true;
            this.cbInativo.Location = new System.Drawing.Point(477, 59);
            this.cbInativo.Name = "cbInativo";
            this.cbInativo.Size = new System.Drawing.Size(111, 17);
            this.cbInativo.TabIndex = 14;
            this.cbInativo.Text = "Buscar Com Pago";
            this.cbInativo.UseVisualStyleBackColor = true;
            this.cbInativo.CheckedChanged += new System.EventHandler(this.cbInativo_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(638, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 13;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxinstrucao
            // 
            this.textBoxinstrucao.Location = new System.Drawing.Point(868, 26);
            this.textBoxinstrucao.Multiline = true;
            this.textBoxinstrucao.Name = "textBoxinstrucao";
            this.textBoxinstrucao.ReadOnly = true;
            this.textBoxinstrucao.Size = new System.Drawing.Size(124, 69);
            this.textBoxinstrucao.TabIndex = 12;
            this.textBoxinstrucao.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            this.textBoxinstrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pesquisar :";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(88, 58);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(373, 20);
            this.txtCliente.TabIndex = 10;
            // 
            // dgvedasaprazo
            // 
            this.dgvedasaprazo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvedasaprazo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenda,
            this.IdCliente,
            this.Nome,
            this.QuantidadeTotal,
            this.QuantidadeDeMezes,
            this.ValorPorMes,
            this.mesesrestantes,
            this.quantidaderestantes,
            this.PagarVariosMeses});
            this.dgvedasaprazo.Location = new System.Drawing.Point(12, 119);
            this.dgvedasaprazo.Name = "dgvedasaprazo";
            this.dgvedasaprazo.Size = new System.Drawing.Size(980, 319);
            this.dgvedasaprazo.TabIndex = 15;
            this.dgvedasaprazo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvedasaprazo_CellContentClick);
            // 
            // IdVenda
            // 
            this.IdVenda.HeaderText = "Id Da Venda";
            this.IdVenda.Name = "IdVenda";
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id Do Cliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome Do Cliente";
            this.Nome.Name = "Nome";
            // 
            // QuantidadeTotal
            // 
            this.QuantidadeTotal.HeaderText = "Quantidade Total";
            this.QuantidadeTotal.Name = "QuantidadeTotal";
            // 
            // QuantidadeDeMezes
            // 
            this.QuantidadeDeMezes.HeaderText = "Quantidades de meses";
            this.QuantidadeDeMezes.Name = "QuantidadeDeMezes";
            // 
            // ValorPorMes
            // 
            this.ValorPorMes.HeaderText = "Valor Por Mes";
            this.ValorPorMes.Name = "ValorPorMes";
            // 
            // mesesrestantes
            // 
            this.mesesrestantes.HeaderText = "Meses Restantes";
            this.mesesrestantes.Name = "mesesrestantes";
            // 
            // quantidaderestantes
            // 
            this.quantidaderestantes.HeaderText = "Quantidade Restante";
            this.quantidaderestantes.Name = "quantidaderestantes";
            // 
            // PagarVariosMeses
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PagarVariosMeses.DefaultCellStyle = dataGridViewCellStyle1;
            this.PagarVariosMeses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PagarVariosMeses.HeaderText = "Pagar";
            this.PagarVariosMeses.Name = "PagarVariosMeses";
            this.PagarVariosMeses.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PagarVariosMeses.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PagarVariosMeses.Text = "Pagar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.voltarToolStripMenuItem.Text = "voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.voltarToolStripMenuItem_Click);
            // 
            // ListarVendaAPrazo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 450);
            this.Controls.Add(this.dgvedasaprazo);
            this.Controls.Add(this.cbInativo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxinstrucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListarVendaAPrazo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarVendaAPrazo";
            this.Load += new System.EventHandler(this.ListarVendaAPrazo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvedasaprazo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbInativo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxinstrucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.DataGridView dgvedasaprazo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeDeMezes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorPorMes;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesesrestantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidaderestantes;
        private System.Windows.Forms.DataGridViewButtonColumn PagarVariosMeses;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
    }
}