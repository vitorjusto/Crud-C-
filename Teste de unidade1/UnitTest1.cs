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
            Assert.IsTrue(pessoa.Testar_se_Nome_e_valido());

        }
        [TestMethod]
        public void Quando_O_Nome_Nao_Tiver_Texto_Entao_O_Nome_E_Invalido()
        {
            Pessoa pessoa = new Pessoa("");
            Assert.IsFalse(pessoa.Testar_se_Nome_e_valido());
        }
        [TestMethod]
        public void Quando_O_Nome_Estiver_Nulo_Entao_O_Nome_E_Invalido()
        {
            Pessoa pessoa = new Pessoa(null);
            Assert.IsFalse(pessoa.Testar_se_Nome_e_valido());
        }

        [TestMethod]
        public void validacao()
        {
            Cliente cliente = new Cliente("Vitor", 1000);
            Assert.IsTrue(cliente.Testar_se_Nome_e_valido());

        }
        [TestMethod]
        public void Quando_O_Sexo_Tiver_Texto_Entao_O_Sexo_E_Valido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "Masculino";
            Assert.IsTrue(pessoa.Testar_se_sexo_e_valido());
        }
        [TestMethod]
        public void Quando_O_Sexo_Nao_Tiver_Texto_Entao_O_Sexo_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = "";
            Assert.IsFalse(pessoa.Testar_se_sexo_e_valido());
        }
        [TestMethod]
        public void Quando_O_Sexo_Tiver_Nulo_Entao_O_Sexo_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.Sexo = null;
            Assert.IsFalse(pessoa.Testar_se_sexo_e_valido());
        }

        [TestMethod]
        public void Quando_O_CPF_Tiver_Texto_Especifico_Entao_O_CPF_E_Valido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "123,456,789-90";
            Assert.IsTrue(pessoa.Testar_Se_CPF_E_Valido());
        }
        [TestMethod]
        public void Quando_O_CPF_Nao_Tiver_O_Texto_Especificado_Entao_O_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "123456789901234";
            Assert.IsFalse(pessoa.Testar_Se_CPF_E_Valido());
        }
        [TestMethod]
        public void Quando_O_CPF_Estiver_Vazio_Entao_o_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = "";
            Assert.IsFalse(pessoa.Testar_Se_CPF_E_Valido());
        }

        [TestMethod]
        public void Quando_O_CPF_Estiver_Nulo_Entao_o_CPF_E_Invalido()
        {
            Pessoa pessoa = new Pessoa();
            pessoa.CPF = null;
            Assert.IsFalse(pessoa.Testar_Se_CPF_E_Valido());
        }




        //VALIDAR CLASSE ENDERECO





        [TestMethod]
        public void Quando_O_CEP_Tiver_Texto_Especifico_Entao_O_CEP_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "12345-123";
            Assert.IsTrue(endereco.Validar_Se_CEP_E_Valido());
        }
        [TestMethod]
        public void Quando_O_CEP_Nao_Tiver_O_Texto_Especificado_Entao_O_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "123456789";
            Assert.IsFalse(endereco.Validar_Se_CEP_E_Valido());
        }
        [TestMethod]
        public void Quando_O_CEP_Estiver_Vazio_Entao_o_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = "";
            Assert.IsFalse(endereco.Validar_Se_CEP_E_Valido());
        }

        [TestMethod]
        public void Quando_O_CEP_Estiver_Nulo_Entao_o_CEP_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cep = null;
            Assert.IsFalse(endereco.Validar_Se_CEP_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Logradouro_Tiver_Texto_Entao_O_Logradouro_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua 16";
            Assert.IsTrue(endereco.Validar_Se_Logradouro_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Logradouro_Nao_Tiver_Texto_Entao_O_Logradouro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = "";
            Assert.IsFalse(endereco.Validar_Se_Logradouro_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Logradouro_Tiver_Nulo_Entao_O_Logradouro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = null;
            Assert.IsFalse(endereco.Validar_Se_Logradouro_E_Valido());
        }
        [TestMethod]
        public void Quando_A_Cidade_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = "Jales";
            Assert.IsTrue(endereco.Validar_Se_Cidade_E_Valido());
        }
        
        [TestMethod]
        public void Quando_A_Cidade_Nao_Tiver_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = "";
            Assert.IsFalse(endereco.Validar_Se_Cidade_E_Valido());
        }

        [TestMethod]
        public void Quando_A_Cidade_Estiver_Nulo_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Cidade = null;
            Assert.IsFalse(endereco.Validar_Se_Cidade_E_Valido());
        }

        [TestMethod]
        public void Quando_O_UF_Tiver_Texto_Entao_Cidade_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = "SP";
            Assert.IsTrue(endereco.Validar_Se_UF_E_Valido());
        }

        [TestMethod]
        public void Quando_O_UF_Nao_Tiver_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = "";
            Assert.IsFalse(endereco.Validar_Se_UF_E_Valido());
        }

        [TestMethod]
        public void Quando_O_UF_Estiver_Nulo_Texto_Entao_Cidade_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.UF = null;
            Assert.IsFalse(endereco.Validar_Se_UF_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Bairro_Tiver_Texto_Entao_Bairro_E_Valido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = "Centro";
            Assert.IsTrue(endereco.Validar_Se_Bairro_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Bairro_Tiver_Caracteres_Especificos_entao_Texto_Entao_Bairro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = "çáàãâéèêíìîóòõôúùûÇÁÀÃÂÉÈÊÍÌÎÓÒÕÔÚÙÛ -";
            Assert.IsTrue(endereco.Validar_Se_Bairro_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Bairro_Nao_Tiver_Texto_Entao_Bairro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = "";
            Assert.IsFalse(endereco.Validar_Se_Bairro_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Bairro_Estiver_Nulo_Texto_Entao_Bairro_E_Invalido()
        {
            Endereco endereco = new Endereco();
            endereco.Bairro = null;
            Assert.IsFalse(endereco.Validar_Se_Bairro_E_Valido());
        }


        //VALIDAR CLASSE CONTATO

        [TestMethod]
        public void Quando_O_Email_Tiver_Texto_Especificado_Entao_O_Email_E_Valido()
        {
            Contato contato = new Contato();
            contato.Email = "Vitohugojusto1@Gmail.com";
            Assert.IsTrue(contato.Testar_Se_Email_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Email_Nao_Tiver_Texto_Especificado_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = "Vitohugojusto1Gmailcom";
            Assert.IsFalse(contato.Testar_Se_Email_E_Valido());
        }
    
        [TestMethod]
        public void Quando_O_Email_Nao_Tiver_Texto_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = "";
            Assert.IsFalse(contato.Testar_Se_Email_E_Valido());
        }
    
        [TestMethod]
        public void Quando_O_Email_Estiver_Nulo_Entao_O_Email_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Email = null;
            Assert.IsFalse(contato.Testar_Se_Email_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Telefone_Tiver_Texto_Especificado_Entao_O_Telefone_E_Valido()
        {
            Contato contato = new Contato();
            contato.Telefone = "1234 - 1234";
            Assert.IsTrue(contato.Testar_Se_Telefone_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Telefone_Nao_Tiver_Texto_Especificado_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = "123456789";
            Assert.IsFalse(contato.Testar_Se_Telefone_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Telefone_Nao_Tiver_Texto_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = "";
            Assert.IsFalse(contato.Testar_Se_Telefone_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Telefone_Estiver_Nulo_Entao_O_Telefone_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Telefone = null;
            Assert.IsFalse(contato.Testar_Se_Telefone_E_Valido());
        }

        [TestMethod]
        public void Quando_O_DDI_Tiver_Texto_Especificado_Entao_O_DDI_E_Valido()
        {
            Contato contato = new Contato();
            contato.DDI = "+55";
            Assert.IsTrue(contato.Testar_Se_DDI_E_Valido());
        }
        [TestMethod]
        public void Quando_O_DDI_Nao_Tiver_Texto_Especificado_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = "123456789";
            Assert.IsFalse(contato.Testar_Se_DDI_E_Valido());
        }

        [TestMethod]
        public void Quando_O_DDI_Nao_Tiver_Texto_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = "";
            Assert.IsFalse(contato.Testar_Se_DDI_E_Valido());
        }

        [TestMethod]
        public void Quando_O_DDI_Estiver_Nulo_Entao_O_DDI_E_Invalido()
        {
            Contato contato = new Contato();
            contato.DDI = null;
            Assert.IsFalse(contato.Testar_Se_DDI_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Celular_Tiver_Texto_Especificado_Entao_O_Celular_E_Valido()
        {
            Contato contato = new Contato();
            contato.Celular = "(11) 9123 - 1234";
            Assert.IsTrue(contato.Testar_Se_Celular_E_Valido());
        }
        [TestMethod]
        public void Quando_O_Celular_Nao_Tiver_Texto_Especificado_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = "123456789";
            Assert.IsFalse(contato.Testar_Se_Celular_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Celular_Nao_Tiver_Texto_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = "";
            Assert.IsFalse(contato.Testar_Se_Celular_E_Valido());
        }

        [TestMethod]
        public void Quando_O_Celular_Estiver_Nulo_Entao_O_Celular_E_Invalido()
        {
            Contato contato = new Contato();
            contato.Celular = null;
            Assert.IsFalse(contato.Testar_Se_Celular_E_Valido());
        }

    }
}
