using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using ContasAReceber.model;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;

namespace ContasAReceber.controller
{
    class OperacoesContas
    {
        Contas contas = new Contas();

        public DataSet datSet()
        {
            return contas.dataSet();
        }
        public DataTable ExibGridContas()
        {

            return contas.ExibeGridContas();
        }
        public void InserirConta(string entrada, int idCliente, double valor, string documento, int classe, int situacao, string vencimento, string pagamento)
        {
            contas.InserirConta(entrada, idCliente, valor, documento, classe, situacao, vencimento, pagamento);

        }
        public object[] PesquisarDivida(String documento)
        {
            object[] obj = new object[10];
            obj[0] = contas.PesquisaContoas(documento)[0];
            obj[1] = contas.PesquisaContoas(documento)[1];
            obj[2] = contas.PesquisaContoas(documento)[2];
            obj[3] = contas.PesquisaContoas(documento)[3];
            obj[4] = contas.PesquisaContoas(documento)[4];
            obj[5] = contas.PesquisaContoas(documento)[5];
            obj[6] = contas.PesquisaContoas(documento)[6];
            obj[7] = contas.PesquisaContoas(documento)[7];
            obj[8] = contas.PesquisaContoas(documento)[8];
            obj[9] = contas.PesquisaContoas(documento)[9];
            return obj;
        }
        public object[] PesquisarCliente(String nome)
        {
            Cliente cliente = new Cliente();
            object[] retorno = new object[2];
            retorno[0] = cliente.PesquisarCliente(nome)[0];
            retorno[1] = cliente.PesquisarCliente(nome)[1];
            return retorno;
        }

        public void DeletarContas(Int32 idcontas)
        {
            contas.DeletarContas(idcontas);
        }

        public void AtualizaContas(string entrada, Int32 idcliente, Double valor, String documento, Int32 classe, Int32 situacao, string vencimento, string pagamento, int idcontas)
        {
            contas.AtualizarContas(entrada, idcliente, valor, documento, classe, situacao, vencimento, pagamento, idcontas);
        }

