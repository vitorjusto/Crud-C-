
namespace crud_teste.vieew
{
    partial class ListarProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxinstrucao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CampoDePesquisa = new System.Windows.Forms.TextBox();
            this.dataGridProduto = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoDeVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fabricante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alterar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.AlterarEstoque = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Inativar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BuscarAtivo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(588, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 12;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxinstrucao
            // 
            this.textBoxinstrucao.Location = new System.Drawing.Point(808, 39);
            this.textBoxinstrucao.Multiline = true;
            this.textBoxinstrucao.Name = "textBoxinstrucao";
            this.textBoxinstrucao.ReadOnly = true;
            this.textBoxinstrucao.Size = new System.Drawing.Size(124, 69);
            this.textBoxinstrucao.TabIndex = 11;
            this.textBoxinstrucao.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            this.textBoxinstrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Pesquisar :";
            // 
            // CampoDePesquisa
            // 
            this.CampoDePesquisa.Location = new System.Drawing.Point(89, 64);
            this.CampoDePesquisa.Name = "CampoDePesquisa";
            this.CampoDePesquisa.Size = new System.Drawing.Size(327, 20);
            this.CampoDePesquisa.TabIndex = 9;
            // 
            // dataGridProduto
            // 
            this.dataGridProduto.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.PrecoDeVenda,
            this.Estoque,
            this.Fabricante,
            this.Alterar,
            this.AlterarEstoque,
            this.Inativar});
            this.dataGridProduto.Location = new System.Drawing.Point(15, 127);
            this.dataGridProduto.MultiSelect = false;
            this.dataGridProduto.Name = "dataGridProduto";
            this.dataGridProduto.ReadOnly = true;
            this.dataGridProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProduto.Size = new System.Drawing.Size(917, 329);
            this.dataGridProduto.TabIndex = 8;
            this.dataGridProduto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduto_CellContentClick);
            this.dataGridProduto.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProduto_CellMouseClick_1);
            this.dataGridProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridProduto_CellMouseDoubleClick);
            // 
            // IdProduto
            // 
            this.IdProduto.HeaderText = "IdProduto";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            // 
            // NomeProduto
            // 
            this.NomeProduto.HeaderText = "Nome Produto";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            // 
            // PrecoDeVenda
            // 
            this.PrecoDeVenda.HeaderText = "Preco De Venda";
            this.PrecoDeVenda.Name = "PrecoDeVenda";
            this.PrecoDeVenda.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            // 
            // Fabricante
            // 
            this.Fabricante.HeaderText = "Fabricante";
            this.Fabricante.Name = "Fabricante";
            this.Fabricante.ReadOnly = true;
            // 
            // Alterar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // AlterarEstoque
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AlterarEstoque.DefaultCellStyle = dataGridViewCellStyle2;
            this.AlterarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AlterarEstoque.HeaderText = "Alterar Estoque";
            this.AlterarEstoque.Name = "AlterarEstoque";
            this.AlterarEstoque.ReadOnly = true;
            this.AlterarEstoque.Text = "Alterar Estoque";
            this.AlterarEstoque.UseColumnTextForButtonValue = true;
            // 
            // Inativar
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Inativar.DefaultCellStyle = dataGridViewCellStyle3;
            this.Inativar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inativar.HeaderText = "Inativar";
            this.Inativar.Name = "Inativar";
            this.Inativar.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // BuscarAtivo
            // 
            this.BuscarAtivo.AutoSize = true;
            this.BuscarAtivo.Location = new System.Drawing.Point(433, 65);
            this.BuscarAtivo.Name = "BuscarAtivo";
            this.BuscarAtivo.Size = new System.Drawing.Size(117, 17);
            this.BuscarAtivo.TabIndex = 14;
            this.BuscarAtivo.Text = "Buscar com Inativo";
            this.BuscarAtivo.UseVisualStyleBackColor = true;
            this.BuscarAtivo.CheckedChanged += new System.EventHandler(this.BuscarAtivo_CheckedChanged);
            // 
            // ListarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 468);
            this.Controls.Add(this.BuscarAtivo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxinstrucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampoDePesquisa);
            this.Controls.Add(this.dataGridProduto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListaProduto";
            this.Load += new System.EventHandler(this.ListarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxinstrucao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CampoDePesquisa;
        private System.Windows.Forms.DataGridView dataGridProduto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.CheckBox BuscarAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoDeVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fabricante;
        private System.Windows.Forms.DataGridViewButtonColumn Alterar;
        private System.Windows.Forms.DataGridViewButtonColumn AlterarEstoque;
        private System.Windows.Forms.DataGridViewButtonColumn Inativar;
    }
}