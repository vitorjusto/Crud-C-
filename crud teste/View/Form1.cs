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


namespace crud_teste
{
    public partial class LColaboradores : Form
    {
        public LColaboradores()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'crudDataSetEndereco.Endereco'. Você pode movê-la ou removê-la conforme necessário.
            this.enderecoTableAdapter.Fill(this.crudDataSetEndereco.Endereco);
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet.Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.crudDataSet.Colaborador);
            // TODO: esta linha de código carrega dados na tabela 'crudDataSetCliente.cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.crudDataSetCliente.cliente);



        }

        private void colaboradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Colaborador().Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Cliente().Show();

        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            GridListar.DataSource = clienteBindingSource7;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridListar.DataSource = colaboradorBindingSource4;
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultarColaborador().Show();
        }
    }
}
