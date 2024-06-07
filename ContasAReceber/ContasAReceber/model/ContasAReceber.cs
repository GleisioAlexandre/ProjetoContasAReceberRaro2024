using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;
using System.Data;
using ContasAReceber.controller;
using System.Configuration;

namespace ContasAReceber.model
{
    class ContasAReceber
    {
        private string stringDeConexao = ConfigurationManager.ConnectionStrings["ConexaoFirebird"].ConnectionString;


        public DataSet dataSet()
        {
            string query = "SELECT contasareceber.entrada, pessoa.nome, contasareceber.valor, contasareceber.documento, class.tipo, situacao.situacao, contasareceber.vencimento, contasareceber.pagamento FROM contasareceber JOIN pessoa ON contasareceber.idcliente = pessoa.idpessoa JOIN class ON contasareceber.class = class.iidclass JOIN situacao ON contasareceber.situacao = situacao.idsituacao";
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbDataAdapter adaptador = new FbDataAdapter(query, bd.conexao(stringDeConexao));
            DataSet dataSet  = new DataSet();
            bd.AbreConexao();
            adaptador.Fill(dataSet, "contasareceber");
            return dataSet;
        }
        public DataTable ExibeGridContas()
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            bd.AbreConexao();
            string query = "SELECT contasareceber.entrada, pessoa.nome, contasareceber.valor, contasareceber.documento, class.tipo, situacao.situacao, contasareceber.vencimento, contasareceber.pagamento FROM contasareceber JOIN pessoa ON contasareceber.idcliente = pessoa.idpessoa JOIN class ON contasareceber.class = class.iidclass JOIN situacao ON contasareceber.situacao = situacao.idsituacao";
            FbCommand comando = new FbCommand(query, bd.conexao(stringDeConexao));
            FbDataAdapter adaptador = new FbDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            bd.Fechaconexao();
            return dt;
        }
        public void InserirConta(string entrada, int idCliente, double valor, string documento, int classe, int situacao, string vencimento, object pagamento)
        {
           
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand($"insert into contasareceber (entrada, idcliente, valor, documento, class, situacao, vencimento, pagamento) values ('{entrada}', '{idCliente}', '{valor}', '{documento}', '{classe}', '{situacao}', '{vencimento}', '{pagamento}')",bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@entrada", entrada);
            comando.Parameters.AddWithValue("@idcliente", idCliente);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@class", classe);
            comando.Parameters.AddWithValue("@situacao", situacao);
            comando.Parameters.AddWithValue("@vencimento", vencimento);
            comando.Parameters.AddWithValue("@pagamento", pagamento);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
        public object[] PesquisaContoas(String documento)
        {
            object[] obj = new object[10];
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("select idcontas, entrada, (pessoa.idpessoa), (pessoa.nome), valor ,documento, class, situacao, vencimento, pagamento from contasareceber join pessoa on idpessoa = contasareceber.idcliente where documento = @documento;", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@documento", documento);
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
            }
            bd.Fechaconexao();
            return obj;
        }
        public void DeletarContas(Int32 idcontas)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("delete from contasareceber where idcontas = @idcontas;", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@idcontas", idcontas);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }
        public void AtualizarContas(string entrada, Int32 idcliente, Double valor, String documento, Int32 classe, Int32 situacao, string vencimento, string pagamento, int idcontas)
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("update contasareceber set entrada = @entrada, idcliente = @idcliente ,valor = @valor ,documento = @documento ,class = @classe, situacao = @situacao, vencimento = @vencimento, pagamento = @pagamento where  idcontas = @idcontas", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@entrada", entrada);
            comando.Parameters.AddWithValue("@idcliente", idcliente);
            comando.Parameters.AddWithValue("@valor", valor);
            comando.Parameters.AddWithValue("@documento", documento);
            comando.Parameters.AddWithValue("@classe", classe);
            comando.Parameters.AddWithValue("@situacao", situacao);
            comando.Parameters.AddWithValue("@vencimento", vencimento);
            comando.Parameters.AddWithValue("@pagamento", pagamento);
            comando.Parameters.AddWithValue("@idcontas", idcontas);
            bd.AbreConexao();
            comando.ExecuteNonQuery();
            bd.Fechaconexao();
        }

    }

   
}
