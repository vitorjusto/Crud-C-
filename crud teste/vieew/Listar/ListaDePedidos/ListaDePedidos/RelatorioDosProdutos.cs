using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model.Listagem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos
{
    public partial class RelatorioDosProdutos : Form
    {
        AlterarProduto oAlterar = new AlterarProduto();

        List<RelatorioProdutosVendaListagem> _produtos = new List<RelatorioProdutosVendaListagem>();

        public struct pesquisar
        {
            public string nomeDoCliente { get; set; }

            public string nomeDoProduto { get; set; }

            public bool pesquisarPorData { get; set; }

            public DateTime DataInicial { get; set; }
            public DateTime DataFinal { get; set; }
        }

        public RelatorioDosProdutos()
        {
            InitializeComponent();
            _produtos = oAlterar.RelatorioDeVendaDosProdutos();

            gbListarPorData.Visible = false;

        }

        private void PreencherDataGrid(bool comAtivo)
        {
            DataGridViewCellStyle  produtoinativo = new DataGridViewCellStyle();
            produtoinativo.BackColor = Color.SlateGray;
            produtoinativo.ForeColor = Color.White;

            DataGridRelatorioDeProduto.Rows.Clear();
            var index = 0;
            foreach (var produto in _produtos)
            {
                DataGridRelatorioDeProduto.Rows.Add();
                DataGridRelatorioDeProduto.Rows[index].Cells[0].Value = produto.idProduto;
                DataGridRelatorioDeProduto.Rows[index].Cells[1].Value = produto.nomeProduto;
                DataGridRelatorioDeProduto.Rows[index].Cells[2].Value = produto.Quantidade;
                DataGridRelatorioDeProduto.Rows[index].Cells[3].Value = produto.TotalBruto;
                DataGridRelatorioDeProduto.Rows[index].Cells[4].Value = produto.Desconto;
                DataGridRelatorioDeProduto.Rows[index].Cells[5].Value = produto.TotalLiquido;
                DataGridRelatorioDeProduto.Rows[index].Cells[6].Value = produto.TotalCusto;
                DataGridRelatorioDeProduto.Rows[index].Cells[7].Value = produto.TotalPrecoDeVenda;
                DataGridRelatorioDeProduto.Rows[index].Cells[8].Value = produto.LucroEmPorcento;
                DataGridRelatorioDeProduto.Rows[index].Cells[9].Value = produto.LucroEmDinheiro;
                
                if(comAtivo && !produto.Ativo)
                {
                    var j = 0;
                    while (j < 10)
                    {
                        DataGridRelatorioDeProduto.Rows[index].Cells[j].Style = produtoinativo;
                        j++;
                    }
                }else if(!comAtivo && !produto.Ativo)
                {
                    DataGridRelatorioDeProduto.Rows[index].Visible = false;
                }
                index++;
            }

        }

        private void CalcularLucros(bool comInativo)
        {
            var lista = _produtos;
            if (lista.Count != 0)
            {
                if (!comInativo)
                    lista = lista.Where(x => x.Ativo).ToList();

                txtMaisLucrativoTotal.Text = lista.Max(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMaisLucrativo.Text = lista.OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).First().nomeProduto;

                txtMaisVendidaTotal.Text = lista.Max(x => x.Quantidade).ToString();
                txtMaisVendido.Text = lista.OrderByDescending(x => x.Quantidade).First().nomeProduto;


                txtMenosLucrativoTotal.Text = lista.Min(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMenosLucrativo.Text = lista.OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).Last().nomeProduto;

                txtMenosVendidaTotal.Text = lista.Min(x => x.Quantidade).ToString();
                txtMenosVendido.Text = lista.OrderByDescending(x => x.Quantidade).Last().nomeProduto;

                txtQuantidadesDeProdutos.Text = lista.Sum(x => x.Quantidade).ToString();
                txtTotalBruto.Text = lista.Sum(x => x.TotalBruto.GetAsDecimal()).ToString("C");
                txtTotalDeDesconto.Text = lista.Sum(x => x.Desconto.GetAsDecimal()).ToString("C");
                txtTotalLiquido.Text = lista.Sum(x => x.TotalLiquido.GetAsDecimal()).ToString("C");
                txtTotalGasto.Text = lista.Sum(x => x.TotalCusto.GetAsDecimal()).ToString("C");


                var lucro = lista.Sum(x => x.LucroEmDinheiro.GetAsDecimal());
                txtLucro.Text = lucro.ToString("C");

                if (lucro > 0.0M)
                    txtLucro.ForeColor = Temas.Positive;
                else if (lucro < 0.0M)
                    txtLucro.ForeColor = Temas.Negative;

            }
            else
            {
                txtMaisLucrativoTotal.Text = "";
                txtMaisLucrativo.Text = "";

                txtMaisVendidaTotal.Text = "";
                txtMaisVendido.Text = "";

                txtMenosLucrativoTotal.Text = "";
                txtMenosLucrativo.Text = "";

                txtMenosVendidaTotal.Text = "";
                txtMenosVendido.Text = "";
            }



        }



        private void RelatorioDosProdutos_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
            PreencherDataGrid(false);
            CalcularLucros(false);
        }

        private void VoltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new vieew.ListaDePedidos.ListagemDePedidos().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PreencherDataGrid(checkBox1.Checked);
            if(checkBox1.Checked)
            {
                checkBox2.Visible = true;
            }else
            {
                checkBox2.Visible = false;
                checkBox2.Checked = false;
                CalcularLucros(false);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalcularLucros(checkBox2.Checked);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            pesquisar pesquisa = new pesquisar();
            pesquisa.nomeDoCliente = txtCliente.Text;
            pesquisa.nomeDoProduto = txtProduto.Text;

            if (chkPesquisarPorData.Checked)
            {
                pesquisa.pesquisarPorData = true;
                pesquisa.DataInicial = dtpDataInicial.Value;
                pesquisa.DataFinal = dtpDataFinal.Value;


                if (!Global.ValidarDatas(dtpDataInicial.Value, dtpDataFinal.Value))
                {
                    new CaixaDeAviso().MensagemDeOk("Data Inicial vem depois da data Final");
                    return;
                }
            }


            _produtos = oAlterar.RelatorioDeVendaDosProdutos(pesquisa);
            PreencherDataGrid(checkBox1.Checked);
            CalcularLucros(checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            gbListarPorData.Visible = chkPesquisarPorData.Checked;
        }
    }
}
