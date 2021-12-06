using crud_teste.controller;
using crud_teste.Model.Listagem;
using crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos;
using crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ListagemDePedidos : Form
    {
        public List<PedidoListagem> pedidos = new List<PedidoListagem>();

        public AlterarVenda oAlterar = new AlterarVenda();

        public struct pesquisar
        {
            public string nomeCliente { get; set; }
            public string nomeColaborador { get; set; }
            public string nomeProduto { get; set; }

            public bool PesquisarPorData { get; set; }

            public DateTime dataInicial { get; set; }
            public DateTime dataFinal { get; set; }
        }

       
        public ListagemDePedidos()
        {
            InitializeComponent();

            Temas.AtribuirTema(this);

            pedidos = oAlterar.Listar();

            ListarECalcularValores();

            gbPesquisarPorData.Visible = false;
        }

        private void ListarECalcularValores()
        {


            DataGridViewCellStyle vendainativa = new DataGridViewCellStyle();
            vendainativa.BackColor = Color.SlateGray;
            vendainativa.ForeColor = Color.White;

            ListarPedidos.Rows.Clear();
            var index = 0;
            foreach (var pedido in pedidos)
            {
                ListarPedidos.Rows.Add();
                ListarPedidos.Rows[index].Cells[0].Value = pedido.IdVenda;
                ListarPedidos.Rows[index].Cells[1].Value = pedido.NomeCompletoCliente();
                ListarPedidos.Rows[index].Cells[2].Value = pedido.NomeCompletoColaborador();
                ListarPedidos.Rows[index].Cells[3].Value = pedido.TipoDeVenda;
                ListarPedidos.Rows[index].Cells[4].Value = pedido.MesesAPrazo == 0 ? "-" : pedido.MesesAPrazo.ToString();
                ListarPedidos.Rows[index].Cells[5].Value = pedido.TotalBruto.GetAsString();
                ListarPedidos.Rows[index].Cells[6].Value = pedido.TotalDeDesconto.GetAsString();
                ListarPedidos.Rows[index].Cells[7].Value = pedido.TotalLiquido.GetAsString();
                ListarPedidos.Rows[index].Cells[8].Value = pedido.quantidadeunitario;
                ListarPedidos.Rows[index].Cells[9].Value = pedido.QuantidadeTotal;
                ListarPedidos.Rows[index].Cells[10].Value = pedido.DiaDavenda.ToString("dd/MM/yyyy");


                
                if(!pedido.ativo)
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
            txtTotalBruto.Text = pedidos.Sum(x => x.ativo? x.TotalBruto.GetAsDecimal() : 0.0M).ToString("C2");
            txtDesconto.Text = pedidos.Sum(x => x.ativo ? x.TotalDeDesconto.GetAsDecimal() + x.DescontoAVIsta.GetAsDecimal() : 0.0M).ToString("C2");
            txtTotalGasto.Text = pedidos.Sum(x => x.ativo ? x.TotalGasto() : 0.0).ToString("C2");
            txttotalLiquido.Text = pedidos.Sum(x => x.ativo ? x.TotalLiquido.GetAsDecimal() : 0.0M).ToString("C2");

            var lucro = pedidos.Sum(x => x.ativo ? x.TotalLiquido.GetAsDecimal() : 0.0M) - (decimal)pedidos.Sum(x => x.ativo ? x.TotalGasto() : 0.0);

            txtLucro.Text = lucro.ToString("C2");
            
            if (lucro > 0)
                txtLucro.ForeColor = Color.Green;
            else if (lucro < 0)
                txtLucro.ForeColor = Color.Red;
            else
                txtLucro.ForeColor = Temas.FontColor;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new RelatorioDosProdutos().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pesquisar pesquisa = new pesquisar();

            pesquisa.nomeCliente = txtCliente.Text;
            pesquisa.nomeColaborador = txtColaborador.Text;
            pesquisa.nomeProduto = txtProduto.Text;

            if (chkPesquisarPorData.Checked)
            {
                pesquisa.PesquisarPorData = true;
                pesquisa.dataInicial = dtpDataInicial.Value.Date;
                pesquisa.dataFinal = dtpDataFinal.Value.Date;

                if (!Global.ValidarDatas(pesquisa.dataInicial, pesquisa.dataFinal))
                {
                    MessageBox.Show("Data Inicial vem depois da data Final");
                    return;
                }
            }
            pedidos = oAlterar.Listar(pesquisa);
            ListarECalcularValores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new RelatorioDoClientes().Show();
        }

        private void chkPesquisarPorData_CheckedChanged(object sender, EventArgs e)
        {
            gbPesquisarPorData.Visible = chkPesquisarPorData.Checked;
        }
    }
}
