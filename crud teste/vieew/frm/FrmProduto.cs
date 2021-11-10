using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produto = new Produto();
            produto = AtribuirCampos();
            var oProduto = new AlterarProduto();
            try
            {




                if (MessageBox.Show("Deseja Cadastrar dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    produto.IdProduto = oProduto.Inserir(produto);
                    MessageBox.Show($"Dados Cadastrados com sucesso\nid = {produto.IdProduto}");

                    new ListarClientes().Show();
                    this.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }

        
}

        private Produto AtribuirCampos()
        {
            var produto = new Produto();

            produto.NomeDoProduto = NomeDoProduto.Text;
            produto.CodigoDeBarras = CodigoDeBarras.Text;
            produto.PrecoDeVenda =float.Parse(PrecoDeVenda.Text);
            produto.PrecoDeCusto =float.Parse(PrecoDeCusto.Text);
            produto.DescontoAVista =float.Parse(DescontoAVista.Text);
            produto.Estoque = long.Parse(Estoque.Text);
            produto.Ativo = Ativo.Checked;
            produto.Fabricante = Fabricante.Text;

            return produto;

        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Mesmo Sair?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ListarClientes().Show();
                this.Close();
            }
        }
    }
}
