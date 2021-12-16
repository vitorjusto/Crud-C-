using crud_teste.vieew.TelaDeVenda;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste
{
    public class Global
    {

        public static bool teste()
        {
            return true;
        }

        public static bool isNotIntChar(char c)
        {
            if(char.IsDigit(c) || c.ToString() == "\b")
            {
                return false;
            }else
            {
                return true;
            }
        }

        public static bool isNotIntText(char c, string text)
        {
            if (char.IsDigit(c) && (text.Length) < 10)
            {
                return false;
            }
            else if(c.ToString() == "\b" && text.Length <= 10)
            {
                return false;
            }
            return true;
        }

        public static bool isNotFloatText(char c, string text)
        {
            if (char.IsDigit(c) || c.ToString() == "\b" || (c.ToString() == "," && !text.Contains(",")))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string setTextBoxAsIntText(string text)
        {
            return new string((from c in text where char.IsDigit(c) select c).ToArray());
        }

        public static bool ValidarDatas(DateTime DataInicial, DateTime DataFinal)
        {
            return DateTime.Compare(DataInicial.Date, DataFinal.Date) <= 0 && DateTime.Compare(DataFinal.Date, DateTime.Today) <= 0;
        }

        public static void pesquisar(string nome, string entrada, TextBox control)
        {
            var listar = new ListarVendaCliente(nome, entrada);
            listar.ShowDialog();
            if (nome == "produto" && !string.IsNullOrEmpty(listar.produto.NomeDoProduto))
            {
                control.Text = listar.produto.NomeDoProduto;
            }
            else if (nome == "cliente" && !string.IsNullOrEmpty(listar.cliente.Nome))
                control.Text = listar.cliente.nomeCompleto();
            else if(nome == "colaborador" && !string.IsNullOrEmpty(listar.colaborador.Nome))
                control.Text = listar.colaborador.nomeCompleto();

        }
    }
}
