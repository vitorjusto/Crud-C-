using CRUD_teste.Model;

namespace crud_teste.controller
{
    class AlterarColaborador
    {
        public Colaborador consultarColaborador(int id)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            stmt.conectar();
            Colaborador colaborador = new Colaborador();

            colaborador = stmt.ConsultarColaborador($"Select * from Colaborador where idColaborador = {id}");
            colaborador.endereco = stmt.ConsultarEndereco($"Select* from Endereco where idendereco = {colaborador.endereco.IdEndereco}");

            stmt.desconectar();
            return colaborador;
        }

        public void SalvarColaborador(Colaborador colaborador)
        {
            ConexaoDAO stmt = new ConexaoDAO();

            stmt.conectar();
            stmt.AlterarCliente($"update colaborador set Nome = '{colaborador.Nome}', Sobrenome = '{colaborador.SobreNome}', sexo = '{colaborador.Sexo}', DataDeNascimento = '{colaborador.DataDeNascimento}', cpf = '{colaborador.CPF}', Telefone = '{colaborador.contato.Telefone}', Email = '{colaborador.contato.Email}', Celular='{colaborador.contato.Celular}' where idColaborador = {colaborador.idColaborador}; ");
            stmt.AlterarCliente($"update endereco set CEP = '{colaborador.endereco.Cep}', Logradouro = '{colaborador.endereco.Logradouro}', Cidade = '{colaborador.endereco.Cidade}', UF = '{colaborador.endereco.UF}', Complemento= '{colaborador.endereco.Complemento}', Bairro= '{colaborador.endereco.Bairro}', Numero= '{colaborador.endereco.Numero}' where idEndereco= {colaborador.endereco.IdEndereco}; ");
            stmt.desconectar();

        }

        public void Excluir(int id, int idEndereco)
        {

            ConexaoDAO stmt = new ConexaoDAO();
            stmt.conectar();
            stmt.AlterarCliente($"delete from Colaborador where idColaborador = {id}; ");
            stmt.AlterarCliente($"delete from Endereco where idEndereco = {idEndereco}");
            stmt.desconectar();
        }

        public int conectarComDAO(Colaborador colaborador)
        {
            ConexaoDAO stmt = new ConexaoDAO();
            stmt.conectar();

            var idEndereco = stmt.GravarEndereco($"insert into Endereco OUTPUT INSERTED.idEndereco Values('{colaborador.endereco.Cep}', '{colaborador.endereco.Logradouro}', '{colaborador.endereco.Cidade}', '{colaborador.endereco.UF}', '{colaborador.endereco.Complemento}', '{colaborador.endereco.Bairro}', {colaborador.endereco.Numero});");
            var idColaborador = stmt.GravarColaborador($"insert into Colaborador OUTPUT INSERTED.idColaborador  Values('{colaborador.Nome}', '{colaborador.SobreNome}', '{colaborador.Sexo}',  {colaborador.Salario}, {colaborador.PorcentagemDeComissao}, '{colaborador.CPF}', '{colaborador.DadosBancarios}', '{colaborador.contato.Email}', '{colaborador.contato.Telefone}', '{colaborador.contato.DDI} {colaborador.contato.Celular}', {idEndereco}, '{colaborador.DataDeNascimento}');");
            stmt.desconectar();
            return idColaborador;

        }
    }
}
