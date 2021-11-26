
namespace crud_teste
{
    partial class FrmCliente
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.label12 = new System.Windows.Forms.Label();
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
            this.data = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ValorLimite = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome: ";
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(54, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(125, 20);
            this.Nome.TabIndex = 1;
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(288, 19);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(325, 20);
            this.Sobrenome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sobrenome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sexo: ";
            // 
            // Sexo
            // 
            this.Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.Sexo.Location = new System.Drawing.Point(54, 57);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(125, 21);
            this.Sexo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Data De Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Linite De Compra a Prazo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "CEP: ";
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(58, 19);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(125, 20);
            this.CEP.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Logradouro: ";
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(96, 59);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(86, 20);
            this.Logradouro.TabIndex = 13;
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(292, 19);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(113, 20);
            this.Cidade.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(223, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cidade: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(435, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "UF: ";
            // 
            // UF
            // 
            this.UF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.UF.Location = new System.Drawing.Point(463, 19);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(48, 21);
            this.UF.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(209, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Complemento: ";
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(292, 59);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(219, 20);
            this.Complemento.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(526, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Bairro:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(513, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Numero: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 95);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "CPF:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(82, 69);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(297, 20);
            this.Email.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(13, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(213, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Celular: ";
            // 
            // Celular2
            // 
            this.Celular2.Location = new System.Drawing.Point(339, 23);
            this.Celular2.Mask = "(00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(86, 20);
            this.Celular2.TabIndex = 42;
            // 
            // Celular1
            // 
            this.Celular1.Location = new System.Drawing.Point(264, 23);
            this.Celular1.Mask = "+00";
            this.Celular1.Name = "Celular1";
            this.Celular1.Size = new System.Drawing.Size(41, 20);
            this.Celular1.TabIndex = 41;
            this.Celular1.Text = "55";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(81, 23);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(103, 20);
            this.Telefone.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "Telefone: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
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
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(27, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 54);
            this.button1.TabIndex = 47;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.data.Location = new System.Drawing.Point(321, 88);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(216, 20);
            this.data.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ValorLimite);
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(27, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(699, 123);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // ValorLimite
            // 
            this.ValorLimite.Location = new System.Drawing.Point(363, 58);
            this.ValorLimite.Name = "ValorLimite";
            this.ValorLimite.Size = new System.Drawing.Size(100, 20);
            this.ValorLimite.TabIndex = 53;
            this.ValorLimite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValorLimite_KeyPress);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(54, 89);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(125, 20);
            this.CPF.TabIndex = 52;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Numero);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CEP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Logradouro);
            this.groupBox2.Controls.Add(this.Cidade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.UF);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Complemento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Bairro);
            this.groupBox2.Location = new System.Drawing.Point(28, 156);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 104);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(569, 59);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(103, 20);
            this.Numero.TabIndex = 23;
            this.Numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numero_KeyPress);
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(569, 19);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(103, 20);
            this.Bairro.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Telefone);
            this.groupBox3.Controls.Add(this.Celular2);
            this.groupBox3.Controls.Add(this.Celular1);
            this.groupBox3.Controls.Add(this.Email);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(27, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(699, 102);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(744, 455);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.Label label12;
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
        private System.Windows.Forms.DateTimePicker data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.TextBox ValorLimite;
    }
}