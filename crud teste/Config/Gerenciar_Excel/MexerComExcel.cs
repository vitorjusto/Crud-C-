using ClosedXML.Excel;
using crud_teste.controller;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace crud_teste.Config.Gerenciar_Excel
{
    public class MexerComExcel
    {

        public static void criararquivo()
        {
            SaveFileDialog destino = new SaveFileDialog();
            destino.Filter = "Arquivo xlsx|*.xlsx";
            destino.Title = "Salvar relatório";
            destino.ShowDialog();

            if (destino.FileName == "")
                return;

            var arquivo = new XLWorkbook();
            DataTable produtos = new DataTable();

            arquivo.Worksheets.Add(CriarHistoricoDeProduto(), "Relatório Completo");
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

            arquivo.SaveAs(destino.FileName);

        }

        public static DataTable CriarHistoricoDeProduto()
        {
            DataTable produtos = new DataTable();
            var relatorio = new AlterarVenda().ListarProdutosDaVendas();
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
                produtos.Rows.Add(row, item.IdCarrinho, item.produto.NomeDoProduto, item.precoDeCusto.GetAsDecimal(), item.precoDeVenda.GetAsDecimal(), item.quantidade, item.PrecoBruto.GetAsDecimal(), item.Desconto.GetAsDecimal(), item.PrecoLiquido.GetAsDecimal());
                row++;
            }


            return produtos;

        }


        public static DataTable criarRelatorioDeVenda()
        {
            DataTable venda = new DataTable();
            var relatorio = new AlterarVenda().Listar();

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
                venda.Rows.Add(row, item.IdVenda, item.NomeCompletoColaborador(), item.NomeCompletoCliente(), item.QuantidadeTotal, item.TotalBruto.GetAsDecimal(), item.TotalDeDesconto.GetAsDecimal(), item.TotalLiquido.GetAsDecimal(), item.TipoDeVenda) ;
            }

            return venda;
        }
    }
}
