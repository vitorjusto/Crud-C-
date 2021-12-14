using crud_teste.Config.Mensagem;
using crud_teste.controller;
using crud_teste.Model;
using System;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.Listar
{
    public partial class PagarMeses : Form
    {
        public VendaAPrazo venda = new VendaAPrazo();
        private AlterarVenda oAlterar = new AlterarVenda();
        public PagarMeses(VendaAPrazo novavenda)
        {
            venda = novavenda;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                venda = oAlterar.PagarMeses(venda, (int)nudMeses.Value);
            }
            catch
            {
                new CaixaDeErro().FalhaNoBancoDeDados();
            }
            finally
            {
                this.Dispose();
            }
        }
        private void PagarMeses_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
            nudMeses.Maximum = venda.mesesrestantes;
            txtquantidadeTotal.Text = venda.ValorPorMes.GetAsString();
        }
        private void nudMeses_ValueChanged(object sender, EventArgs e)
        {
            txtquantidadeTotal.Text = (venda.ValorPorMes.GetAsDecimal() * nudMeses.Value).ToString("C2");
        }
    }
}
