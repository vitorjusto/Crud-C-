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
            // TODO: esta linha de código carrega dados na tabela 'cOLABORADOR.Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            this.colaboradorTableAdapter.Fill(this.cOLABORADOR.Colaborador);
            // TODO: esta linha de código carrega dados na tabela 'cliente._cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.cliente._cliente);
            // TODO: esta linha de código carrega dados na tabela 'crudDataSetEndereco.Endereco'. Você pode movê-la ou removê-la conforme necessário.
            this.enderecoTableAdapter.Fill(this.crudDataSetEndereco.Endereco);
            // TODO: esta linha de código carrega dados na tabela 'crudDataSet.Colaborador'. Você pode movê-la ou removê-la conforme necessário.
            // TODO: esta linha de código carrega dados na tabela 'crudDataSetCliente.cliente'. Você pode movê-la ou removê-la conforme necessário.

            this.BackColor = Global.BackgroundColor;
            dataGridView1.BackgroundColor = Global.BackgroundColor;
            GridListar.BackgroundColor = Global.BackgroundColor;
            menuStrip1.ForeColor = Global.FontColor;
            label1.ForeColor = Global.FontColor;
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
            GridListar.DataSource = clienteBindingSource8;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridListar.DataSource = colaboradorBindingSource5;
            
        }

        private void colaboradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultarColaborador().Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ConsultarCliente().Show();
        }

        private void opçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Opcoes().Show();
        }
    }
}
