using CRUD_teste.Model;

namespace crud_teste.controller
{
    class AlterarColaborador
    {
        public Colaborador consultarColaborador(int id)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            Colaborador colaborador = new Colaborador();
            colaborador = stmt.ConsultarColaborador(id);
           
            return colaborador;
        }

        public void SalvarColaborador(Colaborador colaborador)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.SalvarColaborador(colaborador);

        }

        public void Excluir(Colaborador colaborador)
        {

            ConexaoDAO stmt = new ConexaoDAO();
            stmt.ExcluirColaborador(colaborador);
        }

        public int conectarComDAO(Colaborador colaborador)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            colaborador.idColaborador = stmt.GravarColaborador(colaborador);

            return colaborador.idColaborador;

        }
    }
}
