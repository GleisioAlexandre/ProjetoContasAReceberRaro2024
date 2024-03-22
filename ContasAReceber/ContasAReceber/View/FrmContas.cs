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

namespace ContasAReceber.View
{
    public partial class FrmContas : Form
    {
        public FrmContas()
        {
            InitializeComponent();

        }
       

        private void FrmContas_Load(object sender, EventArgs e)
        {
            CorGrid();
            OperacoesContas op = new OperacoesContas();
            try
            {
                dtgContas.DataSource = bindingSource1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            bindingSource1.DataSource = op.bindiSourceContas().Tables["contasareceber"];
                                                  
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
           
            OperacoesContas op = new OperacoesContas();
            dtgContas.DataSource = bindingSource1;
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


        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            printDocument1.PrintPage += printDocument1_PrintPage;
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
        private int rowIndex = 0;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int marginLeft = 1;
            int marginTop = 10;
            int x = marginLeft + e.MarginBounds.Left;
            int y = marginTop + e.MarginBounds.Top;

            int linhas = e.MarginBounds.Height / dtgContas.RowTemplate.Height;

            for (int i = 0; i < dtgContas.ColumnCount; i++)
            {
                e.Graphics.DrawString(dtgContas.Columns[i].HeaderText, dtgContas.Font, Brushes.Black, x, y);
                x += dtgContas.Columns[i].Width;
            }
            y += dtgContas.RowTemplate.Height;

            for (int i = 0; i < linhas && dtgContas.CurrentRow != null; i++)
            {
                x = e.MarginBounds.Left;
                for (int j = 0; j < dtgContas.Columns.Count; j++)
                {
                    e.Graphics.DrawString(dtgContas.CurrentRow.Cells[j].Value.ToString(),
                        dtgContas.Font, Brushes.Black, x, y);
                    x += dtgContas.Columns[j].Width;
                }
                y += dtgContas.RowTemplate.Height;
                linhas--;

                if (linhas == 0)
                {
                    rowIndex = i + 1;
                    if (rowIndex < dtgContas.Rows.Count)
                    {
                        e.HasMorePages = true;
                    }
                    else
                    {
                        e.HasMorePages = false;
                        rowIndex = 0;
                    }
                    return;
                }

            }
            e.HasMorePages = false;
            rowIndex = 0;

           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            OperacoesContas op = new OperacoesContas();
            bindingSource1.DataSource = op.bindiSourceContas().Tables["contasareceber"];
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
                     Console.WriteLine(textoDaCelula);
                     FrmOperacoesContas frmInserirContas = new FrmOperacoesContas(this);
                     frmInserirContas.DadosDOFormContas(textoDaCelula);
                     frmInserirContas.ShowDialog();
                 }
             }
            
        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
          
        }
    }
}
    

