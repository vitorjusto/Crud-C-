using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using crud_teste.controller;
using System.Windows.Forms;

namespace crud_teste
{
    public partial class ConsultarColaborador : Form
    {
        public int idpesquisado;
        public int enderecoPesquisado;
        public ConsultarColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarColaborador oColaborador = new AlterarColaborador();
            try
            {
                

                Colaborador colaborador = new Colaborador();
                var id = Id.Text;

                colaborador = oColaborador.consultarColaborador(int.Parse(id));

                AtribuirCampos(colaborador);
                
                idpesquisado = colaborador.idColaborador;
                enderecoPesquisado = colaborador.endereco.IdEndereco;

                this.Text = "Consultando: " + colaborador.nomeCompleto();
            }
            catch
            {
                MessageBox.Show("Id Inválida");
            }
            
            

        }

        private void AtribuirCampos(Colaborador colaborador)
        {
            Nome.Text = colaborador.Nome.ToString();
            Sobrenome.Text = colaborador.SobreNome;
            Sexo.Text = colaborador.Sexo;
            CPF.Text = colaborador.CPF;
            Salario.Text = colaborador.Salario.ToString();
            Porcentagem.Text = colaborador.PorcentagemDeComissao.ToString();
            Conta.Text = colaborador.DadosBancarios;
            Telefone.Text = colaborador.contato.Telefone;
            Celular2.Text = colaborador.contato.Celular;
            emailText.Text = colaborador.contato.Email;
            Data.Text = colaborador.DataDeNascimento.ToString();

            AtribuirCamposEnderecos(colaborador.endereco);


        }

        private void AtribuirCamposEnderecos(Endereco endereco)
        {
            CEP.Text = endereco.Cep;
            Logradouro.Text = endereco.Logradouro;
            Cidade.Text = endereco.Cidade;
            UF.Text = endereco.UF;
            Complemento.Text = endereco.Complemento;
            Bairro.Text = endereco.Bairro;
            Numero.Text = endereco.Numero.ToString();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new LColaboradores().Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idpesquisado != 0)
            {
                Nome.Enabled = true;
                Sobrenome.Enabled = true;
                Sexo.Enabled = true;
                Data.Enabled = true;
                Conta.Enabled = true;
                CPF.Enabled = true;
                Telefone.Enabled = true;
                Celular2.Enabled = true;
                emailText.Enabled = true;
                CEP.Enabled = true;
                Logradouro.Enabled = true;
                Cidade.Enabled = true;
                UF.Enabled = true;
                Numero.Enabled = true;
                Bairro.Enabled = true;
                Complemento.Enabled = true;
                BotaoSalvar.Enabled = true;
                Porcentagem.Enabled = true;
                Salario.Enabled = true;
                Conta.Enabled = true;
                Excluir.Enabled = true;
            }
        }

        public void Bloquear()
        {
            Nome.Enabled = false;
            Sobrenome.Enabled = false;
            Sexo.Enabled = false;
            Data.Enabled = false;
            CPF.Enabled = false;
            Telefone.Enabled = false;
            Celular2.Enabled = false; 
            emailText.Enabled = false;
            CEP.Enabled = false;
            Logradouro.Enabled = false;
            Cidade.Enabled = false;
            UF.Enabled = false;
            Numero.Enabled = false;
            Bairro.Enabled = false;
            Complemento.Enabled = false;
            BotaoSalvar.Enabled = false;
            Conta.Enabled = false;
            Porcentagem.Enabled = false;
            Conta.Enabled = false;
            Salario.Enabled = false;

            Excluir.Enabled = false;
        }

        public void Limpar()
        {
            Nome.Text= "";
            Sobrenome.Text = "";
            Sexo.Text = "";
            Data.Text = "";
            CPF.Text = "";
            Telefone.Text = "";
            Celular2.Text = "";
            emailText.Text = "";
            CEP.Text = "";
            Logradouro.Text = "";
            Cidade.Text = "";
            UF.Text = "";
            Numero.Text = "";
            Bairro.Text = "";
            Complemento.Text = "";
            Conta.Text = "";
            Porcentagem.Text = "";
            Conta.Text = "";
            Salario.Text = "";
            Id.Text = "";
  
        }

        private void BotaoSalvar_Click_1(object sender, EventArgs e)
        {
            Colaborador colaborador = new Colaborador();
            colaborador = preencherCampos();
            List<string> validacoes = colaborador.ValidarColaborador();
            ConexaoDAO stmt = new ConexaoDAO();

            if (validacoes.Count == 0)
            {
                try
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();


                    if ((int)MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {
                        oColaborador.SalvarColaborador(colaborador);
                        MessageBox.Show("Dados Cadastrado com sucesso");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

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

        private void Excluir_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                AlterarColaborador oColaborador = new AlterarColaborador();
                ConexaoDAO stmt = new ConexaoDAO();
                try
                {
                    oColaborador.Excluir(idpesquisado, enderecoPesquisado);
                    this.Text = "Consultar Colaborador";
                    MessageBox.Show("Dados excluidos com sucesso");
                    idpesquisado = 0;
                    enderecoPesquisado = 0;
                    Bloquear();
                    Limpar();
                }
                catch
                {
                    MessageBox.Show("Falha ao conectar com o banco de dados");
                }
                finally
                {
                    
                    
                }

            }   
        }

        private void ConsultarColaborador_Load(object sender, EventArgs e)
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
            label17.ForeColor = Global.FontColor;
            label18.ForeColor = Global.FontColor;
        }

        public Colaborador preencherCampos()
        {
            Colaborador colaborador = new Colaborador();


            

            colaborador.Nome = Nome.Text;
            colaborador.SobreNome = Sobrenome.Text;
            colaborador.Sexo = Sexo.Text;
            decimal.TryParse(Salario.Text, out decimal x);
            colaborador.Salario = x;
            colaborador.DataDeNascimento = Data.ToString().Remove(10);
            colaborador.CPF = CPF.Text;
            colaborador.DadosBancarios = Conta.Text;
            colaborador.contato.Email = emailText.Text;
            colaborador.contato.Telefone = Telefone.Text;
            colaborador.contato.DDI = "0";
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
