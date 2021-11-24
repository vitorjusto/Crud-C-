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
        private Pedido_Produto PedidoExemplo1 = new Pedido_Produto
            (
                -12.2,
                -14.5,
                -35.4,
                -23,
                -12.3,
                -145.5,
                -1,
                -1,
                -13
            );

        

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

            Assert.IsTrue(resultado.ToString().Contains("Telefone Inválido"));
        }



        [TestMethod]
        public void Quando_O_DDI_Tiver_Texto_Especificado_Entao_O_DDI_E_Valido()
        {
            MyCelular celular = new MyCelular("(00) 9000 - 0000");
            CelularValidation validacao = new CelularValidation();
            celular.DDI = "+55";

            var resultado = validacao.Validate(celular);

            Assert.IsFalse(resultado.ToString().Contains("DDI inválida"));
        }
        [DataTestMethod]
        [DataRow("")]
        public void Quando_O_DDI_Nao_Tiver_Texto_Especificado_Entao_O_DDI_E_Invalido(string ddi)
        {
            MyCelular celular = new MyCelular("12");
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


        //Produto


        [TestMethod]
        public void Quando_O_Nome_Do_Produto_Tiver_Text_Entao_o_produto_e_valido()
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.NomeDoProduto = "Camiseta";

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("Nome não pode ser vazio"));

        }


        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void Quando_O_Nome_Do_Produto_nao_Tiver_Text_Entao_o_produto_e_Invalido(string nome)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.NomeDoProduto = nome;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("Nome não pode ser vazio"));
        }

        [DataTestMethod]
        [DataRow("1234567890123")]
        [DataRow("12345678901234")]
        [DataRow("1234567890123456")]
        public void Quando_O_CodigoDeBarras_Texto_Especificado_Entao_o_produto_e_valido(string codDeBarras)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.CodigoDeBarras = codDeBarras;

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("Codigo De Barras Não Pode Ser Vazio") || resultado.ToString().Contains("Codigo De Barras deve ter entre 13 e 16 caracteres"));

        }


        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        [DataRow("123456789012345611")]
        [DataRow("123456")]
        public void Quando_O_CodigoDeBarras_Texto_nao_Especificado_Entao_o_produto_e_valido(string codDeBarras)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.CodigoDeBarras = codDeBarras;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("Codigo De Barras Não Pode Ser Vazio") || resultado.ToString().Contains("Codigo De Barras deve ter entre 13 e 16 caracteres"));

        }

        [TestMethod]
        public void Quando_O_Preco_De_Venda_For_Maior_Que_zero_entao_O_preco_de_venda_e_valido()
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.PrecoDeVenda = 12.0F;

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("O preço da venda deve ser maior que zero"));

        }

        [DataTestMethod]
        [DataRow(0.0F)]
        [DataRow(-12.0F)]
        
        public void Quando_O_Preco_De_Venda_For_Menor_Ou_Igual_A_zero_entao_O_preco_de_venda_e_valido(float preco)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.PrecoDeVenda = preco;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("O preço da venda deve ser maior que zero"));

        }
        [TestMethod]
        public void Quando_O_Preco_De_Custo_For_Maior_Que_zero_entao_O_preco_de_Custo_e_valido()
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.PrecoDeCusto = 12.0F;

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("O preco de custo deve ser maior que zero"));

        }

        [DataTestMethod]
        [DataRow(0.0F)]
        [DataRow(-12.0F)]

        public void Quando_O_Preco_De_Custo_For_Menor_Ou_Igual_A_zero_entao_O_preco_de_Custo_e_valido(float preco)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.PrecoDeCusto = preco;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("O preco de custo deve ser maior que zero"));

        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(12)]
        public void Quando_O_Estoque_For_Maior_Ou_Igual_A_zero_entao_O_Estoque_e_valido(int estoque)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.Estoque = estoque;

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("O Estoque não pode ser vazio"));

        }

        [DataTestMethod]
        [DataRow(-12)]
        public void Quando_O_Estoque_For_Menor_Que_zero_entao_O_Estoque_e_invalido(int estoque)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.Estoque = estoque;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("O Estoque não pode ser vazio"));

        }

        [TestMethod]
        public void Quando_O_Fabricante_Tiver_Texto_entao_Fabricante_e_valido()
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.Fabricante = "Avon";

            var resultado = validacao.Validate(produto);

            Assert.IsFalse(resultado.ToString().Contains("Fabricante não deve ser vazio"));

        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void Quando_O_Fabricante_nao_Tiver_Texto_entao_Fabricante_e_invalido(string nome)
        {
            Produto produto = new Produto();
            ProdutoValidation validacao = new ProdutoValidation();
            produto.Fabricante = nome;

            var resultado = validacao.Validate(produto);

            Assert.IsTrue(resultado.ToString().Contains("Fabricante não deve ser vazio"));

        }


        //Validar Pedido_Produto

        [TestMethod]
        public void Quando_o_Id_Do_Produto_For_Maior_Que_zero_então_O_Id_Do_Produto_è_Valido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.produto.IdProduto = 1;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("Escolha um produto primeiro!"));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-12)]
        public void Quando_o_Id_Do_Produto_For_Menor_ou_Igual_A_zero_então_O_Id_Do_Produto_é_Invalido(int id)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.produto.IdProduto = id;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("Escolha um produto primeiro!"));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(12)]
        public void Quando_O_Desconto_For_Maior_Ou_Igual_A_Zero_Então_o_Desconto_é_Valido(int desconto)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.Desconto = desconto;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("Desconto não deve ser menor que zero"));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-15)]
        public void Quando_O_Desconto_For_Menor_Que_Zero_Então_o_Desconto_é_Invalido(int desconto)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.Desconto = desconto;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("Desconto não deve ser menor que zero"));
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(15)]
        public void Quando_A_Quantidade_For_Maior_Que_Zero_Então_A_Quantidade_é_Valido(int quantidade)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.quantidade = quantidade;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("Quantidade tem que ser maior que zero"));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-15)]
        [DataRow(0)]
        public void Quando_A_Quantidade_For_Menor_ou_Igual_A_Zero_Então_A_Quantidade_é_Invalido(int quantidade)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.quantidade = quantidade;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("Quantidade tem que ser maior que zero"));
        }

        [DataTestMethod]
        [DataRow(1)]
        [DataRow(15)]
        [DataRow(0)]
        public void Quando_A_Quantidade_For_Maior_Ou_IguaL_A_Zero_Então_A_Quantidade_é_Valido(int quantidade)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.quantidadeRestante = quantidade;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("Não pode ter mais quantidade do que estoque"));
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(-15)]
        public void Quando_A_Quantidade_Restante_For_Menor_Que_Zero_Então_A_Quantidade_é_Invalido(int quantidade)
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.quantidadeRestante = quantidade;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("Não pode ter mais quantidade do que estoque"));
        }

        [TestMethod]
        public void Quando_o_Preco_Liquido_For_Maior_Que_Zero_Então_é_Valido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.PrecoLiquido = 12.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("Preco liquido não pode ser negativo"));

        }

        [TestMethod]
        public void Quando_o_Preco_Liquido_For_Ou_Igual_A__Zero_Então_é_Invalido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.PrecoLiquido = -15.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("Preco liquido não pode ser negativo"));

        }

        [TestMethod]
        public void Quando_o_Preco_Bruto_For_Maior_Que_Zero_Então_é_Valido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.PrecoBruto = 12.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("O preco bruto é maior que zero"));

        }

        [TestMethod]
        public void Quando_o_Preco_Bruto_For_Ou_Igual_A__Zero_Então_é_Invalido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.PrecoBruto = -15.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("O preco bruto é maior que zero"));

        }

        [TestMethod]
        public void Quando_o_Preco_Unitario_For_Maior_Que_Zero_Então_é_Valido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.precoDeVenda = 12.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsFalse(resultado.ToString().Contains("O preço unitário não pode ser negativo"));

        }

        [TestMethod]
        public void Quando_o_Preco_Unitario_For_Ou_Igual_A__Zero_Então_é_Invalido()
        {
            Pedido_Produto pedido = new Pedido_Produto();
            pedido.precoDeVenda = -15.0;
            CarrinhoValidation validar = new CarrinhoValidation();

            var resultado = validar.Validate(pedido);

            Assert.IsTrue(resultado.ToString().Contains("O preço unitário não pode ser negativo"));

        }


        //Validar Venda


        [TestMethod]
        public void Quando_O_Id_Do_Cliente_For_Maior_Que_Zero_Então_O_Cliente_é_Valido()
        {
            Venda venda = new Venda();
            venda.IdCliente = 1;
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Selecione um cliente"));

        }


        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Quando_O_Id_Do_Cliente_For_Menor_Ou_Igual_A_Zero_Então_O_Cliente_é_Invalido(int id)
        {
            Venda venda = new Venda();
            venda.IdCliente = id;
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Selecione um cliente"));

        }


        [TestMethod]
        public void Quando_O_Id_Do_Colaborador_For_Maior_Que_Zero_Então_O_Colaborador_é_Valido()
        {
            Venda venda = new Venda();
            venda.IdColaborador = 1;
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Selecione um colaborador"));

        }


        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        public void Quando_O_Id_Do_Colaborador_For_Menor_Ou_Igual_A_Zero_Então_O_Colaborador_é_Invalido(int id)
        {
            Venda venda = new Venda();
            venda.IdColaborador = id;
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Selecione um colaborador"));

        }

        [TestMethod]
        public void Se_O_Tipo_De_Venda_Tiver_Texto_Então_Tipo_De_Venda_é_Valido()
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A Vista";
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Selecione um tipo de venda"));

        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow(null)]
        public void Se_O_Tipo_De_Venda_Não_Tiver_Texto_Então_Tipo_De_Venda_é_Invalido(string tipo)
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = tipo;
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Selecione um tipo de venda"));

        }

        [TestMethod]
        public void Se_A_Quantidade_Unitaria_For_Maio_Que_zero_Então_Quantidade_Unitario_é_Válido()
        {
            Venda venda = new Venda();
            venda.Pedido_Produto.Add(new Pedido_Produto());
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Adicione um produto"));

        }

        [TestMethod]
        public void Se_A_Quantidade_Unitaria_For_Zero_Então_Quantidade_Unitario_é_Inválido()
        {
            Venda venda = new Venda();
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Adicione um produto"));
        }

        [TestMethod]
        public void Se_O_Total_Liquido_For_Maior_Que_Zero_Então_Total_Liquido_é_Valido()
        {
            Venda venda = new Venda();
            venda.Pedido_Produto.Add(new Pedido_Produto());
            VendaValidation validar = new VendaValidation();
            
            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Total Liquido não pode ser menor que zero"));

        }

        [TestMethod]
        public void se_O_Total_Liquido_For_Menor_Ou_Igual_A_Zero_Então_O_Total_Liquido_é_inválida()
        {
            Venda venda = new Venda();
            VendaValidation validar = new VendaValidation();
            venda.Pedido_Produto.Add(PedidoExemplo1);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Total Liquido não pode ser menor que zero"));
        }

        [TestMethod]
        public void Se_O_Total_De_Desconto_For_Maior_Ou_Igual_A_Zero_Então_Total_De_Desconto_é_Valido()
        {
            Venda venda = new Venda();
            venda.Pedido_Produto.Add(new Pedido_Produto());
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Total de desconto não pode ser negativo"));

        }

        [TestMethod]
        public void Se_O_Total_De_Desconto_For_Menor_Que_Zero_Então_Total_De_Desconto_é_Invalido()
        {
            Venda venda = new Venda();
            VendaValidation validar = new VendaValidation();
            venda.Pedido_Produto.Add(PedidoExemplo1);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Total de desconto não pode ser negativo"));
        }


        [TestMethod]
        public void Se_O_Total_Bruto_For_Maior_Ou_Igual_A_Zero_Então_Total_Bruto_é_Valido()
        {
            Venda venda = new Venda();
            venda.Pedido_Produto.Add(new Pedido_Produto());
            VendaValidation validar = new VendaValidation();

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("Total bruto não pode ser negativo"));

        }

        [TestMethod]
        public void Se_O_Total_Bruto_For_Menor_Que_Zero_Então_Total_Bruto_é_Invalido()
        {
            Venda venda = new Venda();
            VendaValidation validar = new VendaValidation();
            venda.Pedido_Produto.Add(PedidoExemplo1);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("Total bruto não pode ser negativo"));
        }

        [TestMethod]
        public void Se_A_Venda_A_Vista_Tiver_Desconto_Maior_Que_Zero_Entao_A_Venda_é_Valida()
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A vista";
            venda.DescontoAVIsta = 1.2;
            VendaValidation validar = new VendaValidation(12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("O desconto a vista não pode ser nulo"));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-12)]
        public void Se_A_Venda_A_Vista_Tiver_Desconto_Menor_Ou_Igual_A_Zero_Entao_A_Venda_é_Invalida(float desconto)
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A vista";
            venda.DescontoAVIsta = desconto;
            VendaValidation validar = new VendaValidation(12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("O desconto a vista não pode ser nulo"));
        }

        [TestMethod]
        public void Se_Meses_A_Prazo_For_Maior_Que_zero_então_A_Venda_é_valida()
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A Prazo";
            venda.MesesAPrazo = 1;
            VendaValidation validar = new VendaValidation(12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("A quantidade de mezes não pode ser nulo"));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-12)]
        public void Se_Meses_A_Prazo_For_Menor_ou_Igual_A_zero_então_A_Venda_é_valida(int meses)
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A Prazo";
            venda.MesesAPrazo = meses;
            VendaValidation validar = new VendaValidation(12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("A quantidade de mezes não pode ser nulo"));
        }

        [TestMethod]
        public void Se_A_Compra_A_Prazo_Não_Estrapolar_O_Valor_Limite_Então_A_Venda_é_Valido()
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A Prazo";
            VendaValidation validar = new VendaValidation(12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsFalse(resultado.ToString().Contains("O Total Liquido é maior que o valor limite"));
        }

        [TestMethod]
        public void Se_A_Compra_A_Prazo_Estrapolar_O_Valor_Limite_Então_A_Venda_é_Invalido()
        {
            Venda venda = new Venda();
            venda.TipoDeVenda = "A Prazo";
            VendaValidation validar = new VendaValidation(-12, venda);

            var resultado = validar.Validate(venda);

            Assert.IsTrue(resultado.ToString().Contains("O Total Liquido é maior que o valor limite"));

        }
    }
}
