using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using crud_teste.controller;
using System.Windows.Forms;
using crud_teste.vieew;
namespace crud_teste
{
    public partial class ConsultarColaborador : Form
    {
        private Colaborador colaboradorGlobal = new Colaborador();
        public ConsultarColaborador(int id)
        {
            InitializeComponent();
            AlterarColaborador oColaborador = new AlterarColaborador();
            try
            {



                colaboradorGlobal.idColaborador = id;

                colaboradorGlobal = oColaborador.consultarColaborador(colaboradorGlobal.idColaborador);

                AtribuirCampos(colaboradorGlobal);


                this.Text = "Consultando: " + colaboradorGlobal.nomeCompleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

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
            DDI.Text = colaborador.contato.DDI;
            emailText.Text = colaborador.contato.Email;
            Data.Text = colaborador.DataDeNascimento;

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
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina de listagem?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new ListarColaboradores().Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colaboradorGlobal.idColaborador != 0)
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
                DDI.Enabled = true;
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
            DDI.Enabled = false;
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
            DDI.Text = "";
        
        }

        private void BotaoSalvar_Click_1(object sender, EventArgs e)
        {
             preencherCampos();
            List<string> validacoes = colaboradorGlobal.ValidarColaborador();
            ConexaoDAO stmt = new ConexaoDAO();

            if (validacoes.Count == 0)
            {
                try
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();


                    if ((int)MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {
                        oColaborador.SalvarColaborador(colaboradorGlobal);
                        MessageBox.Show("Dados Salvos com sucesso");
                        Bloquear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
            else
            {
                
                MessageBox.Show(String.Join("\n", validacoes.ToArray()), "Atenção");
                MessageBox.Show("Valide os campos", "Atenção");
            }


        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                AlterarColaborador oColaborador = new AlterarColaborador();
                try
                {
                    oColaborador.Excluir(colaboradorGlobal);
                    this.Text = "Consultar Colaborador";
                    MessageBox.Show("Dados excluidos com sucesso");
                    colaboradorGlobal = null;
                    Bloquear();
                    Limpar();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
        }

        public void preencherCampos()
        {




            colaboradorGlobal.Nome = Nome.Text;
            colaboradorGlobal.SobreNome = Sobrenome.Text;
            colaboradorGlobal.Sexo = Sexo.Text;
            decimal.TryParse(Salario.Text, out decimal x);
            colaboradorGlobal.Salario = x;
            colaboradorGlobal.DataDeNascimento = Data.Value.ToString().Remove(10);
            colaboradorGlobal.CPF = CPF.Text;
            colaboradorGlobal.DadosBancarios = Conta.Text;
            colaboradorGlobal.contato.Email = emailText.Text;
            colaboradorGlobal.contato.Telefone = Telefone.Text;
            colaboradorGlobal.contato.DDI = "0";
            colaboradorGlobal.contato.Celular = Celular2.Text;

            colaboradorGlobal.PorcentagemDeComissao = Porcentagem.Value;




            colaboradorGlobal.endereco.Cep = CEP.Text;
            colaboradorGlobal.endereco.Logradouro = Logradouro.Text;
            colaboradorGlobal.endereco.Cidade = Cidade.Text;
            colaboradorGlobal.endereco.UF = UF.Text;
            colaboradorGlobal.endereco.Complemento = Complemento.Text;
            colaboradorGlobal.endereco.Bairro = Bairro.Text;
            int.TryParse(Numero.Text, out int i);

            colaboradorGlobal.endereco.Numero = i;





        }

        private void data_ValueChanged(object sender, EventArgs e)
        {

        }
    }

   
}
