using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();

            Global.AtribuirTema(this);

            PrecoDeVenda.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeVenda.Text);
            PrecoDeCusto.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeCusto.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var produto = AtribuirCampos();
            ProdutoValidation validar = new ProdutoValidation();
            var validares = validar.Validate(produto);
            if (validares.IsValid)
            {
                try
                {
                    var oProduto = new AlterarProduto();

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
            else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
            }

        }

        private Produto AtribuirCampos()
        {
            var produto = new Produto();

            produto.NomeDoProduto = NomeDoProduto.Text;
            produto.CodigoDeBarras = CodigoDeBarras.Text;
            produto.PrecoDeVenda = PrecoDeVenda.Text;
            produto.PrecoDeCusto = PrecoDeCusto.Text;
            produto.Estoque = long.Parse(Estoque.Text == ""? "0": Estoque.Text);
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

        private void Estoque_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotIntChar(e.KeyChar);

        private void PrecoDeVenda_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeVenda.Text);

        private void PrecoDeCusto_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeCusto.Text);

        private void PrecoDeVenda_Leave(object sender, EventArgs e)
        {
            PrecoDeVenda.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeVenda.Text);
        }

        private void PrecoDeCusto_Leave(object sender, EventArgs e)
        {
            PrecoDeCusto.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeCusto.Text);
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
