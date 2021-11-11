using System;
using CRUD_teste.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.controller;
using crud_teste.Validation;
using System.Linq;

namespace crud_teste
{
    public partial class FrmColaborador : Form
    {
        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new ListarClientes().Show();
            }
            
           
        }

        private void Colaborador_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            groupBox1.ForeColor = Global.FontColor;
            groupBox2.ForeColor = Global.FontColor;
            groupBox3.ForeColor = Global.FontColor;

            menuStrip2.ForeColor = Global.FontColor;
            label1.ForeColor = Global.FontColor;
            menuStrip2.BackColor = Global.Strip;
            menuStrip2.BackColor = Global.Strip;
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

        private void button1_Click(object sender, EventArgs e)
        {



            

            Colaborador colaborador = new Colaborador();
            AlterarColaborador oCadastrar = new AlterarColaborador();
            colaborador = preencherCampos();
            ColaboradorValidator validar = new ColaboradorValidator();

            var validateres = validar.Validate(colaborador);

            if (validateres.IsValid)
            {
                try
                {



                    
                    if (MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        colaborador.idColaborador = oCadastrar.conectarComDAO(colaborador);
                        MessageBox.Show($"Dados Cadastrados com sucesso\nid = {colaborador.idColaborador}");

                        new ListarClientes().Show();
                        this.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção");
                }
                
            }else
            {

                    MessageBox.Show(validateres.Errors.FirstOrDefault().ToString(), "Atenção");
                
            }
            
        }

        public string ConverterData(string Data)
        {
            return $"{Data[6]}{Data[7]}{Data[8]}{Data[9]}-{Data[0]}{Data[1]}-{Data[3]}{Data[4]}";
        }

        public Colaborador preencherCampos()
        {
            Colaborador colaborador = new Colaborador();




            colaborador.Nome = Nome.Text;
            colaborador.SobreNome = Sobrenome.Text;
            colaborador.Sexo = Sexo.Text;
            colaborador.Salario = decimal.Parse(Salario.Text);
            colaborador.DataDeNascimento = Data.Value;
            colaborador.CPF = CPF.Text;
            colaborador.contato.Email = Email.Text;
            colaborador.contato.Telefone = Telefone.Text;
            colaborador.contato.Celular = Celular2.Text;

            colaborador.contato.Celular.DDI = Celular1.Text;
            colaborador.PorcentagemDeComissao = decimal.Parse(Porcentagem.Text);


           

            colaborador.endereco.Cep = CEP.Text;
            colaborador.endereco.Logradouro = Logradouro.Text;
            colaborador.endereco.Cidade = Cidade.Text;
            colaborador.endereco.UF = UF.Text;
            colaborador.endereco.Complemento = Complemento.Text;
            colaborador.endereco.Bairro = Bairro.Text; 
            int.TryParse(Numero.Text, out int i);

            colaborador.endereco.Numero = i;


            colaborador.DadosBancarios.Banco = Banco.Text;
            colaborador.DadosBancarios.Agencia = int.Parse(Agencia.Text);
            colaborador.DadosBancarios.Conta = int.Parse(Conta.Text);
            colaborador.DadosBancarios.Digito = int.Parse(Digito.Text);



            return colaborador;


        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotIntChar(e.KeyChar);
        }

        private void Porcentagem_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Global.isNotFloatText(e.KeyChar, Porcentagem.Text);
        }

        private void Salario_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Global.isNotFloatText(e.KeyChar, Salario.Text);
        }
    }
}
