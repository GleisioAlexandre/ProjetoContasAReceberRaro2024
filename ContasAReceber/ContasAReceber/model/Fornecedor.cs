using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace ContasAReceber.model
{
    class Fornecedor
    {
        private string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;
        public void InserirFornecedor(string RAZAOSOCIAL)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand($"insert into FORNECEDORES (RAZAOSOCIAL) values ('{RAZAOSOCIAL}')", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@RAZAOSOCIAL", RAZAOSOCIAL);
           /* comando.Parameters.AddWithValue("@cadastropessoa", cadastropessoa);
            comando.Parameters.AddWithValue("@cep", cep);
            comando.Parameters.AddWithValue("@logradouro", logradouro);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@bairro", bairro);
            comando.Parameters.AddWithValue("@cidade", cidade);
            comando.Parameters.AddWithValue("@estado", estado);*/
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
    }
}
