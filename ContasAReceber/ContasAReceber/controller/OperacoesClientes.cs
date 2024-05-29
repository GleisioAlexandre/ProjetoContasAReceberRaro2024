using ContasAReceber.model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ContasAReceber.controller
{
    class OperacoesClientes
    {
        Cliente cliente = new Cliente();

        public DataSet BindigSourceClientes()
        {
            return cliente.BindingSourceClinetes(); ;
        }
        public void InseirClinete(String nome, String cadastropessoa, String nomeContato, String telefone, String celular, String email, String cep, String logradouro, Int32 numero, String complemento, String bairro, String cidade, String uf, Int32 pj)
        {
            cliente.InserirClientes(nome, cadastropessoa, nomeContato, telefone, celular, email, cep, logradouro, numero, complemento, bairro, cidade, uf, pj);
        }
        public object[] PesquisaCliente(String nome)
        {
            object[] obj = new object[15];
            obj[0] = cliente.PesquisarCliente(nome)[0];
            obj[1] = cliente.PesquisarCliente(nome)[1];
            obj[2] = cliente.PesquisarCliente(nome)[2];
            obj[3] = cliente.PesquisarCliente(nome)[3];
            obj[4] = cliente.PesquisarCliente(nome)[4];
            obj[5] = cliente.PesquisarCliente(nome)[5];
            obj[6] = cliente.PesquisarCliente(nome)[6];
            obj[7] = cliente.PesquisarCliente(nome)[7];
            obj[8] = cliente.PesquisarCliente(nome)[8];
            obj[9] = cliente.PesquisarCliente(nome)[9];
            obj[10] = cliente.PesquisarCliente(nome)[10];
            obj[11] = cliente.PesquisarCliente(nome)[11];
            obj[12] = cliente.PesquisarCliente(nome)[12];
            obj[13] = cliente.PesquisarCliente(nome)[13];
            obj[14] = cliente.PesquisarCliente(nome)[14];
            return obj;
        }
        public void DeletaCliente(int idcliente)
        {
            cliente.DeletarCliente(idcliente);
        }
        public void AtualizarCliente(String nome, String cadastropessoa, String nomeContato, String telefone, String celular, String email, String cep, String logradouro, Int32 numero, String complemento, String bairro, String cidade, String uf, Int32 pj, Int32 idpessoa)
        {
            cliente.AtualizarCliente(nome, cadastropessoa, nomeContato, telefone, celular, email ,cep, logradouro, numero, complemento, bairro, cidade, uf, pj, idpessoa);
        }
        public void GerarRelatorio(DataGridView dtgClientes)
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
                Conteudo(doc, dtgClientes);
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
            Image logo = Image.GetInstance(ConfigurationManager.AppSettings["Logo"]);
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
            Paragraph titulo = new Paragraph("\n\n Clientes \n\n", fontTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingBefore = -100f;
            titulo.SpacingAfter = -20f;
            doc.Add(titulo);
        }
        private void Conteudo(Document doc, DataGridView dtgClientes)
        {
            BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fonteCabecalho = new Font(baseFont, 8);
            Font fonteConteudo = new Font(baseFont, 7);
            PdfPTable table = new PdfPTable(dtgClientes.Columns.Count);
            table.WidthPercentage = 105;
            float[] larguraColuna = new float[] { 0f, 2f, 1f, 1f, 1f, 1f, 1f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f };
            table.SetWidths(larguraColuna);
            AdicionarCabecalho(dtgClientes, table, fonteCabecalho);
            AdicionaDados(dtgClientes, table, fonteConteudo);
            doc.Add(table);
        }
        private void AdicionarCabecalho(DataGridView dtgClientes, PdfPTable table, Font fontCabecalho)
        {
            foreach (DataGridViewColumn column in dtgClientes.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, fontCabecalho));
                cell.BackgroundColor = new BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                table.AddCell(cell);
            }
        }
        private void AdicionaDados(DataGridView dtgClientes, PdfPTable table, Font fonteConteudo)
        {
            foreach (DataGridViewRow row in dtgClientes.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    PdfPCell cellPdf = new PdfPCell(new Phrase(cell.Value != null ? cell.Value.ToString() : string.Empty, fonteConteudo));
                    table.AddCell(cellPdf);
                }
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
        public string FomataNumeroTelefone(string numeroTelefone)
        {

            return numeroTelefone == "(  )    -" || numeroTelefone == "(  )     -" ? "": numeroTelefone;
        }       
    }
}
