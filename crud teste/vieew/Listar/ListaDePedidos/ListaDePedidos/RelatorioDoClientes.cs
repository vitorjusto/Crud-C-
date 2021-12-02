using crud_teste.controller;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos
{
    public partial class RelatorioDoClientes : Form
    {
        AlterarCliente oAlterar = new AlterarCliente();
        List<RelatorioClienteListagem> Clientes = new List<RelatorioClienteListagem>();

        public struct Pesquisa
        {
            public string Nome { get; set; }

            public DateTime DataInicial { get; set; }

            public DateTime DataFinal { get; set; }

            public string OrdernarPor { get; set; }

            public string crescente { get; set; }
        }

        public RelatorioDoClientes()
        {
            InitializeComponent();
        }

        private void RelatorioDoClientes_Load(object sender, EventArgs e)
        {
            Global.AtribuirTema(this);

            Clientes = oAlterar.RelatorioDeVenda();

            PreencherDataGrid(false);
            CalcularLucros(false);
        }

        private void PreencherDataGrid(bool comInativo)
        {
            DataGridViewCellStyle clienteinativo = new DataGridViewCellStyle();
            clienteinativo.BackColor = Color.SlateGray;
            clienteinativo.ForeColor = Color.White;

            dgvRelatorioDosClientes.Rows.Clear();
            var index = 0;
            foreach (var cliente in Clientes)
            {
                dgvRelatorioDosClientes.Rows.Add();
                dgvRelatorioDosClientes.Rows[index].Cells[0].Value = cliente.idcliente;
                dgvRelatorioDosClientes.Rows[index].Cells[1].Value = cliente.NomeCompleto();
                dgvRelatorioDosClientes.Rows[index].Cells[2].Value = cliente.QuantidadeDeVenda;
                dgvRelatorioDosClientes.Rows[index].Cells[3].Value = cliente.QuantidadeTotal;
                dgvRelatorioDosClientes.Rows[index].Cells[4].Value = cliente.TotalBruto.GetAsString();
                dgvRelatorioDosClientes.Rows[index].Cells[5].Value = cliente.TotalDeDesconto.GetAsString();
                dgvRelatorioDosClientes.Rows[index].Cells[6].Value = cliente.TotalDedescontoAVista.GetAsString();
                dgvRelatorioDosClientes.Rows[index].Cells[7].Value = cliente.TotalLiquido.GetAsString();
                dgvRelatorioDosClientes.Rows[index].Cells[8].Value = cliente.LimiteRestante.GetAsString();

                if (comInativo && !cliente.Ativo)
                {
                    var j = 0;
                    while (j < 9)
                    {

                        dgvRelatorioDosClientes.Rows[index].Cells[j].Style = clienteinativo;
                        j++;
                    }
                }
                else if (!comInativo && !cliente.Ativo)
                    dgvRelatorioDosClientes.Rows[index].Visible = false;
             

                index++;
            }

        }

        private void CalcularLucros(bool comInativo)
        {
            var lista = Clientes;
            if (lista.Count != 0)
            {
                if (!comInativo)
                    lista = lista.Where(x => x.Ativo).ToList();

                txtclientemaiscompra.Text = lista.OrderByDescending(x => x.QuantidadeTotal).First().NomeCompleto();
                txtClienteMaisCompraQuantidade.Text = lista.Max(x => x.QuantidadeTotal).ToString();
                txtClienteMaisLucrativo.Text = lista.OrderByDescending(x => x.TotalLiquido.GetAsDecimal()).First().NomeCompleto();
                txtClienteMaisLucrativoValor.Text = lista.Max(x => x.TotalLiquido.GetAsDecimal()).ToString("C");
                txtClienteFiel.Text = lista.OrderByDescending(x => x.QuantidadeDeVenda).First().NomeCompleto();
                txtMaximoDeVenda.Text = lista.Max(x => x.QuantidadeDeVenda).ToString();

                txtMenosLucrativo.Text = lista.OrderByDescending(x => x.TotalLiquido.GetAsDecimal()).Last().NomeCompleto();
                txtMenosLucrativoValor.Text = lista.Min(x => x.TotalLiquido.GetAsDecimal()).ToString("C");
                txtMenosVendido.Text = lista.OrderByDescending(x => x.QuantidadeTotal).Last().NomeCompleto();
                txtMenosVendidoQuantidade.Text = lista.Min(x => x.QuantidadeTotal).ToString();
            }
            else
            {
                txtclientemaiscompra.Text = "";
                txtClienteMaisCompraQuantidade.Text = "";
                txtClienteMaisLucrativo.Text = "";
                txtClienteMaisLucrativoValor.Text = "";
                txtClienteFiel.Text = "";
                txtMaximoDeVenda.Text = "";

                txtMenosLucrativo.Text = "";
                txtMenosLucrativoValor.Text = "";
                txtMenosVendido.Text = "";
                txtMenosVendidoQuantidade.Text = "";
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new vieew.ListaDePedidos.ListagemDePedidos().Show();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGrid(cbListarInativo.Checked);
            cbConsiderarInativo.Visible = cbListarInativo.Checked;

            if (cbListarInativo.Checked)
            {
                cbConsiderarInativo.Visible = true;
            }
            else
            {
                cbConsiderarInativo.Visible = false;
                cbConsiderarInativo.Checked = false;
                CalcularLucros(false);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisa pesquisa = new Pesquisa();

            pesquisa.Nome = txtCliente.Text;
            pesquisa.DataInicial = dtpDataInicial.Value;
            pesquisa.DataFinal = dtpDataFinal.Value;

            switch (cobTipo.SelectedIndex)
            { 
                case 0:
                    pesquisa.OrdernarPor = "c.idCliente";
                    break;
                case 1:
                    pesquisa.OrdernarPor = "sum(v.quantidadeTotal)";
                    break;
                case 2:
                    pesquisa.OrdernarPor = "sum(v.TotalDeDesconto)";
                    break;
                case 3:
                    pesquisa.OrdernarPor = "SUM(ca.PrecoDeVenda) - sum(ca.PrecoDeCusto)";
                    break;


            }

            switch(cobCrescente.SelectedIndex)
            {
                case 0:
                    pesquisa.crescente = "ASC";
                    break;
                case 1:
                    pesquisa.crescente = "DESC";
                    break;
            }

            Clientes = oAlterar.RelatorioDeVenda(pesquisa);
            PreencherDataGrid(cbListarInativo.Checked);
            CalcularLucros(cbConsiderarInativo.Visible);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = true;

    }
}
