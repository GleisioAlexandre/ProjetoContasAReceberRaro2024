using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContasAReceber.controller;
using ContasAReceber.model;
using FirebirdSql.Data.FirebirdClient;
using PagedList;
using System.Drawing.Printing;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Renderer;
using System.IO;
using System.Diagnostics;

namespace ContasAReceber.View
{
    public partial class FrmContas : Form
    {
        OperacoesContas op = new OperacoesContas();
        public FrmContas()
        {
            InitializeComponent();
        }
        private void FrmContas_Load(object sender, EventArgs e)
        {
            try
            {
                AtualizaGridContas();
                toolStripComboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void CorGrid()
        {

            int colunaIndex = 5;
            foreach (DataGridViewRow row in dtgContas.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataGridViewCell celula = row.Cells[colunaIndex];

                    string textocelula = celula.Value.ToString();
                    if (textocelula == "Pago")
                    {
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }

                }
            }
        }
        public void AtualizaGridContas()
        {
            bindingSource1.DataSource = op.BindiSourceContas().Tables["contasareceber"];
            dtgContas.DataSource =bindingSource1;
            toolStripTextBox1.Clear();
        }
        private void FrmContas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                FrmOperacoesContas frmInserirContas = new FrmOperacoesContas(this);
                frmInserirContas.ShowDialog();
            }
        }
        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            bindingSource1.DataSource = op.BindiSourceContas().Tables["contasareceber"];
            string filtro = toolStripTextBox1.Text;
            if(bindingSource1 != null)
            {
                bindingSource1.Filter = string.Format("nome like '%{0}%'", filtro);
            }
        }
        private void dtgContas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && e.RowIndex < dtgContas.Rows.Count)
             {
                 DataGridViewRow linhaClicada = dtgContas.Rows[e.RowIndex];

                 int indiceDaColuna = 3;

                 object valorDaCelula = linhaClicada.Cells[indiceDaColuna].Value;

                 if (valorDaCelula != null)
                 {
                     string textoDaCelula = valorDaCelula.ToString();
                     FrmOperacoesContas operacoesContas = new FrmOperacoesContas(this);
                     operacoesContas.DadosDoFormContas(textoDaCelula);
                     operacoesContas.ShowDialog();
                 }
             }
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string situacao = toolStripComboBox1.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(situacao))
            {
                bindingSource1.RemoveFilter();
            }
            else if (situacao.Equals("Todos"))
            {
                bindingSource1.RemoveFilter();
            }
            else
            {
                bindingSource1.Filter = $"situacao = '{situacao}'";
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
          
        }
        private void GerarRelatorio()
        {

            try
            {
                string caminhoPdf = @"E:\Desktop\bd\relatorio.pdf";
                using (PdfWriter writer = new PdfWriter(@"E:\Desktop\bd\relatorio.pdf"))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document documento = new Document(pdf);
                        Paragraph titulo = new Paragraph("Relatorio");
                        titulo.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                        pdf.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4.Rotate());
                        titulo.SetFontSize(30);
                        documento.Add(titulo);
                        Table table = new Table(dtgContas.Columns.Count);

                        foreach (DataGridViewColumn column in dtgContas.Columns)
                        {
                            table.AddHeaderCell(new Paragraph(column.HeaderText)); 
                        }
                        foreach (DataGridViewRow row in dtgContas.Rows)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                table.AddCell(new Paragraph(cell.Value.ToString()));
                            }
                        }
                        foreach (Cell cell in table.GetChildren())
                        {
                            foreach (IBlockElement element in cell.GetChildren())
                            {
                                if (element is Paragraph paragraph)
                                {
                                    paragraph.SetFontSize(9f);
                                }
                            }
                        }

                        documento.Add(table);
                        documento.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex}", "Erro");
                Console.WriteLine(ex);
            }
          /*  if (File.Exists(caminhoPdf))
            {
                Process.Start(caminhoPdf);
            }*/
        }

       
    }
}
    

