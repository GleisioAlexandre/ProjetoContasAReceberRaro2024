using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAReceber.controller
{
    class ManipuladorTextBox
    {
        public void TextoMaiusculo(TextBox texto)
        {
            texto.Text = texto.Text.ToUpper();
            texto.SelectionStart = texto.Text.Length;
        }
        public void LimpaCamposCadastroClientes(Label lblIdCliente, TextBox txtCliente, MaskedTextBox txtCpfCnpj, MaskedTextBox txtCep, TextBox txtLogradouro, TextBox txtNumero, TextBox txtComplemento, TextBox txtBairro, TextBox txtCidade, TextBox txtUf)
        {
            lblIdCliente.Text = "";
            txtCliente.Clear();
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
        }
        public void NegacaoZero(object sender, KeyPressEventArgs e)
        {
            TextBox numero = (TextBox)sender;
            if (numero.Text.Length == 0 && e.KeyChar == '0')
            {

                e.Handled = true;
            }
        }
        public void TextoDouble(object sender, KeyPressEventArgs e)
        {
            TextBox numero = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (numero.Text.Contains(".") || numero.Text.Contains(",")))
            {
                e.Handled = true;
            }
        }
        public void TextBoxNumerico(object sender, KeyPressEventArgs e)
        {
            TextBox numero = (TextBox)sender;
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
        public void PersonalizaDadosPessoais(bool cbxPjChecked, Label lblNomePessoa, Label lblTipoPessoa, MaskedTextBox txtCpfCnpj)
        {
            if (cbxPjChecked)
            {
                lblNomePessoa.Text = "Razão Social";
                lblTipoPessoa.Text = "CNPJ";
                txtCpfCnpj.Mask = "##,###,###/####-##";
                txtCpfCnpj.Width = 171;
            }
            else
            {
                lblNomePessoa.Text = "Nome";
                lblTipoPessoa.Text = "CPF";
                txtCpfCnpj.Mask = "###,###,###-##";
                txtCpfCnpj.Width = 135;
            }
        }
    }
}
