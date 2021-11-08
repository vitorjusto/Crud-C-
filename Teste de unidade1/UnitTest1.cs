using crud_teste;
using crud_teste.Model;
using crud_teste.Model.Object_Values;
using crud_teste.Validation;
using crud_teste.Validation.Object_Values_Validations;
using CRUD_teste.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Teste_de_unidade1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(Global.teste());

        }
        [TestMethod]
        public void Quando_O_Nome_Tiver_Texto_Entao_O_Nome_E_Valido()
        {
            Pessoa pessoa = new Pessoa("vitor");
            PessoaValidation validacao = new PessoaValidation();

            var resultado = validacao.Validate(pessoa);


            Assert.IsFalse(resultado.ToString().Contains("Nome não pode ser vazio"));

        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void Quando_O_Nome_Nao_Tiver_Texto_Ou_Nulo_Entao_O_Nome_E_Invalido(string nome)
        {
            Pessoa pessoa = new Pessoa(nome);
            PessoaValidation validacao = new PessoaValidation();

            var resultado = validacao.Validate(pessoa);

            Assert.IsTrue(resultado.ToString().Contains("Nome não pode ser vazio"));
        }



        [TestMethod]
        public void Quando_O_Sexo_Tiver_Texto_Entao_O_Sexo_E_Valido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "Masculino";
            PessoaValidation validacao = new PessoaValidation();

            var resultado = validacao.Validate(pessoa); ;

            Assert.IsFalse(resultado.ToString().Contains("Sexo não pode ser vazio"));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void Quando_O_Sexo_Nao_Tiver_Texto_Entao_O_Sexo_E_Invalido(string sexo)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = sexo;
            PessoaValidation validacao = new PessoaValidation();

            var resultado = validacao.Validate(pessoa); ;

            Assert.IsTrue(resultado.ToString().Contains("Sexo não pode ser vazio"));
        }


        [TestMethod]
        public void Quando_O_CPF_Tiver_Texto_Especifico_Entao_O_CPF_E_Valido()
        {
            MyCPF CPF = new MyCPF("123,456,789-90");
            CPFValidation validacao = new CPFValidation();

            var resultado = validacao.Validate(CPF); 

            Assert.IsFalse(resultado.ToString().Contains("CPF Inválido"));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow("2345234234")]


        public void Quando_O_CPF_Nao_Tiver_O_Texto_ou_Incorreto_Especificado_Entao_O_CPF_E_Invalido(string cpf)
        {
            MyCPF CPF = new MyCPF(cpf);
            CPFValidation validacao = new CPFValidation();

            var resultado = validacao.Validate(CPF);
            Assert.IsTrue(resultado.ToString().Contains("CPF Inválido"));
        }






        ////VALIDAR CLASSE ENDERECO





        [TestMethod]
        public void Quando_O_CEP_Tiver_Texto_Especifico_Entao_O_CEP_E_Valido()
        {
            MyCEP CEP = new MyCEP("12345-123");
            CEPValidation validacao = new CEPValidation();


            var resultado = validacao.Validate(CEP);

            Assert.IsFalse(resultado.ToString().Contains("Cep inválido"));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow("2345234")]
        public void Quando_O_CEP_Nao_Tiver_O_Texto_Ou_Incorreto_Especificado_Entao_O_CEP_E_Invalido(string cep)
        {
            MyCEP CEP = new MyCEP(cep);
            CEPValidation validacao = new CEPValidation();


            var resultado = validacao.Validate(CEP);

            Assert.IsTrue(resultado.ToString().Contains("Cep inválido"));
        }




        [TestMethod]
        public void Quando_O_Logradouro_Tiver_Texto_Entao_O_Logradouro_E_Valido()
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.Logradouro = "Rua 16 á";

            var resultado = validacao.Validate(endereco);

            Assert.IsFalse(resultado.ToString().Contains("Logradouro invalido"));
        }
        [DataTestMethod]
        [DataRow("")]
        public void Quando_O_Logradouro_Nao_Tiver_Texto_Entao_O_Logradouro_E_Invalido(string logradouro)
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.Logradouro = logradouro;

            var resultado = validacao.Validate(endereco);

            Assert.IsTrue(resultado.ToString().Contains("Logradouro invalido"));
        }

        [TestMethod]
        public void Quando_A_Cidade_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.Cidade = "Jales";

            var resultado = validacao.Validate(endereco);

            Assert.IsFalse(resultado.ToString().Contains("Cidade inválida"));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("12")]
        public void Quando_A_Cidade_Nao_Tiver_Texto_Ou_Tiver_Invalida_Entao_Cidade_E_Invalido(string cidade)
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.Cidade = cidade;

            var resultado = validacao.Validate(endereco);

            Assert.IsTrue(resultado.ToString().Contains("Cidade inválida"));
        }



        [TestMethod]
        public void Quando_O_UF_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.UF = "SP";

            var resultado = validacao.Validate(endereco);

            Assert.IsFalse(resultado.ToString().Contains("Campo UF é obrigatório"));
        }

        [TestMethod]
        public void Quando_O_UF_Nao_Tiver_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.UF = "";

            var resultado = validacao.Validate(endereco);
    
            Assert.IsTrue(resultado.ToString().Contains("Campo UF é obrigatório"));
        }



        [TestMethod]
        public void Quando_O_Bairro_Tiver_Texto_Entao_Bairro_E_Valido()
        {
            Endereco endereco = new Endereco();
            EnderecoValidation validacao = new EnderecoValidation();
            endereco.Bairro = "Bairro";

            var resultado = validacao.Validate(endereco);

            Assert.IsFalse(resultado.ToString().Contains("Campo bairro é obrigatório"));
        }







        ////VALIDAR CLASSE CONTATO

        [TestMethod]
        public void Quando_O_Email_Tiver_Texto_Especificado_Entao_O_Email_E_Valido()
        {
            Contato contato = new Contato();
            ContatoValidation validacao = new ContatoValidation();
            contato.Email = "Vitohugojusto1@Gmail.com";

            var resultado = validacao.Validate(contato);

            Assert.IsFalse(resultado.ToString().Contains("Email inválido"));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow("12")]
        public void Quando_O_Email_Nao_Tiver_Texto_Especificado_Entao_O_Email_E_Invalido(string email)
        {
            Contato contato = new Contato();
            ContatoValidation validacao = new ContatoValidation();
            contato.Email = email;

            var resultado = validacao.Validate(contato);

            Assert.IsTrue(resultado.ToString().Contains("Email inválido"));
        }





        [TestMethod]
        public void Quando_O_Telefone_Tiver_Texto_Especificado_Entao_O_Telefone_E_Valido()
        {
            Contato contato = new Contato();
            ContatoValidation validacao = new ContatoValidation();
            contato.Telefone = "1234 - 1234";


            var resultado = validacao.Validate(contato);

            Assert.IsFalse(resultado.ToString().Contains("Telefone Invalido"));
        }


        [DataTestMethod]
        [DataRow("")]
        [DataRow("12")]
        public void Quando_O_Telefone_Nao_Tiver_Texto_Especificado_Entao_O_Telefone_E_Valido(string telefone)
        {
            Contato contato = new Contato();
            ContatoValidation validacao = new ContatoValidation();
            contato.Telefone =telefone;


            var resultado = validacao.Validate(contato);

            Assert.IsTrue(resultado.ToString().Contains("Telefone Invalido"));
        }



        [TestMethod]
        public void Quando_O_DDI_Tiver_Texto_Especificado_Entao_O_DDI_E_Valido()
        {
            MyCelular celular = new MyCelular("SDD");
            CelularValidation validacao = new CelularValidation();
            celular.DDI = "+55";

            var resultado = validacao.Validate(celular);

            Assert.IsFalse(resultado.ToString().Contains("DDI inválida"));
        }
        [DataTestMethod]
        [DataRow("")]
        [DataRow("12")]
        public void Quando_O_DDI_Nao_Tiver_Texto_Especificado_Entao_O_DDI_E_Invalido(string ddi)
        {
            MyCelular celular = new MyCelular("SDD");
            CelularValidation validacao = new CelularValidation();
            celular.DDI = ddi;

            var resultado = validacao.Validate(celular);

            Assert.IsTrue(resultado.ToString().Contains("DDI inválida"));
        }




        [TestMethod]
        public void Quando_O_Celular_Tiver_Texto_Especificado_Entao_O_Celular_E_Valido()
        {
            MyCelular celular = new MyCelular("(11) 9123 - 1234");
            CelularValidation validacao = new CelularValidation();

            var resultado = validacao.Validate(celular);

            Assert.IsFalse(resultado.ToString().Contains("Celular inválida"));
        }




        [DataTestMethod]
        [DataRow("")]
        [DataRow("12")]
        public void Quando_O_Celular_Estiver_Nulo_Entao_O_Celular_E_Invalido(string Strcelular)
        {
            MyCelular celular = new MyCelular(Strcelular);
            CelularValidation validacao = new CelularValidation();

            var resultado = validacao.Validate(celular);

            Assert.IsTrue(resultado.ToString().Contains("Celular inválida"));
        }




        ////Colaborador


        [TestMethod]

        public void Quando_O_Salario_For_Maior_Que_Zero_Entao_E_Valido()
        {
            Colaborador colaborador = new Colaborador();
            ColaboradorValidator validacao = new ColaboradorValidator();
            colaborador.Salario = 12.0M;

            var resultado = validacao.Validate(colaborador);

            Assert.IsFalse(resultado.ToString().Contains("Salário deve ser Maior que zero"));

        }
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-3)]
        public void Quando_O_Salario_For_Menor_Ou_Igual_A_Zero_Entao_E_Invalido(double n)
        {
            Colaborador colaborador = new Colaborador();
            ColaboradorValidator validacao = new ColaboradorValidator();
            colaborador.Salario = (decimal)n;

            var resultado = validacao.Validate(colaborador);

            Assert.IsTrue(resultado.ToString().Contains("Salário deve ser Maior que zero"));
        }


    }
}
