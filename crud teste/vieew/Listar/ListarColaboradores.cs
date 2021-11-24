using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using crud_teste;
using System.Windows.Forms;
using crud_teste.controller;
namespace crud_teste.vieew
{
    public partial class ListarColaboradores : Form
    {
        public ListarColaboradores()
        {

            InitializeComponent();
            AlterarColaborador oAlterar = new AlterarColaborador();
            dataGridColaboradores.DataSource =  oAlterar.ListarColaboradores();

            dataGridColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListarColaboradores_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            dataGridColaboradores.BackgroundColor = Global.BackgroundColor;

            label.ForeColor = Global.FontColor;

            textBoxinstrucao.BackColor = Global.BackgroundColor;
            textBoxinstrucao.ForeColor = Global.FontColor;
        }

        

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
            this.Close();
        }

        

       

        private void dataGridColaboradores_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var x = int.Parse(dataGridColaboradores.Rows[e.RowIndex].Cells[0].Value.ToString());

            new ConsultarColaborador(x).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarColaborador oAlterar = new AlterarColaborador();
            int.TryParse(CampoDePesquisa.Text, out int id);
            if (id > 0)
                dataGridColaboradores.DataSource = oAlterar.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "id");
            else
                dataGridColaboradores.DataSource = oAlterar.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "Nome");
        }

       
    }
}
