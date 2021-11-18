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
            Buscarsoativo(produtos);
            
        }


        public void preencherDataGrid(List<ProdutoListagem> produtos)
        {
            dataGridProduto.Rows.Clear();
            var i = 0;
            foreach(var produto in produtos)
            {
                dataGridProduto.Rows.Add();
                dataGridProduto.Rows[i].Cells[0].Value = produto.IdProduto;
                dataGridProduto.Rows[i].Cells[1].Value = produto.nomeProduto;
                dataGridProduto.Rows[i].Cells[2].Value = produto.PrecodeVenda;
                dataGridProduto.Rows[i].Cells[3].Value = produto.Estoque;
                dataGridProduto.Rows[i].Cells[4].Value = produto.fabricante;
                dataGridProduto.Rows[i].Cells[5].Value = produto.Ativo;

                i++;
            }
            dataGridProduto.AllowUserToAddRows = false;



            dataGridProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void Buscarsoativo(List<ProdutoListagem> produtos)
        {
            dataGridProduto.Rows.Clear();
            var i = 0;
            foreach (var produto in produtos)
            {
                if (produto.Ativo)
                {
                    dataGridProduto.Rows.Add();
                    dataGridProduto.Rows[i].Cells[0].Value = produto.IdProduto;
                    dataGridProduto.Rows[i].Cells[1].Value = produto.nomeProduto;
                    dataGridProduto.Rows[i].Cells[2].Value = produto.PrecodeVenda;
                    dataGridProduto.Rows[i].Cells[3].Value = produto.Estoque;
                    dataGridProduto.Rows[i].Cells[4].Value = produto.fabricante;
                    dataGridProduto.Rows[i].Cells[5].Value = produto.Ativo;

                    i++;
                }
            }
            dataGridProduto.AllowUserToAddRows = false;



            dataGridProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    

        private void ListaProduto_Load(object sender, EventArgs e)
        {

        }

        private void dataGridProduto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

            if(CampoDePesquisa.Text == "")
            {
                preencherDataGrid(oAlterar.Listar());
            }
            else if(id == 0 )
            {
                preencherDataGrid(oAlterar.Listar(CampoDePesquisa.Text, "nome"));
            }
            else
            {
                preencherDataGrid(oAlterar.Listar(CampoDePesquisa.Text, "id"));
            }
        }

        private void dataGridProduto_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var x = int.Parse(dataGridProduto.Rows[e.RowIndex].Cells[0].Value.ToString());

            new ConsultarProduto(x).Show();
            this.Close();
        }

        private void BuscarAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if(BuscarAtivo.Checked)
            {
                Buscarsoativo(produtos);
            }else
            {
                preencherDataGrid(produtos);
            }
        }
    }
}
