
using System.Windows.Forms;

namespace crud_teste.vieew.Listar.ListaDePedidos.ListagemDePedidos
{
    public partial class RelatorioDeProdutos : Form
    {
        public RelatorioDeProdutos()
        {
            InitializeComponent();
        }

        private void RelatorioDeProdutos_Load(object sender, System.EventArgs e)
        {
            Global.AtribuirTema(this);
        }
    }
}
