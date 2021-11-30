using crud_teste.controller;
using crud_teste.Model.Listagem;
using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ListagemDePedidos : Form
    {
        public List<PedidoListagem> pedidos = new List<PedidoListagem>();

        public AlterarVenda oAlterar = new AlterarVenda();

        public struct ValoresTotais
        {
            public List<PedidoListagem> pedidosAtivos { get; set; }
            public double totalBruto { get => pedidosAtivos.Sum(x => x.TotalBruto.GetAsDouble()); }
            public double totalDesconto { get => pedidosAtivos.Sum(x => x.TotalDeDesconto.GetAsDouble()); }

            public double totalGasto { get => pedidosAtivos.Sum(x => x.TotalGasto()); }

            public double totalReceita { get => pedidosAtivos.Sum(x => x.TotalReceita()); }

            public double lucro { get => totalReceita - totalGasto; }

        };

        private ValoresTotais valoresTotais = new ValoresTotais();
       
        public ListagemDePedidos()
        {
            InitializeComponent();

            Global.AtribuirTema(this);

            pedidos = oAlterar.Listar();


            DataGridViewCellStyle vendainativa = new DataGridViewCellStyle();
            vendainativa.BackColor = Color.SlateGray;
            vendainativa.ForeColor = Color.White;

            ValoresTotais valoresTotais = new ValoresTotais();
            valoresTotais.pedidosAtivos = new List<PedidoListagem>();
           
            var index = 0;
            foreach(var pedido in pedidos)
            {
                ListarPedidos.Rows.Add();
                ListarPedidos.Rows[index].Cells[0].Value = pedido.IdVenda;
                ListarPedidos.Rows[index].Cells[1].Value = pedido.NomeCompletoCliente();
                ListarPedidos.Rows[index].Cells[2].Value = pedido.NomeCompletoColaborador();
                ListarPedidos.Rows[index].Cells[3].Value = pedido.TipoDeVenda;
                ListarPedidos.Rows[index].Cells[4].Value = pedido.MesesAPrazo == 0? "-": pedido.MesesAPrazo.ToString();
                ListarPedidos.Rows[index].Cells[5].Value = pedido.TotalBruto.GetAsString();
                ListarPedidos.Rows[index].Cells[6].Value = pedido.TotalDeDesconto.GetAsString();
                ListarPedidos.Rows[index].Cells[7].Value = pedido.TotalLiquido.GetAsString();
                ListarPedidos.Rows[index].Cells[8].Value = pedido.quantidadeunitario;
                ListarPedidos.Rows[index].Cells[9].Value = pedido.QuantidadeTotal;


                if (pedido.ativo)
                {
                    valoresTotais.pedidosAtivos.Add(pedido);
                }else
                {
                    var j = 0;
                    while (j < 10)
                    {
                        ListarPedidos.Rows[index].Cells[j].Style = vendainativa;
                        j++;
                    }
                }

                index++;

            }

            ListarPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            ListarPedidos.AllowUserToAddRows = false;
           
            NumeroDePedidos.Text = pedidos.Count().ToString();
            txtTotalBruto.Text = valoresTotais.totalBruto.ToString("C2");
            txtDesconto.Text = valoresTotais.totalDesconto.ToString("C2");
            txtTotalGasto.Text = valoresTotais.totalGasto.ToString("C2");
            txttotalLiquido.Text = valoresTotais.totalReceita.ToString("C2");
            txtLucro.Text = valoresTotais.lucro.ToString("C2"); 
            
            if(valoresTotais.lucro > 0)
                txtLucro.ForeColor = Color.Green;
            else if(valoresTotais.lucro < 0)
                txtLucro.ForeColor = Color.Red;
            else
                txtLucro.ForeColor = Global.FontColor;

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListarClientes().Show();
        }

        private void ListarPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var x = int.Parse(ListarPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());

                this.Close();
                new ConsultarVenda(x).Show();

        }

        private void ListagemDePedidos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
