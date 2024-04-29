using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContasAReceber.controller;
using ContasAReceber.model;
using ContasAReceber.servico;
using Newtonsoft.Json;

namespace ContasAReceber.View
{
    public partial class FrmOperacoesClientes : Form
    {
        private FrmClientes clientes;
        private int LocalizacaoX;
        private int LocalizacaoY;
        OperacoesClientes operacoesClientes = new OperacoesClientes();
        ManipuladorTextBox manipuladorTextBox = new ManipuladorTextBox();
        public FrmOperacoesClientes(FrmClientes frmClientes)

        {
            InitializeComponent();
            LocalizacaoX = (Screen.PrimaryScreen.Bounds.Width - this.Width)/2;
            LocalizacaoY = (Screen.PrimaryScreen.Bounds.Height - this.Height)/2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.clientes = frmClientes;
        }
        public void DadosDoFormClientes(string stringDoFormClientes)
        {
            string nome = stringDoFormClientes;
           
            lblIdCliente.Text = operacoesClientes.PesquisaCliente(nome)[0].ToString();
            txtCliente.Text = operacoesClientes.PesquisaCliente(nome)[1].ToString();
           
            txtNomeContato.Text = operacoesClientes.PesquisaCliente(nome)[3].ToString();
            txtTelefone.Text = operacoesClientes.PesquisaCliente(nome)[4].ToString();
            txtCelular.Text = operacoesClientes.PesquisaCliente(nome)[5].ToString();
            txtEmail.Text = operacoesClientes .PesquisaCliente(nome)[6].ToString();
            txtCep.Text = operacoesClientes .PesquisaCliente(nome)[7].ToString();
            txtLogradouro.Text = operacoesClientes .PesquisaCliente(nome)[8].ToString();
            txtNumero.Text = operacoesClientes .PesquisaCliente(nome)[9].ToString();
            txtComplemento.Text = operacoesClientes .PesquisaCliente(nome)[10].ToString();
            txtBairro.Text = operacoesClientes .PesquisaCliente(nome)[11].ToString();
            txtCidade.Text = operacoesClientes .PesquisaCliente(nome)[12].ToString();
            txtUf.Text = operacoesClientes .PesquisaCliente(nome)[13].ToString();
            if (operacoesClientes .PesquisaCliente(nome)[14].Equals(1)/*cbxPj*/)
            {
                cbxPj.Checked = true;
            }
            else
            {
                cbxPj.Checked = false;
            }
             txtCpfCnpj.Text = operacoesClientes .PesquisaCliente(nome)[2].ToString();
        }
        private void FrmOperacoesClientes_Load(object sender, EventArgs e)
        {
            if (txtCliente.Text.Equals(""))
            {
                btnEditarCliente.Enabled = false;
                btnDeletarCliente.Enabled = false;
            }
            else
            {
                btnCadastrarCliente.Enabled = false;
            }
        }
        private void FrmOperacoesClientes_Move(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(LocalizacaoX, LocalizacaoY);
        }
        private void btnPesquisaCep(object sender, EventArgs e)
        {
            try
            {
                ServicoBuscaCep buscaCep = new ServicoBuscaCep();
                txtCep.Text = buscaCep.ConsultaCep(txtCep.Text)[0].ToString();
                txtLogradouro.Text = buscaCep.ConsultaCep(txtCep.Text)[1].ToString();
                txtBairro.Text = buscaCep.ConsultaCep(txtCep.Text)[2].ToString();
                txtCidade.Text = buscaCep.ConsultaCep(txtCep.Text)[3].ToString();
                txtUf.Text = buscaCep.ConsultaCep(txtCep.Text)[4].ToString();
                txtNumero.Text = "0";
                txtNumero.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxPj_CheckedChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.PersonalizaDadosPessoais(cbxPj.Checked, lblNomePessoa, lblTipoPessoa, txtCpfCnpj);
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            int pj;
            try
            {
                if (cbxPj.Checked == true)
                {
                    pj = 1;
                }
                else
                {
                    pj = 0;
                }
                OperacoesClientes opcliente = new OperacoesClientes();
                opcliente.AtualizarCliente(txtCliente.Text, txtCpfCnpj.Text, txtNomeContato.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text, txtCep.Text, txtLogradouro.Text, Int32.Parse(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, pj, Int32.Parse(lblIdCliente.Text));
                clientes.AtualizaGriCliente();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeletarCliente_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem Certeza que deseja remover o registro?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    OperacoesClientes opclinete = new OperacoesClientes();
                    opclinete.DeletaCliente(Int32.Parse(lblIdCliente.Text));

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            int pj;
            try
            {
                if (cbxPj.Checked == true)
                {
                     pj = 1;
                }
                else
                {
                    pj = 0;
                }
                OperacoesClientes opCliente = new OperacoesClientes();
                opCliente.InseirClinete(txtCliente.Text, txtCpfCnpj.Text, txtNomeContato.Text, txtTelefone.Text, txtCelular.Text, txtEmail.Text,txtCep.Text, txtLogradouro.Text, Int32.Parse(txtNumero.Text), txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, pj);
                clientes.AtualizaGriCliente();
                this.Close();
            } catch (Exception ex)
            {

                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmOperacoesClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientes.AtualizaGriCliente();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtCliente);
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtComplemento);
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtNumero.KeyPress += manipuladorTextBox.TextBoxNumerico;
        }

        private void txtNomeContato_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtNomeContato);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtEmail);
        }

        private void txtLogradouro_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtLogradouro);
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

            manipuladorTextBox.TextoMaiusculo(txtBairro);
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtCidade);
        }

        private void txtUf_TextChanged(object sender, EventArgs e)
        {
            manipuladorTextBox.TextoMaiusculo(txtUf);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
