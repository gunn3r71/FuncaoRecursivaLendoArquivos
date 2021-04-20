using System;
using System.IO;
using System.Threading;

namespace FuncaoRecursivaLendoArquivos
{
    class Program
    {
        //Programa que vai ler os arquivos de uma pasta chamada ArquivosDotNetRead
        private static void LerArquivo(string nome,int numero_arquivo)
        {
            string nome_arquivo = $@"C:\ArquivosDotNetRead\{nome}{numero_arquivo}.txt"; // Monta a string que gera o caminho do arquivo a ser lido
            if (File.Exists(nome_arquivo)) // verifica se arquivo existe
            {
                using (StreamReader arquivo = File.OpenText(nome_arquivo)) // Linha que abre o arquivo
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null) // Código que faz a leitura das linhas
                    {
                        Console.WriteLine(linha);
                    }
                }
                LerArquivo(nome, numero_arquivo + 1); // Chama a função incrementando um ao número do arquivo
            } else
            {
                Console.WriteLine("Não existem mais arquivos para Ler!");
            }
        }

        static void Main(string[] args)
        {
            LerArquivo("arq", 1); //Chamando a função passando arq como parâmetro de nome de arquivo e 1 como número de arquivo
            Console.ReadKey();
        }
    }
}
