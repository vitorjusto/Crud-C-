using crud_teste.controller;
using crud_teste.Model;
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

namespace crud_teste.vieew.ListaDePedidos
{
    public partial class ListagemDePedidos : Form
    {
        public List<PedidoListagem> pedidos = new List<PedidoListagem>();

        public AlterarVenda oAlterar = new AlterarVenda();
        public ListagemDePedidos()
        {
            InitializeComponent();


            pedidos = oAlterar.Listar();


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ListagemDePedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
