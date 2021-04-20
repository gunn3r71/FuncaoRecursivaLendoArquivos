﻿using System;
using System.IO;
using System.Threading;

namespace FuncaoRecursivaLendoArquivos
{
    class Program
    {
        //Programa que vai ler os arquivos de uma pasta chamada ArquivosDotNetRead
        private static void LerArquivo(string nome_arquivo)
        {
            using (StreamReader arquivo = File.OpenText(nome_arquivo)) // Linha que abre o arquivo
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null) // Código que faz a leitura das linhas
                {
                    Console.WriteLine(linha); 
                }
            }
        }

        static void Main(string[] args)
        {
            LerArquivo(@"C:\ArquivosDotNetRead\arq1.txt");
        }
    }
}
