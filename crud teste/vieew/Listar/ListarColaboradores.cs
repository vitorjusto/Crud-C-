using crud_teste.Config;
using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew
{
    public partial class ListarColaboradores : Form
    {
        List<ColaboradorListagem> listagem = new List<ColaboradorListagem>();
        public ListarColaboradores()
        {

            InitializeComponent();
            AlterarColaborador oAlterar = new AlterarColaborador();
        }
        public void listarNaGrid(bool comAtivo)
        {
            DataGridViewCellStyle colaboradorinativo = new DataGridViewCellStyle();
            colaboradorinativo.BackColor = Color.SlateGray;
            colaboradorinativo.ForeColor = Color.White;

            var index = 0;
            dataGridColaboradores.Rows.Clear();
            foreach (var colaborador in listagem)
            {
                dataGridColaboradores.Rows.Add();

                dataGridColaboradores.Rows[index].Cells[0].Value = colaborador.idColaborador;
                dataGridColaboradores.Rows[index].Cells[1].Value = colaborador.NomeCompleto;
                dataGridColaboradores.Rows[index].Cells[2].Value = colaborador.sexo;
                dataGridColaboradores.Rows[index].Cells[3].Value = colaborador.DataDeNascimento;
                dataGridColaboradores.Rows[index].Cells[4].Value = colaborador.Endereço;
                dataGridColaboradores.Rows[index].Cells[5].Value = colaborador.Contato;

                if (comAtivo && !colaborador.Ativo)
                {
                    var j = 0;
                    while (j < 6)
                    {

                        dataGridColaboradores.Rows[index].Cells[j].Style = colaboradorinativo;
                        j++;
                    }
                    dataGridColaboradores.Rows[index].Cells[7].Value = "Ativar";
                }
                else if (!comAtivo && !colaborador.Ativo)
                {
                    dataGridColaboradores.Rows[index].Visible = false;
                }
                else
                {
                    dataGridColaboradores.Rows[index].Cells[7].Value = "Inativar";
                }

                index++;

            }

            dataGridColaboradores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridColaboradores.AllowUserToAddRows = false;
        }

        private void ListarColaboradores_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
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
            consultar(x);

        }

        private void consultar(int id)
        {
            new ConsultarColaborador(id).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarColaborador oAlterar = new AlterarColaborador();
            try
            {


                int.TryParse(CampoDePesquisa.Text, out int id);
                if (id > 0)
                    listagem = oAlterar.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "id");
                else
                    listagem = oAlterar.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "Nome");

                listarNaGrid(cbAtivo.Checked);
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
            }
        }

        private void dataGridColaboradores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 6)
            {
                consultar(int.Parse(dataGridColaboradores.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
            else if (e.ColumnIndex == 7)
            {
                var mensagem = listagem[e.RowIndex].Ativo ? $"Deseja Mesmo Inativar o {listagem[e.RowIndex].NomeCompleto}" : $"Deseja Mesmo Reativar o {listagem[e.RowIndex].NomeCompleto}";

                if (new CaixaDeAviso().MensagemDeSimENao(mensagem))
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();
                    try
                    {
                        oColaborador.AlterarAtivo(listagem[e.RowIndex]);

                        listagem[e.RowIndex].Ativo = !listagem[e.RowIndex].Ativo;

                        listarNaGrid(cbAtivo.Checked);
                    }
                    catch
                    {
                        new CaixaDeErro().FalhaNoBancoDeDados();
                    }
                }
            }
        }

        private void cbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            listarNaGrid(cbAtivo.Checked);
        }
    }
}
