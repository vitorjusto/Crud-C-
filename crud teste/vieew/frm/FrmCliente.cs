using System;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.Validation;
using System.Linq;
using crud_teste.Model.Object_Values;
using Tema;

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

            int.TryParse(Numero.Text, out int i);
            cliente.endereco.Numero = i;

            return cliente;

        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)=>
            e.Handled = Global.isNotIntChar(e.KeyChar);


        private void ValorLimite_KeyPress(object sender, KeyPressEventArgs e)=>
            e.Handled = Global.isNotFloatText(e.KeyChar, ValorLimite.Text);

        private void ValorLimite_Leave(object sender, EventArgs e) =>
            ValorLimite.Text = MyDinheiro.SetTextBoxAsMoneyValue(ValorLimite.Text);


        private void Sexo_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = true;

        private void UF_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

    }

}

