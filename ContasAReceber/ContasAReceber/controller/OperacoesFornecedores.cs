using ContasAReceber.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.controller
{
    class OperacoesFornecedores
    {
       public void InserirFornecedor(string razaosocial)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.InserirFornecedor(razaosocial);
        }
        
    }
}
