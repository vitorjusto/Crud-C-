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
                if (MessageBox.Show("Deseja mesmo excluir todos os dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
            Global.AtribuirTema(this);
        }

       

        
    }
}

