using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using crud_teste.vieew.TelaDeVenda;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class CadastroDePedidos : Form
    {
        public List<CarrinhoListagem> carrinhos = new List<CarrinhoListagem>();



        public Cliente cliente = new Cliente();
        public Colaborador colaborador = new Colaborador();
        public Produto produto = new Produto();
        public CadastroDePedidos()
        {
            InitializeComponent();
        }

        
        private void NomeCliente_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("cliente");
            listar.ShowDialog();

            cliente = listar.cliente;
            NomeCliente.Text = cliente.nomeCompleto();
            LimiteDeCompraaPraso.Text = cliente.LimiteDeCompra.ToString();

        }

        private void CadastroDePedidos_Load(object sender, EventArgs e)
        {

        }

        private void NomeCliente_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox8_Click(object sender, EventArgs e)
        {
            var listar = new ListarCarrinho(carrinhos);
            listar.ShowDialog();

            carrinhos = listar.carrinhos;

            AdicionarNaVenda();

        }
        private void NomeDoColaborador_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("colaborador");
            listar.ShowDialog();
            colaborador = listar.colaborador;
            NomeDoColaborador.Text = colaborador.nomeCompleto();

        }

        private void NomeDoProduto_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void NomeDoProduto_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("produto");
            listar.ShowDialog();

            produto = listar.produto;
            NomeDoProduto.Text = produto.NomeDoProduto;
            QuantidadeEmEstoque.Text = produto.Estoque.ToString();
            PrecoUnitario.Text =  produto.PrecoDeVenda.ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotIntChar(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Quantidade.Text != "" && QuantidadeEmEstoque.Text != "")
            {
                QuantidadeRestante.Text = (long.Parse(QuantidadeEmEstoque.Text) - long.Parse(Quantidade.Text)).ToString();
                PrecoBruto.Text = (produto.PrecoDeVenda * long.Parse(Quantidade.Text)).ToString();
                PrecoLiquido.Text = (float.Parse(PrecoBruto.Text) - float.Parse(Desconto.Text == "" ? "0" : Desconto.Text)).ToString();
            }
            else
            {

                QuantidadeRestante.Text = "";
                PrecoBruto.Text = "";
                PrecoLiquido.Text = "";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotFloatText(e.KeyChar, Desconto.Text);


            PrecoLiquido.Text = (float.Parse(PrecoBruto.Text) - float.Parse(Desconto.Text == "" ? "0" : Desconto.Text)).ToString();
        }

        private void Desconto_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarrinhoListagem carrinho = new CarrinhoListagem();
            var oAlterar = new AlterarCarrinho();

            carrinho.PrecoBruto = float.Parse(PrecoBruto.Text);
            carrinho.Desconto = int.Parse(Desconto.Text);
            carrinho.PrecoLiquido = float.Parse(PrecoLiquido.Text);
            carrinho.idProduto = produto.IdProduto;
            carrinho.quantidade = int.Parse(Quantidade.Text);
            carrinho.NomeProduto = produto.NomeDoProduto;
            carrinho.PrecoDeVenda = produto.PrecoDeVenda;

            try
            {
                carrinhos.Add(carrinho);

                LimparGroupBoxProduto();


                AdicionarNaVenda();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atenção");
            }




        }



        private void LimparGroupBoxProduto()
        {
            NomeDoProduto.Text = "";
            Quantidade.Text = "";
            QuantidadeEmEstoque.Text = "";
            QuantidadeRestante.Text = "";
            PrecoBruto.Text = "";
            PrecoLiquido.Text = "";
            PrecoUnitario.Text = "";
            Desconto.Text = "";
        }


        public void AdicionarNaVenda()
        {
            QuantidadeUnitario.Text = carrinhos.Count().ToString();

            QuantidadeTotal.Text = carrinhos.Sum(x => x.quantidade).ToString();

            TotalBruto.Text = carrinhos.Sum(x => x.PrecoBruto).ToString();
            TotalLiquido.Text = carrinhos.Sum(x => x.PrecoLiquido).ToString();
            TotalDesconto.Text = carrinhos.Sum(x => x.Desconto).ToString();

        }

        private void FormaDePagamento_TextChanged(object sender, EventArgs e)
        {
            if(FormaDePagamento.Text.Equals("A vista"))
            {

                labelLimite.Visible = false;
                LimiteDeCompraaPraso.Visible = false;

                labeledit.Text = "Desconto a Vista: ";
                labeledit.Visible = true;

                DescontoAVista.Text = "";
                DescontoAVista.Visible = true;
            }else if(FormaDePagamento.Text.Equals("A Prazo"))
            {
                labeledit.Text = "Meses A Prazo: ";
                labeledit.Visible = true;

                DescontoAVista.Text = "";
                DescontoAVista.Visible = true;

                labelLimite.Visible= true;
                LimiteDeCompraaPraso.Visible = true;
            }else
            {
                labeledit.Visible = false;
                DescontoAVista.Visible = false;


                labelLimite.Visible = false;
                LimiteDeCompraaPraso.Visible = false;
                DescontoAVista.Text = "";
            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListarClientes().Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();
            venda = receberCampos();


        }

        public Venda receberCampos()
        {
            Venda venda = new Venda();

            venda.IdCliente = cliente.idCliente;
            venda.IdColaborador = colaborador.idColaborador;
            venda.QuantidadeDeTotal = int.Parse(QuantidadeTotal.Text);
            venda.QuantidadeUnitario = int.Parse(QuantidadeUnitario.Text);
            venda.TipoDeVenda = FormaDePagamento.Text;

            venda.TotalBruto = float.Parse(TotalBruto.Text);
            venda.TotalDeDesconto = float.Parse(TotalDesconto.Text);
            venda.TotalLiquido = float.Parse(TotalLiquido.Text);


            if (venda.TipoDeVenda.Equals("A vista"))
            {
                venda.DescontoAVIsta = DescontoAVista.Text.Equals("") ? 0 : float.Parse(DescontoAVista.Text);
                venda.MesesAPrazo = 0;
            }
            else if (venda.TipoDeVenda.Equals("A Prazo"))
            {
                venda.DescontoAVIsta = 0.0F;
                venda.MesesAPrazo = DescontoAVista.Text.Equals("") ? 0 : int.Parse(DescontoAVista.Text);
            }




            return venda;
        }

        private void DescontoAVista_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (FormaDePagamento.Text.Equals("A vista"))
                e.Handled = Global.isNotFloatText(e.KeyChar, DescontoAVista.Text);
            else
                e.Handled = Global.isNotIntChar(e.KeyChar);

        }

        private void DescontoAVista_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
