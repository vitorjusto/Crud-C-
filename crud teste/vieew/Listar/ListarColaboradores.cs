using System;
using System.Collections.Generic;
using System.Windows.Forms;
using crud_teste.controller;
using crud_teste.Model;

namespace crud_teste.vieew
{
    public partial class ListarColaboradores : Form
    {
        List<ColaboradorListagem> listagem = new List<ColaboradorListagem>();
        public ListarColaboradores()
        {

            InitializeComponent();
            AlterarColaborador oAlterar = new AlterarColaborador();
            listagem =  oAlterar.ListarColaboradores();

            var index = 0;
            foreach(var colaborador in listagem)
            {
                dataGridColaboradores.Rows.Add();

                dataGridColaboradores.Rows[index].Cells[0].Value = colaborador.idColaborador;
                dataGridColaboradores.Rows[index].Cells[1].Value = colaborador.NomeCompleto;
                dataGridColaboradores.Rows[index].Cells[2].Value = colaborador.sexo;
                dataGridColaboradores.Rows[index].Cells[3].Value = colaborador.DataDeNascimento;
                dataGridColaboradores.Rows[index].Cells[4].Value = colaborador.Endereço;
                dataGridColaboradores.Rows[index].Cells[5].Value = colaborador.Contato;

                index++;

            }


            dataGridColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridColaboradores.AllowUserToAddRows = false;

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
            consultar(x)


        }

        private void consultar(int id)
        {
            new ConsultarColaborador(id).Show();
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

        private void dataGridColaboradores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                consultar(int.Parse(dataGridColaboradores.Rows[e.RowIndex].Cells[0].Value.ToString()))
            }else if(e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();
                    try
                    {
                        oColaborador.Excluir(int.Parse(dataGridColaboradores.Rows[e.RowIndex].Cells[0].Value.ToString()));
                        this.Text = "Consultar Colaborador";
                        MessageBox.Show("Dados excluidos com sucesso");
                        new ListarColaboradores().Show();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {


                    }

                }
            }
        }
    }
}
