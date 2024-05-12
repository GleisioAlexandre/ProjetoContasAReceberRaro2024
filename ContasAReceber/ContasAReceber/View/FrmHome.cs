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
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmClientes clientes = new FrmClientes();
                clientes.MdiParent = this;
                clientes.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void contasAReceberToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmContasAReceber contas = new FrmContasAReceber();
            contas.MdiParent = this;
            contas.Show();
        }
        private void configurarBancoDeDabosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConfiguracao configuracao = new FrmConfiguracao();
            configuracao.MdiParent = this;
            configuracao.WindowState = FormWindowState.Normal;
            configuracao.Show();
        }

        private void TitulosAPagar_Click(object sender, EventArgs e)
        {
            FrmContasAPagar contasAPagar = new FrmContasAPagar();
            contasAPagar.MdiParent = this;
            contasAPagar.WindowState = FormWindowState.Maximized;
            contasAPagar.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor fornecedor = new FrmFornecedor();
            fornecedor.MdiParent = this;
            fornecedor.WindowState = FormWindowState.Maximized;
            fornecedor.Show();
        }

        private void planoDeContasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPlanoDeContas planoDeContas = new FrmPlanoDeContas();
            planoDeContas.MdiParent = this;
            planoDeContas.WindowState = FormWindowState.Maximized;
            planoDeContas.Show();
        }
    }
}
