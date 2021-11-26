using crud_teste.controller;
using crud_teste.Model.Listagem;
using crud_teste.vieew.Consultar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class ListarProduto : Form
    {
        public List<ProdutoListagem> produtos = new List<ProdutoListagem>();

        public ListarProduto()
        {
            InitializeComponent();
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;
            dataGridProduto.BackgroundColor = Global.BackgroundColor;
            BuscarAtivo.ForeColor = Global.FontColor;
            textBoxinstrucao.BackColor = Global.BackgroundColor;

            AlterarProduto oAlterar = new AlterarProduto();
            produtos = oAlterar.Listar();
            preencherDataGrid(BuscarAtivo.Checked);
        }

        public void preencherDataGrid(bool comAtivo)
        {
            DataGridViewCellStyle colaboradorinativo = new DataGridViewCellStyle();
            colaboradorinativo.BackColor = Color.SlateGray;
            colaboradorinativo.ForeColor = Color.White;

            dataGridProduto.Rows.Clear();
            var i = 0;
            foreach (var produto in produtos)
            {
                dataGridProduto.Rows.Add();
                dataGridProduto.Rows[i].Cells[0].Value = produto.IdProduto;
                dataGridProduto.Rows[i].Cells[1].Value = produto.nomeProduto;
                dataGridProduto.Rows[i].Cells[2].Value = produto.PrecodeVenda;
                dataGridProduto.Rows[i].Cells[3].Value = produto.Estoque;
                dataGridProduto.Rows[i].Cells[4].Value = produto.fabricante;

                if (comAtivo && !produto.Ativo)
                {
                    var j = 0;
                    while (j < 5)
                    {

                        dataGridProduto.Rows[i].Cells[j].Style = colaboradorinativo;
                        j++;
                    }
                    dataGridProduto.Rows[i].Cells[6].Value = "Ativar";
                }
                else if (!comAtivo && !produto.Ativo)
                    dataGridProduto.Rows[i].Visible = false;
                else
                    dataGridProduto.Rows[i].Cells[6].Value = "Inativar";

                i++;
            }
            dataGridProduto.AllowUserToAddRows = false;
            dataGridProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarProduto oAlterar = new AlterarProduto();


            int.TryParse(CampoDePesquisa.Text, out int id);

            if (CampoDePesquisa.Text == "")
            {
                produtos = oAlterar.Listar();
                preencherDataGrid(BuscarAtivo.Checked);
            }
            else if (id == 0)
            {
                produtos = oAlterar.Listar(CampoDePesquisa.Text, "nome");
                preencherDataGrid(BuscarAtivo.Checked);
            }
            else
            {
                produtos = oAlterar.Listar(CampoDePesquisa.Text, "id");
                preencherDataGrid(BuscarAtivo.Checked);
            }
        }

        private void dataGridProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var x = int.Parse(dataGridProduto.Rows[e.RowIndex].Cells[0].Value.ToString());

            new ConsultarProduto(x).Show();
            this.Close();
        }

        private void BuscarAtivo_CheckedChanged(object sender, EventArgs e) => preencherDataGrid(BuscarAtivo.Checked);

        private void dataGridProduto_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == -1)
                return;

            if (e.ColumnIndex == 5)
            {
                var x = int.Parse(dataGridProduto.Rows[e.RowIndex].Cells[0].Value.ToString());

                new ConsultarProduto(x).Show();
                this.Close();
            }
            else if (e.ColumnIndex == 6)
            {
                var mensagem = produtos[e.RowIndex].Ativo ? $"Deseja Mesmo Inativar o {produtos[e.RowIndex].nomeProduto}" : $"Deseja Mesmo Reativar o {produtos[e.RowIndex].nomeProduto}";

                if (MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    AlterarProduto oAlterar = new AlterarProduto();
                    try
                    {
                        oAlterar.AlterarAtivo(produtos[e.RowIndex]);

                        produtos[e.RowIndex].Ativo = !produtos[e.RowIndex].Ativo;


                        preencherDataGrid(BuscarAtivo.Checked);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
