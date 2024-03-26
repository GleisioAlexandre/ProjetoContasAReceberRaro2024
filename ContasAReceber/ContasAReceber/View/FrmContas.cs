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

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 50;
            int y = 50;
            int cellHeight = 20;

            foreach (DataGridViewColumn column in dtgContas.Columns)
            {
                e.Graphics.DrawString(column.HeaderText, dtgContas.Font, Brushes.Black, x, y);
                x += column.Width;
            }
            foreach (DataGridViewRow row in dtgContas.Rows)
            {
                y += cellHeight;
                x = 50;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(cell.Value.ToString(), dtgContas.Font, Brushes.Black, x, y);
                    x += cell.OwningColumn.Width;
                }
               
            }
        }
    }
}
    

