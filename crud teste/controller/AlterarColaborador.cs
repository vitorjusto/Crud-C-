using CRUD_teste.Model;
using System.Collections.Generic;
using crud_teste.Model;
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

        public List<ColaboradorListagem> ListarColaboradores()
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarColaboradores();


        }

        public List<ColaboradorListagem> ListarColaboradoresPesquisado(string nome, string param)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarColaboradores(nome, param);
        }
    }
}
