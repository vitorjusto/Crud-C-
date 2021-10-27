using System;
using CRUD_teste.Model;
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
            var cadastrado = false;
            Colaborador colaborador = new Colaborador();

            colaborador = preencherCampos();
            try
            {

                if (!colaborador.ValidarColaborador())
                {
                    throw new Exception("Valide os dados");
                }


                if ((int)MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {
                    var idEndereco = stmt.GravarEndereco($"insert into Endereco OUTPUT INSERTED.idEndereco Values('{colaborador.endereco.Cep}', '{colaborador.endereco.Logradouro}', '{colaborador.endereco.Cidade}', '{colaborador.endereco.UF}', '{colaborador.endereco.Complemento}', '{colaborador.endereco.Bairro}', {colaborador.endereco.Numero});");
                    var idColaborador = stmt.GravarColaborador($"insert into Colaborador OUTPUT INSERTED.idColaborador  Values('{colaborador.Nome}', '{colaborador.SobreNome}', '{colaborador.Sexo}',  {colaborador.Salario}, {colaborador.PorcentagemDeComissao}, '{colaborador.CPF}', '{colaborador.DadosBancarios}', '{colaborador.contato.Email}', '{colaborador.contato.Telefone}', '{colaborador.contato.DDI} {colaborador.contato.Celular}', {idEndereco}, '{colaborador.DataDeNascimento}');");
                    MessageBox.Show($"Dados Cadastrados com sucesso\nid = {idColaborador}");
                    cadastrado = true;

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

            if (cadastrado)
            {
                this.Close();
                new LColaboradores().Show();
            }
        }

        public string ConverterData(string Data)
        {
            return $"{Data[6]}{Data[7]}{Data[8]}{Data[9]}-{Data[0]}{Data[1]}-{Data[3]}{Data[4]}";
        }

        public Colaborador preencherCampos()
        {
            Colaborador colaborador = new Colaborador();




            colaborador.Nome = Nome.Text;
            colaborador.SobreNome = Sobrenome.Text;
            colaborador.Sexo = Sexo.Text;
            colaborador.Salario = Salario.Value;
            colaborador.DataDeNascimento = Data.ToString().Remove(10);
            colaborador.CPF = CPF.Text;
            colaborador.DadosBancarios = Dados.Text;
            colaborador.contato.Email = Email.Text;
            colaborador.contato.Telefone = Telefone.Text;
            colaborador.contato.DDI = Celular1.Text;
            colaborador.contato.Celular = Celular2.Text;
            
            colaborador.PorcentagemDeComissao = Porcentagem.Value;


           

            colaborador.endereco.Cep = CEP.Text;
            colaborador.endereco.Logradouro = Logradouro.Text;
            colaborador.endereco.Cidade = Cidade.Text;
            colaborador.endereco.UF = UF.Text;
            colaborador.endereco.Complemento = Complemento.Text;
            colaborador.endereco.Bairro = Bairro.Text; 
            int.TryParse(Numero.Text, out int i);

            colaborador.endereco.Numero = i;



            return colaborador;


        }

       
    }
}
