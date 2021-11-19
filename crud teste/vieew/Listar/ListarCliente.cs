using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using crud_teste.controller;
using System.Windows.Forms;
using crud_teste.Model;

namespace crud_teste.vieew
{
    public partial class ListarCliente : Form
    {
        public List<ClienteListagem> clientes = new List<ClienteListagem>();
        public ListarCliente()
        {
            InitializeComponent();
            AlterarCliente oAlterar = new AlterarCliente();

            clientes = oAlterar.ListarCliente();
            var index = 0;
            foreach(var cliente in clientes )
            {
                dataGridCliente.Rows.Add();

                dataGridCliente.Rows[index].Cells[0].Value = cliente.idcliente;
                dataGridCliente.Rows[index].Cells[1].Value = cliente.nomecompleto;
                dataGridCliente.Rows[index].Cells[2].Value = cliente.Sexo;
                dataGridCliente.Rows[index].Cells[3].Value = cliente.DataDeNascimento;
                dataGridCliente.Rows[index].Cells[4].Value = cliente.Endereço;
                dataGridCliente.Rows[index].Cells[5].Value = cliente.Contato;

                index++;
            }
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            dataGridCliente.BackgroundColor = Global.BackgroundColor;


            textBoxinstrucao.BackColor = Global.BackgroundColor;
            textBoxinstrucao.ForeColor = Global.FontColor;
        }

       

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
            this.Close();
        }

        private void dataGridCliente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            
            var x = int.Parse(dataGridCliente.Rows[e.RowIndex].Cells[0].Value.ToString());

            Consultar(x);

                
            
            
        }


        private void Consultar(int index)
        {
            new ConsultarCliente(index).Show();
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            AlterarCliente oAlterar = new AlterarCliente();

            int.TryParse(CampoDePesquisa.Text, out int id);
            if (id > 0)
            {
                dataGridCliente.DataSource = oAlterar.ListarCliente(CampoDePesquisa.Text, "id");
            }
            else
            {
                dataGridCliente.DataSource = oAlterar.ListarCliente(CampoDePesquisa.Text, "nome");
            }


        }

        private void dataGridCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                Consultar(int.Parse(dataGridCliente.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }else if(e.ColumnIndex == 7)
            {
                if(MessageBox.Show($"Deseja mesmo Excluir o {clientes[e.RowIndex].nomecompleto}?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlterarCliente oAlterar = new AlterarCliente();
                    oAlterar.excluir(clientes[e.RowIndex].idcliente);
                }
            }
        }
    }
}
