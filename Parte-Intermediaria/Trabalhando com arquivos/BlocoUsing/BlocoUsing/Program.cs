using System;
using System.IO;
namespace BlocoUsing 
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file1.txt";

            try
            {
                //Bloco using: é utilizado para garantir que os recursos sejam liberados corretamente.Mesmo que ocorra uma exceção.
                //Ele é especialmente útil para trabalhar com objetos que implementam a interface IDisposable (que o CLI do .NET não gerencia), como FileStream, StreamReader, etc.
                //Ele fecha automaticamente o recurso instanciado dentro dos () após o bloco de código ser executado, mesmo que ocorra uma exceção.

                using (StreamReader sr = File.OpenText(path)) //O método File.OpenText é utilizado para abrir um arquivo de texto para leitura. Ele retorna um objeto StreamReader que pode ser usado para ler o conteúdo do arquivo.
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }
    }
}