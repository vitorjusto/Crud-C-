using crud_teste.vieew;
using crud_teste.vieew.ListaDePedidos;
using System;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.Configuration;
using System.Net;
using System.Windows.Forms;

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
            Global.AtribuirTema(this);
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Global.AlterarTema(checkBox1.Checked);
            Global.AtribuirTema(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
