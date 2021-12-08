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
using Tema;

namespace crud_teste.vieew.TelaDeVenda
{
    public partial class AlterarProdutoDoCarrinho : Form
    {
        public Pedido_Produto produto = new Pedido_Produto();
        public CarrinhoListagem produtoL = new CarrinhoListagem();
        public AlterarProdutoDoCarrinho(Pedido_Produto oproduto)
        {
            produto = oproduto;
            InitializeComponent();


        }

        private void AlterarProdutoDoCarrinho_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);

            txtNomeDoProduto.Text = produto.produto.NomeDoProduto;
            txtPrecoBruto.Text = produto.PrecoBruto.GetAsString();
            txtDesconto.Text = produto.Desconto.GetAsString();
            txtPrecoLiquido.Text = produto.PrecoLiquido.GetAsString();
            txtPrecoUnitario.Text = produto.precoDeVenda.GetAsString();
            txtQuantidade.Text = produto.quantidade.ToString();
            txtQuantidadeEmEstoque.Text = produto.produto.Estoque.ToString();
            txtQuantidadeRestante.Text = produto.quantidadeRestante.ToString();
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            produto.quantidade = long.Parse(txtQuantidade.Text == "" ? "0" : txtQuantidade.Text);
            calcularPrecos();
        }

        private void calcularPrecos()
        {
            produto.PrecoBruto = produto.quantidade * produto.precoDeVenda.GetAsDecimal();
            produto.PrecoLiquido = produto.PrecoBruto.GetAsDecimal() - produto.Desconto.GetAsDecimal();

            txtQuantidadeRestante.Text = (produto.produto.Estoque - produto.quantidade).ToString();
            txtPrecoBruto.Text = produto.PrecoBruto.GetAsString();
            txtPrecoLiquido.Text = produto.PrecoLiquido.GetAsString();

            produto.quantidadeRestante = long.Parse(txtQuantidadeRestante.Text == "" ? "0" : txtQuantidadeRestante.Text);
        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            produto.Desconto = txtDesconto.Text;
            calcularPrecos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            produto.PrecoBruto = txtPrecoBruto.Text;
            produto.PrecoLiquido = txtPrecoLiquido.Text;
            produto.quantidade = long.Parse(txtQuantidade.Text == "" ? "0" : txtQuantidade.Text);
            produto.quantidadeRestante = long.Parse(txtQuantidadeRestante.Text == "" ? "0" : txtQuantidadeRestante.Text);
            produto.Desconto = txtDesconto.Text;

            produtoL.NomeProduto = txtNomeDoProduto.Text;
            produtoL.PrecoDeVenda = txtPrecoUnitario.Text;
            produtoL.Desconto = txtDesconto.Text;
            produtoL.PrecoBruto = txtPrecoBruto.Text;
            produtoL.PrecoLiquido = txtPrecoLiquido.Text;
            produtoL.quantidade = long.Parse(txtQuantidade.Text);
            this.Dispose();
        }
    }
}
