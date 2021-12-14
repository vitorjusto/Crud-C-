using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.Listar
{
    public partial class ListarVendaAPrazo : Form
    {

        AlterarVenda oAlterar = new AlterarVenda();
        List<VendaAPrazo> listadevenda = new List<VendaAPrazo>();
        public ListarVendaAPrazo()
        {
            InitializeComponent();
        }

        private void ListarVendaAPrazo_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
            try
            {
                listadevenda = oAlterar.ListarVendaAPrazo();
                AtualizarLista(false);
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
            }
        }

        private void AtualizarLista(bool comPago)
        {
            DataGridViewCellStyle vendapaga = new DataGridViewCellStyle();
            vendapaga.BackColor = Color.SlateGray;
            vendapaga.ForeColor = Color.White;

            var index = 0;

            dgvedasaprazo.Rows.Clear();
            foreach (var venda in listadevenda)
            {
                dgvedasaprazo.Rows.Add();
                dgvedasaprazo.Rows[index].Cells[0].Value = venda.idVenda;
                dgvedasaprazo.Rows[index].Cells[1].Value = venda.idCliente;
                dgvedasaprazo.Rows[index].Cells[2].Value = venda.cliente.nomeCompleto();
                dgvedasaprazo.Rows[index].Cells[3].Value = venda.ValorTotal.GetAsString();
                dgvedasaprazo.Rows[index].Cells[4].Value = venda.QuantidadeDeMeses;
                dgvedasaprazo.Rows[index].Cells[5].Value = venda.ValorPorMes;
                dgvedasaprazo.Rows[index].Cells[6].Value = venda.mesesrestantes;
                dgvedasaprazo.Rows[index].Cells[7].Value = venda.quantidaderestante.GetAsString();

                if (comPago && !venda.Pendente)
                {
                    var j = 0;
                    while (j < 9)
                    {
                        dgvedasaprazo.Rows[index].Cells[j].Style = vendapaga;
                        j++;
                    }
                    dgvedasaprazo.Rows[index].Cells[8].Value = "Pago";
                }
                else if (!comPago && !venda.Pendente)
                {
                    dgvedasaprazo.Rows[index].Visible = false;
                }
                else
                    dgvedasaprazo.Rows[index].Cells[8].Value = "Pagar";

                index++;
            }
            dgvedasaprazo.AllowUserToAddRows = false;
            dgvedasaprazo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                listadevenda = oAlterar.ListarVendaAPrazo(txtCliente.Text);
                AtualizarLista(cbInativo.Checked);
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
            }
        }

        private void cbInativo_CheckedChanged(object sender, EventArgs e)
        {
            AtualizarLista(cbInativo.Checked);
        }

        private void dgvedasaprazo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == dgvedasaprazo.Columns.IndexOf(PagarVariosMeses) && listadevenda[e.RowIndex].Pendente)
            {
                try
                {
                    var alterar = new PagarMeses(listadevenda[e.RowIndex]);
                    alterar.ShowDialog();
                    listadevenda[e.RowIndex] = alterar.venda;
                    AtualizarLista(cbInativo.Checked);
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }
            }
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new ListarClientes().Show();
        }
    }
}
