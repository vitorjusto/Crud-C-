
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
            this.label6 = new System.Windows.Forms.Label();
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
            this.label14 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Celular1 = new System.Windows.Forms.MaskedTextBox();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Porcentagem = new crud_teste.Config.Custom_Controls.PercentTextBox();
            this.Salario = new crud_teste.Config.Custom_Controls.MoneyTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Numero = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Digito = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Conta = new System.Windows.Forms.TextBox();
            this.Agencia = new System.Windows.Forms.TextBox();
            this.Banco = new System.Windows.Forms.TextBox();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.Location = new System.Drawing.Point(59, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(101, 20);
            this.Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome:";
            // 
            // Sobrenome
            // 
            this.Sobrenome.Location = new System.Drawing.Point(303, 20);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(427, 20);
            this.Sobrenome.TabIndex = 2;
            // 
            // Sexo
            // 
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outro"});
            this.Sexo.Location = new System.Drawing.Point(59, 60);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(101, 21);
            this.Sexo.TabIndex = 3;
            this.Sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sexo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sexo: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Data De Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sálario: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "% de Comissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "CEP: ";
            // 
            // CEP
            // 
            this.CEP.Location = new System.Drawing.Point(79, 20);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(84, 20);
            this.CEP.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Logradouro: ";
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(79, 60);
            this.Logradouro.MaxLength = 99;
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(85, 20);
            this.Logradouro.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(178, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cidade: ";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(273, 20);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(142, 20);
            this.Cidade.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "UF:";
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
            this.UF.Location = new System.Drawing.Point(486, 20);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(49, 21);
            this.UF.TabIndex = 10;
            this.UF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.UF_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Complemento: ";
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(273, 60);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(262, 20);
            this.Complemento.TabIndex = 13;
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(625, 20);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(105, 20);
            this.Bairro.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(570, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bairro:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(570, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Numero: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Telefone: ";
            // 
            // Telefone
            // 
            this.Telefone.Location = new System.Drawing.Point(79, 20);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(90, 20);
            this.Telefone.TabIndex = 15;
            // 
            // Celular1
            // 
            this.Celular1.Location = new System.Drawing.Point(273, 20);
            this.Celular1.Mask = "+00";
            this.Celular1.Name = "Celular1";
            this.Celular1.Size = new System.Drawing.Size(39, 20);
            this.Celular1.TabIndex = 16;
            this.Celular1.Text = "55";
            // 
            // Celular2
            // 
            this.Celular2.Location = new System.Drawing.Point(320, 20);
            this.Celular2.Mask = "(00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(95, 20);
            this.Celular2.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Celular: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(446, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Email:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(527, 20);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(203, 20);
            this.Email.TabIndex = 18;
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(626, 60);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(104, 20);
            this.CPF.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(570, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "CPF:";
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(807, 24);
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
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(23, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 78);
            this.button1.TabIndex = 23;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data
            // 
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(303, 60);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(112, 20);
            this.Data.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Porcentagem);
            this.groupBox1.Controls.Add(this.Salario);
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(24, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 140);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // Porcentagem
            // 
            this.Porcentagem.Location = new System.Drawing.Point(303, 100);
            this.Porcentagem.MaxLength = 15;
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(112, 20);
            this.Porcentagem.TabIndex = 7;
            // Salario
            // 
            this.Salario.Location = new System.Drawing.Point(59, 100);
            this.Salario.MaxLength = 15;
            this.Salario.Name = "Salario";
            this.Salario.Negative = System.Drawing.Color.Red;
            this.Salario.Positive = System.Drawing.Color.Green;
            this.Salario.Size = new System.Drawing.Size(101, 20);
            this.Salario.StyleText = false;
            this.Salario.TabIndex = 6;
            this.Salario.Zero = System.Drawing.Color.Black;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Numero);
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
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(24, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 100);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereco";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(626, 60);
            this.Numero.MaxLength = 6;
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(104, 20);
            this.Numero.TabIndex = 14;
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
            this.groupBox3.Location = new System.Drawing.Point(24, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 60);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Digito);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.Conta);
            this.groupBox4.Controls.Add(this.Agencia);
            this.groupBox4.Controls.Add(this.Banco);
            this.groupBox4.Location = new System.Drawing.Point(24, 331);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(755, 60);
            this.groupBox4.TabIndex = 69;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dados Bancários";
            // 
            // Digito
            // 
            this.Digito.Location = new System.Drawing.Point(697, 20);
            this.Digito.MaxLength = 1;
            this.Digito.Name = "Digito";
            this.Digito.Size = new System.Drawing.Size(32, 20);
            this.Digito.TabIndex = 22;
            this.Digito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Conta_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(653, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Digito:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(446, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 6;
            this.label21.Text = "Conta:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 24);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 5;
            this.label20.Text = "Banco:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(285, 26);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 13);
            this.label19.TabIndex = 4;
            this.label19.Text = "Agencia:";
            // 
            // Conta
            // 
            this.Conta.Location = new System.Drawing.Point(527, 20);
            this.Conta.MaxLength = 5;
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(120, 20);
            this.Conta.TabIndex = 21;
            this.Conta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Conta_KeyPress);
            // 
            // Agencia
            // 
            this.Agencia.Location = new System.Drawing.Point(380, 23);
            this.Agencia.MaxLength = 3;
            this.Agencia.Name = "Agencia";
            this.Agencia.Size = new System.Drawing.Size(35, 20);
            this.Agencia.TabIndex = 20;
            this.Agencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Agencia_KeyPress);
            // 
            // Banco
            // 
            this.Banco.Location = new System.Drawing.Point(79, 20);
            this.Banco.MaxLength = 99;
            this.Banco.Name = "Banco";
            this.Banco.Size = new System.Drawing.Size(90, 20);
            this.Banco.TabIndex = 19;
            // 
            // FrmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(807, 497);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "FrmColaborador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.Label label6;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox Celular1;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker Data;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Conta;
        private System.Windows.Forms.TextBox Agencia;
        private System.Windows.Forms.TextBox Banco;
        private System.Windows.Forms.TextBox Digito;
        private System.Windows.Forms.TextBox Numero;
        private Config.Custom_Controls.PercentTextBox Porcentagem;
        private Config.Custom_Controls.MoneyTextBox Salario;
    }
}