
namespace crud_teste.vieew.TelaDeVenda
{
    partial class ListarCarrinho
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxinstrucao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoDePesquisa = new System.Windows.Forms.TextBox();
            this.dataGridCarrinho = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(437, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 17;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxinstrucao
            // 
            this.textBoxinstrucao.Location = new System.Drawing.Point(648, 22);
            this.textBoxinstrucao.Multiline = true;
            this.textBoxinstrucao.Name = "textBoxinstrucao";
            this.textBoxinstrucao.ReadOnly = true;
            this.textBoxinstrucao.Size = new System.Drawing.Size(124, 69);
            this.textBoxinstrucao.TabIndex = 16;
            this.textBoxinstrucao.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            this.textBoxinstrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Pesquisar :";
            // 
            // CampoDePesquisa
            // 
            this.CampoDePesquisa.Location = new System.Drawing.Point(86, 50);
            this.CampoDePesquisa.Name = "CampoDePesquisa";
            this.CampoDePesquisa.Size = new System.Drawing.Size(325, 20);
            this.CampoDePesquisa.TabIndex = 14;
            // 
            // dataGridCarrinho
            // 
            this.dataGridCarrinho.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCarrinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCarrinho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Quantidade,
            this.PrecoUnitario,
            this.PrecoBruto,
            this.Desconto,
            this.PrecoLiquido});
            this.dataGridCarrinho.Location = new System.Drawing.Point(12, 118);
            this.dataGridCarrinho.MultiSelect = false;
            this.dataGridCarrinho.Name = "dataGridCarrinho";
            this.dataGridCarrinho.ReadOnly = true;
            this.dataGridCarrinho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCarrinho.Size = new System.Drawing.Size(776, 310);
            this.dataGridCarrinho.TabIndex = 13;
            this.dataGridCarrinho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCarrinho_CellContentClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // PrecoUnitario
            // 
            this.PrecoUnitario.HeaderText = "Preço Unitário";
            this.PrecoUnitario.Name = "PrecoUnitario";
            this.PrecoUnitario.ReadOnly = true;
            // 
            // PrecoBruto
            // 
            this.PrecoBruto.HeaderText = "Preço Bruto";
            this.PrecoBruto.Name = "PrecoBruto";
            this.PrecoBruto.ReadOnly = true;
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
            // ListarCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxinstrucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampoDePesquisa);
            this.Controls.Add(this.dataGridCarrinho);
            this.Name = "ListarCarrinho";
            this.Text = "ListarCarrinho";
            this.Load += new System.EventHandler(this.ListarCarrinho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCarrinho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxinstrucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampoDePesquisa;
        private System.Windows.Forms.DataGridView dataGridCarrinho;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoLiquido;
    }
}