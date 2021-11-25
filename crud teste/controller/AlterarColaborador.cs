using CRUD_teste.Model;
using System.Collections.Generic;
using crud_teste.Model;
namespace crud_teste.controller
{
    public class AlterarColaborador
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

        public void Excluir(int id)
        {
            ConexaoDAO stmt = new ConexaoDAO();


            stmt.ExcluirColaborador(id);
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

        public List<ColaboradorListagem> ListarColaboradoresAtivos()
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarColaboradoresAtivos();


        }

        public List<ColaboradorListagem> ListarColaboradoresPesquisado(string nome, string param)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarColaboradores(nome, param);
        }

        public List<ColaboradorListagem> ListarColaboradoresAtivos(string nome, string param)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            return stmt.ListarColaboradoresAtivos(nome, param);
        }
        public void AlterarAtivo(ColaboradorListagem colaborador)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            stmt.AlterarAtivo(colaborador);
        }
    }
}
