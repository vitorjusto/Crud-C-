using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_teste
{
    public partial class ConsultarColaborador : Form
    {
        public ConsultarColaborador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.conectar();


            try
            {
                var id = Id.Text;

                stmt.ConsultarColaborador($"Select * from Colaborador where id = {id}");
 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos inválidos ou incompletos", "Atenção");
            }
            finally
            {
                stmt.desconectar();

            }

        }
    }
}
