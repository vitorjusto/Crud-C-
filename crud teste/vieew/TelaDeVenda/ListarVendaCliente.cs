using crud_teste.controller;
using crud_teste.Model;
using crud_teste.Model.Listagem;
using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.TelaDeVenda
{
    public partial class ListarVendaCliente : Form
    {
        public AlterarCliente oAlterar = new AlterarCliente();
        public AlterarColaborador oAlterarColaborador = new AlterarColaborador();
        public AlterarProduto oAlterarProduto = new AlterarProduto();
        public string Buscar { get; set; }

        public List<Pedido_Produto> carrinhos = new List<Pedido_Produto>();

        public List<ProdutoListagem> produtos = new List<ProdutoListagem>();

        public Produto produto = new Produto();
        public Cliente cliente = new Cliente();
        public Colaborador colaborador = new Colaborador();
        public ListarVendaCliente(string busca, string entrada)
        {
            InitializeComponent();

            Temas.AtribuirTema(this);


            Buscar = busca;

            CampoDePesquisa.Text = entrada;

            if (Buscar == "cliente")
                ListarClientes(oAlterar.ListarClienteAtivos(entrada, "nome"));
            else if (Buscar == "colaborador")
                ListarColaboradores(oAlterarColaborador.ListarColaboradoresAtivos(entrada, "nome"));
            else if (Buscar == "produto")
            {
                ListarProdutos(oAlterarProduto.ListarAtivo());
            }

            dataGridGeral.AllowUserToAddRows = false;
            dataGridGeral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        public ListarVendaCliente(string busca, List<Pedido_Produto> carrinhos)
        {


            InitializeComponent();

            Temas.AtribuirTema(this);

            dataGridGeral.Rows.Clear();
            dataGridGeral.Columns.Clear();

            Buscar = busca;

            dataGridGeral.Columns.Add("IdProduto", "Id do Produto");
            dataGridGeral.Columns.Add("Nome", "nome");
            dataGridGeral.Columns.Add("PrecoDeVenda", "Preço de venda");
            dataGridGeral.Columns.Add("Estoque", "Estoque");
            dataGridGeral.Columns.Add("Fabricante", "Fabricante");
            produtos = oAlterarProduto.ListarAtivo();

            int i = 0;
            foreach (var produto in produtos)
            {

                dataGridGeral.Rows.Add();
                dataGridGeral.Rows[i].Cells[0].Value = produto.IdProduto;
                dataGridGeral.Rows[i].Cells[1].Value = produto.nomeProduto;
                dataGridGeral.Rows[i].Cells[2].Value = produto.PrecodeVenda;
                dataGridGeral.Rows[i].Cells[4].Value = produto.fabricante;
                foreach (var item in carrinhos)
                {
                    if (produto.IdProduto == item.produto.IdProduto)
                    {
                        dataGridGeral.Rows[i].Visible = false;
                    }

                }

                dataGridGeral.Rows[i].Cells[3].Value = produto.Estoque;

                i++;


            }


            dataGridGeral.AllowUserToAddRows = false;
            dataGridGeral.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);

        }


        public void ListarClientes(List<ClienteListagem> clientes)
        {

            dataGridGeral.Rows.Clear();
            dataGridGeral.Columns.Clear();

            dataGridGeral.Columns.Add("IdCliente", "Id do Cliente");
            dataGridGeral.Columns.Add("Nome", "Nome Completo");
            dataGridGeral.Columns.Add("Sexo", "Sexo");
            dataGridGeral.Columns.Add("DataDeNascimento", "Data De Nascimento");
            dataGridGeral.Columns.Add("Endereco", "Endereço");
            dataGridGeral.Columns.Add("Contato", "Contato");


            int i = 0;
            foreach (var cliente in clientes)
            {

                dataGridGeral.Rows.Add();
                dataGridGeral.Rows[i].Cells[0].Value = cliente.idcliente;
                dataGridGeral.Rows[i].Cells[1].Value = cliente.nomecompleto;
                dataGridGeral.Rows[i].Cells[2].Value = cliente.Sexo;
                dataGridGeral.Rows[i].Cells[3].Value = cliente.DataDeNascimento;
                dataGridGeral.Rows[i].Cells[4].Value = cliente.Endereço;
                dataGridGeral.Rows[i].Cells[5].Value = cliente.Contato;
                i++;


            }
        }
        

        public void ListarColaboradores(List<ColaboradorListagem> colaboradores)
        {
            dataGridGeral.Rows.Clear();
            dataGridGeral.Columns.Clear();

            dataGridGeral.Columns.Add("IdCliente", "Id do Cliente");
            dataGridGeral.Columns.Add("Nome", "Nome Completo");
            dataGridGeral.Columns.Add("Sexo", "Sexo");
            dataGridGeral.Columns.Add("Salario", "Salário");
            dataGridGeral.Columns.Add("DataDeNascimento", "Data De Nascimento");
            dataGridGeral.Columns.Add("Endereco", "Endereço");
            dataGridGeral.Columns.Add("Contato", "Contato");


            int i = 0;
            foreach (var colaborador in colaboradores)
            {

                dataGridGeral.Rows.Add();
                dataGridGeral.Rows[i].Cells[0].Value = colaborador.idColaborador;
                dataGridGeral.Rows[i].Cells[1].Value = colaborador.NomeCompleto;
                dataGridGeral.Rows[i].Cells[2].Value = colaborador.sexo;
                dataGridGeral.Rows[i].Cells[3].Value = colaborador.salario;
                dataGridGeral.Rows[i].Cells[4].Value = colaborador.DataDeNascimento;
                dataGridGeral.Rows[i].Cells[5].Value = colaborador.Endereço;
                dataGridGeral.Rows[i].Cells[6].Value = colaborador.Contato;
                i++;


            }
        }

       
        public void ListarProdutos(List<ProdutoListagem> produtos)
        {

            dataGridGeral.Rows.Clear();
            dataGridGeral.Columns.Clear();

            dataGridGeral.Columns.Add("IdProduto", "Id do Produto");
            dataGridGeral.Columns.Add("Nome", "nome");
            dataGridGeral.Columns.Add("PrecoDeVenda", "Preço de venda");
            dataGridGeral.Columns.Add("Estoque", "Estoque");
            dataGridGeral.Columns.Add("Fabricante", "Fabricante");

  
            int i = 0;
            foreach (var produto in produtos)
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
        
        public void ListarCarrinhos(List<Pedido_Produto> carrinho)
        {
            
           
        }
        

        private void dataGridCliente_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var x = int.Parse(dataGridGeral.Rows[e.RowIndex].Cells[0].Value.ToString());
            if (Buscar == "cliente")
                cliente = oAlterar.consultarCliente(x);
            else if (Buscar == "colaborador")
                colaborador = oAlterarColaborador.consultarColaborador(x);
            else if (Buscar == "produto")
            {
                produto = oAlterarProduto.Consultar(x);
                produto.Estoque = produtos[e.RowIndex].Estoque;
            }

            this.Dispose();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AlterarCliente oAlterar = new AlterarCliente();

            int.TryParse(CampoDePesquisa.Text, out int id);
            if (id > 0)
            {
                if (Buscar == "cliente")
                    ListarClientes(oAlterar.ListarClienteAtivos(CampoDePesquisa.Text, "id"));
                else if (Buscar == "colaborador")
                    ListarColaboradores(oAlterarColaborador.ListarColaboradoresAtivos(CampoDePesquisa.Text, "id"));
                else if (Buscar == "produto")
                    ListarProdutos(oAlterarProduto.ListarAtivos(CampoDePesquisa.Text, "id"));
            }
            else
            {
                if (Buscar == "cliente")
                    ListarClientes(oAlterar.ListarClienteAtivos(CampoDePesquisa.Text, "nome"));
                else if (Buscar == "colaborador")
                    ListarColaboradores(oAlterarColaborador.ListarColaboradoresAtivos(CampoDePesquisa.Text, "nome"));
                else if (Buscar == "produto")
                    ListarProdutos(oAlterarProduto.ListarAtivos(CampoDePesquisa.Text, "nome"));
            }
        }

        private void ListarVendaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
