using System.Windows.Forms;

namespace crud_teste.Config.Mensagem
{
    class CaixaDeInformacao : CaixasDeMensagem
    {
        public override void MensagemDeOk(string mensagem) =>
             MessageBox.Show(mensagem, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

        public override bool MensagemDeSimENao(string mensagem) =>
            MessageBox.Show(mensagem, "Informação", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes;
    }
}
