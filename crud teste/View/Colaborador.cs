using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace crud_teste_View
{
    public partial class Colaborador : Form
    {
        public Colaborador()
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
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.conectar();

           
            try
            {
                var idEndereco = stmt.GravarEndereco($"insert into Endereco OUTPUT INSERTED.idEndereco Values('{CEP.Text}', '{Logradouro.Text}', '{Cidade.Text}', '{UF.Text}', '{Complemento.Text}', '{Bairro.Text}', {Numero.Text});");
                var data = ConverterData(Data.Text);


                var idColaborador = stmt.GravarColaborador($"insert into Colaborador OUTPUT INSERTED.idColaborador  Values('{Nome.Text}', '{Sobrenome.Text}', '{Sexo.Text}', '{data}', {Salario.Text}, {Porcentagem.Text}, '{CPF.Text}', '{Dados.Text}', '{Email.Text}', '{Telefone.Text}', '{Celular2.Text}', {idEndereco});");
                MessageBox.Show($"Dados Cadastrados com sucesso\nid = {idColaborador}");
                this.Close();
                new LColaboradores().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos inválidos ou incompletos", "Atenção");
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
    }
}
