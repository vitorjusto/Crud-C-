using crud_teste.Model.Object_Values;
using EnumsNET;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_teste.Model
{
    public class FiltroRelatorioCliente
    {

            
            public string Nome { get; set; }

            public bool PesquisarPorData { get; set; }

            public DateTime DataInicial { get; set; }

            public DateTime DataFinal { get; set; }

            public enum OrdenarPor 
            {
                    [Description ("idCliente")]
                        PorId,
                    [Description ("Nome")]
                        PorNome,
                    [Description ("sum(v.quantidadeTotal)")]
                        PorQuantidade,
                    [Description ("sum(v.TotalDeDesconto) + sum(v.DescontoAVista)")]
                        PorTotalDeDesconto,
                    [Description ("SUM(ca.PrecoDeVenda) - sum(ca.PrecoDeCusto)")]
                        PorLucro,
            }
       
            public enum crescente
            {
                [Description ("ASC")]
                    Crescente,
                [Description ("DESC")]
                    Decresente,
            }
            public enum condicao
            {
                 [Description (">")]
                    MaiorQue,
                 [Description (">=")]
                    MaiorIgualQue,
                 [Description ("<")]
                    MenorQue,
                 [Description ("<=")]
                    MenorIgualQue,
                 [Description ("=")]
                    Igual,
                 [Description("!=")]
                    Diferente,
                 [Description("between")]
                    Entre,
            }
            
            public enum Condicaopor
            {
                [Description("SUM(V.TotalBruto)")]
                PorTotalBruto,
                [Description("SUM(V.quantidadetotal)")]
                PorQuantidade,
                [Description("SUM(v.TotalDeDesconto) + sum(v.DescontoAVista)")]
                PorTotalDeDesconto,
                [Description("SUM(v.TotalLiquido)")]
                PorTotalLiquido,
                
            }
            public MyDinheiro valorInicial { get; set; }

            public MyDinheiro ValorFinal { get; set; }
            public long topresultadosnumero { get; set; }

            public string query { get; set; }

        public void GerarSql(string nome, bool PesquisarPorData, DateTime DataInicial, DateTime DataFinal, int ordenarPor, int crescente, int condicao, int condicaoPor, bool comCondicao, MyDinheiro ValorInicial, MyDinheiro ValorFinal, bool considerarTopResults, long topresultadosnumero, bool comAtivo)
        {
            query = $@"select ";

            if (considerarTopResults)
            {
                query += $@"Top (@TopResultado) ";
                
            }
            this.topresultadosnumero = topresultadosnumero;

            query += $@"c.idcliente, nome, sobrenome, COUNT(V.idvenda) as 'QuantidadeDeVenda',
                            SUM(V.quantidadetotal) as 'QuantidadeTotal',
                            SUM(V.TotalBruto) as 'TotalBruto', SUM(v.TotalDeDesconto) as 'TotalDeDesconto',
                            sum(v.DescontoAVista) as 'TotalDedescontoAVista', SUM(v.TotalLiquido) as 'TotalLiquido',
                            c.LimiteRestante, p.Ativo,  SUM(ca.Totalgasto) as 'PrecoDeCusto'

                            from cliente c
                            inner join pessoa p on p.idPessoa = c.IdPessoa
                            inner join Venda v on v.idCliente = c.idCliente
                            inner join Carrinho ca on ca.idVenda = v.idVenda

                            where nome + ' ' + sobrenome like @Nome +'%' and v.ativo = 1";

            if (PesquisarPorData)
            {
                query += "and Cast(DiaDaVenda as date) between @DataInicial and @DataFinal ";
                this.DataInicial = DataInicial;
                this.DataFinal = DataFinal;
            }

            if (comAtivo)
                query += "and p.Ativo = 1";

            query += "group by c.idCliente, Nome, Sobrenome, LimiteRestante, p.ativo ";

            if (comCondicao)
            {
                query += $"Having {((Condicaopor)condicaoPor).AsString(EnumFormat.Description)}";
                if (condicao == 6)
                {
                    query += $" between @ValorInicial and @ValorFinal ";
                }
                else
                {
                    query += $@"{((condicao)condicao).AsString(EnumFormat.Description)} @ValorInicial ";
                }
            }

            Nome = nome;
            this.ValorFinal = ValorFinal;
            valorInicial = ValorInicial;
            this.DataFinal = DataFinal;
            this.DataInicial = DataInicial;
            this.topresultadosnumero = topresultadosnumero;

            query += $@"order by {((OrdenarPor)ordenarPor).AsString(EnumFormat.Description)} {((crescente)crescente).AsString(EnumFormat.Description)}";
        }

    }
}
