﻿using System;
using System.IO;
using System.Threading;

namespace FuncaoRecursivaLendoArquivos
{
    class Program
    {
        //Programa que vai ler os arquivos de uma pasta chamada ArquivosDotNetRead
        private static void LerArquivo(string nome,int numero_arquivo)
        {
            string diretorio = @"C:\ArquivosDotNetRead\";
            string nome_arquivo = $"{diretorio}{nome}{numero_arquivo}.txt";
            if (File.Exists(nome_arquivo))
            {
                using (StreamReader arquivo = File.OpenText(nome_arquivo)) // Linha que abre o arquivo
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null) // Código que faz a leitura das linhas
                    {
                        Console.WriteLine(linha);
                    }
                }
            } else
            {
                Console.ReadKey();
            }

            LerArquivo(nome,numero_arquivo+1);
        }

        static void Main(string[] args)
        {
            LerArquivo("arq", 1);
        }
    }
}
