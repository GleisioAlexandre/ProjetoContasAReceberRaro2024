using ContasAReceber.controller;
using ContasAReceber.model;
using Microsoft.Reporting.WinForms;
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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        OperacoesContas operacoesContas = new OperacoesContas();
        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            this.Controls.Add(reportViewer1);
            dataSet();
        }
        private void dataSet()
        {
            contasBindingSource.DataSource = operacoesContas.datSet();
           /* DataSet dataSet = operacoesContas.datSet();
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dataSet.Tables["contasareceber"]));
            reportViewer1.RefreshReport();*/
        }
    }
}
