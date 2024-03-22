using ContasAReceber.model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.servico
{
    class ServicoBuscaCep
    {
        public object[] ConsultaCep(String cep)
        {
            object[] obj = new object[5];
            string url = $"https://viacep.com.br/ws/{cep}/json/";
            WebClient client = new WebClient
            {
                Encoding = Encoding.UTF8
            };
            string json = client.DownloadString(url);
            CepInfo cepInfo = JsonConvert.DeserializeObject<CepInfo>(json);
            obj[0] = cepInfo.Cep;
            obj[1] = cepInfo.Logradouro.ToUpper();
            obj[2] = cepInfo.Bairro.ToUpper();
            obj[3] = cepInfo.Localidade.ToUpper();
            obj[4] = cepInfo.Uf;
            return obj;
        }
         
    }
}
