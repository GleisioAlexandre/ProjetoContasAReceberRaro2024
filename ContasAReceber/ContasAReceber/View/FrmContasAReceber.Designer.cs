namespace ContasAReceber.View
{
    partial class FrmContasAReceber
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContasAReceber));
            this.dtgContas = new System.Windows.Forms.DataGridView();
            this.entrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BntPrint = new System.Windows.Forms.ToolStripButton();
            this.TxtNomeCliente = new System.Windows.Forms.ToolStripTextBox();
            this.CbxSituacao = new System.Windows.Forms.ToolStripComboBox();
            this.btnPesquisar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.dataInicial = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.BtnInserir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.lblValor = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.rbSituacao = new System.Windows.Forms.RadioButton();
            this.rbData = new System.Windows.Forms.RadioButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgContas
            // 
            this.dtgContas.AllowUserToAddRows = false;
            this.dtgContas.AllowUserToDeleteRows = false;
            this.dtgContas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgContas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgContas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.entrada,
            this.nome,
            this.valor,
            this.documento,
            this.tipo,
            this.situacao,
            this.vencimento,
            this.pagamento});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgContas.DefaultCellStyle = dataGridViewCellStyle7;
            this.dtgContas.Location = new System.Drawing.Point(0, 28);
            this.dtgContas.Name = "dtgContas";
            this.dtgContas.ReadOnly = true;
            this.dtgContas.RowHeadersVisible = false;
            this.dtgContas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgContas.Size = new System.Drawing.Size(1632, 447);
            this.dtgContas.TabIndex = 2;
            this.dtgContas.VirtualMode = true;
            this.dtgContas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgContas_CellDoubleClick);
            this.dtgContas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgContas_CellFormatting);
            // 
            // entrada
            // 
            this.entrada.DataPropertyName = "entrada";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.entrada.DefaultCellStyle = dataGridViewCellStyle2;
            this.entrada.HeaderText = "Entrada";
            this.entrada.Name = "entrada";
            this.entrada.ReadOnly = true;
            this.entrada.Width = 75;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 400;
            // 
            // valor
            // 
            this.valor.DataPropertyName = "valor";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.valor.DefaultCellStyle = dataGridViewCellStyle3;
            this.valor.HeaderText = "Valor";
            this.valor.Name = "valor";
            this.valor.ReadOnly = true;
            this.valor.Width = 90;
            // 
            // documento
            // 
            this.documento.DataPropertyName = "documento";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.documento.DefaultCellStyle = dataGridViewCellStyle4;
            this.documento.HeaderText = "Documento";
            this.documento.Name = "documento";
            this.documento.ReadOnly = true;
            this.documento.Width = 90;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 58;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 73;
            // 
            // vencimento
            // 
            this.vencimento.DataPropertyName = "vencimento";
            dataGridViewCellStyle5.Format = "d";
            dataGridViewCellStyle5.NullValue = null;
            this.vencimento.DefaultCellStyle = dataGridViewCellStyle5;
            this.vencimento.HeaderText = "Vencimento";
            this.vencimento.Name = "vencimento";
            this.vencimento.ReadOnly = true;
            this.vencimento.Width = 87;
            // 
            // pagamento
            // 
            this.pagamento.DataPropertyName = "pagamento";
            dataGridViewCellStyle6.Format = "d";
            dataGridViewCellStyle6.NullValue = null;
            this.pagamento.DefaultCellStyle = dataGridViewCellStyle6;
            this.pagamento.HeaderText = "Pagamento";
            this.pagamento.Name = "pagamento";
            this.pagamento.ReadOnly = true;
            this.pagamento.Width = 87;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bindingNavigator1.BindingSource = this.bindingSource1;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorSeparator2,
            this.toolStripLabel1,
            this.TxtNomeCliente,
            this.toolStripSeparator1,
            this.CbxSituacao,
            this.toolStripSeparator2,
            this.toolStripSeparator3,
            this.toolStripSeparator6,
            this.btnPesquisar,
            this.toolStripSeparator7,
            this.BntPrint});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1632, 28);
            this.bindingNavigator1.TabIndex = 3;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // BntPrint
            // 
            this.BntPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BntPrint.Image = global::ContasAReceber.Properties.Resources.icons8_print_16;
            this.BntPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BntPrint.Name = "BntPrint";
            this.BntPrint.Size = new System.Drawing.Size(24, 25);
            this.BntPrint.Text = "Imprimir";
            this.BntPrint.Click += new System.EventHandler(this.BntImprimir_Click);
            // 
            // TxtNomeCliente
            // 
            this.TxtNomeCliente.Name = "TxtNomeCliente";
            this.TxtNomeCliente.Size = new System.Drawing.Size(400, 28);
            // 
            // CbxSituacao
            // 
            this.CbxSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxSituacao.Items.AddRange(new object[] {
            "Todos",
            "Atrasado",
            "Em Dia",
            "Pago"});
            this.CbxSituacao.Name = "CbxSituacao";
            this.CbxSituacao.Size = new System.Drawing.Size(121, 28);
            this.CbxSituacao.Tag = "";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(24, 25);
            this.btnPesquisar.Text = "toolStripButton1";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(200, 0, 250, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // dataInicial
            // 
            this.dataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataInicial.Location = new System.Drawing.Point(625, 3);
            this.dataInicial.Name = "dataInicial";
            this.dataInicial.Size = new System.Drawing.Size(97, 22);
            this.dataInicial.TabIndex = 9;
            this.dataInicial.Value = new System.DateTime(2024, 6, 30, 0, 0, 0, 0);
            // 
            // dataFinal
            // 
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataFinal.Location = new System.Drawing.Point(726, 3);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(97, 22);
            this.dataFinal.TabIndex = 10;
            this.dataFinal.Value = new System.DateTime(2024, 6, 30, 0, 0, 0, 0);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(124, 417);
            // 
            // BtnInserir
            // 
            this.BtnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnInserir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnInserir.Name = "BtnInserir";
            this.BtnInserir.Size = new System.Drawing.Size(58, 24);
            this.BtnInserir.Text = "Inserir";
            this.BtnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // lblValor
            // 
            this.lblValor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(106, 24);
            this.lblValor.Text = "Total: R$ 0,00";
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnInserir,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.lblValor});
            this.toolStrip.Location = new System.Drawing.Point(0, 476);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1632, 27);
            this.toolStrip.TabIndex = 7;
            this.toolStrip.Text = "toolStrip1";
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(839, 4);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(70, 21);
            this.rbNome.TabIndex = 11;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = false;
            // 
            // rbSituacao
            // 
            this.rbSituacao.AutoSize = true;
            this.rbSituacao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSituacao.ForeColor = System.Drawing.Color.White;
            this.rbSituacao.Location = new System.Drawing.Point(915, 4);
            this.rbSituacao.Name = "rbSituacao";
            this.rbSituacao.Size = new System.Drawing.Size(92, 21);
            this.rbSituacao.TabIndex = 12;
            this.rbSituacao.TabStop = true;
            this.rbSituacao.Text = "Situação";
            this.rbSituacao.UseVisualStyleBackColor = false;
            // 
            // rbData
            // 
            this.rbData.AutoSize = true;
            this.rbData.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbData.ForeColor = System.Drawing.Color.White;
            this.rbData.Location = new System.Drawing.Point(1013, 4);
            this.rbData.Name = "rbData";
            this.rbData.Size = new System.Drawing.Size(63, 21);
            this.rbData.TabIndex = 13;
            this.rbData.TabStop = true;
            this.rbData.Text = "Data";
            this.rbData.UseVisualStyleBackColor = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 25);
            this.toolStripLabel1.Text = "Cliente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(100, 0, 1, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 28);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rbTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTodos.ForeColor = System.Drawing.Color.White;
            this.rbTodos.Location = new System.Drawing.Point(1082, 4);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(74, 21);
            this.rbTodos.TabIndex = 14;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = false;
            // 
            // FrmContasAReceber
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1632, 503);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.rbData);
            this.Controls.Add(this.rbSituacao);
            this.Controls.Add(this.rbNome);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataInicial);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dtgContas);
            this.KeyPreview = true;
            this.Name = "FrmContasAReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Receber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmContas_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmContas_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dtgContas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgContas;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripTextBox TxtNomeCliente;
        private System.Windows.Forms.ToolStripComboBox CbxSituacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BntPrint;
        private System.Windows.Forms.ToolStripButton btnPesquisar;
        private System.Windows.Forms.DateTimePicker dataInicial;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn pagamento;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripButton BtnInserir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripLabel lblValor;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.RadioButton rbSituacao;
        private System.Windows.Forms.RadioButton rbData;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.RadioButton rbTodos;
    }
}