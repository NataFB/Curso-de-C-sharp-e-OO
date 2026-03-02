using System;
using System.IO;
using System.Collections.Generic;
namespace TrabalhandoComDiretorios 
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\PastaTesteDirectory";
            try
            {
                //Listar Diretórios, (*.*) para listar todos os Diretórios, SearchOption.AllDirectories para listar Diretórios em subdiretórios
                //IEnumerable<string> é uma coleção de strings que pode ser enumerada, ou seja, pode ser percorrida usando um loop foreach, e é retornada pelo método EnumerateFiles, que é usado para listar arquivos em um diretório.É um tipo mais genérico do que listas, pois pode ser usado para qualquer tipo de coleção, enquanto List<string> é uma implementação específica de uma lista de strings.
                IEnumerable<string> folder = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string folderName in folder)
                {
                    Console.WriteLine(folderName);
                }

                //Pode utilizar var para que o compilador infira o tipo da variável, que nesse caso é IEnumerable<string>, mas é importante lembrar que o tipo deve ser claro a partir do contexto para evitar confusões.
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); //Listar arquivos, (*.*) para listar todos os arquivos, SearchOption.AllDirectories para listar arquivos em subdiretórios
                Console.WriteLine("FILES:");
                foreach (string filesName in files)
                {
                    Console.WriteLine(filesName);
                }

                Directory.CreateDirectory(path + @"\PastaTesteDirectory2"); //Criar um diretório, se o diretório já existir, ele não será criado e não lançará uma exceção
            } 
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}