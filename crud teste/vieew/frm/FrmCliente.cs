using System;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.Validation;
using System.Linq;
using crud_teste.Model.Object_Values;
using Tema;
using crud_teste.Config;
using crud_teste.Config.Mensagem;

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
            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal?"))
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
                if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo cadastrar os dados?"))
                {
                    try
                    {
                        AlterarCliente oAlterar = new AlterarCliente();
                        var id = oAlterar.conectarComDAO(cliente);

                        new CaixaDeInformacao().MensagemDeOk($"Dados cadastrados com sucesso !!!\n id = {id}");


                        new ListarClientes().Show();
                        this.Close();

                    }
                    catch
                    {
                        new CaixaDeErro().FalhaNoBancoDeDados();
                    }
                }
            }
            else
            {
                new CaixaDeAviso().MensagemDeOk(validateres.Errors.FirstOrDefault().ToString());
            }
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);

            ValorLimite.Text = MyDinheiro.SetTextBoxAsMoneyValue(ValorLimite.Text);

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
            cliente.LimiteDeCompra = ValorLimite.Text;
            cliente.endereco.Cep = CEP.Text;
            cliente.endereco.Logradouro = Logradouro.Text;
            cliente.endereco.Cidade = Cidade.Text;
            cliente.endereco.UF = UF.Text;
            cliente.endereco.Complemento = Complemento.Text;
            cliente.endereco.Bairro = Bairro.Text;


            cliente.endereco.Numero = Numero.Text;

            return cliente;

        }

        private void Sexo_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = true;

        private void UF_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    }

}

