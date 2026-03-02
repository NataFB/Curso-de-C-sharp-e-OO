using ExercicioFixacaoArquivos.Entities;
using System;
using System.Globalization;
using System.IO;

namespace ExercicioFixacaoArquivos 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicita ao usuário o caminho completo do arquivo de origem
            Console.Write("Enter file full path: ");
            string sourceFilePath = Console.ReadLine();

            try
            {
                // Lê todas as linhas do arquivo informado
                // Cada linha do arquivo vira uma posição do array "lines"
                string[] lines = File.ReadAllLines(sourceFilePath);

                string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);  // Obtém o caminho da pasta onde o arquivo de origem está localizado
                string targetFolderPath = sourceFolderPath + @"\out"; // Define o caminho da pasta de saída chamada "out"
                string targetFilePath = targetFolderPath + @"\summary.csv";  // Define o caminho completo do arquivo de saída "summary.csv" dentro da pasta "out"

                // Cria a pasta "out" caso ela ainda não exista
                // Se já existir, nada acontece (não gera erro)
                Directory.CreateDirectory(targetFolderPath);

                // Abre o arquivo summary.csv em modo de acréscimo (append)
                // Se o arquivo não existir, ele será criado
                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {

                        string[] fields = line.Split(','); // Divide a linha em partes usando a vírgula como separador.Ex:"TV,900.00,1" → ["TV", "900.00", "1"]
                        string name = fields[0]; // O nome do produto é a primeira parte da linha (posição 0 do array "fields")
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture); // Segundo campo: preço do produto
                        int quantity = int.Parse(fields[2]);  // Terceiro campo: quantidade do produto

                        Product prod = new Product(name, price, quantity); // Cria um objeto do tipo Product usando os dados lidos do arquivo

                        sw.WriteLine(prod.Name + "," + prod.Total().ToString("F2", CultureInfo.InvariantCulture));// Escreve no arquivo summary.csv
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