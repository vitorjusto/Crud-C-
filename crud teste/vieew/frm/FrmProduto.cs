using crud_teste.Config;
using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using System;
using System.Linq;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();

            Temas.AtribuirTema(this);

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

                    if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo cadastrar os dados?"))
                    {
                        produto.IdProduto = oProduto.Inserir(produto);
                        new CaixaDeInformacao().MensagemDeOk($"Dados Cadastrados com sucesso\nid = {produto.IdProduto}");

                        new ListarClientes().Show();
                        this.Close();
                    }
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }
            }
            else
                new CaixaDeAviso().MensagemDeOk(validares.Errors.FirstOrDefault().ToString());

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
            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal?"))
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
