using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.model
{
   
    class Relatorio
    {
        private string stringDeConexao = "User=SYSDBA; Password=masterkey; Database=C:/ContasAReceber/BancodeDados/BD.FDB; DataSource=localhost;Port=3050";
        public DataTable ExibGrid()
        {
            BancoDeDados bd = new BancoDeDados(stringDeConexao);
            bd.AbreConexao();
            FbCommand comando = new FbCommand("select pessoa.nome as cliente, sum(valor) as total_devido from contasareceber join pessoa on idpessoa = contasareceber.idcliente join class on class = contasareceber.class join situacao on idsituacao = contasareceber.situacao where situacao.situacao = 'Pago'  group by pessoa.nome;", bd.conexao(stringDeConexao));
            FbDataAdapter adaptador = new FbDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            bd.Fechaconexao();
            return dt; 
        }
    }
}
