using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.vieew.TelaDeVenda
{
    public partial class ListarCarrinho : Form
    {
        public AlterarCarrinho oAlterar = new AlterarCarrinho();
        public List<CarrinhoListagem> carrinhosL = new List<CarrinhoListagem>();
        public List<Pedido_Produto> carrinhos = new List<Pedido_Produto>();
        public ListarCarrinho(List<CarrinhoListagem> carrinhosLparam, List<Pedido_Produto> carrinhosparam)
        {
            InitializeComponent();
            this.carrinhos = carrinhosparam;
            this.carrinhosL = carrinhosLparam;

            this.BackColor = Global.BackgroundColor;
            dataGridCarrinho.BackgroundColor = Global.BackgroundColor;


            textBoxinstrucao.BackColor = Global.BackgroundColor;
            textBoxinstrucao.ForeColor = Global.FontColor;


            
            


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

        private void ListarCarrinho_Load(object sender, EventArgs e)
        {

        }

        private void dataGridCarrinho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                if(MessageBox.Show("Deseja mesmo remover esse item?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dataGridCarrinho.Rows.RemoveAt(e.RowIndex);
                    carrinhos.RemoveRange(e.RowIndex, 1);
                    carrinhosL.RemoveRange(e.RowIndex, 1);
                }
            }
        }
    }
}
