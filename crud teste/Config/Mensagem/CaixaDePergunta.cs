
using System.Windows.Forms;

namespace crud_teste.Config.Mensagem
{
    public class CaixaDePergunta : CaixasDeMensagem
    {
        public override void MensagemDeOk(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Question);

        public override bool MensagemDeSimENao(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;


    }
}
