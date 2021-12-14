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

namespace crud_teste.vieew.Consultar
{
    public partial class ConsultarProduto : Form
    {
        public Produto produtoGlobal = new Produto();
        AlterarProduto oAlterar = new AlterarProduto();
        public ConsultarProduto(int id)
        {
            InitializeComponent();
            Temas.AtribuirTema(this);
            try
            {


                produtoGlobal.IdProduto = id;
                produtoGlobal = oAlterar.Consultar(id);
                atribuirCampos(produtoGlobal);
            }catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
                new ListarProduto().Show();
                this.Hide();
            }

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
                    if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo alterar os dados?"))
                    {
                        oAlterar.Salvar(produtoGlobal);
                        new CaixaDeInformacao().MensagemDeOk("Dados salvos com sucesso !!");
                        new ListarProduto().Show();
                        this.Close();
                    }
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }
            }
            else
            {
                new CaixaDeAviso().MensagemDeOk(validares.Errors.FirstOrDefault().ToString());
            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal Listagem?"))
            {
                new ListarProduto().Show();
                this.Hide();
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (new CaixaDeAviso().MensagemDeSimENao("Deseja excluir os dados (Dados Serão excluidos permanente)?"))
                {
                    oAlterar.Excluir(produtoGlobal.IdProduto);
                    new CaixaDeInformacao().MensagemDeOk("Dados excluidos com sucesso !!"); 
                    new ListarProduto().Show();
                    this.Close();
                }
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados(); 
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

    }
}
