
namespace crud_teste.vieew
{
    partial class ListarColaboradores
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
            this.menuPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CampoDePesquisa = new System.Windows.Forms.TextBox();
            this.dataGridColaboradores = new System.Windows.Forms.DataGridView();
            this.label = new System.Windows.Forms.Label();
            this.textBoxinstrucao = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColaboradores)).BeginInit();
            this.SuspendLayout();
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
            this.CampoDePesquisa.Location = new System.Drawing.Point(74, 59);
            this.CampoDePesquisa.Name = "CampoDePesquisa";
            this.CampoDePesquisa.Size = new System.Drawing.Size(355, 20);
            this.CampoDePesquisa.TabIndex = 2;
            // 
            // dataGridColaboradores
            // 
            this.dataGridColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridColaboradores.Location = new System.Drawing.Point(12, 133);
            this.dataGridColaboradores.Name = "dataGridColaboradores";
            this.dataGridColaboradores.ReadOnly = true;
            this.dataGridColaboradores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridColaboradores.Size = new System.Drawing.Size(776, 305);
            this.dataGridColaboradores.TabIndex = 3;
            this.dataGridColaboradores.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridColaboradores_CellMouseDoubleClick_1);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 62);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 13);
            this.label.TabIndex = 4;
            this.label.Text = "Pesquisar:";
            // 
            // textBoxinstrucao
            // 
            this.textBoxinstrucao.Location = new System.Drawing.Point(650, 30);
            this.textBoxinstrucao.Multiline = true;
            this.textBoxinstrucao.Name = "textBoxinstrucao";
            this.textBoxinstrucao.ReadOnly = true;
            this.textBoxinstrucao.Size = new System.Drawing.Size(127, 70);
            this.textBoxinstrucao.TabIndex = 5;
            this.textBoxinstrucao.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            this.textBoxinstrucao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(456, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListarColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxinstrucao);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dataGridColaboradores);
            this.Controls.Add(this.CampoDePesquisa);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ListarColaboradores";
            this.Text = "ListarColaboradores";
            this.Load += new System.EventHandler(this.ListarColaboradores_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuPrincipalToolStripMenuItem;
        private System.Windows.Forms.TextBox CampoDePesquisa;
        private System.Windows.Forms.DataGridView dataGridColaboradores;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxinstrucao;
        private System.Windows.Forms.Button button1;
    }
}