using ContasAReceber.model;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.controller
{
    class RelatoriosClientes
    {
        private string stringDeConexao = "User=SYSDBA; Password=masterkey; Database=C:/ContasAReceber/BancodeDados/BD.FDB; DataSource=localhost;Port=3050";
        public object[] ClientesDevedores(string nomeCliente)
        {
            object[] obj = new object[2];
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            FbCommand comando = new FbCommand("select pessoa.nome as cliente, sum(valor) as total_devido from contasareceber join pessoa on idpessoa = contasareceber.idcliente join class on class = contasareceber.class join situacao on idsituacao = contasareceber.situacao where pessoa.nome = @nomeCliente and contasareceber.situacao = 2 group by pessoa.nome;", bd.conexao(stringDeConexao));
            comando.Parameters.AddWithValue("@nomeCliente", nomeCliente);
            bd.AbreConexao();
            FbDataReader leitor = comando.ExecuteReader();
            while (leitor.Read())
            {
                obj[0] = leitor[0];
                obj[1] = leitor[1];
            }
            bd.Fechaconexao();
            return obj;
            
        }

    }
}


