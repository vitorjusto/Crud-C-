
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
            this.pe = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.CampoDePesquisa.Location = new System.Drawing.Point(265, 43);
            this.CampoDePesquisa.Name = "CampoDePesquisa";
            this.CampoDePesquisa.Size = new System.Drawing.Size(296, 20);
            this.CampoDePesquisa.TabIndex = 2;
            this.CampoDePesquisa.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridColaboradores
            // 
            this.dataGridColaboradores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridColaboradores.Location = new System.Drawing.Point(12, 133);
            this.dataGridColaboradores.Name = "dataGridColaboradores";
            this.dataGridColaboradores.Size = new System.Drawing.Size(776, 305);
            this.dataGridColaboradores.TabIndex = 3;
            // 
            // pe
            // 
            this.pe.AutoSize = true;
            this.pe.Location = new System.Drawing.Point(179, 46);
            this.pe.Name = "pe";
            this.pe.Size = new System.Drawing.Size(56, 13);
            this.pe.TabIndex = 4;
            this.pe.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(581, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 51);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Digite qualquer nome ou digite numeros se quiser pesquisar por Id";
            // 
            // ListarColaboradores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pe);
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
        private System.Windows.Forms.Label pe;
        private System.Windows.Forms.TextBox textBox1;
    }
}