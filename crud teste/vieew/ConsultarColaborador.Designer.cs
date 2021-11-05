
namespace crud_teste
{
    partial class ConsultarColaborador
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Data = new System.Windows.Forms.DateTimePicker();
            this.Porcentagem = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.Salario = new System.Windows.Forms.TextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.Conta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sexo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Sobrenome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CEP = new System.Windows.Forms.MaskedTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.Numero = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.UF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DDI = new System.Windows.Forms.MaskedTextBox();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.paginaInicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BotaoSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Excluir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Porcentagem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Data);
            this.groupBox1.Controls.Add(this.Porcentagem);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.Salario);
            this.groupBox1.Controls.Add(this.CPF);
            this.groupBox1.Controls.Add(this.Conta);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Sexo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Sobrenome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Data
            // 
            this.Data.Enabled = false;
            this.Data.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Data.Location = new System.Drawing.Point(339, 51);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(161, 20);
            this.Data.TabIndex = 74;
            this.Data.ValueChanged += new System.EventHandler(this.data_ValueChanged);
            // 
            // Porcentagem
            // 
            this.Porcentagem.DecimalPlaces = 2;
            this.Porcentagem.Enabled = false;
            this.Porcentagem.Location = new System.Drawing.Point(357, 82);
            this.Porcentagem.Name = "Porcentagem";
            this.Porcentagem.Size = new System.Drawing.Size(98, 20);
            this.Porcentagem.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(566, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "CPF";
            // 
            // Salario
            // 
            this.Salario.Enabled = false;
            this.Salario.Location = new System.Drawing.Point(51, 82);
            this.Salario.Name = "Salario";
            this.Salario.Size = new System.Drawing.Size(98, 20);
            this.Salario.TabIndex = 71;
            // 
            // CPF
            // 
            this.CPF.Enabled = false;
            this.CPF.Location = new System.Drawing.Point(635, 54);
            this.CPF.Mask = "000.000.000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(114, 20);
            this.CPF.TabIndex = 66;
            // 
            // Conta
            // 
            this.Conta.Enabled = false;
            this.Conta.Location = new System.Drawing.Point(569, 82);
            this.Conta.Name = "Conta";
            this.Conta.Size = new System.Drawing.Size(180, 20);
            this.Conta.TabIndex = 66;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 65;
            this.label12.Text = "Conta Bancaria: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Porcentagem de Comissão";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sálario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Nascimento";
            // 
            // Sexo
            // 
            this.Sexo.Enabled = false;
            this.Sexo.FormattingEnabled = true;
            this.Sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Outros"});
            this.Sexo.Location = new System.Drawing.Point(49, 53);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(100, 21);
            this.Sexo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // Sobrenome
            // 
            this.Sobrenome.Enabled = false;
            this.Sobrenome.Location = new System.Drawing.Point(339, 19);
            this.Sobrenome.Name = "Sobrenome";
            this.Sobrenome.Size = new System.Drawing.Size(410, 20);
            this.Sobrenome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sobrenome";
            // 
            // Nome
            // 
            this.Nome.Enabled = false;
            this.Nome.Location = new System.Drawing.Point(49, 20);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(100, 20);
            this.Nome.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CEP);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.Complemento);
            this.groupBox2.Controls.Add(this.Numero);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Bairro);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.Logradouro);
            this.groupBox2.Controls.Add(this.UF);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Cidade);
            this.groupBox2.Location = new System.Drawing.Point(12, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 115);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // CEP
            // 
            this.CEP.Enabled = false;
            this.CEP.Location = new System.Drawing.Point(65, 22);
            this.CEP.Mask = "00000-000";
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(100, 20);
            this.CEP.TabIndex = 59;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(506, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(34, 13);
            this.label19.TabIndex = 58;
            this.label19.Text = "Bairro";
            // 
            // Complemento
            // 
            this.Complemento.Enabled = false;
            this.Complemento.Location = new System.Drawing.Point(262, 73);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(331, 20);
            this.Complemento.TabIndex = 55;
            // 
            // Numero
            // 
            this.Numero.Enabled = false;
            this.Numero.Location = new System.Drawing.Point(681, 72);
            this.Numero.Mask = "0000";
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(49, 20);
            this.Numero.TabIndex = 51;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(612, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 50;
            this.label13.Text = "Numero: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "CEP: ";
            // 
            // Bairro
            // 
            this.Bairro.Enabled = false;
            this.Bairro.Location = new System.Drawing.Point(569, 19);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(161, 20);
            this.Bairro.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Logradouro: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(179, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Complemento: ";
            // 
            // Logradouro
            // 
            this.Logradouro.Enabled = false;
            this.Logradouro.Location = new System.Drawing.Point(90, 73);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(75, 20);
            this.Logradouro.TabIndex = 42;
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
            this.UF.Location = new System.Drawing.Point(448, 22);
            this.UF.Name = "UF";
            this.UF.Size = new System.Drawing.Size(52, 21);
            this.UF.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Cidade: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(392, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 45;
            this.label10.Text = "UF:";
            // 
            // Cidade
            // 
            this.Cidade.Enabled = false;
            this.Cidade.Location = new System.Drawing.Point(255, 22);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(120, 20);
            this.Cidade.TabIndex = 44;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DDI);
            this.groupBox3.Controls.Add(this.Celular2);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.Telefone);
            this.groupBox3.Controls.Add(this.emailText);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(12, 268);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 76);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // DDI
            // 
            this.DDI.Enabled = false;
            this.DDI.Location = new System.Drawing.Point(262, 22);
            this.DDI.Mask = "+00";
            this.DDI.Name = "DDI";
            this.DDI.Size = new System.Drawing.Size(24, 20);
            this.DDI.TabIndex = 72;
            // 
            // Celular2
            // 
            this.Celular2.Enabled = false;
            this.Celular2.Location = new System.Drawing.Point(306, 23);
            this.Celular2.Mask = "(00) 0000 - 0000";
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(123, 20);
            this.Celular2.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 58;
            this.label14.Text = "Telefone: ";
            // 
            // Telefone
            // 
            this.Telefone.Enabled = false;
            this.Telefone.Location = new System.Drawing.Point(90, 22);
            this.Telefone.Mask = "0000 - 0000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(85, 20);
            this.Telefone.TabIndex = 59;
            // 
            // emailText
            // 
            this.emailText.Enabled = false;
            this.emailText.Location = new System.Drawing.Point(486, 26);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(204, 20);
            this.emailText.TabIndex = 64;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(445, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 63;
            this.label16.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(208, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 62;
            this.label15.Text = "Celular: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paginaInicialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paginaInicialToolStripMenuItem
            // 
            this.paginaInicialToolStripMenuItem.Name = "paginaInicialToolStripMenuItem";
            this.paginaInicialToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.paginaInicialToolStripMenuItem.Text = "Voltar";
            this.paginaInicialToolStripMenuItem.Click += new System.EventHandler(this.paginaInicialToolStripMenuItem_Click);
            // 
            // BotaoSalvar
            // 
            this.BotaoSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BotaoSalvar.Enabled = false;
            this.BotaoSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSalvar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BotaoSalvar.Location = new System.Drawing.Point(257, 350);
            this.BotaoSalvar.Name = "BotaoSalvar";
            this.BotaoSalvar.Size = new System.Drawing.Size(259, 79);
            this.BotaoSalvar.TabIndex = 66;
            this.BotaoSalvar.Text = "Salvar";
            this.BotaoSalvar.UseVisualStyleBackColor = false;
            this.BotaoSalvar.Click += new System.EventHandler(this.BotaoSalvar_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(12, 350);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(239, 79);
            this.button2.TabIndex = 65;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Excluir
            // 
            this.Excluir.BackColor = System.Drawing.Color.Red;
            this.Excluir.Enabled = false;
            this.Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Excluir.Location = new System.Drawing.Point(529, 350);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(232, 79);
            this.Excluir.TabIndex = 67;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = false;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // ConsultarColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.BotaoSalvar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConsultarColaborador";
            this.Text = "Consultar Colaborador";
            this.Load += new System.EventHandler(this.ConsultarColaborador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Porcentagem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Sobrenome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Sexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Numero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.ComboBox UF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Conta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.MaskedTextBox CEP;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paginaInicialToolStripMenuItem;
        private System.Windows.Forms.Button BotaoSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Excluir;
        private System.Windows.Forms.TextBox Salario;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown Porcentagem;
        private System.Windows.Forms.MaskedTextBox DDI;
        private System.Windows.Forms.DateTimePicker Data;
    }
}