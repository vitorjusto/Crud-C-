using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.vieew;

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
                MessageBox.Show("Id inválida");

            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new ListarCliente().Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
           
           
        }

        public void AtribuirCamposClientes(Cliente cliente)
        {
            Nome.Text = cliente.Nome;
            Sobrenome.Text = cliente.SobreNome;
            Sexo.Text = cliente.Sexo;
            ValorLimite.Text = cliente.LimiteDeCompra.ToString();
            CPF.Text = cliente.CPF;
            Telefone.Text = cliente.contato.Telefone;
            Celular2.Text = cliente.contato.Celular;
            Celular1.Text = cliente.contato.DDI;
            Email.Text = cliente.contato.Email;
            data.Text = cliente.DataDeNascimento;
            CEP.Text = cliente.endereco.Cep;
            Logradouro.Text = cliente.endereco.Logradouro;
            Cidade.Text = cliente.endereco.Cidade;
            UF.Text = cliente.endereco.UF;
            Complemento.Text = cliente.endereco.Complemento;
            Bairro.Text = cliente.endereco.Bairro;
            Numero.Text = cliente.endereco.Numero.ToString();

        }

       

        public void button2_Click(object sender, EventArgs e)
        {
            if (clienteglobal.idCliente != 0)
            {
                Nome.Enabled = true;
                Sobrenome.Enabled = true;
                Sexo.Enabled = true;
                data.Enabled = true;
                ValorLimite.Enabled = true;
                CPF.Enabled = true;
                Telefone.Enabled = true;
                Celular2.Enabled = true;
                Email.Enabled = true;
                CEP.Enabled = true;
                Logradouro.Enabled = true;
                Cidade.Enabled = true;
                UF.Enabled = true;
                Numero.Enabled = true;
                Bairro.Enabled = true;
                Complemento.Enabled = true;
                BotaoSalvar.Enabled = true;
                Excluir.Enabled = true;
            }

        }

        public void Bloquear()
        {
            Nome.Enabled = false;
            Sobrenome.Enabled = false;
            Sexo.Enabled = false;
            data.Enabled = false;
            ValorLimite.Enabled = false;
            CPF.Enabled = false;
            Telefone.Enabled = false;
            Celular2.Enabled = false;
            Email.Enabled = false;
            CEP.Enabled = false;
            Logradouro.Enabled = false;
            Cidade.Enabled = false;
            UF.Enabled = false;
            Numero.Enabled = false;
            Bairro.Enabled = false;
            Complemento.Enabled = false;
            BotaoSalvar.Enabled = false;

            Excluir.Enabled = false;
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {

            SalvarCampos();

            List<string> validacoes = clienteglobal.ValidarCliente();

            if (validacoes.Count == 0)
            {
                try
                {




                    if ((int)MessageBox.Show("Deseja Alterar esses dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {

                        AlterarCliente oAlterar = new AlterarCliente();
                        oAlterar.SalvarCliente(clienteglobal);
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
                ConexaoDAO stmt = new ConexaoDAO();
                try
                {
                    AlterarCliente oAlterar = new AlterarCliente();
                    oAlterar.excluir(clienteglobal);

                    this.Text = "Consultar Cliente";
                }
                catch
                {

                    MessageBox.Show("Falha ao conectar com bancos de dados");
                }
                finally
                {
                    clienteglobal = null;
                    Bloquear();
                    Limpar();
                }
            }
            
        }

            public void Limpar()
            {
                Nome.Text = "";
                Sobrenome.Text = "";
                Sexo.Text = "";
                CPF.Text = "";
                Telefone.Text = "";
                Celular2.Text = "";
                Email.Text = "";
                CEP.Text = "";
                Logradouro.Text = "";
                Cidade.Text = "";
                UF.Text = "";
                Numero.Text = "";
                Bairro.Text = "";
                Complemento.Text = "";
                ValorLimite.Text = "";

            }

        private void ConsultarCliente_Load(object sender, EventArgs e)
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
        public void SalvarCampos()
        {

            clienteglobal.Nome = Nome.Text;
            clienteglobal.SobreNome = Sobrenome.Text;
            clienteglobal.Sexo = Sexo.Text;
            clienteglobal.CPF = CPF.Text;
            clienteglobal.contato.Telefone = Telefone.Text;
            clienteglobal.contato.DDI = Celular1.Text;
            clienteglobal.contato.Celular = Celular2.Text;
            clienteglobal.contato.Email = Email.Text;
            clienteglobal.DataDeNascimento = data.Value.ToString().Remove(10);
            clienteglobal.LimiteDeCompra = ValorLimite.Value;

            clienteglobal.endereco.Cep = CEP.Text;
            clienteglobal.endereco.Logradouro = Logradouro.Text;
            clienteglobal.endereco.Cidade = Cidade.Text;
            clienteglobal.endereco.UF = UF.Text;
            clienteglobal.endereco.Complemento = Complemento.Text;
            clienteglobal.endereco.Bairro = Bairro.Text;
            clienteglobal.endereco.Numero = int.Parse(Numero.Text);







        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e)
        {
 
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsPunctuation(e.KeyChar))
            {
                
                e.Handled = true;

            }
        }

        private void Numero_TextChanged(object sender, EventArgs e)
        {

        }
    }
      
        
}


