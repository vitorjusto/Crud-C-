using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CRUD_teste.Model;
using crud_teste.vieew;
using crud_teste.vieew.ListaDePedidos;

namespace crud_teste
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            menuStrip1.ForeColor = Global.FontColor;
            menuStrip1.BackColor = Global.Strip;
        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmColaborador().Show();
           
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmCliente().Show();

        }

       

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Opcoes().Show();
        }

        private void colaboradoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListarColaboradores().Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListarCliente().Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FrmProduto().Show();

        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListarProduto().Show();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            new ListagemDePedidos().Show();
        }

        private void novoPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CadastroDePedidos().Show();
        }
    }
}
