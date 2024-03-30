using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using FirebirdSql.Data.FirebirdClient;
using ContasAReceber.model;
using System.Windows.Forms;

namespace ContasAReceber.controller
{
    class OperacoesContas
    {
        Contas contas = new Contas();
        
        public DataSet datSet()
        {
            return contas.dataSet();
        }
        public DataTable ExibGridContas()
        {
            
            return contas.ExibeGridContas();
        }
        public void InserirConta(string entrada, int idCliente, double valor, string documento, int classe, int situacao, string vencimento, string pagamento)
        {
            contas.InserirConta(entrada, idCliente, valor, documento, classe, situacao, vencimento, pagamento);
            
        }
        public object[] PesquisarDivida(String documento)
        {
            object[] obj = new object[10];
            obj[0] = contas.PesquisaContoas(documento)[0];
            obj[1] = contas.PesquisaContoas(documento)[1];
            obj[2] = contas.PesquisaContoas(documento)[2];
            obj[3] = contas.PesquisaContoas(documento)[3];
            obj[4] = contas.PesquisaContoas(documento)[4];
            obj[5] = contas.PesquisaContoas(documento)[5];
            obj[6] = contas.PesquisaContoas(documento)[6];
            obj[7] = contas.PesquisaContoas(documento)[7];
            obj[8] = contas.PesquisaContoas(documento)[8];
            obj[9] = contas.PesquisaContoas(documento)[9];
            return obj;
        }
        public object[] PesquisarCliente(String nome)
        {
            Cliente cliente = new Cliente();
            object[] retorno = new object[2];
            retorno[0] = cliente.PesquisarCliente(nome)[0];
            retorno[1] = cliente.PesquisarCliente(nome)[1];
            return retorno;
        }

        public void DeletarContas(Int32 idcontas)
        {
            contas.DeletarContas(idcontas);
        }

        public void AtualizaContas(string entrada, Int32 idcliente, Double valor, String documento, Int32 classe, Int32 situacao, string vencimento, string pagamento, int idcontas)
        {
            contas.AtualizarContas(entrada, idcliente, valor, documento, classe, situacao, vencimento, pagamento, idcontas);
        }
    }
}
