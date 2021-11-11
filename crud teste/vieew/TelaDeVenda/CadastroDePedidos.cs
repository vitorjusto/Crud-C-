using crud_teste.Model;
using crud_teste.vieew.TelaDeVenda;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.vieew
{
    public partial class CadastroDePedidos : Form
    {

        public Cliente cliente = new Cliente();
        public Colaborador colaborador = new Colaborador();
        public Produto produto = new Produto();
        public CadastroDePedidos()
        {
            InitializeComponent();
        }

        
        private void NomeCliente_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("cliente");
            listar.ShowDialog();

            cliente = listar.cliente;
            NomeCliente.Text = cliente.nomeCompleto();

        }

        private void CadastroDePedidos_Load(object sender, EventArgs e)
        {

        }

        private void NomeCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void NomeDoColaborador_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("colaborador");
            listar.ShowDialog();
            colaborador = listar.colaborador;
            NomeDoColaborador.Text = colaborador.nomeCompleto();

        }

        private void NomeDoProduto_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void NomeDoProduto_DoubleClick(object sender, EventArgs e)
        {
            var listar = new ListarVendaCliente("produto");
            listar.ShowDialog();

            produto = listar.produto;
            NomeDoProduto.Text = produto.NomeDoProduto;
            QuantidadeEmEstoque.Text = produto.Estoque.ToString();
            PrecoUnitario.Text =  produto.PrecoDeVenda.ToString();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.isNotIntChar(e.KeyChar);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (Quantidade.Text != "" && QuantidadeEmEstoque.Text != "")
            {
                QuantidadeRestante.Text = (long.Parse(QuantidadeEmEstoque.Text) - long.Parse(Quantidade.Text)).ToString();
                PrecoBruto.Text = (produto.PrecoDeVenda * long.Parse(Quantidade.Text)).ToString();
            }
            else
                QuantidadeRestante.Text = "";
        }
    }
}
