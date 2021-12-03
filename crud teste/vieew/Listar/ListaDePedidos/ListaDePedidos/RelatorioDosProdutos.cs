﻿using crud_teste.controller;
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


                //txtQuantidadesDeProdutos.Text = lista.Sum(x => x.Quantidade).ToString();
                //txtTotalBruto.Text = lista.Sum(x => x.TotalBruto.GetAsDecimal()).ToString("C2");
                //txtTotalDeDesconto.Text = lista.Sum(x => x.TotalDeDesconto.GetAsDecimal() + x.TotalDedescontoAVista.GetAsDecimal()).ToString("c2");
                //txtTotalLiquido.Text = lista.Sum(x => x.TotalLiquido.GetAsDecimal()).ToString("C2");
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
            Global.AtribuirTema(this);
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
            _produtos = oAlterar.RelatorioDeVendaDosProdutos(txtCliente.Text, txtProduto.Text, dtpDataInicial.Value, dtpDataFinal.Value);
            PreencherDataGrid(checkBox1.Checked);
            CalcularLucros(checkBox2.Checked);
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
