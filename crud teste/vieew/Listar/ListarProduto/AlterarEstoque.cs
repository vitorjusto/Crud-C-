using crud_teste.controller;
using crud_teste.Model.Listagem;
using System;
using System.Windows.Forms;

namespace crud_teste.vieew.Listar.ListarProduto
{
    public partial class AlterarEstoque : Form
    {
        AlterarProduto oAltetar = new AlterarProduto();
        public ProdutoListagem Produto = new ProdutoListagem();
        public AlterarEstoque(ProdutoListagem produto)
        {
            InitializeComponent();
            
            Produto = produto;
            nudEstoque.Value = Produto.Estoque;

        }

        private void AlterarEstoque_Load(object sender, EventArgs e)
        {
            Global.AtribuirTema(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                oAltetar.AlterarEstoque(Produto.IdProduto, (long)nudEstoque.Value);
                Produto.Estoque = (long)nudEstoque.Value;
            }
            catch
            {
                MessageBox.Show("Falha ao conectar com o banco de dados");
            }
            finally
            {
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