        public void GerarRelatorio(DataGridView dtgContas)
        {
            string data = DateTime.Now.ToString("ddMMyyyyhhmmss");
            try
            {
                string caminho = PegarCaminho() + $@"\{data}.pdf";
                Document doc = CriarDocumento();
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
                writer.PageEvent = new Rodape();
                doc.Open();
                Cabecalho(doc);
                Conteudo(doc, dtgContas);
                doc.Close();
                writer.Close();
                AbrirPdf(caminho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
                Console.WriteLine(ex);
            }
        }
        private Document CriarDocumento()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(30, 30, 30, 30);
            doc.AddCreationDate();
            doc.Open();
            return doc;
        }
        private void Cabecalho(Document doc)
        {
            Data(doc);
            PdfPTable headerTable = new PdfPTable(2);
            headerTable.TotalWidth = 560;
            headerTable.LockedWidth = true;
            headerTable.HorizontalAlignment = Element.ALIGN_CENTER;
            Image logo = Image.GetInstance(@"E:\Download\logo.png");
            logo.ScaleAbsolute(100f, 40f);
            PdfPCell logoCell = new PdfPCell(logo);
            logoCell.HorizontalAlignment = Element.ALIGN_LEFT;
            logoCell.Border = PdfPCell.NO_BORDER;
            headerTable.AddCell(logoCell);
            PdfPCell headerCell = new PdfPCell();
            headerCell.HorizontalAlignment = Element.ALIGN_RIGHT;
            headerCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            headerCell.Border = PdfPCell.NO_BORDER;
            headerTable.AddCell(headerCell);
            doc.Add(headerTable);
            doc.Add(headerCell);
            DadosDaEmpresa(doc);
            Endereco(doc);
            Contato(doc);
            Titulo(doc);
        }
        private void Data(Document doc)
        {
            Font fontData = new Font(BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 8);
            Paragraph data = new Paragraph(DateTime.Now.ToString(), fontData);
            data.Alignment = Element.ALIGN_RIGHT;
            doc.Add(data);
        }
        private void DadosDaEmpresa(Document doc)
        {
            Font fontEmpresa = new Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 5);
            Paragraph dadosEmpresa = new Paragraph("RARO DO SER CONFECÇOES LTDA \n31.269.525/0001-50", fontEmpresa);
            dadosEmpresa.Alignment = Element.ALIGN_LEFT;
            doc.Add(dadosEmpresa);
        }
        private void Endereco(Document doc)
        {
            Font fontEndereco = new Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 5);
            Paragraph endereco = new Paragraph("Rua Jose dos Reis, 492\nENGENHO DE DENTRO\nRIO DE JANEIRO - RJ\nCEP: 20770-061", fontEndereco);
            endereco.Alignment = Element.ALIGN_LEFT;
            doc.Add(endereco);
        }
        private void Contato(Document doc)
        {
            Font fontContato = new Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 5);
            Paragraph contato = new Paragraph("3899-7788", fontContato);
            contato.Alignment = Element.ALIGN_LEFT;
            doc.Add(contato);
        }
        private void Titulo(Document doc)
        {
            Font fontTitulo = new Font(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 30);
            Paragraph titulo = new Paragraph("\n\nRelatório de Clientes \n\n", fontTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingBefore = -100f;
            titulo.SpacingAfter = -20f;
            doc.Add(titulo);
        }

        private void Conteudo(Document doc, DataGridView dtgContas)
        {
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fonteCabecalho = new Font(baseFont, 8);
            Font fonteConteudo = new Font(baseFont, 7);
            PdfPTable table = new PdfPTable(dtgContas.Columns.Count);
            table.WidthPercentage = 105;
            float[] larguraColuna = new float[] { 1f, 4f, 1f, 1f, 0f, 1f, 1f, 1f };
            table.SetWidths(larguraColuna);
            AdicionarCabecalho(dtgContas, table, fonteCabecalho);
            AdicionaDados(dtgContas, table, fonteConteudo);
            doc.Add(table);
        }
        private void AdicionarCabecalho(DataGridView dtgContas, PdfPTable table, Font fontCabecalho)
        {
            foreach (DataGridViewColumn column in dtgContas.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontCabecalho));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }
        }
        private void AdicionaDados(DataGridView dtgContas, PdfPTable table, Font fonteConteudo)
        {
            foreach (DataGridViewRow row in dtgContas.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell cellPdf = new PdfPCell(new Phrase(cell.Value != null ? cell.Value.ToString() : string.Empty, fonteConteudo));
                    AjustarFormatoCelula(cell, cellPdf);
                    table.AddCell(cellPdf);
                }
            }
        }
        private void AjustarFormatoCelula(DataGridViewCell cell, PdfPCell cellPdf)
        {
            string dataFormatada = (cell.Value != null && cell.Value != DBNull.Value && DateTime.TryParse(cell.Value.ToString(), out DateTime data)) ? data.ToString("dd/MM/yyyy") : string.Empty;
            switch (cell.OwningColumn.Name)
            {
                case "entrada":
                    cellPdf.Phrase = new Phrase(dataFormatada, cellPdf.Phrase.Font);
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
                case "valor":
                    string valorMonetario = string.Format("{0:C}", cell.Value != null ? cell.Value : 0);
                    cellPdf.Phrase = new Phrase(valorMonetario, cellPdf.Phrase.Font);
                    cellPdf.HorizontalAlignment = Element.ALIGN_RIGHT;
                    break;
                case "documento":
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
                case "tipo":
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
                case "situacao":
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
                case "vencimento":
                    cellPdf.Phrase = new Phrase(dataFormatada, cellPdf.Phrase.Font);
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
                case "pagamento":
                    cellPdf.Phrase = new Phrase(dataFormatada, cellPdf.Phrase.Font);
                    cellPdf.HorizontalAlignment = Element.ALIGN_CENTER;
                    break;
            }

        }

        private string PegarCaminho()
        {
            string caminho = "";
            // Cria um novo FolderBrowserDialog
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            // Define o título da caixa de diálogo
            browserDialog.Description = "Selecione uma pasta";
            // Define o diretório inicial
            browserDialog.SelectedPath = @"Desktop\";
            // Exibe a caixa de diálogo e aguarda o usuário selecionar um diretório
            DialogResult result = browserDialog.ShowDialog();
            // Verifica se o usuário selecionou um diretório
            caminho = browserDialog.SelectedPath;
            return caminho;
        }
        private void AbrirPdf(string caminhoPdf)
        {
            try
            {
                if (File.Exists(caminhoPdf))
                {
                    Process.Start(caminhoPdf);
                }
                else
                {
                    MessageBox.Show("O arquivo PDF não foi encontrado!", "Erro ao Abrir o PDF");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao Gerar o PDF: {ex.Message}", "Erro ao gerar o PDF");
            }
        }
        public class Rodape : PdfPageEventHelper
        {
            // Variável para armazenar o número total de páginas
            protected int totalPaginas;

            // Sobrescreve o método OnStartPage para atualizar o número total de páginas
            public override void OnStartPage(PdfWriter writer, Document document)
            {
                base.OnStartPage(writer, document);
                totalPaginas++;
            }

            // Sobrescreve o método OnEndPage para adicionar o número de página ao rodapé
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);

                // Cria uma fonte para o texto do rodapé
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                Font fontRodape = new Font(baseFont, 8);

                // Cria um objeto Phrase com o número da página
                Phrase frasePagina = new Phrase("Página " + writer.PageNumber + " de " + totalPaginas, fontRodape);

                // Adiciona o número da página ao rodapé na posição desejada
                ColumnText.ShowTextAligned(writer.DirectContent,
                    Element.ALIGN_CENTER,
                    frasePagina,
                    document.PageSize.Width / 2,
                    document.BottomMargin - 10,
                    0);
            }
        }

    }
}
