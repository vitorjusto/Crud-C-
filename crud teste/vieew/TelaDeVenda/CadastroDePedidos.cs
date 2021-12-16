using crud_teste.Config;
using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using crud_teste.vieew.TelaDeVenda;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew
{
    public partial class CadastroDePedidos : Form
    {
        public List<CarrinhoListagem> carrinhosL = new List<CarrinhoListagem>();
        public Pedido_Produto carrinho = new Pedido_Produto();
        public Venda venda = new Venda();

        public CadastroDePedidos()
        {
            InitializeComponent();

            Temas.AtribuirTema(this);

            Desconto.Text = MyDinheiro.SetTextBoxAsMoneyValue(Desconto.Text);
            PrecoUnitario.Text = MyDinheiro.SetTextBoxAsMoneyValue("0");

            TotalBruto.Text = MyDinheiro.SetTextBoxAsMoneyValue("0");
            TotalDesconto.Text = MyDinheiro.SetTextBoxAsMoneyValue("0");
            TotalLiquido.Text = MyDinheiro.SetTextBoxAsMoneyValue("0");

        }

        private void NomeCliente_DoubleClick(object sender, EventArgs e)
        {
            PesquisarPorCliente("");
        }

        public void PesquisarPorCliente(string entrada)
        {
            var listar = new ListarVendaCliente("cliente", entrada);
            listar.ShowDialog();

            venda.cliente = listar.cliente;
            if (venda.cliente.Aniversariante())
                new CaixaDeInformacao().MensagemDeOk($"Parabéns {venda.cliente.nomeCompleto()}, Hoje é seu aniversário");
            NomeCliente.Text = venda.cliente.nomeCompleto();
            LimiteDeCompraaPraso.Text = venda.cliente.LimiteDeCompra.ToString();
        }

        public void PesquisarPorColaborador(string entrada)
        {

            var listar = new ListarVendaCliente("colaborador", entrada);
            listar.ShowDialog();
            venda.colaborador = listar.colaborador;
            NomeDoColaborador.Text = venda.colaborador.nomeCompleto();
            venda.colaborador.PorcentagemDeComissao = venda.colaborador.PorcentagemDeComissao;
        }

        private void textBox8_Click(object sender, EventArgs e)
        {

        }
        private void NomeDoColaborador_DoubleClick(object sender, EventArgs e)
        {
            PesquisarPorColaborador("");
        }

        public void preenchervaloresnoproduto()
        {

            NomeDoProduto.Text = carrinho.produto.NomeDoProduto;
            QuantidadeEmEstoque.Text = carrinho.produto.Estoque.ToString();
            PrecoUnitario.Text = carrinho.produto.PrecoDeVenda.GetAsString();
            carrinho.precoDeVenda = carrinho.produto.PrecoDeVenda.GetAsDouble();
            carrinho.precoDeCusto = carrinho.produto.PrecoDeCusto.GetAsDouble();

        }

        private void NomeDoProduto_DoubleClick(object sender, EventArgs e)
        {
            ListarProduto("");
        }

        public void ListarProduto(string texto)
        {
            var listar = new ListarVendaCliente("produto", venda.Pedido_Produto, texto);
            listar.ShowDialog();
            carrinho.produto = listar.produto;
            preenchervaloresnoproduto();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            var listar = new ListarCarrinho(carrinhosL, venda.Pedido_Produto);
            listar.ShowDialog();

            carrinhosL = listar.carrinhosL;
            venda.Pedido_Produto = listar.carrinhos;
            if (listar.alterar)
            {
                carrinho = listar.carrinho;

                Desconto.Text = carrinho.Desconto.GetAsString();
                Quantidade.Text = carrinho.quantidade.ToString();

                preenchervaloresnoproduto();

                PreencherValoresCarrinhos();
            }

            AdicionarNaVenda();
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = Global.isNotIntText(e.KeyChar, Quantidade.Text);


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            carrinho.quantidade = long.Parse(Quantidade.Text == "" ? "0" : Quantidade.Text);
            PreencherValoresCarrinhos();
        }

        public void PreencherValoresCarrinhos()
        {

            carrinho.PrecoBruto = (Dinheiro.ConverterParaDecimal(PrecoUnitario.Text) * carrinho.quantidade).ToString();

            carrinho.PrecoLiquido = (carrinho.PrecoBruto.GetAsDouble() - carrinho.Desconto.GetAsDouble());

            QuantidadeRestante.Text = (long.Parse(QuantidadeEmEstoque.Text == "" ? "0" : QuantidadeEmEstoque.Text) - carrinho.quantidade).ToString();
            PrecoBruto.Text = carrinho.PrecoBruto.GetAsString();

            PrecoLiquido.Text = carrinho.PrecoLiquido.GetAsString();
        }
        private void Desconto_TextChanged_1(object sender, EventArgs e)
        {
            carrinho.Desconto = Desconto.Text;
            PreencherValoresCarrinhos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarrinhoListagem carrinhoL = new CarrinhoListagem();
            Pedido_Produto ocarrinho = new Pedido_Produto(
                carrinho.Desconto,
                carrinho.precoDeCusto,
                carrinho.precoDeVenda,
                long.Parse(Quantidade.Text == "" ? "0" : Quantidade.Text),
                carrinho.PrecoBruto,
                carrinho.PrecoLiquido,
                0,
                (carrinho.produto.Estoque) - carrinho.quantidade
           ) ;
            ocarrinho.produto = carrinho.produto;

            carrinhoL.PrecoBruto = carrinho.PrecoBruto;
            carrinhoL.Desconto = carrinho.Desconto.GetAsDouble();
            carrinhoL.PrecoLiquido = carrinho.PrecoLiquido;
            carrinhoL.idProduto = carrinho.produto.IdProduto;
            carrinhoL.quantidade = carrinho.quantidade;
            carrinhoL.NomeProduto = carrinho.produto.NomeDoProduto;
            carrinhoL.PrecoDeVenda = (float)carrinho.produto.PrecoDeVenda.GetAsDouble();

            var validar = new CarrinhoValidation();


            var validares = validar.Validate(ocarrinho);

            if (validares.IsValid)
            {
                venda.Pedido_Produto.Add(ocarrinho);
                carrinhosL.Add(carrinhoL);


                LimparGroupBoxProduto();


                AdicionarNaVenda();

            }
            else
                new CaixaDeAviso().MensagemDeOk(validares.Errors.FirstOrDefault().ToString());

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

            carrinho.produto = new Produto();
        }

        public void AdicionarNaVenda()
        {

            QuantidadeUnitario.Text = venda.Pedido_Produto.Count().ToString();

            QuantidadeTotal.Text = venda.Pedido_Produto.Sum(x => x.quantidade).ToString();
            var desconto = new MyDinheiro(DescontoAVista.Text);
            TotalBruto.Text = venda.Pedido_Produto.Sum(x => x.PrecoBruto.GetAsDouble()).ToString("C2");
            TotalLiquido.Text = venda.Pedido_Produto.Sum(x => x.PrecoLiquido.GetAsDouble() - float.Parse(FormaDePagamento.Text.Equals("A vista") && DescontoAVista.Text != "" ? desconto.GetAsDouble().ToString(): "0")).ToString("c2");
            TotalDesconto.Text = venda.Pedido_Produto.Sum(x => x.Desconto.GetAsDouble()).ToString("c2");

        }

        private void FormaDePagamento_TextChanged(object sender, EventArgs e)
        {
            if (FormaDePagamento.Text.Equals("A vista"))
            {

                labelLimite.Visible = false;
                LimiteDeCompraaPraso.Visible = false;

                labeledit.Text = "Desconto a Vista: ";
                labeledit.Visible = true;
                

                DescontoAVista.Text = MyDinheiro.SetTextBoxAsMoneyValue("0");
                DescontoAVista.Visible = true;
            }
            else if (FormaDePagamento.Text.Equals("A Prazo"))
            {
                labeledit.Text = "Meses A Prazo: ";
                labeledit.Visible = true;

                DescontoAVista.Text = "";
                DescontoAVista.Visible = true;

                labelLimite.Visible = true;
                LimiteDeCompraaPraso.Visible = true;
                LimiteDeCompraaPraso.Text = venda.cliente.LimiteRestante.ToString();
            }
            else
            {
                labeledit.Visible = false;
                DescontoAVista.Visible = false;

                labelLimite.Visible = false;
                LimiteDeCompraaPraso.Visible = false;
                DescontoAVista.Text = "";
                LimiteDeCompraaPraso.Text = "";
            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListarClientes().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            receberCampos();
            var validar = new VendaValidation((decimal)venda.cliente.LimiteRestante.GetAsDouble(), venda);
            var validares = validar.Validate(venda);

            if (validares.IsValid)
            {
                try
                {
                    if (new CaixaDePergunta().MensagemDeSimENao("deseja mesmo efetuar venda?"))
                    {
                        AlterarVenda alterarvenda = new AlterarVenda();
                        venda.DiaDaVenda = DateTime.Now;
                        alterarvenda.cadastrar(venda);
                        new CaixaDeInformacao().MensagemDeOk("venda efetuada com sucesso!");

                        if (new CaixaDePergunta().MensagemDeSimENao("deseja enviar recibo por email?"))
                        {
                            try
                            {
                                EnviarEmail.EnviarEmailDeVenda(venda);
                                new CaixaDeInformacao().MensagemDeOk("Enviado No Email Com Sucesso");
                            }
                            catch
                            {
                                new CaixaDeErro().MensagemDeOk("Não foi possivel enviar o Email, certifique-se se o usuario cadastrou o Email correto");
                            }
                        }
                        LimparVenda();
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

        public void LimparVenda()
        {
            carrinhosL = new List<CarrinhoListagem>();
            venda.Pedido_Produto = new List<Pedido_Produto>();
            carrinho = new Pedido_Produto();

            venda.cliente = new Cliente();
            venda.colaborador = new Colaborador();

            NomeCliente.Text = "";
            NomeDoColaborador.Text = "";

            QuantidadeUnitario.Text = "";
            QuantidadeTotal.Text = "";
            TotalBruto.Text = "";
            TotalDesconto.Text = "";
            TotalLiquido.Text = "";

            FormaDePagamento.Text = "";
            LimparGroupBoxProduto();

        }

        public Venda receberCampos()
        {

            venda.cliente.idCliente = venda.cliente.idCliente;
            venda.colaborador.idColaborador = venda.colaborador.idColaborador;
            venda.TipoDeVenda = FormaDePagamento.Text;

            if (venda.TipoDeVenda.Equals("A vista"))
            {
                venda.DescontoAVista = DescontoAVista.Text.Equals("") ? "0.0" : DescontoAVista.Text;

                venda.MesesAPrazo = 0;
            }
            else if (venda.TipoDeVenda.Equals("A Prazo"))
            {
                venda.DescontoAVista = 0.0F;
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

        private void DescontoAVista_TextChanged(object sender, EventArgs e) =>
            AdicionarNaVenda();


        private void button3_Click(object sender, EventArgs e)
        {
            if(new CaixaDeAviso().MensagemDeSimENao("Deseja Mesmo Cancelar A Venda?"))
                LimparVenda();
        }

        private void DescontoAVista_Leave(object sender, EventArgs e)
        {
            if (FormaDePagamento.Text.Equals("A vista"))
                DescontoAVista.Text = MyDinheiro.SetTextBoxAsMoneyValue(DescontoAVista.Text);
        }
         private void FormaDePagamento_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void NomeCliente_Enter(object sender, EventArgs e)
        {
            NomeCliente.Text = "";
        }

        private void NomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                PesquisarPorCliente(NomeCliente.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisarPorCliente("");
        }

        private void NomeDoColaborador_Enter(object sender, EventArgs e)
        {
            NomeDoColaborador.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PesquisarPorColaborador("");
        }

        private void NomeDoColaborador_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                PesquisarPorColaborador(NomeDoColaborador.Text);
        }

        private void NomeCliente_Leave(object sender, EventArgs e)
        {
            NomeCliente.Text = venda.cliente.nomeCompleto();
        }

        private void NomeDoColaborador_Leave(object sender, EventArgs e)
        {
            NomeDoColaborador.Text = venda.colaborador.nomeCompleto();
        }

        private void NomeDoProduto_Enter(object sender, EventArgs e)
        {
            NomeDoProduto.Text = "";
        }
        private void NomeDoProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                ListarProduto(NomeDoProduto.Text);
        }

        private void NomeDoProduto_Leave(object sender, EventArgs e)
        {
            NomeDoProduto.Text = carrinho.produto.NomeDoProduto;
        }

    }
}
