using crud_teste.Config;
using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Validation;
using crud_teste.vieew.TelaDeVenda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ConsultarVenda : Form
    {
        private Venda _venda = new Venda();
        private Pedido_Produto _pedido = new Pedido_Produto();
        private List<Pedido_Produto> oldList = new List<Pedido_Produto>();
        public ConsultarVenda(int id)
        {
            InitializeComponent();

            this.BackColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.Strip;

            AlterarVenda oAlterar = new AlterarVenda();

            _venda = oAlterar.Consultar(id);

            oldList.AddRange(_venda.Pedido_Produto);

            gbProduto.Visible = false;

           

            preencherCampos();

        }

        private void preencherCampos()
        {
     
            txtCliente.Text = _venda.cliente.nomeCompleto();
            txtColaborador.Text = _venda.colaborador.nomeCompleto();


            txtTotalUnitaria.Text = _venda.QuantidadeUnitario.ToString();
            txtQuantidadeTotal.Text = _venda.QuantidadeDeTotal.ToString();

            txtTotalBruto.Text = _venda.TotalBruto.GetAsString();
            txtTotalDesconto.Text = _venda.TotalDeDesconto.GetAsString();
            txtTotalLiquido.Text = _venda.TotalLiquido.GetAsString();

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {

            var janeladocarrinho = new ListarItens(_venda);
            janeladocarrinho.ShowDialog();

            
            if (janeladocarrinho.selectedIndex != -1)
            {
                lbNomeProduto.Visible = false;
                txtnomeProduto.Visible = false;
                _venda = janeladocarrinho.venda;
                _pedido = _venda.Pedido_Produto[janeladocarrinho.selectedIndex];
                _pedido.produto.Estoque += _pedido.quantidade;

                abrirProduto();
            }

        }

        private void abrirProduto()
        {
            txtnomeProduto.Text = _pedido.produto.NomeDoProduto;
            txtquantidade.Text = _pedido.quantidade.ToString();
            txtquantidadeemestoque.Text = _pedido.produto.Estoque.ToString();
            txtQuantidadeRestante.Text = (_pedido.produto.Estoque - _pedido.quantidade).ToString();

            txtPrecoUnitario.Text = _pedido.produto.PrecoDeVenda.GetAsString();
            txtValorBruto.Text = _pedido.PrecoBrutoAtual.GetAsString();
            txtDesconto.Text = _pedido.Desconto.GetAsString();
            txtPrecoLiquido.Text = _pedido.PrecoLiquidoAtual.GetAsString();


            gbProduto.Visible = true;
        }

        private void txtnomeProduto_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var listadeProduto = new ListarVendaCliente("produto");
            listadeProduto.ShowDialog();
            _pedido.produto = listadeProduto.produto;
           

            abrirProduto();
        }

        

        private void txtquantidade_TextChanged(object sender, EventArgs e)
        {


            _pedido.quantidade = Convert.ToInt64(txtquantidade.Text == ""? "0": txtquantidade.Text);
            txtQuantidadeRestante.Text = (_pedido.produto.Estoque - _pedido.quantidade).ToString();

            CalcularCampos();
        }

        private void CalcularCampos()
        {
            txtValorBruto.Text = (Dinheiro.ConverterParaDecimal(txtPrecoUnitario.Text) * decimal.Parse(txtquantidade.Text == "" ? "0" : txtquantidade.Text)).ToString("C2");
            txtPrecoLiquido.Text = (Dinheiro.ConverterParaDecimal(txtValorBruto.Text) - Dinheiro.ConverterParaDecimal(txtDesconto.Text)).ToString("C");

        }

        private void ExcluirProduto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo remover esse item (será considerado como reembolso a quantidade em estoque será alterada)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    AlterarVenda oalterar = new AlterarVenda();
                    oalterar.aumentarEstoque(_pedido);

                    _venda.Pedido_Produto.Remove(_pedido);
                    oldList.Remove(_pedido);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtquantidade_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotIntText(e.KeyChar, txtquantidade.Text);


        private void txtDesconto_Enter(object sender, EventArgs e) => txtDesconto.Text = (Dinheiro.ConverterParaDecimal(txtDesconto.Text)).ToString();

        private void txtDesconto_Leave(object sender, EventArgs e) => txtDesconto.Text = Dinheiro.converterParaDinheiro(txtDesconto.Text);

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotFloatText(e.KeyChar, txtDesconto.Text);

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sair();
        }


        private void sair()
        {
            if (_venda.Pedido_Produto.Count == 0)
            {
                if (MessageBox.Show("Esta venda resultou em 0 (zero) produtos listados, deseja excluir venda?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    AlterarVenda oAlterar = new AlterarVenda();
                    try
                    {
                        oAlterar.ExcluirVenda(_venda.IdVenda);
                        this.Close();
                        new ListagemDePedidos().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                this.Close();
                new ListagemDePedidos().Show();
            }
        }

        private Pedido_Produto receberCamposDoProduto()
        {
            var pedido = new Pedido_Produto();
            pedido.produto = _pedido.produto;

            pedido.PrecoBruto = txtValorBruto.Text;
            pedido.quantidade = Convert.ToInt64(txtquantidade.Text == "" ? "0" : txtquantidade.Text);
            pedido.quantidadeRestante = Convert.ToInt64(txtQuantidadeRestante.Text == ""? "0" : txtQuantidadeRestante.Text);
            pedido.precoDeCusto = txtPrecoUnitario.Text;
            pedido.PrecoBruto = txtValorBruto.Text;
            pedido.Desconto = txtDesconto.Text;
            pedido.PrecoLiquido = txtPrecoLiquido.Text;
            pedido.precoDeVenda = txtPrecoUnitario.Text;
            return pedido;
        }

        private void ApagarCampoDoProduto()
        {
            gbProduto.Visible = false;

            txtnomeProduto.Text = "";
            txtquantidade.Text = "";
            txtquantidadeemestoque.Text = "";
            txtQuantidadeRestante.Text = "";

            txtPrecoUnitario.Text = "";
            txtValorBruto.Text = "";
            txtDesconto.Text = "";
            txtPrecoLiquido.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var validar = new CarrinhoValidation();
            var pedido = receberCamposDoProduto();
            var validares = validar.Validate(pedido);

            if (validares.IsValid)
            {
                if (btnAlterarProduto.Text.Equals("Alterar Produto"))
                {
                    _venda.Pedido_Produto.Remove(_pedido);

                    receberCamposDoProduto();

                    _venda.Pedido_Produto.Add(pedido);

                    ApagarCampoDoProduto();

                    preencherCampos();
                }
            }else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
            }
        }

        private void ConsultarVenda_Load(object sender, EventArgs e)
        {

        }

        private void txtDesconto_TextChanged(object sender, EventArgs e)
        {
            CalcularCampos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var validar = new VendaValidation(_venda.cliente.LimiteDeCompra, _venda);
            var validares = validar.Validate(_venda);

            if(validares.IsValid)
            {
                try
                {
                    if (MessageBox.Show("Deseja Mesmo Alterar esta venda?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        AlterarVenda oAlterar = new AlterarVenda();
                        oAlterar.SalvarProduto(_venda);
                        this.Close();
                        new ListagemDePedidos().Show();
                    }


                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(validares.Errors.FirstOrDefault().ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            _pedido = new Pedido_Produto();
            ApagarCampoDoProduto();
            lbNomeProduto.Visible = true;
            txtnomeProduto.Visible = true;
            gbProduto.Visible = true;

        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Deseja Mesmo Inativar esta venda, todos os produtos retornarão no estoque e não fazerá parte do lucro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    AlterarVenda oAlterar = new AlterarVenda();

                    oAlterar.MudarAtivacao(_venda);

                    foreach (var item in oldList)
                    {
                        oAlterar.aumentarEstoque(item);
                    }



                    if (MessageBox.Show("Deseja salvar alterações ( mais possivel alterar)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                    {
                        oAlterar.SalvarProduto(_venda);
                        
                    }

                    this.Close();
                    new ListagemDePedidos().Show();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
