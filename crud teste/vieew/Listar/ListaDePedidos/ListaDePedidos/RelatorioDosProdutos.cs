using crud_teste.controller;
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

namespace crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos
{
    public partial class RelatorioDosProdutos : Form
    {
        AlterarProduto oAlterar = new AlterarProduto();

        List<RelatorioProdutosVendaListagem> _produtos = new List<RelatorioProdutosVendaListagem>();

        public RelatorioDosProdutos()
        {
            InitializeComponent();
            _produtos = oAlterar.RelatorioDeVendaDosProdutos();


        }

        private void preencherDataGrid(bool comAtivo)
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
            DataGridRelatorioDeProduto.AllowUserToAddRows = false;
            DataGridRelatorioDeProduto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void calcularLucros(bool comInativo)
        {
            if (comInativo)
            {
                txtMaisLucrativoTotal.Text = _produtos.Max(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMaisLucrativo.Text = _produtos.OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).First().nomeProduto;

                txtMaisVendidaTotal.Text = _produtos.Max(x => x.Quantidade).ToString();
                txtMaisVendido.Text = _produtos.OrderByDescending(x => x.Quantidade).First().nomeProduto;


                txtMenosLucrativoTotal.Text = _produtos.Min(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMenosLucrativo.Text = _produtos.OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).Last().nomeProduto;

                txtMenosVendidaTotal.Text = _produtos.Min(x => x.Quantidade).ToString();
                txtMenosVendido.Text = _produtos.OrderByDescending(x => x.Quantidade).Last().nomeProduto;
            }
            else
            {
                txtMaisLucrativoTotal.Text = _produtos.Where(x => x.Ativo).Max(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMaisLucrativo.Text = _produtos.Where(x => x.Ativo).OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).First().nomeProduto;

                txtMaisVendidaTotal.Text = _produtos.Where(x => x.Ativo).Max(x => x.Quantidade).ToString();
                txtMaisVendido.Text = _produtos.Where(x => x.Ativo).OrderByDescending(x => x.Quantidade).First().nomeProduto;


                txtMenosLucrativoTotal.Text = _produtos.Where(x => x.Ativo).Min(x => x.LucroEmDinheiro.GetAsDecimal()).ToString("C");
                txtMenosLucrativo.Text = _produtos.Where(x => x.Ativo).OrderByDescending(x => x.LucroEmDinheiro.GetAsDecimal()).Last().nomeProduto;

                txtMenosVendidaTotal.Text = _produtos.Where(x => x.Ativo).Min(x => x.Quantidade).ToString();
                txtMenosVendido.Text = _produtos.Where(x => x.Ativo).OrderByDescending(x => x.Quantidade).Last().nomeProduto;
            }

        }



        private void RelatorioDosProdutos_Load(object sender, EventArgs e)
        {
            Global.AtribuirTema(this);
            preencherDataGrid(false);
            calcularLucros(false);
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new vieew.ListaDePedidos.ListagemDePedidos().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            preencherDataGrid(checkBox1.Checked);
            if(checkBox1.Checked)
            {
                checkBox2.Visible = true;
            }else
            {
                checkBox2.Visible = false;
                checkBox2.Checked = false;
                calcularLucros(false);
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            calcularLucros(checkBox2.Checked);
        }
    }
}
