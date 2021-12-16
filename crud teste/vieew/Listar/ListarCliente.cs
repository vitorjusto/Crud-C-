using crud_teste.Config;
using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew
{
    public partial class ListarCliente : Form
    {
        public List<ClienteListagem> clientes = new List<ClienteListagem>();
        public ListarCliente()
        {
            InitializeComponent();
            AlterarCliente oAlterar = new AlterarCliente();
        }

        public void ListarNaDatagrid(bool comAtivo)
        {
            DataGridViewCellStyle clienteinativo = new DataGridViewCellStyle();
            clienteinativo.BackColor = Color.SlateGray;
            clienteinativo.ForeColor = Color.White;

            var index = 0;
            dataGridCliente.Rows.Clear();
            foreach (var cliente in clientes)
            {
                dataGridCliente.Rows.Add();

                dataGridCliente.Rows[index].Cells[0].Value = cliente.idcliente;
                dataGridCliente.Rows[index].Cells[1].Value = cliente.nomecompleto;
                dataGridCliente.Rows[index].Cells[2].Value = cliente.Sexo;
                dataGridCliente.Rows[index].Cells[3].Value = cliente.DataDeNascimento;
                dataGridCliente.Rows[index].Cells[4].Value = cliente.Endereço;
                dataGridCliente.Rows[index].Cells[5].Value = cliente.Contato;

                if (comAtivo && !cliente.Ativo)
                {
                    var j = 0;
                    while (j < 6)
                    {

                        dataGridCliente.Rows[index].Cells[j].Style = clienteinativo;
                        j++;
                    }

                    dataGridCliente.Rows[index].Cells[7].Value = "Ativar";

                }
                else if (!comAtivo && !cliente.Ativo)
                {
                    dataGridCliente.Rows[index].Visible = false;
                }
                else
                {
                    dataGridCliente.Rows[index].Cells[7].Value = "Inativar";
                }

                index++;
            }
            dataGridCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ListarCliente_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ListarClientes().Show();
            this.Close();
        }
        private void dataGridCliente_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            var x = int.Parse(dataGridCliente.Rows[e.RowIndex].Cells[0].Value.ToString());
            Consultar(x);
        }

        private void Consultar(int index)
        {
            new ConsultarCliente(index).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlterarCliente oAlterar = new AlterarCliente();

            int.TryParse(CampoDePesquisa.Text, out int id);
            try
            {
                if (id > 0)
                    clientes = oAlterar.ListarCliente(CampoDePesquisa.Text, "id");
                else
                    clientes = oAlterar.ListarCliente(CampoDePesquisa.Text, "nome");

                ListarNaDatagrid(cbInativo.Checked);
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
            }

        }

        private void dataGridCliente_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
                return;

            if (e.ColumnIndex == 6)
            {
                Consultar(int.Parse(dataGridCliente.Rows[e.RowIndex].Cells[0].Value.ToString()));
            }
            else if (e.ColumnIndex == 7)
            {
                try
                {
                    var mensagem = clientes[e.RowIndex].Ativo ? $"Deseja Mesmo Inativar o {clientes[e.RowIndex].nomecompleto}" : $"Deseja Mesmo Reativar o {clientes[e.RowIndex].nomecompleto}";

                    if (new CaixaDeAviso().MensagemDeSimENao(mensagem))
                    {
                        AlterarCliente oAlterar = new AlterarCliente();
                        oAlterar.AlterarAtivo(clientes[e.RowIndex]);
                        clientes[e.RowIndex].Ativo = !clientes[e.RowIndex].Ativo;

                        ListarNaDatagrid(cbInativo.Checked);
                    }
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }
            }
        }

        private void cbInativo_CheckedChanged(object sender, EventArgs e)
        {
            ListarNaDatagrid(cbInativo.Checked);
        }
    }
}
