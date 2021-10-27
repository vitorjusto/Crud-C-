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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina principal?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new LColaboradores().Show();
            }

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

           


            
           ConexaoDAO stmt = new ConexaoDAO();

              stmt.conectar();


                try
                {
                    if(Nome.Text.Length == 0)
                    {
                        throw new Exception("O campo nome é obrigatorio!");
                    }
                    if(Sexo.Text.Length == 0)
                    {
                        throw new Exception("O campo sexo é obrigatório");
                    }
                    if(CPF.Text.Length != 14)
                    {
                        throw new Exception("Digite um CPF valido!");
                    }
                    if (CEP.Text.Length != 9)
                    {
                        throw new Exception("Digite um CEP valido!");
                    }
                    
                    if(UF.Text.Length == 0)
                    {
                        throw new Exception("O campo UF é Obrigatório");
                    }

                    if(Cidade.Text.Length == 0)
                    {
                        throw new Exception("O Campo cidade é obrigatório");
                    }
                    if(Bairro.Text.Length == 0)
                    {
                        throw new Exception("O campo bairro é obrigatório");
                    }
                    if(Logradouro.Text.Length == 0)
                    {
                        throw new Exception("O campo Logradouro é obrigatório");
                    }
                    
                    uint.TryParse(Numero.Text, out uint a);
                    if (a == 0)
                    {
                        throw new Exception("Digite um numero de casa válido!");
                    }

                    if(!((Telefone.Text.Length == 11) || (Celular2.Text.Length == 16) || (Email.Text.Length != 0)) )
                    {
                        throw new Exception("Escreva apenas um campo de contato");
                    }

                if ((int)MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {
                    var idEndereco = stmt.GravarEndereco($"insert into Endereco OUTPUT INSERTED.idEndereco Values('{CEP.Text}', '{Logradouro.Text}', '{Cidade.Text}', '{UF.Text}', '{Complemento.Text}', '{Bairro.Text}', {Numero.Text});");

                    decimal.TryParse(ValorLimite.Text, out decimal b);

                    var idColaborador = stmt.GravarColaborador($"insert into cliente OUTPUT INSERTED.idCliente Values('{Nome.Text}', '{Sobrenome.Text}', '{Sexo.Text}', '{CPF.Text}',{b}, '{Telefone.Text}', '{Celular1.Text} {Celular2.Text}','{Email.Text}', {idEndereco}, '{data.Value.ToString().Remove(10)}');");
                    MessageBox.Show($"Dados Cadastrados com sucesso\nid = {idColaborador}");
                    this.Close();
                    new LColaboradores().Show();
                }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Atenção");
                }
                finally
                {
                    stmt.desconectar();

                }
            }

        private void FrmCliente_Load(object sender, EventArgs e)
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

        }
    }

        
     
    }

