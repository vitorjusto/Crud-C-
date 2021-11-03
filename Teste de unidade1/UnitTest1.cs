using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using crud_teste;
using CRUD_teste.Model;
using crud_teste.Model;
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
            Pessoa pessoa = new Pessoa("Vitor");

            var resultado = pessoa.Testar_se_Nome_e_valido();

            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void Quando_O_Nome_Nao_Tiver_Texto_Entao_O_Nome_E_Invalido()
        {
            Pessoa pessoa = new Pessoa("");

            var resultado = pessoa.Testar_se_Nome_e_valido();

            Assert.IsFalse( resultado);
        }
        [TestMethod]
        public void Quando_O_Nome_Estiver_Nulo_Entao_O_Nome_E_Invalido()
        {
            Pessoa pessoa = new Pessoa(null);

            var resultado = pessoa.Testar_se_Nome_e_valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void validacao()
        {
            Cliente cliente = new Cliente("Vitor", 1000);

            var resultado = cliente.Testar_se_Nome_e_valido();

            Assert.IsTrue(resultado);

        }
        [TestMethod]
        public void Quando_O_Sexo_Tiver_Texto_Entao_O_Sexo_E_Valido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "Masculino";

            var resultado = pessoa.Testar_se_sexo_e_valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_Sexo_Nao_Tiver_Texto_Entao_O_Sexo_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "";

            var resultado = pessoa.Testar_se_sexo_e_valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_O_Sexo_Tiver_Nulo_Entao_O_Sexo_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = null;

            var resultado = pessoa.Testar_se_sexo_e_valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_CPF_Tiver_Texto_Especifico_Entao_O_CPF_E_Valido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "123,456,789-90";

            var resultado = pessoa.Testar_Se_CPF_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_CPF_Nao_Tiver_O_Texto_Especificado_Entao_O_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "123456789901234";

            var resultado = pessoa.Testar_Se_CPF_E_Valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_O_CPF_Estiver_Vazio_Entao_o_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "";

            var resultado = pessoa.Testar_Se_CPF_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_CPF_Estiver_Nulo_Entao_o_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = null;

            var resultado = pessoa.Testar_Se_CPF_E_Valido();

            Assert.IsFalse(resultado);
        }




        //VALIDAR CLASSE ENDERECO





        [TestMethod]
        public void Quando_O_CEP_Tiver_Texto_Especifico_Entao_O_CEP_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "12345-123";

            var resultado = endereco.Validar_Se_CEP_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_CEP_Nao_Tiver_O_Texto_Especificado_Entao_O_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "123456789";

            var resultado = endereco.Validar_Se_CEP_E_Valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_O_CEP_Estiver_Vazio_Entao_o_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "";

            var resultado = endereco.Validar_Se_CEP_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_CEP_Estiver_Nulo_Entao_o_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = null;

            var resultado = endereco.Validar_Se_CEP_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Logradouro_Tiver_Texto_Entao_O_Logradouro_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua 16 á";

            var resultado = endereco.Validar_Se_Logradouro_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_Logradouro_Nao_Tiver_Texto_Entao_O_Logradouro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "";

            var resultado = endereco.Validar_Se_Logradouro_E_Valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_O_Logradouro_Tiver_Nulo_Entao_O_Logradouro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = null;

            var resultado = endereco.Validar_Se_Logradouro_E_Valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_A_Cidade_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = "Jales";

            var resultado = endereco.Validar_Se_Cidade_E_Valido();

            Assert.IsTrue(resultado);
        }
        
        [TestMethod]
        public void Quando_A_Cidade_Nao_Tiver_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = "";

            var resultado = endereco.Validar_Se_Cidade_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_A_Cidade_Estiver_Nulo_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = null;

            var resultado = endereco.Validar_Se_Cidade_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_UF_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = "SP";

            var resultado = endereco.Validar_Se_UF_E_Valido();

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Quando_O_UF_Nao_Tiver_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = "";

            var resultado = endereco.Validar_Se_UF_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_UF_Estiver_Nulo_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = null;

            var resultado = endereco.Validar_Se_UF_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Bairro_Tiver_Texto_Entao_Bairro_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = "Bairro";

            var resultado = endereco.Validar_Se_Bairro_E_Valido();

            Assert.IsTrue(resultado);
        }

        

        [TestMethod]
        public void Quando_O_Bairro_Nao_Tiver_Texto_Entao_Bairro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = "";

            var resultado = endereco.Validar_Se_Bairro_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Bairro_Estiver_Nulo_Texto_Entao_Bairro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = null;

            var resultado = endereco.Validar_Se_Bairro_E_Valido();

            Assert.IsFalse(resultado);
        }


        //VALIDAR CLASSE CONTATO

        [TestMethod]
        public void Quando_O_Email_Tiver_Texto_Especificado_Entao_O_Email_E_Valido()
        {
            Contato contato = new Contato();
            contato.Email = "Vitohugojusto1@Gmail.com";

            var resultado = contato.Testar_Se_Email_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_Email_Nao_Tiver_Texto_Especificado_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = "Vitohugojusto1Gmailcom";

            var resultado = contato.Testar_Se_Email_E_Valido();

            Assert.IsFalse(resultado);
        }
    
        [TestMethod]
        public void Quando_O_Email_Nao_Tiver_Texto_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = "";

            var resultado = contato.Testar_Se_Email_E_Valido();

            Assert.IsFalse(resultado);
        }
    
        [TestMethod]
        public void Quando_O_Email_Estiver_Nulo_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = null;

            var resultado = contato.Testar_Se_Email_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Telefone_Tiver_Texto_Especificado_Entao_O_Telefone_E_Valido()
        {
            Contato contato = new Contato();
            contato.Telefone = "1234 - 1234";

            var resultado = contato.Testar_Se_Telefone_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_Telefone_Nao_Tiver_Texto_Especificado_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = "123456789";

            var resultado = contato.Testar_Se_Telefone_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Telefone_Nao_Tiver_Texto_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = "";

            var resultado = contato.Testar_Se_Telefone_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Telefone_Estiver_Nulo_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = null;

            var resultado = contato.Testar_Se_Telefone_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_DDI_Tiver_Texto_Especificado_Entao_O_DDI_E_Valido()
        {
            Contato contato = new Contato();
            contato.DDI = "+55";

            var resultado = contato.Testar_Se_DDI_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_DDI_Nao_Tiver_Texto_Especificado_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = "123456789";

            var resultado = contato.Testar_Se_DDI_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_DDI_Nao_Tiver_Texto_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = "";

            var resultado = contato.Testar_Se_DDI_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_DDI_Estiver_Nulo_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = null;

            var resultado = contato.Testar_Se_DDI_E_Valido();

            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void Quando_O_Celular_Tiver_Texto_Especificado_Entao_O_Celular_E_Valido()
        {
            Contato contato = new Contato();
            contato.Celular = "(11) 9123 - 1234";

            var resultado = contato.Testar_Se_Celular_E_Valido();

            Assert.IsTrue(resultado);
        }
        [TestMethod]
        public void Quando_O_Celular_Nao_Tiver_Texto_Especificado_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = "123456789";

            var resultado = contato.Testar_Se_Celular_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Celular_Nao_Tiver_Texto_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = "";

            var resultado = contato.Testar_Se_Celular_E_Valido();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Quando_O_Celular_Estiver_Nulo_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = null;

            var resultado = contato.Testar_Se_Celular_E_Valido();

            Assert.IsFalse(resultado);
        }




        //Colaborador


        [TestMethod]

        public void Quando_O_Salario_For_Maior_Que_Zero_Entao_E_Valido()
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Salario = 12.0M;

            var resultado = colaborador.Validar_Se_Salario_E_Valido();

            Assert.IsTrue(resultado);

        }
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-3)]
        public void Quando_O_Salario_For_Menor_Ou_Igual_A_Zero_Entao_E_Invalido(double n)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Salario = (decimal)n;

            var resultado = colaborador.Validar_Se_Salario_E_Valido();

            Assert.IsFalse(resultado);

        }


    }
}
