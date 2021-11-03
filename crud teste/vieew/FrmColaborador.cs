using System;
using CRUD_teste.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.controller;
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

            if((int)MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel) == 1)
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
            List<string> validacoes = colaborador.ValidarColaborador();
            if (validacoes.Count == 0)
            {
                try
                {



                    
                    if ((int)MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {
                        colaborador.idColaborador = oCadastrar.conectarComDAO(colaborador);
                        MessageBox.Show($"Dados Cadastrados com sucesso\nid = {colaborador.idColaborador}");

                        this.Close();
                        new ListarClientes().Show();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção");
                }
                
            }else
            {
                foreach(var x in validacoes)
                {
                    MessageBox.Show(x, "Atenção");
                }
                MessageBox.Show("Valide os campos", "Atenção");
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
            colaborador.Salario = Salario.Value;
            colaborador.DataDeNascimento = Data.Value.ToString().Remove(10);
            colaborador.CPF = CPF.Text;
            colaborador.DadosBancarios = Dados.Text;
            colaborador.contato.Email = Email.Text;
            colaborador.contato.Telefone = Telefone.Text;
            colaborador.contato.DDI = Celular1.Text;
            colaborador.contato.Celular = Celular2.Text;
            
            colaborador.PorcentagemDeComissao = Porcentagem.Value;


           

            colaborador.endereco.Cep = CEP.Text;
            colaborador.endereco.Logradouro = Logradouro.Text;
            colaborador.endereco.Cidade = Cidade.Text;
            colaborador.endereco.UF = UF.Text;
            colaborador.endereco.Complemento = Complemento.Text;
            colaborador.endereco.Bairro = Bairro.Text; 
            int.TryParse(Numero.Text, out int i);

            colaborador.endereco.Numero = i;



            return colaborador;


        }

       
    }
}
