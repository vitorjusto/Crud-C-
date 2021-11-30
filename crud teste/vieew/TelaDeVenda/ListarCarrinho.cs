using crud_teste.Model;
using crud_teste.Model.Listagem;
using System.Collections.Generic;
using System.Windows.Forms;

namespace crud_teste.vieew.TelaDeVenda
{
    public partial class ListarCarrinho : Form
    {
        public List<CarrinhoListagem> carrinhosL = new List<CarrinhoListagem>();
        public List<Pedido_Produto> carrinhos = new List<Pedido_Produto>();
        public Pedido_Produto carrinho = new Pedido_Produto();
        public bool alterar { get; set; }

        public ListarCarrinho(List<CarrinhoListagem> carrinhosLparam, List<Pedido_Produto> carrinhosparam)
        {
            InitializeComponent();
            this.carrinhos = carrinhosparam;
            this.carrinhosL = carrinhosLparam;

            Global.AtribuirTema(this);

            alterar = false;
            var i = 0;

            foreach (var carrinho in carrinhosL)
            {
                dataGridCarrinho.Rows.Add();
                dataGridCarrinho.Rows[i].Cells[0].Value = carrinho.NomeProduto;
                dataGridCarrinho.Rows[i].Cells[1].Value = carrinho.quantidade;
                dataGridCarrinho.Rows[i].Cells[2].Value = carrinho.PrecoDeVenda.GetAsString();
                dataGridCarrinho.Rows[i].Cells[3].Value = carrinho.PrecoBruto.GetAsString();
                dataGridCarrinho.Rows[i].Cells[4].Value = carrinho.Desconto.GetAsString();
                dataGridCarrinho.Rows[i].Cells[5].Value = carrinho.PrecoLiquido.GetAsString();
                i++;
            }
            dataGridCarrinho.AllowUserToAddRows = false;
            dataGridCarrinho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7)
            {
                if(MessageBox.Show("Deseja mesmo remover esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridCarrinho.Rows.RemoveAt(e.RowIndex);
                    carrinhos.RemoveRange(e.RowIndex, 1);
                    carrinhosL.RemoveRange(e.RowIndex, 1);
                }
            }else if(e.ColumnIndex == 6)
            {
                carrinho = carrinhos[e.RowIndex];
                carrinhos.RemoveRange(e.RowIndex, 1);
                carrinhosL.RemoveRange(e.RowIndex, 1);
                alterar = true;
                this.Dispose();
            }
        }

        private void ListarCarrinho_Load(object sender, System.EventArgs e)
        {

        }
    }
}
