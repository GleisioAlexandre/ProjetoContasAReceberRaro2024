using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Configuration;

namespace ContasAReceber.model
{
    class Cliente
    {

        private string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;

        public DataSet BindingSourceClinetes()
        {
            DataSet dt = new DataSet();
            string query = "select * from pessoa";
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbDataAdapter dataAdapter = new FbDataAdapter(query, bd.conexao(stringDeConexao));
            bd.AbreConexao();
            dataAdapter.Fill(dt, "pessoa");
            bd.Fechaconexao();
            return dt;
        }
        public DataTable ExibeGridClientes()
        {
            
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            bd.AbreConexao();
            FbCommand comando = new FbCommand("select * from pessoa;", bd.conexao(stringDeConexao));
            FbDataAdapter adaptador = new FbDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            bd.Fechaconexao();
            return dt;
        }
        public void InserirClientes(String nome, String cadastropessoa, String nomecontato, String telefone, String celular, String email ,String cep, String logradouro, int numero, String complemento, String bairro, String cidade, String uf, int pj)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand($"insert into pessoa (nome, cadastrodepessoa, nomecontato, telefone, celular, email, cep, logradouro, numero, complemento, bairro, cidade, uf, pj) values ('{nome}', '{cadastropessoa}', '{nomecontato}', '{telefone}', '{celular}', '{email}', '{cep}', '{logradouro}', {numero}, '{complemento}', '{bairro}', '{cidade}', '{uf}', {pj});", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cadastrodepessoa", cadastropessoa);
            comando.Parameters.AddWithValue("@nomecontato", nomecontato);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cep", cep);
            comando.Parameters.AddWithValue("@logradouro", logradouro);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@complemento", complemento);
            comando.Parameters.AddWithValue("@bairro", bairro);
            comando.Parameters.AddWithValue("@cidade", cidade);
            comando.Parameters.AddWithValue("@uf", uf);
            comando.Parameters.AddWithValue("@pj", pj);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
        public object[] PesquisarCliente(String nome)
        {
            object[] obj = new object[15];
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("select * from pessoa where nome like @nome", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@nome", '%' + nome + '%');
            bd.AbreConexao();
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                obj[0] = leitor[0];
                obj[1] = leitor[1];
                obj[2] = leitor[2];
                obj[3] = leitor[3];
                obj[4] = leitor[4];
                obj[5] = leitor[5];
                obj[6] = leitor[6];
                obj[7] = leitor[7];
                obj[8] = leitor[8];
                obj[9] = leitor[9];
                obj[10] = leitor[10];
                obj[11] = leitor[11];
                obj[12] = leitor[12];
                obj[13] = leitor[13];
                obj[14] = leitor[14];
            }
            bd.Fechaconexao();
            return obj;
        }
        public void AtualizarCliente(String nome, String cadastropessoa, String nomecontato, String telefone, String celular, String email ,String cep, String logradouro, Int32 numero, String complemento, String bairro, String cidade, String uf, Int32 pj, Int32 idpessoa)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand($"update pessoa set nome = @nome, cadastrodepessoa = @cadastrodepessoa, nomecontato = @nomecontato, telefone = @telefone, celular = @celular, email = @email, cep = @cep , logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro, cidade = @cidade, uf = @uf, pj = @pj where idpessoa = @idpessoa;", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cadastrodepessoa", cadastropessoa);
            comando.Parameters.AddWithValue("@nomecontato", nomecontato);
            comando.Parameters.AddWithValue("@telefone", telefone);
            comando.Parameters.AddWithValue("@celular", celular);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cep", cep);
            comando.Parameters.AddWithValue("@logradouro", logradouro);
            comando.Parameters.AddWithValue("@numero", numero);
            comando.Parameters.AddWithValue("@complemento", complemento);
            comando.Parameters.AddWithValue("@bairro", bairro);
            comando.Parameters.AddWithValue("@cidade", cidade);
            comando.Parameters.AddWithValue("@uf", uf);
            comando.Parameters.AddWithValue("@pj", pj);
            comando.Parameters.AddWithValue("@idpessoa", idpessoa);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
        public void DeletarCliente(int idpessoa)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("delete from pessoa where idpessoa = @idpessoa", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@idpessoa", idpessoa);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
    }
}

