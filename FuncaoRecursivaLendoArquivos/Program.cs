using System;
using System.IO;
using System.Threading;

namespace FuncaoRecursivaLendoArquivos
{
    class Program
    {
        //Programa que vai ler os arquivos de uma pasta chamada ArquivosDotNetRead
        private static void LerArquivo(string arq)
        {
            using (StreamReader arquivo = File.OpenText(arq))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                    ThreadPool.QueueUserWorkItem(ProcessaLinha, linha);
                }
            }
        }

        static void Main(string[] args)
        {
            
        }
    }
}
