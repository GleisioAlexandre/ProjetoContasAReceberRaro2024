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
            OperacoesClientes opClientes = new OperacoesClientes();
            lblIdCliente.Text = opClientes.PesquisaCliente(nome)[0].ToString();
            txtCliente.Text = opClientes.PesquisaCliente(nome)[1].ToString();
           
            txtNomeContato.Text = opClientes.PesquisaCliente(nome)[3].ToString();
            txtTelefone.Text = opClientes.PesquisaCliente(nome)[4].ToString();
            txtCelular.Text = opClientes.PesquisaCliente(nome)[5].ToString();
            txtEmail.Text = opClientes.PesquisaCliente(nome)[6].ToString();
            txtCep.Text = opClientes.PesquisaCliente(nome)[7].ToString();
            txtLogradouro.Text = opClientes.PesquisaCliente(nome)[8].ToString();
            txtNumero.Text = opClientes.PesquisaCliente(nome)[9].ToString();
            txtComplemento.Text = opClientes.PesquisaCliente(nome)[10].ToString();
            txtBairro.Text = opClientes.PesquisaCliente(nome)[11].ToString();
            txtCidade.Text = opClientes.PesquisaCliente(nome)[12].ToString();
            txtUf.Text = opClientes.PesquisaCliente(nome)[13].ToString();
            if (opClientes.PesquisaCliente(nome)[14].Equals(1)/*cbxPj*/)
            {
                cbxPj.Checked = true;
            }
            else
            {
                cbxPj.Checked = false;
            }
             txtCpfCnpj.Text = opClientes.PesquisaCliente(nome)[2].ToString();
        }
        private void FrmOperacoesClientes_Load(object sender, EventArgs e)
        {
            if (txtCliente.Text != "")
            {
                btnNovoCliente.Enabled = false;
                btnCadastrarCliente.Enabled = false;
                btnPesquisarCliente.Enabled = false;
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
            if (cbxPj.Checked == true)
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

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            lblIdCliente.Text = "";
            cbxPj.Checked = false;
            txtCliente.Clear();
            txtCpfCnpj.Clear();
            txtCep.Clear();
            txtLogradouro.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUf.Clear();
            if (btnCadastrarCliente.Enabled == false)
            {
                btnCadastrarCliente.Enabled = true;
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

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            txtCliente.Text = txtCliente.Text.ToUpper();
            txtCliente.SelectionStart = txtCliente.Text.Length;
        }

        private void txtComplemento_TextChanged(object sender, EventArgs e)
        {
            txtComplemento.Text = txtComplemento.Text.ToUpper();
            txtComplemento.SelectionStart = txtComplemento.Text.Length;
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 pj;
                String cliente = txtCliente.Text;
                OperacoesClientes opcliente = new OperacoesClientes();
                lblIdCliente.Text = opcliente.PesquisaCliente(cliente)[0].ToString();
                txtCliente.Text = opcliente.PesquisaCliente(cliente)[1].ToString();
                txtCep.Text = opcliente.PesquisaCliente(cliente)[3].ToString();
                txtLogradouro.Text = opcliente.PesquisaCliente(cliente)[4].ToString();
                txtNumero.Text = opcliente.PesquisaCliente(cliente)[5].ToString();
                txtComplemento.Text = opcliente.PesquisaCliente(cliente)[6].ToString();
                txtBairro.Text = opcliente.PesquisaCliente(cliente)[7].ToString();
                txtCidade.Text = opcliente.PesquisaCliente(cliente)[8].ToString();
                txtUf.Text = opcliente.PesquisaCliente(cliente)[9].ToString();
                pj = Int32.Parse(opcliente.PesquisaCliente(cliente)[10].ToString());
                if (pj == 1)
                {
                    cbxPj.Checked = true;
                }
                else
                {
                    cbxPj.Checked = false;
                }
                txtCpfCnpj.Text = opcliente.PesquisaCliente(cliente)[2].ToString();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            btnCadastrarCliente.Enabled = false;
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
                opcliente.AtualizarCliente(txtCliente.Text, txtCpfCnpj.Text, txtCep.Text, txtLogradouro.Text, txtNumero.Text, txtComplemento.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, pj, Int32.Parse(lblIdCliente.Text));
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
           if (MessageBox.Show("Tem Certeza que deseja remover o registro?","Alerta",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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

        private void FrmOperacoesClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientes.AtualizaGriCliente();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
