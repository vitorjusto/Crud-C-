using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Validation;
using crud_teste.vieew;
using CRUD_teste.Model;
using System;
using System.Linq;
using System.Windows.Forms;
using Tema;

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
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
                this.Close();
                new ListarColaboradores().Show();
            }

        }

        private void AtribuirCampos(Colaborador colaborador)
        {
            Nome.Text = colaborador.Nome.ToString();
            Sobrenome.Text = colaborador.SobreNome;
            Sexo.Text = colaborador.Sexo;
            CPF.Text = colaborador.CPF.RetornarFormatado();
            Salario.Text = colaborador.Salario.ToString();
            Porcentagem.Text = colaborador.PorcentagemDeComissao.ToString();
            Telefone.Text = colaborador.contato.Telefone.ToString();
            Celular2.Text = colaborador.contato.Celular.Celular;
            DDI.Text = colaborador.contato.Celular.DDI;
            emailText.Text = colaborador.contato.Email;
            Data.Value = colaborador.DataDeNascimento;
            txtcomissao.Text = colaborador.comissao.GetAsString();
            txtAtivo.Text = colaboradorGlobal.Ativo ? "Ativo" : "Não Ativo";
            Excluir.Text = colaboradorGlobal.Ativo ? "Desativar" : "Ativar";
            AtribuirCamposEnderecos(colaborador.endereco);
            Banco.Text = colaborador.DadosBancarios.Banco;
            Agencia.Text = colaborador.DadosBancarios.Agencia.ToString() ;
            Conta.Text = colaborador.DadosBancarios.Conta.ToString();
            Digito.Text = colaborador.DadosBancarios.Digito.ToString();
        }

        private void AtribuirCamposEnderecos(Endereco endereco)
        {
            CEP.Text = endereco.Cep.RetornarFormatado();
            Logradouro.Text = endereco.Logradouro;
            Cidade.Text = endereco.Cidade;
            UF.Text = endereco.UF;
            Complemento.Text = endereco.Complemento;
            Bairro.Text = endereco.Bairro;
            Numero.Text = endereco.Numero.ToString();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal?"))
            {
                this.Close();
                new ListarColaboradores().Show();
            }
        }

        private void BotaoSalvar_Click_1(object sender, EventArgs e)
        {
            preencherCampos();
            ConexaoDAO stmt = new ConexaoDAO();
            ColaboradorValidator validator = new ColaboradorValidator();
            var validadores = validator.Validate(colaboradorGlobal);

            if (validadores.IsValid)
            {
                try
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();

                    if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo alterar os dados?"))
                    {
                        oColaborador.SalvarColaborador(colaboradorGlobal);
                        new CaixaDeInformacao().MensagemDeOk("Dados salvos com sucesso !!");
                        new ListarColaboradores().Show();
                        this.Close();
                    }
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }
                
            }
            else
            {
                new CaixaDeAviso().MensagemDeOk(validadores.Errors.FirstOrDefault().ToString());
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            colaboradorGlobal.Ativo = !colaboradorGlobal.Ativo;


            txtAtivo.Text = colaboradorGlobal.Ativo ? "Ativo" : "Não Ativo";
            Excluir.Text = colaboradorGlobal.Ativo ? "Desativar" : "Ativar";
        }

        private void ConsultarColaborador_Load(object sender, EventArgs e) =>
            Temas.AtribuirTema(this);


        public void preencherCampos()
        {

            colaboradorGlobal.Nome = Nome.Text;
            colaboradorGlobal.SobreNome = Sobrenome.Text;
            colaboradorGlobal.Sexo = Sexo.Text;

            colaboradorGlobal.Salario = Salario.Text;
            colaboradorGlobal.DataDeNascimento = Data.Value;
            colaboradorGlobal.CPF = CPF.Text;
            colaboradorGlobal.contato.Email = emailText.Text;
            colaboradorGlobal.contato.Telefone = Telefone.Text;
            colaboradorGlobal.contato.Celular = Celular2.Text;
            colaboradorGlobal.contato.Celular.DDI = DDI.Text;
            colaboradorGlobal.endereco.Cep = CEP.Text;
            colaboradorGlobal.endereco.Logradouro = Logradouro.Text;
            colaboradorGlobal.endereco.Cidade = Cidade.Text;
            colaboradorGlobal.endereco.UF = UF.Text;
            colaboradorGlobal.endereco.Complemento = Complemento.Text;
            colaboradorGlobal.endereco.Bairro = Bairro.Text;
            colaboradorGlobal.endereco.Numero = Numero.Text;
            colaboradorGlobal.DadosBancarios.Banco = Banco.Text;
            colaboradorGlobal.DadosBancarios.Agencia = int.Parse(Agencia.Text == "" ? "0": Agencia.Text);
            colaboradorGlobal.DadosBancarios.Conta = int.Parse(Conta.Text == "" ? "0" : Conta.Text);
            colaboradorGlobal.DadosBancarios.Digito = int.Parse(Digito.Text == "" ? "0" : Digito.Text);
        }

        private void Agencia_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, Agencia.Text);

        private void Conta_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, Conta.Text);

        private void Digito_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, Digito.Text);

        private void Salario_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, Digito.Text);
    }

   
}
