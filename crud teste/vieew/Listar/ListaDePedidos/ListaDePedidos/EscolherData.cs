using crud_teste.Config.Mensagem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tema;

namespace crud_teste.vieew.Listar.ListaDePedidos.ListaDePedidos
{
    public partial class EscolherData : Form
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public EscolherData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Global.ValidarDatas(dtpDataInicial.Value, dtpDataFinal.Value))
            {
                DataInicial = dtpDataInicial.Value;
                DataFinal = dtpDataFinal.Value;
                DialogResult = DialogResult.OK;
                this.Dispose();
            }else
            {
                new CaixaDeAviso().MensagemDeOk("Data Inicial vem depois da data final ou a data final vem depois de hoje");
            }
        }

        private void EscolherData_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
        }
    }
}
