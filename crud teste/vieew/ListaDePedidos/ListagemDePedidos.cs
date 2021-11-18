using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using crud_teste.Model.Object_Values;
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
        
            public MyDinheiro totalBruto { get; set; }
            public MyDinheiro totalDesconto { get; set; }

            public MyDinheiro totalGasto { get; set; }

            public MyDinheiro totalReceita { get; set; }

            public double lucro ()
            {
                return totalReceita.GetAsDouble() - totalBruto.GetAsDouble();
            }

            
            
        };

        private ValoresTotais valoresTotais = new ValoresTotais();
       
        public ListagemDePedidos()
        {
            InitializeComponent();

            this.BackColor = Global.BackgroundColor;
            ListarPedidos.BackgroundColor = Global.BackgroundColor;
            menuStrip1.BackColor = Global.BackgroundColor;
            NumeroDePedidos.BackColor = Global.BackgroundColor;
            NumeroDePedidos.ForeColor = Global.FontColor;

            txtTotalBruto.BackColor = Global.BackgroundColor;
            txtTotalBruto.ForeColor = Global.FontColor;

            txtDesconto.BackColor = Global.BackgroundColor;
            txtDesconto.ForeColor = Global.FontColor;

            txtTotalGasto.BackColor = Global.BackgroundColor;
            txtTotalGasto.ForeColor = Global.FontColor;

            txtTotalGasto.BackColor = Global.BackgroundColor;
            txtTotalGasto.ForeColor = Global.FontColor;

            txttotalLiquido.BackColor = Global.BackgroundColor;
            txttotalLiquido.ForeColor = Global.FontColor;

            txtLucro.BackColor = Global.BackgroundColor;
           

            pedidos = oAlterar.Listar();

            valoresTotais.totalBruto = new MyDinheiro();
            valoresTotais.totalDesconto = new MyDinheiro();
            valoresTotais.totalGasto = new MyDinheiro();
            valoresTotais.totalReceita = new MyDinheiro();
            
            var index = 0;
            foreach(var pedido in pedidos)
            {
                ListarPedidos.Rows.Add();
                ListarPedidos.Rows[index].Cells[0].Value = pedido.venda.IdVenda;
                ListarPedidos.Rows[index].Cells[1].Value = pedido.NomeCompletoCliente();
                ListarPedidos.Rows[index].Cells[2].Value = pedido.NomeCompletoColaborador();
                ListarPedidos.Rows[index].Cells[3].Value = pedido.venda.TipoDeVenda;
                ListarPedidos.Rows[index].Cells[4].Value = pedido.venda.MesesAPrazo == 0? "-": pedido.venda.MesesAPrazo.ToString();
                ListarPedidos.Rows[index].Cells[5].Value = pedido.venda.TotalBruto.GetAsString();
                ListarPedidos.Rows[index].Cells[6].Value = pedido.venda.TotalDeDesconto.GetAsString();
                ListarPedidos.Rows[index].Cells[7].Value = pedido.venda.TotalLiquido.GetAsString();
                ListarPedidos.Rows[index].Cells[8].Value = pedido.venda.QuantidadeUnitario;
                ListarPedidos.Rows[index].Cells[9].Value = pedido.venda.QuantidadeDeTotal;

                valoresTotais.totalBruto.Increment(pedido.venda.TotalBruto);
                valoresTotais.totalDesconto.Increment(pedido.venda.TotalDeDesconto);
                valoresTotais.totalGasto.Increment(pedido.TotalGasto());
                valoresTotais.totalReceita.Increment(pedido.TotalReceita()) ;

                index++;

            }

            ListarPedidos.AllowUserToAddRows = false;
           

            NumeroDePedidos.Text = pedidos.Count().ToString();
            txtTotalBruto.Text = valoresTotais.totalBruto.GetAsString();
            txtDesconto.Text = valoresTotais.totalDesconto.GetAsString();
            txtTotalGasto.Text = valoresTotais.totalGasto.GetAsString();
            txttotalLiquido.Text = valoresTotais.totalReceita.GetAsString();
            txtLucro.Text = valoresTotais.lucro().ToString(); 
            
            if(valoresTotais.lucro() > 0)
            {
                txtLucro.ForeColor = Color.Green;
            }else if(valoresTotais.lucro() < 0)
            {
                txtLucro.ForeColor = Color.Red;
            }else
            {
                txtLucro.ForeColor = Global.FontColor;
            }



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
