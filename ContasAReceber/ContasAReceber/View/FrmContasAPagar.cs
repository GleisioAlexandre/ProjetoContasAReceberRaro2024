using ContasAReceber.controller;
using System;
using System.Windows.Forms;

namespace ContasAReceber.View
{
    public partial class FrmContasAPagar : Form
    {
        ManipuladorTextBox manipuladorText = new ManipuladorTextBox();
        public FrmContasAPagar()
        {
            InitializeComponent();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                txtValor.Text = "0";
            }
            else
            {
                double valor = Double.Parse(txtValor.Text);
                txtValor.Text = valor.ToString("C2");
            }
        }

        private void txtParcelas_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtValor.Text))
                {

                    txtValor.Focus();
                }
                else
                {
                    double valor = Double.Parse(txtValor.Text.Substring(3));
                    int parcela = Int32.Parse(txtParcelas.Text);
                    double valorParcela;
                    valorParcela = valor / parcela;
                    txtValorParcela.Text = valorParcela.ToString("C2");
                    txtObs.Focus();
                }
            } catch
            {
                txtValor.Clear();
                txtParcelas.Clear();
                txtValor.Focus();
                txtValorParcela.Clear();
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {

            txtValor.KeyPress += manipuladorText.TextoDouble;
        }
        private void txtParcelas_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtParcelas.KeyPress += manipuladorText.NegacaoZero;
        }

        private void FrmContasAPagar_Load(object sender, EventArgs e)
        {

        }
    }
}
