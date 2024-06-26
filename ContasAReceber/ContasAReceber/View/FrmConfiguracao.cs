﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContasAReceber.View
{
    public partial class FrmConfiguracao : Form
    {
        private string usuario;
        private string senha;
        private string bancoDados;
        private string servidor;
        private string porta;

        public FrmConfiguracao()
        {
            InitializeComponent();
        }
        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            string stringConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
            string caminhoLogo = ConfigurationManager.AppSettings["Logo"];
            string[] partes = stringConexao.Split(';');
            usuario = partes[0].Substring(partes[0].IndexOf("=") + 1).Trim();
            senha = partes[1].Substring(partes[1].IndexOf("=") + 1).Trim();
            bancoDados = partes[2].Substring(partes[2].IndexOf("=") + 1).Trim();
            servidor = partes[3].Substring(partes[3].IndexOf("=") + 1).Trim();
            porta = partes[4].Substring(partes[4].IndexOf("=") + 1).Trim();
            txtUsuario.Text = usuario;
            txtSenha.Text = senha;
            txtCaminho.Text = bancoDados;
            txtServidor.Text = servidor;
            txtPorta.Text = porta.ToString();
            txtCaminhoLogo.Text = caminhoLogo;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario = txtUsuario.Text;
                senha = txtSenha.Text;
                bancoDados = txtCaminho.Text;
                servidor = txtServidor.Text;
                porta = txtPorta.Text;
                string novaStringConexao = $"User={usuario};password={senha};Database={bancoDados};DataSource={servidor};Port={porta}";
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.ConnectionStrings.ConnectionStrings["ConexaoFirebird"].ConnectionString = novaStringConexao;
                config.AppSettings.Settings["Logo"].Value = txtCaminhoLogo.Text;
                config.Save(ConfigurationSaveMode.Modified);
                MessageBox.Show("Alterações realizadas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ConfigurationManager.RefreshSection(config.ConnectionStrings.SectionInformation.Name + config.AppSettings.SectionInformation.Name);
                txtCaminhoLogo.Text = ConfigurationManager.AppSettings["Logo"];                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Firebird .fdb|*.fdb*";
            DialogResult result = fileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                txtCaminho.Text = fileDialog.FileName;
            }
           

            
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Caminho da Logo"; 
            openFileDialog.Filter = "Todos os arquivos (*.*)|*.*|Logo (*.png)|*.png";
            openFileDialog.Multiselect = false;
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtCaminhoLogo.Text = openFileDialog.FileName;
            }
            else
            {
                MessageBox.Show("Nem um arquivo selecionado!", "Selecione um arquivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
