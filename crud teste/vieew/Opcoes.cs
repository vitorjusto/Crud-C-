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
            new ListarClientes().Show();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            try
            {
                if ((int)MessageBox.Show("Deseja mesmo excluir todos os dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                {

                    stmt.ExcluirTudo();
                    MessageBox.Show("Dados excluidos com sucesso!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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

