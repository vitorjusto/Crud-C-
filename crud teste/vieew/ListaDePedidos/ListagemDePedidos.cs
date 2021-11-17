using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ListagemDePedidos : Form
    {
        public List<PedidoListagem> pedidos = new List<PedidoListagem>();

        public AlterarVenda oAlterar = new AlterarVenda();

        public struct ValoresTotais
        {
        
            public float totalBruto { get; set; }
            public float totalDesconto { get; set; }

            public float totalGasto { get; set; }

            public float totalReceita { get; set; }

            public float lucro ()
            {
                return totalReceita - totalBruto;
            }

            
        };

        private ValoresTotais valoresTotais = new ValoresTotais();

        public ListagemDePedidos()
        {
            InitializeComponent();


            pedidos = oAlterar.Listar();

            var index = 0;
            foreach(var pedido in pedidos)
            {
                ListarPedidos.Rows.Add();
                ListarPedidos.Rows[index].Cells[0].Value = pedido.venda.IdVenda;
                ListarPedidos.Rows[index].Cells[1].Value = pedido.NomeCompletoCliente();
                ListarPedidos.Rows[index].Cells[2].Value = pedido.NomeCompletoColaborador();
                ListarPedidos.Rows[index].Cells[3].Value = pedido.venda.TipoDeVenda;
                ListarPedidos.Rows[index].Cells[4].Value = pedido.venda.MesesAPrazo == 0? "-": pedido.venda.MesesAPrazo.ToString();
                ListarPedidos.Rows[index].Cells[5].Value = pedido.venda.TotalBruto;
                ListarPedidos.Rows[index].Cells[6].Value = pedido.venda.TotalDeDesconto;
                ListarPedidos.Rows[index].Cells[7].Value = pedido.venda.TotalLiquido;
                ListarPedidos.Rows[index].Cells[8].Value = pedido.venda.QuantidadeUnitario;
                ListarPedidos.Rows[index].Cells[9].Value = pedido.venda.QuantidadeDeTotal;

                valoresTotais.totalBruto += pedido.venda.TotalBruto;
                valoresTotais.totalDesconto += pedido.venda.TotalDeDesconto;
                valoresTotais.totalGasto += pedido.TotalGasto();
                valoresTotais.totalReceita += pedido.TotalReceita() ;

                index++;

            }

            ListarPedidos.AllowUserToAddRows = false;

            NumeroDePedidos.Text = pedidos.Count().ToString();
            txtTotalBruto.Text = valoresTotais.totalBruto.ToString();
            txtDesconto.Text = valoresTotais.totalDesconto.ToString();
            txtTotalGasto.Text = valoresTotais.totalGasto.ToString();
            txttotalLiquido.Text = valoresTotais.totalReceita.ToString();
            txtLucro.Text = valoresTotais.lucro().ToString(); 
            




        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ListagemDePedidos_Load(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListarClientes().Show();
        }
    }
}
