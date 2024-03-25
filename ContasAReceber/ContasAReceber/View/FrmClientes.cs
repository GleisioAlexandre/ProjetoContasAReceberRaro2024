using ContasAReceber.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAReceber.View
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }
        OperacoesClientes op = new OperacoesClientes();
        private void FrmClientes_Load(object sender, EventArgs e)
        {
            AtualizaGriCliente();
        }

        private void FrmClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
            {
                FrmOperacoesClientes opClientes = new FrmOperacoesClientes(this);
                opClientes.ShowDialog();
            }
        }
        public void AtualizaGriCliente()
        {
            bindingSource1.DataSource = op.BindigSourceClientes().Tables["pessoa"];
            dtgClientes.DataSource = bindingSource1;
            toolStripTextBox1.Clear();
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            bindingSource1.DataSource = op.BindigSourceClientes().Tables["pessoa"];
            string filtro = toolStripTextBox1.Text;
            if (bindingSource1 != null)
            {
                bindingSource1.Filter = string.Format("nome like '%{0}%'", filtro);
            }
        }

        private void dtgClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgClientes.Rows.Count){
                DataGridViewRow linhaClicada = dtgClientes.Rows[e.RowIndex];
                int indiceDaColuna = 1;
                object valorDaCelula = linhaClicada.Cells[indiceDaColuna].Value;
                if (valorDaCelula != null)
                {
                    string textoDaCelula = valorDaCelula.ToString();
                    FrmOperacoesClientes operacoesClientes = new FrmOperacoesClientes(this);
                    operacoesClientes.DadosDoFormClientes(textoDaCelula);
                    operacoesClientes.ShowDialog();
                   
                }
            }
        }
    }
}

