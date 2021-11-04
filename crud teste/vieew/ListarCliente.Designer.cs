
namespace crud_teste.vieew
{
    partial class ListarCliente
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
            this.dataGridCliente = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CampoDePesquisa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxinstrucao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridCliente
            // 
            this.dataGridCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCliente.Location = new System.Drawing.Point(12, 128);
            this.dataGridCliente.MultiSelect = false;
            this.dataGridCliente.Name = "dataGridCliente";
            this.dataGridCliente.ReadOnly = true;
            this.dataGridCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCliente.Size = new System.Drawing.Size(776, 310);
            this.dataGridCliente.TabIndex = 0;
            this.dataGridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCliente_CellContentClick_1);
            this.dataGridCliente.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCliente_CellMouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrincipalToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuPrincipalToolStripMenuItem
            // 
            this.menuPrincipalToolStripMenuItem.Name = "menuPrincipalToolStripMenuItem";
            this.menuPrincipalToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.menuPrincipalToolStripMenuItem.Text = "Menu Principal";
            this.menuPrincipalToolStripMenuItem.Click += new System.EventHandler(this.menuPrincipalToolStripMenuItem_Click);
            // 
            // CampoDePesquisa
            // 
            this.CampoDePesquisa.Location = new System.Drawing.Point(86, 60);
            this.CampoDePesquisa.Name = "CampoDePesquisa";
            this.CampoDePesquisa.Size = new System.Drawing.Size(325, 20);
            this.CampoDePesquisa.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pesquisar :";
            // 
            // textBoxinstrucao
            // 
            this.textBoxinstrucao.Location = new System.Drawing.Point(648, 32);
            this.textBoxinstrucao.Multiline = true;
            this.textBoxinstrucao.Name = "textBoxinstrucao";
            this.textBoxinstrucao.ReadOnly = true;
            this.textBoxinstrucao.Size = new System.Drawing.Size(124, 69);
            this.textBoxinstrucao.TabIndex = 6;
            this.textBoxinstrucao.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            this.textBoxinstrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(437, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 69);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxinstrucao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CampoDePesquisa);
            this.Controls.Add(this.dataGridCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListarCliente";
            this.Text = "ListarCliente";
            this.Load += new System.EventHandler(this.ListarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCliente)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.TextBox CampoDePesquisa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxinstrucao;
        private System.Windows.Forms.Button button1;
    }
}