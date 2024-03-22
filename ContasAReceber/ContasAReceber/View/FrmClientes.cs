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
            OperacoesClientes opClientes = new OperacoesClientes();
            dtgClientes.DataSource = opClientes.ExibeGridClinetes();
        }
    }
}

