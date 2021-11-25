using crud_teste.Config;
using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using crud_teste.Validation;
using crud_teste.vieew.TelaDeVenda;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class CadastroDePedidos : Form
    {
        public List<CarrinhoListagem> carrinhosL = new List<CarrinhoListagem>();
        public Pedido_Produto carrinho = new Pedido_Produto();
        public Venda venda = new Venda();

        public Cliente cliente = new Cliente();
        public Colaborador colaborador = new Colaborador();
        public CadastroDePedidos()
        {
            InitializeComponent();

            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.ForeColor = Global.FontColor;

            label1.ForeColor = Global.FontColor;
            label2.ForeColor = Global.FontColor;
            label3.ForeColor = Global.FontColor;
            label4.ForeColor = Global.FontColor;
            label5.ForeColor = Global.FontColor;
            label6.ForeColor = Global.FontColor;
            label7.ForeColor = Global.FontColor;
            label10.ForeColor = Global.FontColor;
            label11.ForeColor = Global.FontColor;
            label12.ForeColor = Global.FontColor;
            label13.ForeColor = Global.FontColor;
            label14.ForeColor = Global.FontColor;
            label15.ForeColor = Global.FontColor;
            label16.ForeColor = Global.FontColor;
            label17.ForeColor = Global.FontColor;
            label18.ForeColor = Global.FontColor;
            label20.ForeColor = Global.FontColor;
        }

        
        private void NomeCliente_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("cliente");
            listar.ShowDialog();

            cliente = listar.cliente;
            NomeCliente.Text = cliente.nomeCompleto();
            LimiteDeCompraaPraso.Text = cliente.LimiteDeCompra.ToString();

        }


        private void textBox8_Click(object sender, EventArgs e)
        {
            var listar = new ListarCarrinho(carrinhosL, venda.Pedido_Produto);
            listar.ShowDialog();

            carrinhosL = listar.carrinhosL;
            venda.Pedido_Produto = listar.carrinhos;
            if(listar.alterar)
            {
                carrinho = listar.carrinho;

                Desconto.Text = carrinho.Desconto.GetAsString();
                Quantidade.Text = carrinho.quantidade.ToString();

                preenchervaloresnoproduto();

                PreencherValoresCarrinhos();
            }

            AdicionarNaVenda();

        }
        private void NomeDoColaborador_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("colaborador");
            listar.ShowDialog();
            colaborador = listar.colaborador;
            NomeDoColaborador.Text = colaborador.nomeCompleto();
            venda.colaborador.PorcentagemDeComissao = listar.colaborador.PorcentagemDeComissao;

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
            var listar = new ListarVendaCliente("produto");
            listar.ShowDialog();
            carrinho.produto = listar.produto;
            preenchervaloresnoproduto();


        }

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotIntText(e.KeyChar, Quantidade.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            carrinho.quantidade = long.Parse(Quantidade.Text == "" ? "0" : Quantidade.Text);
            PreencherValoresCarrinhos();
            
        }

        public void PreencherValoresCarrinhos()
        {
            
            carrinho.PrecoBruto = (Dinheiro.ConverterParaDecimal(PrecoUnitario.Text) * carrinho.quantidade).ToString();

            carrinho.PrecoLiquido = ( carrinho.PrecoBruto.GetAsDouble() - carrinho.Desconto.GetAsDouble());



            QuantidadeRestante.Text = (long.Parse(QuantidadeEmEstoque.Text == ""? "0": QuantidadeEmEstoque.Text) - carrinho.quantidade).ToString();
            PrecoBruto.Text = carrinho.PrecoBruto.GetAsString();
            

            PrecoLiquido.Text = carrinho.PrecoLiquido.GetAsString();
        }

        private void Desconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotFloatText(e.KeyChar, Desconto.Text);

            
        }

        private void Desconto_TextChanged(object sender, EventArgs e)
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

           );
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

            }else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
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

            carrinho.produto = new Produto();
        }


        public void AdicionarNaVenda()
        {

            

            QuantidadeUnitario.Text = venda.Pedido_Produto.Count().ToString();

            QuantidadeTotal.Text = venda.Pedido_Produto.Sum(x => x.quantidade).ToString();

            TotalBruto.Text = venda.Pedido_Produto.Sum(x => x.PrecoBruto.GetAsDouble()).ToString();
            TotalLiquido.Text = venda.Pedido_Produto.Sum(x => x.PrecoLiquido.GetAsDouble() - float.Parse(FormaDePagamento.Text.Equals("A vista") && DescontoAVista.Text != "" ? DescontoAVista.Text : "0")).ToString();
            TotalDesconto.Text = venda.Pedido_Produto.Sum(x => x.Desconto.GetAsDouble()).ToString();

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
                LimiteDeCompraaPraso.Text = cliente.LimiteDeCompra.ToString();
            }else
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
            var validar = new VendaValidation(cliente.LimiteDeCompra, venda);


            var validares = validar.Validate(venda);

            if (validares.IsValid)
            {
                try
                {
                    if (MessageBox.Show("Deseja Mesmo Efetuar Venda?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AlterarVenda alterarvenda = new AlterarVenda();
                        alterarvenda.cadastrar(venda);
                        MessageBox.Show("venda efetuada com sucesso!");
                        LimparVenda();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
            }
        }

        public void LimparVenda()
        {
             carrinhosL = new List<CarrinhoListagem>();
             venda.Pedido_Produto = new List<Pedido_Produto>();
             carrinho = new Pedido_Produto();


            cliente = new Cliente();
            colaborador = new Colaborador();

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

            venda.cliente.idCliente = cliente.idCliente;
            venda.colaborador.idColaborador = colaborador.idColaborador;
            venda.TipoDeVenda = FormaDePagamento.Text;



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
            AdicionarNaVenda();
            
        }

        private void TotalLiquido_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LimparVenda();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Desconto_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Desconto_Enter(object sender, EventArgs e)
        {
            Desconto.Text = (Dinheiro.ConverterParaDecimal(Desconto.Text)).ToString();
        }

        private void Desconto_Leave(object sender, EventArgs e)
        {
            Desconto.Text = Dinheiro.converterParaDinheiro(Desconto.Text);
        }

        private void PrecoUnitario_TextChanged(object sender, EventArgs e)
        {
            PreencherValoresCarrinhos();
        }

        private void Desconto_MouseLeave(object sender, EventArgs e)
        {

        }

        private void CadastroDePedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
