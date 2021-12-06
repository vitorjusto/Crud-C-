using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ListarItens : Form
    {
        public Venda venda = new Venda();
        public int selectedIndex = -1;
        public ListarItens(Venda carrinhosLparam)
        {
            InitializeComponent();
            Temas.AtribuirTema(this);
            this.venda = carrinhosLparam;
            AtualizarGrid();

        }

        private void AtualizarGrid()
        {
            var index = 0;
            foreach (var carrinho in venda.Pedido_Produto)
            {
                dataGridCarrinho.Rows.Add();
                dataGridCarrinho.Rows[index].Cells[0].Value = carrinho.produto.NomeDoProduto;
                dataGridCarrinho.Rows[index].Cells[1].Value = carrinho.quantidade;
                dataGridCarrinho.Rows[index].Cells[2].Value = carrinho.PrecoBruto.GetAsString();
                dataGridCarrinho.Rows[index].Cells[3].Value = carrinho.PrecoBrutoAtual.GetAsString();
                dataGridCarrinho.Rows[index].Cells[4].Value = carrinho.Desconto.GetAsString();
                dataGridCarrinho.Rows[index].Cells[5].Value = carrinho.PrecoLiquido.GetAsString();
                dataGridCarrinho.Rows[index].Cells[6].Value = carrinho.PrecoLiquidoAtual.GetAsString();

                index++;
            }

            dataGridCarrinho.AllowUserToAddRows = false;
            dataGridCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridCarrinho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                selectedIndex = e.RowIndex;
                this.Dispose();
            }
            else if (e.ColumnIndex == 8)
            {
                if (MessageBox.Show("Deseja mesmo remover esse item (será considerado como reembolso a quantidade em estoque será alterada)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {

                        AlterarVenda oalterar = new AlterarVenda();
                        oalterar.aumentarEstoque(venda.Pedido_Produto[e.RowIndex]);
                        dataGridCarrinho.Rows.RemoveAt(e.RowIndex);
                        venda.Pedido_Produto.RemoveRange(e.RowIndex, 1);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void ListarItens_Load(object sender, EventArgs e)
        {

        }
    }
}

