
using System.Windows.Forms;

namespace crud_teste.Config.Mensagem
{
    class CaixaDeAviso : CaixasDeMensagem
    {
        public override void MensagemDeOk(string mensagem) =>
             MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        public override bool MensagemDeSimENao(string mensagem) =>
            MessageBox.Show(mensagem, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
    }
}
