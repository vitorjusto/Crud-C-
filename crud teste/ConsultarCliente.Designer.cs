
namespace crud_teste
{
    partial class ConsultarCliente
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
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.data = new System.Windows.Forms.MaskedTextBox();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.ValorLimite = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.d = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.paginaInicialToolStripMenuItem.Text = "Pagina Inicial";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.data);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.ValorLimite);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 138);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // CPF
            // 
            this.CPF.Enabled = false;
            this.CPF.Location = new System.Drawing.Point(81, 109);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(125, 20);
            this.CPF.TabIndex = 85;
            // 
            // data
            // 
            this.data.Enabled = false;
            this.data.Location = new System.Drawing.Point(471, 102);
            this.data.Mask = "00/00/0000";
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(76, 20);
            this.data.TabIndex = 84;
            // 
            // Nome
            // 
            this.Nome.Enabled = false;
            this.Nome.Location = new System.Drawing.Point(81, 35);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(125, 20);
            this.Nome.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nome: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Sobrenome: ";
            // 
            // Sobrenome
            // 
            this.Sobrenome.Enabled = false;
            this.Sobrenome.Location = new System.Drawing.Point(357, 32);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(345, 20);
            this.Sobrenome.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Sexo: ";
            // 
            // Sexo
            // 
            this.Sexo.Enabled = false;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.Sexo.Location = new System.Drawing.Point(81, 74);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(125, 21);
            this.Sexo.TabIndex = 54;
            // 
            // ValorLimite
            // 
            this.ValorLimite.Enabled = false;
            this.ValorLimite.Location = new System.Drawing.Point(447, 67);
            this.ValorLimite.Mask = "0000000,00";
            this.ValorLimite.Name = "ValorLimite";
            this.ValorLimite.Size = new System.Drawing.Size(101, 20);
            this.ValorLimite.TabIndex = 58;
            this.ValorLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Data De Nascimento: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Valor Limite De Compra a Prazo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(31, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(30, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "CPF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Numero);
            this.groupBox2.Controls.Add(this.CEP);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.Bairro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Logradouro);
            this.groupBox2.Controls.Add(this.Complemento);
            this.groupBox2.Controls.Add(this.Cidade);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UF);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(13, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(775, 117);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // Numero
            // 
            this.Numero.Enabled = false;
            this.Numero.Location = new System.Drawing.Point(621, 15);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(58, 20);
            this.Numero.TabIndex = 74;
            // 
            // CEP
            // 
            this.CEP.Enabled = false;
            this.CEP.Location = new System.Drawing.Point(61, 15);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(125, 20);
            this.CEP.TabIndex = 62;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(562, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 73;
            this.label12.Text = "Numero: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "CEP: ";
            // 
            // Bairro
            // 
            this.Bairro.Enabled = false;
            this.Bairro.Location = new System.Drawing.Point(621, 68);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(148, 20);
            this.Bairro.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Logradouro: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(562, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 71;
            this.label11.Text = "Bairro:";
            // 
            // Logradouro
            // 
            this.Logradouro.Enabled = false;
            this.Logradouro.Location = new System.Drawing.Point(100, 68);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(86, 20);
            this.Logradouro.TabIndex = 64;
            // 
            // Complemento
            // 
            this.Complemento.Enabled = false;
            this.Complemento.Location = new System.Drawing.Point(295, 68);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(251, 20);
            this.Complemento.TabIndex = 70;
            // 
            // Cidade
            // 
            this.Cidade.Enabled = false;
            this.Cidade.Location = new System.Drawing.Point(279, 15);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(113, 20);
            this.Cidade.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Complemento: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Cidade: ";
            // 
            // UF
            // 
            this.UF.Enabled = false;
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
            this.UF.Location = new System.Drawing.Point(470, 15);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(44, 21);
            this.UF.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(416, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "UF: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Email);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Telefone);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Celular2);
            this.groupBox3.Location = new System.Drawing.Point(13, 306);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(775, 55);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // Email
            // 
            this.Email.Enabled = false;
            this.Email.Location = new System.Drawing.Point(465, 22);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(304, 20);
            this.Email.TabIndex = 81;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 75;
            this.label14.Text = "Telefone: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(416, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 80;
            this.label16.Text = "Email:";
            // 
            // Telefone
            // 
            this.Telefone.Enabled = false;
            this.Telefone.Location = new System.Drawing.Point(82, 19);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(103, 20);
            this.Telefone.TabIndex = 76;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(212, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 79;
            this.label15.Text = "Celular: ";
            // 
            // Celular2
            // 
            this.Celular2.Enabled = false;
            this.Celular2.Location = new System.Drawing.Point(269, 19);
            this.Celular2.Mask = "+00 (00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(123, 20);
            this.Celular2.TabIndex = 78;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(42, 424);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(129, 20);
            this.Id.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(194, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(178, 77);
            this.button2.TabIndex = 63;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotaoSalvar.Enabled = false;
            this.BotaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.ForeColor = System.Drawing.Color.White;
            this.BotaoSalvar.Location = new System.Drawing.Point(389, 367);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(170, 77);
            this.BotaoSalvar.TabIndex = 64;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = false;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Red;
            this.Excluir.Enabled = false;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Excluir.Location = new System.Drawing.Point(578, 367);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(204, 77);
            this.Excluir.TabIndex = 65;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(13, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 51);
            this.button1.TabIndex = 61;
            this.button1.Text = "Consultar por Id";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // d
            // 
            this.d.AutoSize = true;
            this.d.Location = new System.Drawing.Point(12, 427);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(22, 13);
            this.d.TabIndex = 66;
            this.d.Text = "Id: ";
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.d);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultarCliente";
            this.Text = "Consultar Cliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.MaskedTextBox ValorLimite;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.MaskedTextBox data;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label d;
        private System.Windows.Forms.MaskedTextBox CPF;
    }
}