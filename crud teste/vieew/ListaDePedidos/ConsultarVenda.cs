using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Windows.Forms;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ConsultarVenda : Form
    {
        private Venda _venda = new Venda();
        private Pedido_Produto pedido = new Pedido_Produto();
        public ConsultarVenda(int id)
        {
            InitializeComponent();

            AlterarVenda oAlterar = new AlterarVenda();

            _venda = oAlterar.Consultar(id);

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
            new ListarItens(_venda.Pedido_Produto).ShowDialog();
        }

        private void ConsultarVenda_Load(object sender, EventArgs e)
        {

        }
    }
}
