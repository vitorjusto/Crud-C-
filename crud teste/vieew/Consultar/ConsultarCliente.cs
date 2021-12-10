using System;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.vieew;
using crud_teste.Validation;
using System.Linq;
using crud_teste.Model.Object_Values;
using Tema;
using crud_teste.Config;
using crud_teste.Config.Mensagem;

namespace crud_teste
{
    public partial class ConsultarCliente : Form
    {
        private Cliente clienteglobal = new Cliente();
        public ConsultarCliente(int id)
        {
            InitializeComponent();
            try
            {

                AlterarCliente oAlterar = new AlterarCliente();

                clienteglobal.idCliente = id;

                clienteglobal = oAlterar.consultarCliente(clienteglobal.idCliente);

                AtribuirCamposClientes(clienteglobal);


                this.Text = "Consultando: " + clienteglobal.nomeCompleto();

            }
            catch 
            {
                new CaixaDeErro().FalhaNoBancoDeDados();

            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal ?"))
            {
                this.Close();
                new ListarCliente().Show();
            }
        }
        public void AtribuirCamposClientes(Cliente cliente)
        {
            Nome.Text = cliente.Nome;
            Sobrenome.Text = cliente.SobreNome;
            Sexo.Text = cliente.Sexo;
            ValorLimite.Text = cliente.LimiteDeCompra.ToString();
            CPF.Text = cliente.CPF.RetornarFormatado() ;
            Telefone.Text = cliente.contato.Telefone.ToString();
            Celular.Text = cliente.contato.Celular.Celular;
            DDI.Text = cliente.contato.Celular.DDI;
            Email.Text = cliente.contato.Email;
            data.Value = cliente.DataDeNascimento;
            CEP.Text = cliente.endereco.Cep.RetornarFormatado();
            Logradouro.Text = cliente.endereco.Logradouro;
            Cidade.Text = cliente.endereco.Cidade;
            UF.Text = cliente.endereco.UF;
            Complemento.Text = cliente.endereco.Complemento;
            Bairro.Text = cliente.endereco.Bairro;
            Numero.Text = cliente.endereco.Numero.ToString();

            txtLimiteRestante.Text = cliente.LimiteRestante.ToString();

            txtAtivo.Text = cliente.Ativo ? "Ativo" : "Não Ativo";
            Excluir.Text = cliente.Ativo ? "Desativar" : "Ativar";
        }
        private void BotaoSalvar_Click(object sender, EventArgs e)
        {

            clienteglobal = SalvarCampos();

            ClienteValidation validar = new ClienteValidation();

            var validateres = validar.Validate(clienteglobal);

            if (validateres.IsValid)
            {
                try
                {

                    if (new CaixaDePergunta().MensagemDeSimENao("Deseja alterar esses dados?"))
                    {

                        AlterarCliente oAlterar = new AlterarCliente();
                        oAlterar.SalvarCliente(clienteglobal);
                        new CaixaDeInformacao().MensagemDeOk("Dados salvos com sucesso !!");
                        new ListarCliente().Show();
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
                
                new CaixaDeAviso().MensagemDeOk(validateres.Errors.FirstOrDefault().ToString());
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            clienteglobal.Ativo = !clienteglobal.Ativo;


            txtAtivo.Text = clienteglobal.Ativo ? "Ativo" : "Não Ativo";
            Excluir.Text = clienteglobal.Ativo ? "Desativar" : "Ativar";

        }

        private void ConsultarCliente_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);



            ValorLimite.Text = MyDinheiro.SetTextBoxAsMoneyValue(ValorLimite.Text);
        }
        public Cliente SalvarCampos()
        {

            clienteglobal.Nome = Nome.Text;
            clienteglobal.SobreNome = Sobrenome.Text;
            clienteglobal.Sexo = Sexo.Text;
            clienteglobal.CPF = CPF.Text;
            clienteglobal.contato.Telefone = Telefone.Text;
            clienteglobal.contato.Email = Email.Text;
            clienteglobal.DataDeNascimento = data.Value;
            clienteglobal.LimiteDeCompra = ValorLimite.Text;


            clienteglobal.contato.Celular = Celular.Text;

            clienteglobal.contato.Celular.DDI = DDI.Text;

            clienteglobal.endereco.Cep = CEP.Text;
            clienteglobal.endereco.Logradouro = Logradouro.Text;
            clienteglobal.endereco.Cidade = Cidade.Text;
            clienteglobal.endereco.UF = UF.Text;
            clienteglobal.endereco.Complemento = Complemento.Text;
            clienteglobal.endereco.Bairro = Bairro.Text;
            clienteglobal.endereco.Numero = int.Parse(Numero.Text == "" ? "0" : Numero.Text);

            return clienteglobal;

        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e) =>
                e.Handled = Global.isNotIntChar(e.KeyChar);

        private void ValorLimite_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, ValorLimite.Text);

        private void ValorLimite_Leave(object sender, EventArgs e)
        {
            ValorLimite.Text = MyDinheiro.SetTextBoxAsMoneyValue(ValorLimite.Text);
            
        }

        private void ValorLimite_TextChanged(object sender, EventArgs e)
        {
            clienteglobal.LimiteDeCompra = ValorLimite.Text;
            clienteglobal.CalcularRestante();
            txtLimiteRestante.Text = clienteglobal.LimiteRestante.ToString();
        }
    }
      
        
}


