using ContasAReceber.controller;
using ContasAReceber.servico;
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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void rbPf_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPf.Checked == true)
            {
                txtCadPessoa.Mask = "###,###,###-##";
                txtCadPessoa.Width = 82;
            }
        }

        private void rbPj_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPj.Checked == true)
            {
                txtCadPessoa.Mask = "##,###,###/####-##";
                txtCadPessoa.Width = 104;
            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ServicoBuscaCep buscaCep = new ServicoBuscaCep();
                txtCep.Text = buscaCep.ConsultaCep(txtCep.Text)[0].ToString();
                txtLogradouro.Text = buscaCep.ConsultaCep(txtCep.Text)[1].ToString();
                txtBairro.Text = buscaCep.ConsultaCep(txtCep.Text)[2].ToString();
                txtCidade.Text = buscaCep.ConsultaCep(txtCep.Text)[3].ToString();
                txtUf.Text = buscaCep.ConsultaCep(txtCep.Text)[4].ToString();
                txtNumero.Focus();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                OperacoesFornecedores fornecedores = new OperacoesFornecedores();
                fornecedores.InserirFornecedor(txtRazaoSocial.Text);
            }catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex);
            }
        }
    }
}
