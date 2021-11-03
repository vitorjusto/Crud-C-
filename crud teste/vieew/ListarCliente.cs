using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using crud_teste.controller;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class ListarCliente : Form
    {
        public ListarCliente()
        {
            InitializeComponent();
            AlterarCliente oAlterar = new AlterarCliente();
            dataGridCliente.DataSource = oAlterar.ListarCliente();
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            dataGridCliente.BackgroundColor = Global.BackgroundColor;
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

            new ConsultarCliente(x).Show();
            this.Close();
        }

        private void CampoDePesquisa_TextChanged(object sender, EventArgs e)
        {
            AlterarCliente oAlterar = new AlterarCliente();


            int.TryParse(CampoDePesquisa.Text, out int id);
            if(id > 0)
                dataGridCliente.DataSource = oAlterar.ListarCliente(CampoDePesquisa.Text, "id");
            else

                dataGridCliente.DataSource = oAlterar.ListarCliente(CampoDePesquisa.Text, "nome");

        }
    }
}
