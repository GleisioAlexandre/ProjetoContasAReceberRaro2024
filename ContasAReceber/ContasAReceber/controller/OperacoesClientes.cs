using ContasAReceber.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.controller
{
    class OperacoesClientes
    {
        Cliente cliente = new Cliente();
        public DataTable ExibeGridClinetes()
        {
            return cliente.ExibeGridClientes();
        }
        public void InseirClinete(String nome, String cadastrodepessoa, String cep, String logradouro, String numero, String complemento, String bairro, String cidade, String uf, Int32 pj)
        {
            cliente.InserirClientes(nome, cadastrodepessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, pj);
        }
        public void AtualizarCliente(String nome, String cadastrodepessoa, String cep, String logradouro, String numero, String complemento, String bairro, String cidade, String uf, Int32 pj,  Int32 idpessoa)
        {
            cliente.AtualizarCliente(nome, cadastrodepessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, pj, idpessoa);
        }
        public object[] PesquisaCliente(String nome)
        {
            object[] obj = new object[11];
            obj[0] = cliente.PesquisarCliente(nome)[0];
            obj[1] = cliente.PesquisarCliente(nome)[1];
            obj[2] = cliente.PesquisarCliente(nome)[2];
            obj[3] = cliente.PesquisarCliente(nome)[3];
            obj[4] = cliente.PesquisarCliente(nome)[4];
            obj[5] = cliente.PesquisarCliente(nome)[5];
            obj[6] = cliente.PesquisarCliente(nome)[6];
            obj[7] = cliente.PesquisarCliente(nome)[7];
            obj[8] = cliente.PesquisarCliente(nome)[8];
            obj[9] = cliente.PesquisarCliente(nome)[9];
            obj[10] = cliente.PesquisarCliente(nome)[10];
            return obj;
        }
        public void DeletaCliente(int idcliente)
        {
            cliente.DeletarCliente(idcliente);
        }
    }
}
