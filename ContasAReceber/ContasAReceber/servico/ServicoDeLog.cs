using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContasAReceber.servico
{
    class ServicoDeLog
    {
        public void Logs(string menssagem)
        {
            string ficheiro = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\logs"+DateTime.Now.Date.ToString("ddMMyyy")+".txt";
            StreamWriter file = new StreamWriter(ficheiro, true, Encoding.Default);
            file.WriteLine(DateTime.Now + " > " + menssagem);
            file.Dispose();
        }
    }
}
