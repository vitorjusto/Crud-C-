using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using System;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew.Consultar
{
    public partial class ConsultarProduto : Form
    {
        public Produto produtoGlobal = new Produto();
        AlterarProduto oAlterar = new AlterarProduto();
        public ConsultarProduto(int id)
        {
            InitializeComponent();
            Global.AtribuirTema(this);

            PrecoDeVenda.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeVenda.Text);
            PrecoDeCusto.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeCusto.Text);

            produtoGlobal.IdProduto = id;
            produtoGlobal = oAlterar.Consultar(id);
            atribuirCampos(produtoGlobal);

        }

        public void atribuirCampos(Produto produto)
        {
            NomeDoProduto.Text = produto.NomeDoProduto;
            CodigoDeBarras.Text = produto.CodigoDeBarras;
            PrecoDeVenda.Text = produto.PrecoDeVenda.GetAsString();
            PrecoDeCusto.Text = produto.PrecoDeCusto.GetAsString();
            Estoque.Text = produto.Estoque.ToString();

            txtAtivo.Text = produto.Ativo? "Ativo" : "Inativo";
            btnAtivo.Text = produto.Ativo ? "Inativar" : "Reativar";

            Fabricante.Text = produto.Fabricante;
        }

        public void RecuperarCampos()
        {
            produtoGlobal.NomeDoProduto = NomeDoProduto.Text;
            produtoGlobal.CodigoDeBarras = CodigoDeBarras.Text;
            produtoGlobal.PrecoDeVenda = PrecoDeVenda.Text;
            produtoGlobal.PrecoDeCusto = PrecoDeCusto.Text;
            produtoGlobal.Estoque = long.Parse(Estoque.Text);
            produtoGlobal.Fabricante = Fabricante.Text;
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            RecuperarCampos();
            ProdutoValidation validar = new ProdutoValidation();
            var validares = validar.Validate(produtoGlobal);
            if (validares.IsValid)
            {
                try
                {
                    if (MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        oAlterar.Salvar(produtoGlobal);
                        MessageBox.Show("Produto alterado com sucesso");
                        new ListarProduto().Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo voltar a pagina de listagem?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ListarProduto().Show();
                this.Hide();
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos Permanentemente)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oAlterar.Excluir(produtoGlobal.IdProduto);
                    MessageBox.Show("Produto excluido com sucesso");
                    new ListarProduto().Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Fala ao conectar com o banco de dados");
            }
        }

        private void PrecoDeVenda_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeVenda.Text);

        private void PrecoDeCusto_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeCusto.Text);

        private void btnAtivo_Click(object sender, EventArgs e) 
        {
            produtoGlobal.Ativo = !produtoGlobal.Ativo;


            txtAtivo.Text = produtoGlobal.Ativo ? "Ativo" : "Inativo";
            btnAtivo.Text = produtoGlobal.Ativo ? "Inativar" : "Reativar";

        }

        private void ConsultarProduto_Load(object sender, EventArgs e)
        {

        }

        private void PrecoDeVenda_Leave(object sender, EventArgs e)
        {
            PrecoDeVenda.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeVenda.Text);
        }

        private void PrecoDeCusto_Leave(object sender, EventArgs e)
        {
            PrecoDeCusto.Text = MyDinheiro.SetTextBoxAsMoneyValue(PrecoDeCusto.Text);
        }
    }
}
