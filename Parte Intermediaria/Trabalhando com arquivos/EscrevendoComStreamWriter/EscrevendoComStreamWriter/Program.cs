using System;
using System.IO;

namespace EscrevendoComStreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file1.txt";
            string targetPath = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file2.txt";
            try
            {
                string[] lines = File.ReadAllLines(sourcePath); // Lê todas as linhas do arquivo de origem e armazena em um array de strings

                // O StramWriter é uma classe que permite escrever caracteres em um fluxo de dados, como um arquivo. Ele é usado para escrever texto em um arquivo de forma eficiente.
                using (StreamWriter sw = File.AppendText(targetPath)) //File.AppendText vai abrir o arquivo e adicionar o conteúdo ao final do arquivo, sem sobrescrever o conteúdo existente. Se o arquivo não existir, ele será criado.
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper()); // O método WriteLine escreve uma linha de texto no arquivo, seguido por um caractere de nova linha.
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}