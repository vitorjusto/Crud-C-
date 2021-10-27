
namespace crud_teste
{
    partial class Cliente
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValorLimite = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.Celular1 = new System.Windows.Forms.MaskedTextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(69, 43);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(125, 20);
            this.Nome.TabIndex = 1;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(303, 43);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(345, 20);
            this.Sobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sobrenome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo: ";
            // 
            // Sexo
            // 
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.Sexo.Location = new System.Drawing.Point(69, 81);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(125, 21);
            this.Sexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data De Nascimento: ";
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(303, 81);
            this.Data.Mask = "00/00/0000";
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(78, 20);
            this.Data.TabIndex = 7;
            this.Data.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Linite De Compra a Prazo:";
            // 
            // ValorLimite
            // 
            this.ValorLimite.Location = new System.Drawing.Point(547, 81);
            this.ValorLimite.Mask = "0000000,00";
            this.ValorLimite.Name = "ValorLimite";
            this.ValorLimite.Size = new System.Drawing.Size(101, 20);
            this.ValorLimite.TabIndex = 9;
            this.ValorLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CEP: ";
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(69, 162);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(125, 20);
            this.CEP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Logradouro: ";
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(107, 202);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(86, 20);
            this.Logradouro.TabIndex = 13;
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(303, 162);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(113, 20);
            this.Cidade.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(446, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "UF: ";
            // 
            // UF
            // 
            this.UF.FormattingEnabled = true;
            this.UF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PR",
            "RO",
            "RR",
            "RS",
            "SC",
            "SP"});
            this.UF.Location = new System.Drawing.Point(474, 162);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(25, 21);
            this.UF.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(220, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Complemento: ";
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(303, 202);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(345, 20);
            this.Complemento.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(26, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bairro:";
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(90, 248);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(103, 20);
            this.Bairro.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(528, 165);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Numero: ";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(590, 158);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(58, 20);
            this.Numero.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "CPF:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(93, 341);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(204, 20);
            this.Email.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 343);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(220, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Celular: ";
            // 
            // Celular2
            // 
            this.Celular2.Location = new System.Drawing.Point(315, 292);
            this.Celular2.Mask = "(00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(86, 20);
            this.Celular2.TabIndex = 42;
            // 
            // Celular1
            // 
            this.Celular1.Location = new System.Drawing.Point(275, 292);
            this.Celular1.Mask = "+00";
            this.Celular1.Name = "Celular1";
            this.Celular1.Size = new System.Drawing.Size(22, 20);
            this.Celular1.TabIndex = 41;
            this.Celular1.Text = "55";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(90, 289);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(103, 20);
            this.Telefone.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Telefone: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 24);
            this.menuStrip1.TabIndex = 46;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(69, 116);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(124, 20);
            this.CPF.TabIndex = 48;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Celular2);
            this.Controls.Add(this.Celular1);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Complemento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.UF);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ValorLimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Sobrenome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Cliente";
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Data;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox ValorLimite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.MaskedTextBox Celular1;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CPF;
    }
}