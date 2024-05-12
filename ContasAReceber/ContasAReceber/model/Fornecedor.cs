using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace ContasAReceber.model
{
    class Fornecedor
    {
        private string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
        public DataSet BindingSourceFornecedores()
        {
            DataSet dt = new DataSet();
            string query = "select * from fornecedores";
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(query, bd.conexao(stringDeConexao));
            bd.AbreConexao();
            dataAdapter.Fill(dt, "fornecedores");
            bd.Fechaconexao();
            return dt;

        }
        public void InserirFornecedor(string razaosocial, string cadastropessoa, string cep, string logradouro, int numero ,string complemento ,string bairro, string cidade, string estado)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand($"insert into FORNECEDORES (razaosocial, cadastropessoa, cep, logradouro, numero, complemento, bairro, cidade, estado) values ('{razaosocial}', '{cadastropessoa}', '{cep}', '{logradouro}', {numero}, '{complemento}' ,'{bairro}', '{cidade}', '{estado}');", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@RAZAOSOCIAL", razaosocial);
            comando.Parameters.AddWithValue("@cadastropessoa", cadastropessoa);
            comando.Parameters.AddWithValue("@cep", cep);
            comando.Parameters.AddWithValue("@logradouro", logradouro);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@complemento", complemento);
            comando.Parameters.AddWithValue("@bairro", bairro);
            comando.Parameters.AddWithValue("@cidade", cidade);
            comando.Parameters.AddWithValue("@estado", estado);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
    }
}
