﻿using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Windows.Forms;

namespace crud_teste.vieew.Consultar
{
    public partial class ConsultarProduto : Form
    {
        public Produto produtoGlobal = new Produto();
        AlterarProduto oAlterar = new AlterarProduto();
        public ConsultarProduto(int id)
        {
            InitializeComponent();

            produtoGlobal.IdProduto = id;
            produtoGlobal = oAlterar.Consultar(id);
            atribuirCampos(produtoGlobal);

        }

        public void atribuirCampos(Produto produto)
        {
            NomeDoProduto.Text = produto.NomeDoProduto;
            CodigoDeBarras.Text = produto.CodigoDeBarras;
            PrecoDeVenda.Text = produto.PrecoDeVenda.ToString();
            DescontoAVista.Text = produto.DescontoAVista.ToString();
            PrecoDeCusto.Text = produto.PrecoDeCusto.ToString();
            Estoque.Text = produto.Estoque.ToString();
            Ativo.Checked = produto.Ativo;
            Fabricante.Text = produto.Fabricante;
        }

        public void RecuperarCampos()
        {
            produtoGlobal.NomeDoProduto = NomeDoProduto.Text;
            produtoGlobal.CodigoDeBarras = CodigoDeBarras.Text ;
            produtoGlobal.PrecoDeVenda = float.Parse(PrecoDeVenda.Text);
            produtoGlobal.DescontoAVista = float.Parse(DescontoAVista.Text);
            produtoGlobal.PrecoDeCusto = float.Parse(PrecoDeCusto.Text);
            produtoGlobal.Estoque = long.Parse(Estoque.Text);
            produtoGlobal.Ativo = Ativo.Checked ;
            produtoGlobal.Fabricante = Fabricante.Text ;
        }

        private void BotaoSalvar_Click(object sender, EventArgs e)
        {
            RecuperarCampos();
            try
            {
                if (MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oAlterar.Salvar(produtoGlobal);
                    MessageBox.Show("Produto alterado com sucesso");
                    new ListarProduto().Show();
                    this.Close();
                }
            }catch
            {
                MessageBox.Show("Fala ao conectar com o banco de dados");
            }
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo voltar a pagina de listagem?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ListarProduto().Show();
                this.Hide();
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos Permanentemente)?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    oAlterar.Excluir(produtoGlobal.IdProduto);
                    MessageBox.Show("Produto excluido com sucesso");
                    new ListarProduto().Show();
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Fala ao conectar com o banco de dados");
            }
        }
    }
}