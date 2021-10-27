
namespace crud_teste
{
    partial class FrmColaborador
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
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Porcentagem = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Celular1 = new System.Windows.Forms.MaskedTextBox();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Dados = new System.Windows.Forms.TextBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(59, 19);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(104, 20);
            this.Nome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome:";
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(261, 19);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(369, 20);
            this.Sobrenome.TabIndex = 3;
            // 
            // Sexo
            // 
            this.Sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.Sexo.Location = new System.Drawing.Point(59, 51);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(104, 21);
            this.Sexo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data De Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sálario: ";
            // 
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(59, 86);
            this.Salario.Mask = "00000,00";
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(105, 20);
            this.Salario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "% de Comissão";
            // 
            // Porcentagem
            // 
            this.Porcentagem.Location = new System.Drawing.Point(289, 86);
            this.Porcentagem.Mask = "000";
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(31, 20);
            this.Porcentagem.TabIndex = 12;
            this.Porcentagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CEP: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(59, 19);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(104, 20);
            this.CEP.TabIndex = 14;
            this.CEP.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CEP_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Logradouro: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(79, 70);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(85, 20);
            this.Logradouro.TabIndex = 16;
            this.Logradouro.TextChanged += new System.EventHandler(this.Logradouro_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(244, 19);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(130, 20);
            this.Cidade.TabIndex = 18;
            this.Cidade.TextChanged += new System.EventHandler(this.Cidade_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(391, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "UF:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
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
            this.UF.Location = new System.Drawing.Point(421, 19);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(49, 21);
            this.UF.TabIndex = 21;
            this.UF.SelectedIndexChanged += new System.EventHandler(this.UF_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Complemento: ";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(261, 70);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(211, 20);
            this.Complemento.TabIndex = 23;
            this.Complemento.TextChanged += new System.EventHandler(this.Complemento_TextChanged);
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(516, 19);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(105, 20);
            this.Bairro.TabIndex = 24;
            this.Bairro.TextChanged += new System.EventHandler(this.Bairro_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bairro:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(490, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Numero: ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(560, 70);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(43, 20);
            this.Numero.TabIndex = 27;
            this.Numero.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Numero_MaskInputRejected);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Telefone: ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(84, 19);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(85, 20);
            this.Telefone.TabIndex = 29;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Telefone_MaskInputRejected);
            // 
            // Celular1
            // 
            this.Celular1.Location = new System.Drawing.Point(249, 19);
            this.Celular1.Mask = "+00";
            this.Celular1.Name = "Celular1";
            this.Celular1.Size = new System.Drawing.Size(39, 20);
            this.Celular1.TabIndex = 30;
            this.Celular1.Text = "55";
            this.Celular1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Celular1_MaskInputRejected);
            // 
            // Celular2
            // 
            this.Celular2.Location = new System.Drawing.Point(306, 19);
            this.Celular2.Mask = "(00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(86, 20);
            this.Celular2.TabIndex = 31;
            this.Celular2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Celular2_MaskInputRejected);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(189, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Celular: ";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 74);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Email:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(84, 71);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(204, 20);
            this.Email.TabIndex = 34;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(526, 53);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(104, 20);
            this.CPF.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(469, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "CPF:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(326, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(86, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Conta Bancaria: ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Dados
            // 
            this.Dados.Location = new System.Drawing.Point(428, 87);
            this.Dados.Name = "Dados";
            this.Dados.Size = new System.Drawing.Size(202, 20);
            this.Dados.TabIndex = 38;
            this.Dados.TextChanged += new System.EventHandler(this.Dados_TextChanged);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(686, 24);
            this.menuStrip2.TabIndex = 40;
            this.menuStrip2.Text = "menuStrip2";
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(24, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 50);
            this.button1.TabIndex = 41;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(289, 53);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(126, 20);
            this.Data.TabIndex = 42;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.Dados);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Salario);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Porcentagem);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 124);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CEP);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.Logradouro);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.Cidade);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.UF);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Complemento);
            this.groupBox2.Controls.Add(this.Bairro);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Numero);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(24, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 116);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereco";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Celular2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Telefone);
            this.groupBox3.Controls.Add(this.Celular1);
            this.groupBox3.Controls.Add(this.Email);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Location = new System.Drawing.Point(24, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(636, 100);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // FrmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(686, 454);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmColaborador";
            this.Text = "Colaborador";
            this.Load += new System.EventHandler(this.Colaborador_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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

        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Salario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Porcentagem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox Celular1;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Dados;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}