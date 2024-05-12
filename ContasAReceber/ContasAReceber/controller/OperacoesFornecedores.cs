using ContasAReceber.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.controller
{
    class OperacoesFornecedores
    {
        Fornecedor fornecedor = new Fornecedor();
        public DataSet BindigSourceFornecedores()
        {
            return fornecedor.BindingSourceFornecedores(); ;
        }
     public void InserirFornecedor(string razaosocial, string cadastropessoa, string cep, string logradouro, int numero, string complemento ,string bairro, string cidade, string estaado)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.InserirFornecedor(razaosocial, cadastropessoa, cep, logradouro, numero, complemento ,bairro, cidade, estaado);
        }
      
    }
}
