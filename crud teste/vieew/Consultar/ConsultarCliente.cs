using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CRUD_teste.Model;
using crud_teste.controller;
using crud_teste.vieew;
using crud_teste.Validation;
using System.Linq;

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
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




                    if (MessageBox.Show("Deseja Alterar esses dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        AlterarCliente oAlterar = new AlterarCliente();
                        oAlterar.SalvarCliente(clienteglobal);
                        MessageBox.Show("Dados Salvos com sucesso");
                        new ListarCliente().Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha ao conectar com o bancos de dados" + ex.Message);
                }
                
            }
            else
            {
                
                MessageBox.Show(validateres.Errors.FirstOrDefault().ToString(), "Atenção");
            }

        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ConexaoDAO stmt = new ConexaoDAO();
                try
                {
                    AlterarCliente oAlterar = new AlterarCliente();
                    oAlterar.excluir(clienteglobal);
                    clienteglobal = null;
                    new ListarCliente().Show();
                    this.Close();
                }
                catch
                {

                    MessageBox.Show("Falha ao conectar com bancos de dados");
                }
                finally
                {
                    
                }
            }
            
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
        public Cliente SalvarCampos()
        {

            clienteglobal.Nome = Nome.Text;
            clienteglobal.SobreNome = Sobrenome.Text;
            clienteglobal.Sexo = Sexo.Text;
            clienteglobal.CPF = CPF.Text;
            clienteglobal.contato.Telefone = Telefone.Text;
            clienteglobal.contato.Email = Email.Text;
            clienteglobal.DataDeNascimento = data.Value;
            clienteglobal.LimiteDeCompra = ValorLimite.Value;


            clienteglobal.contato.Celular = Celular.Text;

            clienteglobal.contato.Celular.DDI = DDI.Text;

            clienteglobal.endereco.Cep = CEP.Text;
            clienteglobal.endereco.Logradouro = Logradouro.Text;
            clienteglobal.endereco.Cidade = Cidade.Text;
            clienteglobal.endereco.UF = UF.Text;
            clienteglobal.endereco.Complemento = Complemento.Text;
            clienteglobal.endereco.Bairro = Bairro.Text;
            clienteglobal.endereco.Numero = int.Parse(Numero.Text);




            return clienteglobal;


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


