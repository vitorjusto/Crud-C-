using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
namespace crud_teste
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new LColaboradores().Show();
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            var cadastrado = false;
            var cliente = new Cliente();
            cliente = preencherCampos();



            List<string> validacoes = cliente.ValidarCliente();


            if (validacoes.Count == 0)
            {
                if ((int)MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {
                    AlterarCliente.conectarComDAO(cliente);

                    MessageBox.Show($"Dados Cadastrados com sucesso\nid = ");
                    if (cadastrado)
                    {
                        this.Close();
                        new LColaboradores().Show();
                    }
                }
            }
            else
            {
                foreach (var x in validacoes)
                {
                    MessageBox.Show(x, "Atenção");
                }
                MessageBox.Show("Valide os campos", "Atenção");
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            groupBox1.ForeColor = Global.FontColor;
            groupBox2.ForeColor = Global.FontColor;
            groupBox3.ForeColor = Global.FontColor;

            menuStrip1.ForeColor = Global.FontColor;
            label1.ForeColor = Global.FontColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.BackColor = Global.Strip;
            label1.ForeColor = Global.FontColor;
            label2.ForeColor = Global.FontColor;
            label3.ForeColor = Global.FontColor;
            label4.ForeColor = Global.FontColor;
            label5.ForeColor = Global.FontColor;
            label6.ForeColor = Global.FontColor;
            label7.ForeColor = Global.FontColor;
            label8.ForeColor = Global.FontColor;
            label9.ForeColor = Global.FontColor;
            label10.ForeColor = Global.FontColor;
            label11.ForeColor = Global.FontColor;
            label12.ForeColor = Global.FontColor;
            label14.ForeColor = Global.FontColor;
            label15.ForeColor = Global.FontColor;
            label16.ForeColor = Global.FontColor;

        }
        public Cliente preencherCampos()
        {
            Cliente cliente = new Cliente();
            cliente.Nome = Nome.Text;
            cliente.SobreNome = Sobrenome.Text;
            cliente.Sexo = Sexo.Text;
            cliente.CPF = CPF.Text;
            cliente.contato.Telefone = Telefone.Text;
            cliente.contato.DDI = Celular1.Text;
            cliente.contato.Celular = Celular2.Text;
            cliente.contato.Email = Email.Text;
            cliente.DataDeNascimento = data.Value.ToString().Remove(10);
            cliente.LimiteDeCompra = ValorLimite.Value;

            cliente.endereco.Cep = CEP.Text;
            cliente.endereco.Logradouro = Logradouro.Text;
            cliente.endereco.Cidade = Cidade.Text;
            cliente.endereco.UF = UF.Text;
            cliente.endereco.Complemento = Complemento.Text;
            cliente.endereco.Bairro = Bairro.Text;
            int.TryParse(Numero.Text, out int i);

            cliente.endereco.Numero = i;



            return cliente;


        }
    }


    
     
    }

