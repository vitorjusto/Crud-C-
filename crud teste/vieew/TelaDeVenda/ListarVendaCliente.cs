using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
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

namespace crud_teste.vieew.TelaDeVenda
{
    public partial class ListarVendaCliente : Form
    {
        public AlterarCliente oAlterar = new AlterarCliente();
        public AlterarColaborador oAlterarColaborador = new AlterarColaborador();
        public AlterarProduto oAlterarProduto = new AlterarProduto();
        public string Buscar { get; set; }

        public List<Carrinho> carrinhos = new List<Carrinho>();


        public Produto produto = new Produto();
        public Cliente cliente = new Cliente();
        public Colaborador colaborador = new Colaborador();
        public ListarVendaCliente(string busca)
        {
            InitializeComponent();
            Buscar = busca;
            if (Buscar == "cliente")
                ListarClientes(oAlterar.ListarCliente());
            else if (Buscar == "colaborador")
                ListarColaboradores(oAlterarColaborador.ListarColaboradores());
            else if (Buscar == "produto")
            {
                ListarProdutos(oAlterarProduto.Listar());
            }

            dataGridGeral.AllowUserToAddRows = false;
            dataGridGeral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        public ListarVendaCliente(List<Carrinho> carrinhos, List<Produto> produtos)
        {
            ListarCarrinhos(carrinhos);
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            dataGridGeral.BackgroundColor = Global.BackgroundColor;


            textBoxinstrucao.BackColor = Global.BackgroundColor;
            textBoxinstrucao.ForeColor = Global.FontColor;
        }


        public void ListarClientes(List<ClienteListagem> clientes)
        {

            dataGridGeral.DataSource = clientes;
        }
        

        public void ListarColaboradores(List<ColaboradorListagem> colaboradores)
        {
            dataGridGeral.DataSource = colaboradores;
        }

       
        public void ListarProdutos(List<ProdutoListagem> produtos)
        {
            dataGridGeral.Columns.Add("IdProduto", "Id do Produto");
            dataGridGeral.Columns.Add("Nome", "nome");
            dataGridGeral.Columns.Add("PrecoDeVenda", "Preço de venda");
            dataGridGeral.Columns.Add("Estoque", "Estoque");
            dataGridGeral.Columns.Add("Fabricante", "Fabricante");

  
            int i = 0;
            foreach (var produto in produtos)
            {
                if (produto.Ativo)
                {
                    dataGridGeral.Rows.Add();
                    dataGridGeral.Rows[i].Cells[0].Value = produto.IdProduto;
                    dataGridGeral.Rows[i].Cells[1].Value = produto.nomeProduto;
                    dataGridGeral.Rows[i].Cells[2].Value = produto.PrecodeVenda;
                    dataGridGeral.Rows[i].Cells[3].Value = produto.Estoque;
                    dataGridGeral.Rows[i].Cells[4].Value = produto.fabricante;
                    i++;
                }

            }
        }  
        
        public void ListarCarrinhos(List<Carrinho> carrinho)
        {
            
           
        }
        

        private void dataGridCliente_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
           
          
            var x = int.Parse(dataGridGeral.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (Buscar == "cliente")
                cliente = oAlterar.consultarCliente(x);
            else if (Buscar == "colaborador")
                colaborador = oAlterarColaborador.consultarColaborador(x);
            else if (Buscar == "produto")
                produto = oAlterarProduto.Consultar(x);

            this.Dispose();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AlterarCliente oAlterar = new AlterarCliente();

            int.TryParse(CampoDePesquisa.Text, out int id);
            if (id > 0)
            {
                if (Buscar == "cliente")
                    ListarClientes(oAlterar.ListarCliente(CampoDePesquisa.Text, "id"));
                else if (Buscar == "colaborador")
                    ListarColaboradores(oAlterarColaborador.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "id"));
                else if (Buscar == "produto")
                    ListarProdutos(oAlterarProduto.Listar(CampoDePesquisa.Text, "id"));
            }
            else
            {
                if (Buscar == "cliente")
                    ListarClientes(oAlterar.ListarCliente(CampoDePesquisa.Text, "nome"));
                else if (Buscar == "colaborador")
                    ListarColaboradores(oAlterarColaborador.ListarColaboradoresPesquisado(CampoDePesquisa.Text, "nome"));
                else if (Buscar == "produto")
                    ListarProdutos(oAlterarProduto.Listar(CampoDePesquisa.Text, "nome"));
            }
        }

        private void ListarVendaCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridGeral_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CampoDePesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxinstrucao_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
