using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirebirdSql.Data.FirebirdClient;

namespace ContasAReceber.model
{
    class BancoDeDados
    {
        private FbConnection cx;

        public  BancoDeDados(string stringDeConexao)
        {
            cx = new FbConnection(stringDeConexao);
            
        }

        public FbConnection conexao(string stringDeConexao)
        {
            cx = new FbConnection(stringDeConexao);
            return cx;
        }

        public  void AbreConexao()
        {
            
            try
            {
                if (cx.State == System.Data.ConnectionState.Closed)
                {
                    cx.Open();
                }
            }
            catch (Exception ex)
            {
                
            }
            
        }
        public void Fechaconexao()
        {
            try
            {
                if (cx.State == System.Data.ConnectionState.Open)
                {
                    cx.Close();
                }
            }
            catch (Exception ex)
            {

            }
        }
        
    }
}
