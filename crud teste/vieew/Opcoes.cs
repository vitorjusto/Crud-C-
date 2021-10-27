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
    public partial class Opcoes : Form
    {
        public Opcoes()
        {
            
            InitializeComponent();
            if (Global.BackgroundColor == Color.FromArgb(38, 38, 38))
            {
                Tema.Checked = true;
            }
        }

        private void paginaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            this.Close();
            new LColaboradores().Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            try
            {
                if ((int)MessageBox.Show("Deseja mesmo excluir todo o banco de dados permanentemente", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {
                    stmt.conectar();
                    stmt.AlterarCliente($"delete from Cliente;");
                    stmt.AlterarCliente($"delete from Colaborador;");
                    stmt.AlterarCliente($"delete from Endereco;");


                    MessageBox.Show("Dados excluidos com sucesso!!");
                }
            }
            catch
            {

                MessageBox.Show("Falha ao conectar com bancos de dados");
            }
            finally
            {
                stmt.desconectar();

            }
        }

            

        private void Opcoes_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            Tema.ForeColor = Global.FontColor;
        }

        private void Tema_CheckedChanged(object sender, EventArgs e)
        {
            
                if (Tema.Checked)
                {
                    Global.BackgroundColor = Color.FromArgb(38, 38, 38);
                    Global.FontColor = Color.White;
                    Global.Strip = Color.FromArgb(64, 64, 64);

                    
                }else
                {
                Global.BackgroundColor = Color.AliceBlue;
                Global.FontColor = Color.Black;
                Global.Strip = Color.LightBlue;
                 }
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            Tema.ForeColor = Global.FontColor;

        }
    }
}

