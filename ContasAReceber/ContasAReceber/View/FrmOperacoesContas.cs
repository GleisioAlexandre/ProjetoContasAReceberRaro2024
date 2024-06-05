using ContasAReceber.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ContasAReceber.View
{
    public partial class FrmOperacoesContas : Form
    {
        private FrmContasAReceber contas;
        private int LocalizacaoX;
        private int LocalizacaoY;
        OperacoesContas op = new OperacoesContas();
        ManipuladorTextBox manipuladorText = new ManipuladorTextBox();
        public FrmOperacoesContas(FrmContasAReceber frmContas)
        {
            InitializeComponent();
            LocalizacaoX = (Screen.PrimaryScreen.Bounds.Width - this.Width)/2;
            LocalizacaoY = (Screen.PrimaryScreen.Bounds.Height - this.Height)/2;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.contas = frmContas;
        }
        public void DadosDoFormContas(string stringDoFormContas)
        {
                    string documento = stringDoFormContas;
                    lblConta.Text = op.PesquisarDivida(documento)[0].ToString();
                    txtEntrada.Text = op.PesquisarDivida(documento)[1].ToString();
                    txtCodigoCliente.Text = op.PesquisarDivida(documento)[2].ToString();
                    txtNomeCliente.Text = op.PesquisarDivida(documento)[3].ToString();
                    txtValor.Text = op.PesquisarDivida(documento)[4].ToString();
                    txtDocumento.Text = op.PesquisarDivida(documento)[5].ToString();
                    cbxClass.SelectedIndex = Int32.Parse(op.PesquisarDivida(documento)[6].ToString()) - 1;
                    cbxSituacao.SelectedIndex = Int32.Parse(op.PesquisarDivida(documento)[7].ToString()) - 1;
                    txtVencimento.Text = op.PesquisarDivida(documento)[8].ToString();
                    txtPagamento.Text = op.PesquisarDivida(documento)[9].ToString();
                    btnDeletar.Enabled = true;
                    btnAtualizar.Enabled = true;
                    btnInserir.Enabled = false;
                    txtValor.Focus();
                    txtDocumento.Focus();
        }
        private void FrmInserirContas_Load(object sender, EventArgs e)
        {
            
            if (txtDocumento.Text.Equals(""))
            {
                txtNomeCliente.Focus();
                txtValor.Text = "0,00";
            }
        }
        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
           if (txtNomeCliente.Text.Equals(""))
            {
                MessageBox.Show("O campos Nome do Cliente, não pode ser nulo!");

            }
            else
            {
                try
                {
                    
                    txtCodigoCliente.Text = op.PesquisarCliente(txtNomeCliente.Text)[0].ToString();
                    txtNomeCliente.Text = op.PesquisarCliente(txtNomeCliente.Text)[1].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: Registro não encontrado!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void txtNomeCliente_TextChanged(object sender, EventArgs e)
        {
            manipuladorText.TextoMaiusculo(txtNomeCliente);
        }
        private void txtValor_Validated(object sender, EventArgs e)
        {
           if (txtValor.Text.Equals(""))
            {
                txtValor.Text = "0,00";
            }
            else
            {
                txtValor.Text = double.Parse(txtValor.Text).ToString("N2");
            }
        }
        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.' && e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
        private void txtDocumento_TextChanged(object sender, EventArgs e)
        {
            manipuladorText.TextoMaiusculo(txtDocumento);
        }
        private void txtNomeCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    txtCodigoCliente.Text = op.PesquisarCliente(txtNomeCliente.Text)[0].ToString();
                    txtNomeCliente.Text = op.PesquisarCliente(txtNomeCliente.Text)[1].ToString();
                    txtValor.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
           
             try
             {
                 string  entrada, vencimento, pagamento;
                 entrada = op.FormataData(txtEntrada.Text);
                 vencimento = op.FormataData(txtVencimento.Text);
                 pagamento = op.FormataData(txtPagamento.Text);

                 if (txtNomeCliente.Text.Equals("") || txtValor.Text.Equals("") || txtDocumento.Text.Equals(""))
                 {
                     MessageBox.Show("Todos os campos devem ser preenchidos para a inclusão do registro!", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                     if (MessageBox.Show("Verifique se todos os dados foram inseridos corretamente! \n Se tudo estiver correto clique em SIM", "Informação!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                     {
                         op.InserirConta(entrada, Int32.Parse(txtCodigoCliente.Text), Double.Parse(txtValor.Text), txtDocumento.Text, (cbxClass.SelectedIndex)+1, (cbxSituacao.SelectedIndex)+1, vencimento, pagamento);
                         this.Close();
                         contas.AtualizaGridContas();
                     }
                     else
                     {
                         this.Close();
                     }
                     MessageBox.Show("Dados inseridos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show("Erro ao Tentar Salvar as informações!\n" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDocumento.Text.Equals(""))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos para a exclusão do registro!", "Informação!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                        if (MessageBox.Show("Tem certeza de que quer excluir este registro ?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                        {
                            op.DeletarContas(Int32.Parse(lblConta.Text));
                            contas.AtualizaGridContas();
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    MessageBox.Show("Registro excluido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                        MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string entrada, vencimento, pagamento;
                entrada = op.FormataData(txtEntrada.Text);
                vencimento = op.FormataData(txtVencimento.Text);
                pagamento = op.FormataData(txtPagamento.Text);
                op.AtualizaContas(entrada , Int32.Parse(txtCodigoCliente.Text), Double.Parse(txtValor.Text), txtDocumento.Text, (cbxClass.SelectedIndex + 1), (cbxSituacao.SelectedIndex + 1), vencimento, pagamento, Int32.Parse(lblConta.Text));
                this.Close();
                contas.AtualizaGridContas();
                MessageBox.Show("Registro atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FrmOperacoesContas_Move(object sender, EventArgs e)
        {
            this.Location = new System.Drawing.Point(LocalizacaoX, LocalizacaoY);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
