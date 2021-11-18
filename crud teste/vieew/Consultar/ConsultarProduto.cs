using crud_teste.controller;
using crud_teste.Model;
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
            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;

            label1.ForeColor = Global.FontColor;
            label2.ForeColor = Global.FontColor;
            label3.ForeColor = Global.FontColor;
            label5.ForeColor = Global.FontColor;
            label6.ForeColor = Global.FontColor;
            label7.ForeColor = Global.FontColor;
            Ativo.ForeColor = Global.FontColor;

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
            Ativo.Checked = produto.Ativo;
            Fabricante.Text = produto.Fabricante;
        }

        public void RecuperarCampos()
        {
            produtoGlobal.NomeDoProduto = NomeDoProduto.Text;
            produtoGlobal.CodigoDeBarras = CodigoDeBarras.Text ;
            produtoGlobal.PrecoDeVenda.setFromDouble(double.Parse(PrecoDeVenda.Text));
            produtoGlobal.PrecoDeCusto.setFromDouble(double.Parse(PrecoDeCusto.Text));
            produtoGlobal.Estoque = long.Parse(Estoque.Text);
            produtoGlobal.Ativo = Ativo.Checked ;
            produtoGlobal.Fabricante = Fabricante.Text ;
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
                catch
                {
                    MessageBox.Show("Fala ao conectar com o banco de dados");
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

        private void PrecoDeVenda_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeVenda.Text);
        }

        private void PrecoDeCusto_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = Global.isNotFloatText(e.KeyChar, PrecoDeCusto.Text);
        }

        private void ConsultarProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
