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
using System.IO;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

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
                CorGrid();
                AtualizaGridContas();
                toolStripComboBox1.SelectedText = "Todos";
                SomaValor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro, ao conectar o banco de dados! \n Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

            bindingSource1.DataSource = op.datSet().Tables["contasareceber"];
            string filtro = toolStripTextBox1.Text;
            if (bindingSource1 != null)
            {
                bindingSource1.Filter = string.Format("nome like '%{0}%'", filtro);
            }
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            dtgContas.CurrentRow.DefaultCellStyle.BackColor = Color.Red;
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
                SomaValor();
                ColoreValor();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            op.GerarRelatorio(dtgContas);
        }
        private void dtgContas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CorGrid();           
        }
        //I*************************************Inicio dos metodos criados manualmenet*************************************************************************
        private void SomaValor()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dtgContas.Rows)
            {
                total = total + Convert.ToDecimal(row.Cells[2].Value);
            }
            lblValor.Text = "Total: " + total.ToString("C2");
        }
        private void ColoreValor()
        {
            switch (toolStripComboBox1.SelectedIndex)
            {
                case 0:
                    lblValor.ForeColor = Color.Black;
                    break;
                case 1:
                    lblValor.ForeColor = Color.Red;
                    break;
                case 2:
                    lblValor.ForeColor = Color.Yellow;
                    break;
                case 3:
                    lblValor.ForeColor = Color.Green;
                    break;
               
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
                    }else if (textocelula == "Atrasado")
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }else if (textocelula == "Em Dia")
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = Color.White;
                    }
                }
            }
        }
        public void AtualizaGridContas()
        {
            //Define o bindingSource
            bindingSource1.DataSource = op.datSet().Tables["contasareceber"];
            //Carrega o dataGrid com os dados do bindingSource
            dtgContas.DataSource = bindingSource1;
            //Limpa o texbox do filtro
            toolStripTextBox1.Clear();
           
        }
       
        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            FrmOperacoesContas frmInserirContas = new FrmOperacoesContas(this);
            frmInserirContas.ShowDialog();
        }
    }
}


