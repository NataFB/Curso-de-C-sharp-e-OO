using System;
using System.IO;
namespace UtilizandoPath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\PastaTesteDirectory\file1.txt";
            //O método Path fornece informações sobre caminhos de arquivos e diretórios, além de métodos para manipular esses caminhos.
            //Ele é útil para lidar com caminhos de forma independente do sistema operacional, garantindo que o código funcione corretamente em diferentes ambientes.

            // Exibindo informações sobre o caminho
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);// Retorna o caractere usado para separar diretórios em um caminho (por exemplo, '\' no Windows e '/' no Linux).
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);//Retorna o caractere usado para separar caminhos em uma lista de caminhos (por exemplo, ';' no Windows e ':' no Linux).
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); //Obtem a parte do caminho que representa o diretório.
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));//Obtem a parte do caminho que representa o nome do arquivo, incluindo a extensão.
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));//Obtem a extensão do arquivo, incluindo o ponto (por exemplo, ".txt").
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));//Obtem o nome do arquivo sem a extensão.
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));//Obtem o caminho completo, resolvendo quaisquer partes relativas (como "..") e retornando um caminho absoluto.
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());//Obtem o caminho do diretório temporário do sistema, onde arquivos temporários podem ser criados.
        }
    }
}