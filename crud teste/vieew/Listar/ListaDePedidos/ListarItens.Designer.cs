
namespace crud_teste.vieew.ListaDePedidos
{
    partial class ListarItens
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridCarrinho = new System.Windows.Forms.DataGridView();
            this.NomeDoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoBrutoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoLiquidoAtual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCarrinho
            // 
            this.dataGridCarrinho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeDoProduto,
            this.Quantidade,
            this.PrecoBruto,
            this.PrecoBrutoAtual,
            this.Desconto,
            this.PrecoLiquido,
            this.PrecoLiquidoAtual,
            this.Alterar,
            this.Excluir});
            this.dataGridCarrinho.Location = new System.Drawing.Point(12, 118);
            this.dataGridCarrinho.MultiSelect = false;
            this.dataGridCarrinho.Name = "dataGridCarrinho";
            this.dataGridCarrinho.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridCarrinho.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCarrinho.Size = new System.Drawing.Size(992, 310);
            this.dataGridCarrinho.TabIndex = 18;
            this.dataGridCarrinho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCarrinho_CellClick);
            // 
            // NomeDoProduto
            // 
            this.NomeDoProduto.HeaderText = "Nome Do Produto";
            this.NomeDoProduto.Name = "NomeDoProduto";
            this.NomeDoProduto.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoBruto
            // 
            this.PrecoBruto.HeaderText = "Preço Bruto";
            this.PrecoBruto.Name = "PrecoBruto";
            this.PrecoBruto.ReadOnly = true;
            // 
            // PrecoBrutoAtual
            // 
            this.PrecoBrutoAtual.HeaderText = "Preço Bruto Atual";
            this.PrecoBrutoAtual.Name = "PrecoBrutoAtual";
            this.PrecoBrutoAtual.ReadOnly = true;
            // 
            // Desconto
            // 
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            // 
            // PrecoLiquido
            // 
            this.PrecoLiquido.HeaderText = "Preço Liquido";
            this.PrecoLiquido.Name = "PrecoLiquido";
            this.PrecoLiquido.ReadOnly = true;
            // 
            // PrecoLiquidoAtual
            // 
            this.PrecoLiquidoAtual.HeaderText = "Preço Liquido Atual";
            this.PrecoLiquidoAtual.Name = "PrecoLiquidoAtual";
            this.PrecoLiquidoAtual.ReadOnly = true;
            // 
            // Alterar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Alterar.DefaultCellStyle = dataGridViewCellStyle1;
            this.Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Alterar.HeaderText = "Alterar";
            this.Alterar.Name = "Alterar";
            this.Alterar.ReadOnly = true;
            this.Alterar.Text = "Alterar";
            this.Alterar.UseColumnTextForButtonValue = true;
            // 
            // Excluir
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Excluir.DefaultCellStyle = dataGridViewCellStyle2;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.HeaderText = "Remover";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            this.Excluir.Text = "Remover";
            this.Excluir.UseColumnTextForButtonValue = true;
            // 
            // ListarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.dataGridCarrinho);
            this.Name = "ListarItens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListarItens";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeDoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoBrutoAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoLiquidoAtual;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}