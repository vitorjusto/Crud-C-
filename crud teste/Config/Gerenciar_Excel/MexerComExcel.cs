using ClosedXML.Excel;
using crud_teste.controller;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.Config.Gerenciar_Excel
{
    public class MexerComExcel
    {
        public static DateTime DataInicial { get; set; }
        public static DateTime DataFinal { get; set; }
        public static void criararquivo(DateTime dataInicial, DateTime dataFinal)
        {
            SaveFileDialog destino = new SaveFileDialog();
            destino.Filter = "Arquivo xlsx|*.xlsx";
            destino.Title = "Salvar relatório";
            destino.ShowDialog();

            DataInicial = dataInicial;
            DataFinal = dataFinal;


            if (destino.FileName == "")
                return;

            var arquivo = new XLWorkbook();
            DataTable produtos = new DataTable();

            arquivo.Worksheets.Add(CriarHistoricoDeCarrinhos(), "Relatório Completo");
            var planilha1 = arquivo.Worksheets.Worksheet("Relatório Completo");

            planilha1.ColumnsUsed().Width = 20;
            planilha1.Column(1).Width = 5;
            planilha1.Column(2).Width = 5;
            planilha1.Column(6).Width = 10;

            planilha1.Rows("1").CellsUsed().Style.Fill.BackgroundColor = XLColor.FromArgb(51, 153, 255);
            planilha1.Rows("1").CellsUsed().Style.Font.FontColor = XLColor.FromTheme(XLThemeColor.Text1);

            var index = 2;
            while (index <= planilha1.Rows().Count())
            {
                planilha1.Rows(index.ToString()).CellsUsed().Style.Fill.BackgroundColor = index % 2 == 0 ? XLColor.AliceBlue : XLColor.LightBlue;
                planilha1.Cell(index, 1).DataType = XLDataType.Number;
                planilha1.Cell(index, 2).DataType = XLDataType.Number;

                int col = 4;
                while (col < 10)
                {
                    if (col != 6)
                        planilha1.Cell(index, col).Style.NumberFormat.Format = "R$ #,##0.00_);";
                    col++;
                }
                index++;
            }

            arquivo.Worksheets.Add(criarRelatorioDeVenda(), "Relatório de venda");

            var planilha2 = arquivo.Worksheets.Worksheet("Relatório de venda");

            planilha2.ColumnsUsed().Width = 20;
            planilha2.Column(1).Width = 5;
            planilha2.Column(2).Width = 5;
            planilha2.Column(5).Width = 10;

            planilha2.Rows("1").CellsUsed().Style.Fill.BackgroundColor = XLColor.FromArgb(51, 153, 255);
            planilha2.Rows("1").CellsUsed().Style.Font.FontColor = XLColor.FromTheme(XLThemeColor.Text1);

            index = 2;
            while (index <= planilha2.Rows().Count())
            {
                planilha2.Rows(index.ToString()).CellsUsed().Style.Fill.BackgroundColor = index % 2 == 0 ? XLColor.AliceBlue : XLColor.LightBlue;
                planilha2.Cell(index, 1).DataType = XLDataType.Number;
                planilha2.Cell(index, 2).DataType = XLDataType.Number;

                int col = 5;
                while (col < 9)
                {
                    if (col != 5)
                        planilha2.Cell(index, col).Style.NumberFormat.Format = "R$ #,##0.00_);";
                    col++;
                }
                index++;
            }

            arquivo.Worksheets.Add(criarRelatorioDeProduto(), "Relatório dos Produtos");

            var planilha3 = arquivo.Worksheets.Worksheet("Relatório de venda");

            planilha3.ColumnsUsed().Width = 20;
            planilha3.Column(1).Width = 5;
            planilha3.Column(2).Width = 5;
            planilha3.Column(4).Width = 10;

            planilha3.Rows("1").CellsUsed().Style.Fill.BackgroundColor = XLColor.FromArgb(51, 153, 255);
            planilha3.Rows("1").CellsUsed().Style.Font.FontColor = XLColor.FromTheme(XLThemeColor.Text1);

            index = 2;
            while (index <= planilha2.Rows().Count())
            {
                planilha3.Rows(index.ToString()).CellsUsed().Style.Fill.BackgroundColor = index % 2 == 0 ? XLColor.AliceBlue : XLColor.LightBlue;
                planilha3.Cell(index, 1).DataType = XLDataType.Number;
                planilha3.Cell(index, 2).DataType = XLDataType.Number;
                index++;
            }

            arquivo.SaveAs(destino.FileName);

        }

        public static DataTable CriarHistoricoDeCarrinhos()
        {
            DataTable produtos = new DataTable();
            var relatorio = new AlterarVenda().ListarProdutosDaVendas(DataInicial, DataFinal);
            produtos.Columns.Add(" ");
            produtos.Columns.Add("Id");
            produtos.Columns.Add("Nome Do Produto");
            produtos.Columns.Add("Preço De Custo");
            produtos.Columns.Add("Preço Unitário");
            produtos.Columns.Add("Quantidade");
            produtos.Columns.Add("Preço Bruto");
            produtos.Columns.Add("Desconto");
            produtos.Columns.Add("Preço Liquido");

            var row = 1;
            foreach(var item in relatorio)
            {
                produtos.Rows.Add(row, item.IdCarrinho, item.produto.NomeDoProduto, item.precoDeCusto.GetAsDouble(), item.precoDeVenda.GetAsDouble(), item.quantidade, item.PrecoBruto.GetAsDouble(), item.Desconto.GetAsDouble(), item.PrecoLiquido.GetAsDouble());
                row++;
            }
            return produtos;
        }
        public static DataTable criarRelatorioDeVenda()
        {
            DataTable venda = new DataTable();
            var relatorio = new AlterarVenda().Listar(new crud_teste.vieew.ListaDePedidos.ListagemDePedidos.pesquisar { dataInicial = DataInicial, dataFinal = DataFinal } );

            venda.Columns.Add(" ");
            venda.Columns.Add("Id");
            venda.Columns.Add("Nome Do Colaborador");
            venda.Columns.Add("Nome Do Cliente");
            venda.Columns.Add("Quantidade de Produtos");
            venda.Columns.Add("Total Bruto");
            venda.Columns.Add("Total De Desconto");
            venda.Columns.Add("Total Liquido");
            venda.Columns.Add("Tipo De Venda");

            
            var row = 1;
            foreach(var item in relatorio)
            {
                venda.Rows.Add(row, item.IdVenda, item.NomeCompletoColaborador(), item.NomeCompletoCliente(), item.QuantidadeTotal, item.TotalBruto.GetAsDouble(), item.TotalDeDesconto.GetAsDouble(), item.TotalLiquido.GetAsDouble(), item.TipoDeVenda) ;
                row++;
            }

            return venda;
        }

        public static DataTable criarRelatorioDeProduto()
        {
            DataTable produtos = new DataTable();
            var relatorio = new AlterarProduto().RelatorioDeVendaDosProdutos(new vieew.Listar.ListaDePedidos.ListagemDePedidos.RelatorioDosProdutos.pesquisar { DataInicial = DataInicial, DataFinal = DataFinal});

            produtos.Columns.Add(" ");
            produtos.Columns.Add("Id");
            produtos.Columns.Add("Nome Do Produto");
            produtos.Columns.Add("Quantidade Vendida");
            produtos.Columns.Add("Total Bruto");
            produtos.Columns.Add("Total De Desconto");
            produtos.Columns.Add("Total Liquido");
            produtos.Columns.Add("Lucro (R$)");
            produtos.Columns.Add("Lucro (%)");

            var row = 1;
            foreach(var item in relatorio)
            {
                produtos.Rows.Add
                    (
                        row,
                        item.idProduto,
                        item.nomeProduto,
                        item.Quantidade,
                        item.TotalBruto.GetAsString(),
                        item.DescontoTotal.GetAsString(),
                        item.TotalLiquido.GetAsString(),
                        item.LucroEmDinheiro.GetAsString(),
                        item.LucroEmPorcento.ToString()
                    );
                row++;
            }

            return produtos;
        }
    }
}
