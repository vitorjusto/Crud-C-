using crud_teste.Config;
using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using crud_teste.Model.Object_Values;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos
{
    public partial class RelatorioDoClientes : Form
    {
        AlterarCliente oAlterar = new AlterarCliente();
        List<RelatorioClienteListagem> Clientes = new List<RelatorioClienteListagem>();

       

        public RelatorioDoClientes()
        {
            InitializeComponent();
        }

        private void RelatorioDoClientes_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
            gbPesquisarPorData.Visible = false;
            gbCondicao.Visible = false;

            Clientes = oAlterar.RelatorioDeVenda();

            PreencherDataGrid();
            CalcularLucros(false);
            txtValorFinal.Text = MyDinheiro.SetTextBoxAsMoneyValue("");
            txtValorInicial.Text = MyDinheiro.SetTextBoxAsMoneyValue("");
        }

        private void PreencherDataGrid()
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

                if (!cliente.Ativo)
                {
                    var j = 0;
                    while (j < 9)
                    {

                        dgvRelatorioDosClientes.Rows[index].Cells[j].Style = clienteinativo;
                        j++;
                    }
                }
                else if (!cliente.Ativo)
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

                txtQuantidadesDeProdutos.Text = lista.Sum(x => x.QuantidadeTotal).ToString();
                txtTotalDeVendas.Text = lista.Sum(x => x.QuantidadeDeVenda).ToString();
                txtTotalBruto.Text = lista.Sum(x => x.TotalBruto.GetAsDecimal()).ToString("C2");
                txtTotalDeDesconto.Text = lista.Sum(x => x.TotalDeDesconto.GetAsDecimal() + x.TotalDedescontoAVista.GetAsDecimal()).ToString("c2");
                txtTotalLiquido.Text = lista.Sum(x => x.TotalLiquido.GetAsDecimal()).ToString("C2");

                var lucro = lista.Sum(x => x.TotalLiquido.GetAsDecimal() - x.PrecoDeCusto.GetAsDecimal());
                txtLucro.Text = lucro.ToString("C2");


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


                txtQuantidadesDeProdutos.Text = "";
                txtTotalDeVendas.Text = "";
                txtTotalBruto.Text = "";
                txtTotalDeDesconto.Text = "";
                txtTotalLiquido.Text = "";
                txtLucro.Text = "";

            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new vieew.ListaDePedidos.ListagemDePedidos().Show();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGrid();
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
            FiltroRelatorioCliente pesquisa = new FiltroRelatorioCliente();

            if (!chkPesquisarPorData.Checked || Global.ValidarDatas(dtpDataInicial.Value, dtpDataFinal.Value))
            {
                pesquisa.GerarSql
                    (
                        txtCliente.Text,
                        chkPesquisarPorData.Checked,
                        dtpDataInicial.Value,
                        dtpDataFinal.Value,
                        cobTipo.SelectedIndex,
                        cobCrescente.SelectedIndex,
                        cobCondicao.SelectedIndex,
                        cbcondicaopor.SelectedIndex,
                        chkCondicao.Checked,
                        txtValorInicial.Text,
                        txtValorFinal.Text,
                        cbTop.Checked,
                        long.Parse(txtTop.Text == "" ? "0" : txtTop.Text),
                        !cbListarInativo.Checked
                    );

                Clientes = oAlterar.RelatorioDeVenda(pesquisa);
                PreencherDataGrid();
                CalcularLucros(cbConsiderarInativo.Checked);
            }
            else
                new CaixaDeAviso().MensagemDeOk("Data Inicial é maior que a Data Final");
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e) =>
            e.Handled = true;

        private void cbConsiderarInativo_CheckedChanged(object sender, EventArgs e)
        {
            CalcularLucros(cbConsiderarInativo.Checked);
        }

        private void txtValorInicial_Leave(object sender, EventArgs e)
        {
            if (cbcondicaopor.SelectedIndex != 1)
                txtValorInicial.Text = MyDinheiro.SetTextBoxAsMoneyValue(txtValorInicial.Text);
            else
                txtValorInicial.Text = Global.setTextBoxAsIntText(txtValorInicial.Text);
        }

        private void cobCondicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cobCondicao.SelectedIndex == 6)
            {
                txtValorFinal.Visible = true;
                label16.Visible = true;
            }else
            {
                txtValorFinal.Visible = false;
                label16.Visible = false;
            }
        }

        private void txtValorFinal_Leave(object sender, EventArgs e)
        {
            if(cbcondicaopor.SelectedIndex != 1)
                txtValorFinal.Text = MyDinheiro.SetTextBoxAsMoneyValue(txtValorFinal.Text);
            else
                txtValorFinal.Text = Global.setTextBoxAsIntText(txtValorFinal.Text);
        }

        private void cobCondicao_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbTop_CheckedChanged(object sender, EventArgs e)
        {
            txtTop.Visible = cbTop.Checked;
        }

        private void txtTop_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotIntText(e.KeyChar, txtTop.Text);
        }

        private void txtTop_Leave(object sender, EventArgs e)
        {
            txtTop.Text = txtTop.Text.Equals("") ? "0" : txtTop.Text;
        }

        private void chkPesquisarPorData_CheckedChanged(object sender, EventArgs e)
        {
            gbPesquisarPorData.Visible = chkPesquisarPorData.Checked;
        }

        private void cobCrescente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbcondicaopor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcondicaopor.SelectedIndex == 1)
            {
                txtValorInicial.Text = Global.setTextBoxAsIntText(txtValorInicial.Text);
                txtValorFinal.Text = Global.setTextBoxAsIntText(txtValorFinal.Text);

            }
            else
            {
                txtValorInicial.Text = Dinheiro.converterParaDinheiro(txtValorInicial.Text);
                txtValorFinal.Text = Dinheiro.converterParaDinheiro(txtValorFinal.Text);
            }
        }

        private void chkCondicao_CheckedChanged(object sender, EventArgs e)
        {
            gbCondicao.Visible = chkCondicao.Checked;
        }

        private void cbcondicaopor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
