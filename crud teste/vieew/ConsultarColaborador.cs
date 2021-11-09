﻿using CRUD_teste.Model;
using System;
using System.Collections.Generic;
using crud_teste.controller;
using System.Windows.Forms;
using crud_teste.vieew;
using crud_teste.Validation;
using System.Linq;

namespace crud_teste
{
    public partial class ConsultarColaborador : Form
    {
        private Colaborador colaboradorGlobal = new Colaborador();
        public ConsultarColaborador(int id)
        {
            InitializeComponent();
            AlterarColaborador oColaborador = new AlterarColaborador();
            try
            {



                colaboradorGlobal.idColaborador = id;

                colaboradorGlobal = oColaborador.consultarColaborador(colaboradorGlobal.idColaborador);

                AtribuirCampos(colaboradorGlobal);


                this.Text = "Consultando: " + colaboradorGlobal.nomeCompleto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            

        }

        private void AtribuirCampos(Colaborador colaborador)
        {
            Nome.Text = colaborador.Nome.ToString();
            Sobrenome.Text = colaborador.SobreNome;
            Sexo.Text = colaborador.Sexo;
            CPF.Text = colaborador.CPF.RetornarFormatado();
            Salario.Text = colaborador.Salario.ToString();
            Porcentagem.Text = colaborador.PorcentagemDeComissao.ToString();
            //Conta.Text = colaborador.DadosBancarios;
            Telefone.Text = colaborador.contato.Telefone.ToString();
            Celular2.Text = colaborador.contato.Celular.Celular;
            DDI.Text = colaborador.contato.Celular.DDI;
            emailText.Text = colaborador.contato.Email;
            Data.Value = colaborador.DataDeNascimento;

            AtribuirCamposEnderecos(colaborador.endereco);


        }

        private void AtribuirCamposEnderecos(Endereco endereco)
        {
            CEP.Text = endereco.Cep.RetornarFormatado();
            Logradouro.Text = endereco.Logradouro;
            Cidade.Text = endereco.Cidade;
            UF.Text = endereco.UF;
            Complemento.Text = endereco.Complemento;
            Bairro.Text = endereco.Bairro;
            Numero.Text = endereco.Numero.ToString();
        }

        private void paginaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo voltar a pagina de listagem?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                this.Close();
                new ListarColaboradores().Show();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        

        private void BotaoSalvar_Click_1(object sender, EventArgs e)
        {
            preencherCampos();
            ConexaoDAO stmt = new ConexaoDAO();
            ColaboradorValidator validator = new ColaboradorValidator();
            var validadores = validator.Validate(colaboradorGlobal);

            if (validadores.IsValid)
            {
                try
                {
                    AlterarColaborador oColaborador = new AlterarColaborador();


                    if ((int)MessageBox.Show("Deseja mesmo Alterar os dados?", "Atenção", MessageBoxButtons.OKCancel) == 1)
                    {
                        oColaborador.SalvarColaborador(colaboradorGlobal);
                        MessageBox.Show("Dados Salvos com sucesso");
                        new ListarColaboradores().Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                
            }
            else
            {
                
                MessageBox.Show(validadores.Errors.FirstOrDefault().ToString(), "Atenção");

            }


        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            if ((int)MessageBox.Show("Deseja mesmo Excluir os dados (Serão excluidos permanente)?", "Atenção", MessageBoxButtons.OKCancel) == 1)
            {
                AlterarColaborador oColaborador = new AlterarColaborador();
                try
                {
                    oColaborador.Excluir(colaboradorGlobal);
                    this.Text = "Consultar Colaborador";
                    MessageBox.Show("Dados excluidos com sucesso");
                    colaboradorGlobal = null;
                    new ListarColaboradores().Show();
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    
                    
                }

            }   
        }

        private void ConsultarColaborador_Load(object sender, EventArgs e)
        {
            this.BackColor = Global.BackgroundColor;
            groupBox1.ForeColor = Global.FontColor;
            groupBox2.ForeColor = Global.FontColor;
            groupBox3.ForeColor = Global.FontColor;

            menuStrip1.ForeColor = Global.FontColor;
            label1.ForeColor = Global.FontColor;
            menuStrip1.BackColor = Global.Strip;
            menuStrip1.BackColor = Global.Strip;
            label1.ForeColor = Global.FontColor;
            label2.ForeColor = Global.FontColor;
            label3.ForeColor = Global.FontColor;
            label4.ForeColor = Global.FontColor;
            label5.ForeColor = Global.FontColor;
            label6.ForeColor = Global.FontColor;
            label7.ForeColor = Global.FontColor;
            label8.ForeColor = Global.FontColor;
            label9.ForeColor = Global.FontColor;
            label10.ForeColor = Global.FontColor;
            label11.ForeColor = Global.FontColor;
            label12.ForeColor = Global.FontColor;
            label14.ForeColor = Global.FontColor;
            label15.ForeColor = Global.FontColor;
            label16.ForeColor = Global.FontColor;
            label17.ForeColor = Global.FontColor;
        }

        public void preencherCampos()
        {




            colaboradorGlobal.Nome = Nome.Text;
            colaboradorGlobal.SobreNome = Sobrenome.Text;
            colaboradorGlobal.Sexo = Sexo.Text;
            decimal.TryParse(Salario.Text, out decimal x);
            colaboradorGlobal.Salario = x;
            colaboradorGlobal.DataDeNascimento = Data.Value;
            colaboradorGlobal.CPF = CPF.Text;
            //colaboradorGlobal.DadosBancarios = Conta.Text;
            colaboradorGlobal.contato.Email = emailText.Text;
            colaboradorGlobal.contato.Telefone = Telefone.Text;
            colaboradorGlobal.contato.Celular = Celular2.Text;

            colaboradorGlobal.contato.Celular.DDI = DDI.Text;
            colaboradorGlobal.PorcentagemDeComissao = Porcentagem.Value;




            colaboradorGlobal.endereco.Cep = CEP.Text;
            colaboradorGlobal.endereco.Logradouro = Logradouro.Text;
            colaboradorGlobal.endereco.Cidade = Cidade.Text;
            colaboradorGlobal.endereco.UF = UF.Text;
            colaboradorGlobal.endereco.Complemento = Complemento.Text;
            colaboradorGlobal.endereco.Bairro = Bairro.Text;
            int.TryParse(Numero.Text, out int i);

            colaboradorGlobal.endereco.Numero = i;





        }

        private void data_ValueChanged(object sender, EventArgs e)
        {

        }
    }

   
}
