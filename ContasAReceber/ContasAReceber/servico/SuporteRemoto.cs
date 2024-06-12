using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.servico
{
    class SuporteRemoto
    {
        public void AcessoRemoto()
        {
            string caminhoApp = @"C:\Program Files (x86)\Conectagat\Contas a Receber\Acesso Remoto\Remoto.exe";

            try
            {
                Process processo = new Process();
                processo.StartInfo.FileName = caminhoApp;
                processo.Start();
            } catch (Exception ex)
            {

            }
        }
    }
}
