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
            // TODO: esta linha de código carrega dados na tabela 'cOLABORADOR.Colaborador'. Você pode movê-la ou removê-la conforme necessário.
           
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet.Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'crudDataSetCliente.cliente'. Você pode movê-la ou removê-la conforme necessário.

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

        

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //new ConsultarColaborador().Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
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
    }
}
