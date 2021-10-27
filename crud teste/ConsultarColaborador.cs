using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            ConexaoDAO stmt = new ConexaoDAO();
            try
            {
                stmt.conectar();

                Colaborador colaborador = new Colaborador();
                var id = Id.Text;

                colaborador = stmt.ConsultarColaborador($"Select * from Colaborador where idColaborador = {id}");

                AtribuirCampos(colaborador);
                AtribuirCamposEnderecos(stmt.ConsultarEndereco($"Select * from Endereco where idEndereco = {colaborador.idEndereco}"));
                idpesquisado = colaborador.idColaborador;
                enderecoPesquisado = colaborador.idEndereco;

                this.Text = "Consultando: " + colaborador.nomeCompleto();
            }
            catch
            {
                MessageBox.Show("Id Inválida");
            }
            finally
            {
                stmt.desconectar();
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
            Telefonee.Text = colaborador.Telefone;
            Celular2.Text = colaborador.Celular;
            emailText.Text = colaborador.Email;
            Data.Text = colaborador.DataDeNascimento.ToString();

            
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
                Telefonee.Enabled = true;
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
            Telefonee.Enabled = false;
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
            Telefonee.Text = "";
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

            
                ConexaoDAO stmt = new ConexaoDAO();
                try
                {


                    if (Nome.Text.Length == 0)
                    {
                        throw new Exception("O campo nome é obrigatorio!");
                    }
                    if (Sexo.Text.Length == 0)
                    {
                        throw new Exception("O campo sexo é obrigatório");
                    }

                    decimal.TryParse(Salario.Text, out decimal c);
                    if (c <= 0)
                    {
                        throw new Exception("Digite um sálario válido");
                    }

                    decimal.TryParse(Porcentagem.Text, out c);

                    if (CPF.Text.Length != 14)
                    {
                        throw new Exception("Digite um CPF valido!");
                    }
                    if (CEP.Text.Length != 9)
                    {
                        throw new Exception("Digite um CEP valido!");
                    }

                    if (UF.Text.Length == 0)
                    {
                        throw new Exception("O campo UF é Obrigatório");
                    }

                    if (Cidade.Text.Length == 0)
                    {
                        throw new Exception("O Campo cidade é obrigatório");
                    }
                    if (Bairro.Text.Length == 0)
                    {
                        throw new Exception("O campo bairro é obrigatório");
                    }
                    if (Logradouro.Text.Length == 0)
                    {
                        throw new Exception("O campo Logradouro é obrigatório");
                    }

                    uint.TryParse(Numero.Text, out uint a);
                    if (a == 0)
                    {
                        throw new Exception("Digite um numero de casa válido!");
                    }

                    if (!((Telefonee.Text.Length == 11) || (Celular2.Text.Length == 16) || (emailText.Text.Length != 0)))
                    {
                        throw new Exception("Escreva apenas um campo de contato");
                    }

                    if ((int)MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {
                        stmt.conectar();
                        stmt.AlterarCliente($"update colaborador set Nome = '{Nome.Text}', SobreNome = '{Sobrenome.Text}', sexo = '{Sexo.Text}', DataDeNascimento = '{Data.Text}', CPF = '{CPF.Text}', Telefone = '{Telefonee.Text}', Email = '{emailText.Text}', PorcentagemdeComissao={c}, DadosBancários='{Conta.Text}' where idColaborador = {idpesquisado}; ");
                        stmt.AlterarCliente($"update endereco set CEP = '{CEP.Text}', Logradouro = '{Logradouro.Text}', Cidade = '{Cidade.Text}', UF = '{UF.Text}', Complemento= '{Complemento.Text}', Bairro= '{Bairro.Text}', Numero= '{Numero.Text}' where idEndereco= {enderecoPesquisado}; ");
                        MessageBox.Show("Dados Cadastrado com sucesso");
                        Bloquear();
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {

                    stmt.desconectar();

  
                }
            
            
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                ConexaoDAO stmt = new ConexaoDAO();
                try
                {
                    stmt.conectar();
                    stmt.AlterarCliente($"delete from Colaborador where idColaborador = {idpesquisado}; ");
                    stmt.AlterarCliente($"delete from Endereco where idEndereco = {enderecoPesquisado}");
                    this.Text = "Consultar Colaborador";
                }
                catch
                {
                    MessageBox.Show("Falha ao conectar com o banco de dados");
                }
                finally
                {
                    stmt.desconectar();
                    idpesquisado = 0;
                    enderecoPesquisado = 0;
                    Bloquear();
                    Limpar();
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
    }
}
