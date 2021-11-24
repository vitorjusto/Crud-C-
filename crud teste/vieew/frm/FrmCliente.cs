using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.Validation;
using System.Linq;
using FluentValidation;

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
            if (MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new ListarClientes().Show();
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {


            var cliente = new Cliente();
            cliente = preencherCampos();
            ClienteValidation validar = new ClienteValidation();

            var validateres = validar.Validate(cliente);
            
            if (validateres.IsValid)
            {
                if (MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        AlterarCliente oAlterar = new AlterarCliente();
                        var id = oAlterar.conectarComDAO(cliente);

                        MessageBox.Show($"Dados Cadastrados com sucesso\nid = {id}");
                       

                            new ListarClientes().Show();
                            this.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show(validateres.Errors.FirstOrDefault().ToString(), "Atenção");
                
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
            cliente.contato.Celular = Celular2.Text;
            cliente.contato.Celular.DDI = Celular1.Text;
            cliente.contato.Email = Email.Text;
            cliente.DataDeNascimento = data.Value;
            cliente.LimiteDeCompra = decimal.Parse(ValorLimite.Text);
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

        private void Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Global.isNotIntChar(e.KeyChar);
        }

        private void ValorLimite_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotFloatText(e.KeyChar, ValorLimite.Text);
        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }
    }


    
     
    }

