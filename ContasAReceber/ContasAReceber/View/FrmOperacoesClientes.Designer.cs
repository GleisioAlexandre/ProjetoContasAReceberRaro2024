namespace ContasAReceber.View
{
    partial class FrmOperacoesClientes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.lblIdCliente = new System.Windows.Forms.Label();
            this.lblTipoPessoa = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.cbxPj = new System.Windows.Forms.CheckBox();
            this.lblNomePessoa = new System.Windows.Forms.Label();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnDeletarCliente = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNomeContato = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUf);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLogradouro);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCep);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 393);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(16, 240);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(436, 29);
            this.txtComplemento.TabIndex = 5;
            this.txtComplemento.TextChanged += new System.EventHandler(this.txtComplemento_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 24);
            this.label7.TabIndex = 5;
            this.label7.Text = "Complemento";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(635, 151);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(66, 29);
            this.txtNumero.TabIndex = 4;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(630, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 24);
            this.label6.TabIndex = 4;
            this.label6.Text = "Numero";
            // 
            // txtUf
            // 
            this.txtUf.Location = new System.Drawing.Point(635, 329);
            this.txtUf.Name = "txtUf";
            this.txtUf.Size = new System.Drawing.Size(66, 29);
            this.txtUf.TabIndex = 8;
            this.txtUf.TextChanged += new System.EventHandler(this.txtUf_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(630, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "UF";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(12, 329);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(591, 29);
            this.txtCidade.TabIndex = 7;
            this.txtCidade.TextChanged += new System.EventHandler(this.txtCidade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(485, 240);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(216, 29);
            this.txtBairro.TabIndex = 6;
            this.txtBairro.TextChanged += new System.EventHandler(this.txtBairro_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bairro";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(14, 151);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(589, 29);
            this.txtLogradouro.TabIndex = 3;
            this.txtLogradouro.TextChanged += new System.EventHandler(this.txtLogradouro_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Logradouro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Location = new System.Drawing.Point(119, 65);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(77, 29);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisaCep);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEP";
            // 
            // txtCep
            // 
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCep.Location = new System.Drawing.Point(20, 62);
            this.txtCep.Mask = "#####-###";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(98, 29);
            this.txtCep.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCpfCnpj);
            this.groupBox2.Controls.Add(this.lblIdCliente);
            this.groupBox2.Controls.Add(this.lblTipoPessoa);
            this.groupBox2.Controls.Add(this.txtCliente);
            this.groupBox2.Controls.Add(this.cbxPj);
            this.groupBox2.Controls.Add(this.lblNomePessoa);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(719, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Pessoais";
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Location = new System.Drawing.Point(20, 134);
            this.txtCpfCnpj.Mask = "##,###,###/####-##";
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(170, 29);
            this.txtCpfCnpj.TabIndex = 4;
            // 
            // lblIdCliente
            // 
            this.lblIdCliente.AutoSize = true;
            this.lblIdCliente.Location = new System.Drawing.Point(615, 137);
            this.lblIdCliente.Name = "lblIdCliente";
            this.lblIdCliente.Size = new System.Drawing.Size(20, 24);
            this.lblIdCliente.TabIndex = 3;
            this.lblIdCliente.Text = "0";
            this.lblIdCliente.Visible = false;
            // 
            // lblTipoPessoa
            // 
            this.lblTipoPessoa.AutoSize = true;
            this.lblTipoPessoa.Location = new System.Drawing.Point(16, 110);
            this.lblTipoPessoa.Name = "lblTipoPessoa";
            this.lblTipoPessoa.Size = new System.Drawing.Size(58, 24);
            this.lblTipoPessoa.TabIndex = 2;
            this.lblTipoPessoa.Text = "CNPJ";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(20, 57);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(687, 29);
            this.txtCliente.TabIndex = 0;
            this.txtCliente.TextChanged += new System.EventHandler(this.txtCliente_TextChanged);
            // 
            // cbxPj
            // 
            this.cbxPj.AutoSize = true;
            this.cbxPj.Checked = true;
            this.cbxPj.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxPj.Location = new System.Drawing.Point(546, 26);
            this.cbxPj.Name = "cbxPj";
            this.cbxPj.Size = new System.Drawing.Size(161, 28);
            this.cbxPj.TabIndex = 1;
            this.cbxPj.Text = "Pessoa Jurídica";
            this.cbxPj.UseVisualStyleBackColor = true;
            this.cbxPj.CheckedChanged += new System.EventHandler(this.cbxPj_CheckedChanged);
            // 
            // lblNomePessoa
            // 
            this.lblNomePessoa.AutoSize = true;
            this.lblNomePessoa.Location = new System.Drawing.Point(16, 30);
            this.lblNomePessoa.Name = "lblNomePessoa";
            this.lblNomePessoa.Size = new System.Drawing.Size(119, 24);
            this.lblNomePessoa.TabIndex = 0;
            this.lblNomePessoa.Text = "Razão Social";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(14, 636);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(97, 32);
            this.btnCadastrarCliente.TabIndex = 3;
            this.btnCadastrarCliente.Text = "Cadastrar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.Location = new System.Drawing.Point(221, 636);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(97, 32);
            this.btnEditarCliente.TabIndex = 5;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // btnDeletarCliente
            // 
            this.btnDeletarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarCliente.Location = new System.Drawing.Point(428, 636);
            this.btnDeletarCliente.Name = "btnDeletarCliente";
            this.btnDeletarCliente.Size = new System.Drawing.Size(97, 32);
            this.btnDeletarCliente.TabIndex = 6;
            this.btnDeletarCliente.Text = "Deletar";
            this.btnDeletarCliente.UseVisualStyleBackColor = true;
            this.btnDeletarCliente.Click += new System.EventHandler(this.btnDeletarCliente_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(743, 630);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(735, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Cadastrais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(735, 566);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Contato";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtCelular);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtTelefone);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtNomeContato);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(130, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 267);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(10, 210);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(427, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Email";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(300, 129);
            this.txtCelular.Mask = "(##)#####-####";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(137, 26);
            this.txtCelular.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Celular";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(10, 129);
            this.txtTelefone.Mask = "(##)####-####";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(126, 26);
            this.txtTelefone.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Telefone";
            // 
            // txtNomeContato
            // 
            this.txtNomeContato.Location = new System.Drawing.Point(10, 60);
            this.txtNomeContato.Name = "txtNomeContato";
            this.txtNomeContato.Size = new System.Drawing.Size(427, 26);
            this.txtNomeContato.TabIndex = 1;
            this.txtNomeContato.TextChanged += new System.EventHandler(this.txtNomeContato_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nome do Contato";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(635, 636);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(97, 32);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmOperacoesClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 680);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnDeletarCliente);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.btnCadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmOperacoesClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Clientes";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOperacoesClientes_FormClosed);
            this.Load += new System.EventHandler(this.FrmOperacoesClientes_Load);
            this.Move += new System.EventHandler(this.FrmOperacoesClientes_Move);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbxPj;
        private System.Windows.Forms.Label lblNomePessoa;
        private System.Windows.Forms.Label lblTipoPessoa;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnDeletarCliente;
        private System.Windows.Forms.Label lblIdCliente;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNomeContato;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.Button btnCancelar;
    }
}