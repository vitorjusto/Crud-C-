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
    public partial class FrmColaborador : Form
    {
        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if((int)MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new LColaboradores().Show();
            }
            
           
        }

        private void Colaborador_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            groupBox1.ForeColor = Global.FontColor;
            groupBox2.ForeColor = Global.FontColor;
            groupBox3.ForeColor = Global.FontColor;

            menuStrip2.ForeColor = Global.FontColor;
            label1.ForeColor = Global.FontColor;
            menuStrip2.BackColor = Global.Strip;
            menuStrip2.BackColor = Global.Strip;
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

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.conectar();

           
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
                if(c <= 0)
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

                if (!((Telefone.Text.Length == 11) || (Celular2.Text.Length == 16) || (Email.Text.Length != 0)))
                {
                    throw new Exception("Escreva apenas um campo de contato");
                }



                if ((int)MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {
                    var idEndereco = stmt.GravarEndereco($"insert into Endereco OUTPUT INSERTED.idEndereco Values('{CEP.Text}', '{Logradouro.Text}', '{Cidade.Text}', '{UF.Text}', '{Complemento.Text}', '{Bairro.Text}', {Numero.Text});");



                    var idColaborador = stmt.GravarColaborador($"insert into Colaborador OUTPUT INSERTED.idColaborador  Values('{Nome.Text}', '{Sobrenome.Text}', '{Sexo.Text}',  {Salario.Text}, {c}, '{CPF.Text}', '{Dados.Text}', '{Email.Text}', '{Telefone.Text}', '{Celular1.Text} {Celular2.Text}', {idEndereco}, '{Data.Value.ToString().Remove(10)}');");
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

        public string ConverterData(string Data)
        {
            return $"{Data[6]}{Data[7]}{Data[8]}{Data[9]}-{Data[0]}{Data[1]}-{Data[3]}{Data[4]}";
        }

        private void Cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Complemento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void UF_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Logradouro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CEP_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Numero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Celular1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Celular2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Dados_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
