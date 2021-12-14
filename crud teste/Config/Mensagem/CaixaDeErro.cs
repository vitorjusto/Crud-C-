using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste.Config.Mensagem
{
    class CaixaDeErro : CaixasDeMensagem
    {
        public override void MensagemDeOk(string mensagem) => 
            MessageBox.Show(mensagem, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
        public override bool MensagemDeSimENao(string mensagem) =>
            MessageBox.Show(mensagem, "Erro!", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes;

        public void FalhaNoBancoDeDados() =>
            MensagemDeOk("Falha Ao Conectar com o bancos de dados, Certifique-se que você esteja conectado com a internet");
    }
}
