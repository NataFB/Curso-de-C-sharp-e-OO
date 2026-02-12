using System.IO;

namespace FilestrameStreamreader
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Caminho do arquivo a ser lido
            string path = @"C:\Users\nataf\OneDrive\Documentos\Curso-de-C-sharp-e-OO\Parte Intermediaria\Trabalhando com arquivos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try 
            {
                // Criando o FileStream para ler o arquivo.
                // (caminho do arquivo, modo de abertura)
                fs = new FileStream(path, FileMode.Open);
                // Criando o StreamReader para ler o conteúdo do arquivo.
                sr = new StreamReader(fs);
                while (!sr.EndOfStream)
                {
                    // Lendo o conteúdo do arquivo e exibindo no console.
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error accurred");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fechando o StreamReader e o FileStream para liberar os recursos.
                // Como eles não são gerenciados pelo clr do .NET pois são recursos externos, nesse caso conversa diretamente com o sistema operacional.
                // É necessário fechá - los para liberar os recursos alocados por eles.
                // Verificando se o StreamReader e o FileStream foram criados antes de tentar fechá-los.
                if (sr != null) sr.Close();
                if(fs != null) fs.Close();
            }

        }
    }
}