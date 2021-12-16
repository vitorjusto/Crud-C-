using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model.Listagem;
using crud_teste.vieew.Consultar;
using crud_teste.vieew.Listar.ListarProduto;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew
{
    public partial class ListarProduto : Form
    {
        public List<ProdutoListagem> produtos = new List<ProdutoListagem>();

        public ListarProduto()
        {
            InitializeComponent();
            Temas.AtribuirTema(this);

            AlterarProduto oAlterar = new AlterarProduto();
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
                    dataGridProduto.Rows[i].Cells[7].Value = "Ativar";
                }
                else if (!comAtivo && !produto.Ativo)
                    dataGridProduto.Rows[i].Visible = false;
                else
                    dataGridProduto.Rows[i].Cells[7].Value = "Inativar";

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

            try
            {
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
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
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
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 5)
            {
                var x = int.Parse(dataGridProduto.Rows[e.RowIndex].Cells[0].Value.ToString());

                new ConsultarProduto(x).Show();
                this.Close();
            }
            else if (e.ColumnIndex == 7)
            {
                var mensagem = produtos[e.RowIndex].Ativo ? $"Deseja Mesmo Inativar o {produtos[e.RowIndex].nomeProduto}" : $"Deseja Mesmo Reativar o {produtos[e.RowIndex].nomeProduto}";

                if (new CaixaDeAviso().MensagemDeSimENao(mensagem))
                {
                    AlterarProduto oAlterar = new AlterarProduto();
                    try
                    {
                        oAlterar.AlterarAtivo(produtos[e.RowIndex]);

                        produtos[e.RowIndex].Ativo = !produtos[e.RowIndex].Ativo;


                        preencherDataGrid(BuscarAtivo.Checked);
                    }
                    catch
                    {
                        new CaixaDeErro().FalhaNoBancoDeDados();
                    }
                }
            }
            else if (e.ColumnIndex == 6)
            {
                AlterarEstoque formAlterar = new AlterarEstoque(produtos[e.RowIndex]);

                formAlterar.ShowDialog();
                Temas.AtribuirTema(this);
                dataGridProduto.Rows[e.RowIndex].Cells[3].Value = formAlterar.Produto.Estoque;
            }
        }
    }
}
