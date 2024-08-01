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
using ContasAReceber.servico;

namespace ContasAReceber.View
{
    public partial class FrmContasAReceber : Form
    {
        OperacoesContas op = new OperacoesContas();
        ServicoDeLog log = new ServicoDeLog();
        public FrmContasAReceber()
        {
            InitializeComponent();
            log.Logs("Foi aberto o " + this.Name);
        }
        private void FrmContas_Load(object sender, EventArgs e)
        {
            try
            {
                CorGrid();
                AtualizaGridContas();
                CbxSituacao.SelectedIndex = 0;
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
        private void BntImprimir_Click(object sender, EventArgs e)
        {
            op.GerarRelatorio(dtgContas, lblValor.Text);
        }
        private void dtgContas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            CorGrid();           
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
          
            if (rbNome.Checked == true)
            {
                FiltroNomeCliente();
                
            }
            else if (rbSituacao.Checked)
            {
                FiltroSituacao();
            }
            else if (rbData.Checked)
            {
                FiltroData();
            }
            else if (rbTodos.Checked)
            {
                FiltroCompleto2();
            }
        }
        //*************************************Inicio dos metodos criados manualmenet*************************************************************************
        private void Filtro()
        {
            string filtro = TxtNomeCliente.Text;
            string situacao = CbxSituacao.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(filtro) && !string.IsNullOrEmpty(situacao))
            {
                // Use aspas simples (' ') ao redor do valor da situação
                bindingSource1.Filter = $"Nome LIKE '%{filtro}%' AND Situacao = '{situacao}'";
                SomaValor();
                ColoreValor();
            }
        }
        private void FiltroNomeCliente()
        {
            string filtro = TxtNomeCliente.Text;
            if (bindingSource1.DataSource != null)
            {
                filtro = TxtNomeCliente.Text;
                bindingSource1.DataSource = op.datSet().Tables["contasareceber"];

                if (bindingSource1 != null)
                {
                    bindingSource1.Filter = $"nome like '%{filtro}%'";
                    SomaValor();
                    ColoreValor();
                }
                else
                {
                    bindingSource1.RemoveFilter();
                }
            }
        }
        private void FiltroSituacao()
        {
            string situacao = CbxSituacao.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(situacao))
            {
                bindingSource1.RemoveFilter();
            }
            else if (situacao.Equals("Todos"))
            {
                bindingSource1.RemoveFilter();
                SomaValor();
                ColoreValor();
            }
            else
            {
                bindingSource1.Filter = $"situacao = '{situacao}'";
                SomaValor();
                ColoreValor();
            }
        }

        private void FiltroData()
        {
           DateTime dataInicio = dataInicial.Value;
           DateTime dataTermino = dataFinal.Value;
            string situacao = CbxSituacao.Text;
            string dataInicialFormatada = dataInicio.ToString("dd/MM/yyyy");
            string dataFinalFormatada = dataTermino.ToString("dd/MM/yyyy");
            string situacaoFiltro = $"situacao = '{situacao}'";
            string filtroData = $"vencimento >= '{dataInicialFormatada}' AND vencimento <= '{dataFinalFormatada}'";
            string filtroCompleto = $"{situacaoFiltro} AND {filtroData}";
            bindingSource1.Filter = filtroCompleto;
            SomaValor();
            ColoreValor();
        }
        private void FiltroCompleto1()
        {
            DateTime dataInicio = dataInicial.Value;
            DateTime dataTermino = dataFinal.Value;
            string situacao = CbxSituacao.Text;
            string dataInicialFormatada = dataInicio.ToString("dd/MM/yyyy");
            string dataFinalFormatada = dataTermino.ToString("dd/MM/yyyy");
            string situacaoFiltro = $"situacao = '{situacao}'";
            string filtroData = $"vencimento >= '{dataInicialFormatada}' AND vencimento <= '{dataFinalFormatada}'";
            string filtroCompleto = $"{situacaoFiltro} AND {filtroData}";
            bindingSource1.Filter = filtroCompleto;
            SomaValor();
            ColoreValor();
        }
        private void FiltroCompleto2()
        {
            DateTime dataInicio = dataInicial.Value;
            DateTime dataTermino = dataFinal.Value;
            string nomeCliente = TxtNomeCliente.Text;
            string situacao = CbxSituacao.Text;
            string dataInicialFormatada = dataInicio.ToString("dd/MM/yyyy");
            string dataFinalFormatada = dataTermino.ToString("dd/MM/yyyy");
            string nomeFiltro = $"nome LIKE '%{nomeCliente}%'";
            string situacaoFiltro = $"situacao = '{situacao}'";
            string filtroData = string.Format($"vencimento >= '{dataInicialFormatada}' AND vencimento <= '{dataFinalFormatada}'");
            string filtroCompleto = $"{nomeFiltro} AND {situacaoFiltro} AND {filtroData}";
            bindingSource1.Filter = filtroCompleto;
            SomaValor();
            ColoreValor();
        }
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
            switch (CbxSituacao.SelectedIndex)
            {
                case 0:
                    lblValor.ForeColor = Color.Black;
                    SomaValor();
                    break;
                case 1:
                    lblValor.ForeColor = Color.Red;
                    SomaValor();
                    break;
                case 2:
                    lblValor.ForeColor = Color.Yellow;
                    SomaValor();
                    break;
                case 3:
                    lblValor.ForeColor = Color.Green;
                    SomaValor();
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
            TxtNomeCliente.Clear();
        }
       
        private void BtnInserir_Click(object sender, EventArgs e)
        {
            FrmOperacoesContas frmInserirContas = new FrmOperacoesContas(this);
            frmInserirContas.ShowDialog();
        }
    }
}


