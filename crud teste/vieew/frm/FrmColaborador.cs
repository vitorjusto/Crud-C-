﻿using System;
using CRUD_teste.Model;
using System.Windows.Forms;
using System.Collections.Generic;
using crud_teste.controller;
using crud_teste.Validation;
using System.Linq;
using Tema;
using crud_teste.Config;
using crud_teste.Model.Object_Values;
using crud_teste.Config.Mensagem;

namespace crud_teste
{
    public partial class FrmColaborador : Form
    {
        public FrmColaborador()
        {
            InitializeComponent();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo voltar a pagina principal?"))
            {
                this.Close();
                new ListarClientes().Show();
            }

        }

        private void Colaborador_Load(object sender, EventArgs e)
        {
            Temas.AtribuirTema(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Colaborador colaborador = preencherCampos();
            AlterarColaborador oCadastrar = new AlterarColaborador();
            ColaboradorValidator validar = new ColaboradorValidator();

            var validateres = validar.Validate(colaborador);

            if (validateres.IsValid)
            {
                try
                {

                    if (new CaixaDePergunta().MensagemDeSimENao("Deseja mesmo cadastrar os dados?"))
                    {
                        colaborador.idColaborador = oCadastrar.conectarComDAO(colaborador);
                        new CaixaDeInformacao().MensagemDeOk($"Dados Cadastrados com sucesso\nid = {colaborador.idColaborador}");

                        new ListarClientes().Show();
                        this.Close();

                    }
                }
                catch
                {
                    new CaixaDeErro().FalhaNoBancoDeDados();
                }

            }
            else
            {
                new CaixaDeAviso().MensagemDeOk(validateres.Errors.FirstOrDefault().ToString());
            }

        }

        public Colaborador preencherCampos()
        {
            Colaborador colaborador = new Colaborador();

            colaborador.Nome = Nome.Text;
            colaborador.SobreNome = Sobrenome.Text;
            colaborador.Sexo = Sexo.Text;
            colaborador.Salario = Salario.Text;
            colaborador.DataDeNascimento = Data.Value;
            colaborador.CPF = CPF.Text;
            colaborador.contato.Email = Email.Text;
            colaborador.contato.Telefone = Telefone.Text;
            colaborador.contato.Celular = Celular2.Text;

            colaborador.contato.Celular.DDI = Celular1.Text;
            colaborador.PorcentagemDeComissao = decimal.Parse(Porcentagem.Text == ""? "0" : Porcentagem.Text);

            colaborador.endereco.Cep = CEP.Text;
            colaborador.endereco.Logradouro = Logradouro.Text;
            colaborador.endereco.Cidade = Cidade.Text;
            colaborador.endereco.UF = UF.Text;
            colaborador.endereco.Complemento = Complemento.Text;
            colaborador.endereco.Bairro = Bairro.Text;
            int.TryParse(Numero.Text, out int i);

            colaborador.endereco.Numero = i;

            colaborador.DadosBancarios.Banco = Banco.Text;
            colaborador.DadosBancarios.Agencia = int.Parse(Agencia.Text == "" ? "0" : Agencia.Text);
            colaborador.DadosBancarios.Conta = int.Parse(Conta.Text == "" ? "0" : Conta.Text);
            colaborador.DadosBancarios.Digito = int.Parse(Digito.Text == "" ? "0" : Digito.Text);

            return colaborador;

        }

        private void Numero_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotIntChar(e.KeyChar);


        private void Porcentagem_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotFloatText(e.KeyChar, Porcentagem.Text);

        private void Salario_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotFloatText(e.KeyChar, Salario.Text);

        private void Sexo_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void UF_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = true;

        private void Agencia_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = Global.isNotIntChar(e.KeyChar);

        private void Salario_Leave(object sender, EventArgs e) => Salario.Text = MyDinheiro.SetTextBoxAsMoneyValue(Salario.Text);
    }
}
