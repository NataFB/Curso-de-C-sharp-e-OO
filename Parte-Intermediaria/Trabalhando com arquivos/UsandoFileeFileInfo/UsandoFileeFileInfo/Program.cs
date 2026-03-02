using System;
using System.IO;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Usandofilefileinfo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Coloque o caminho do arquivo que deseja ler. O @ é para evitar erros de escape de caracteres, como a barra invertida.
            string sourcePath = @"C:\Users\nataf\\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file1.txt";

            // Coloque o caminho do arquivo de destino.
            string targetPath = @"C:\Users\nataf\\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath); // Cria um objeto FileInfo para o arquivo de origem.
                fileInfo.CopyTo(targetPath); // Copia o arquivo para o caminho de destino.
                string[] lines = File.ReadAllLines(sourcePath); // Lê todas as linhas do arquivo de origem e armazena em um array de strings.
                foreach (string line in lines)
                {
                    Console.WriteLine(line); // Imprime cada linha do arquivo de origem no console.
                }
            }
            catch (IOException e) // IOException é a classe base para erros de entrada/saída, como problemas de leitura ou escrita em arquivos.
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}