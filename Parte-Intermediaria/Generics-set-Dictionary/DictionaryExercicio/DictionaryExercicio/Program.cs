namespace DictionaryExercicio
{
    class Program 
    {
        static void Main(string[] args)
        {
            // Pede ao usuário o caminho completo do arquivo e lê o caminho digitado pelo usuário e armazena na variável path
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                // Abre o arquivo de texto para leitura. O "using" garante que o arquivo será fechado automaticamente após o uso
                using (StreamReader sr = File.OpenText(path))
                {
                    // Cria um Dictionary onde:
                    // string = nome do candidato (chave)
                    // int = quantidade de votos (valor)
                    Dictionary<string, int> dict = new Dictionary<string, int>();

                    // Enquanto não chegar ao final do arquivo
                    while (!sr.EndOfStream)
                    {
                        // Lê uma linha do arquivo. Split(",") divide a string em duas partes usando a vírgula
                        string[] votingRecord = sr.ReadLine().Split(",");

                        // Pega o nome do candidato (primeira posição do array)
                        string candidate = votingRecord[0];

                        // Converte a quantidade de votos (segunda posição) de string para int
                        int votes = int.Parse(votingRecord[1]);

                        // Verifica se o candidato já existe no Dictionary
                        if (dict.ContainsKey(candidate))
                        {
                            // Se já existir, soma os votos ao valor atual
                            dict[candidate] += votes;
                        }
                        else
                        {
                            // Se não existir, adiciona o candidato com a quantidade de votos
                            dict[candidate] = votes;
                        }
                    }

                    // Percorre todos os elementos do Dictionary
                    foreach (var item in dict)
                    {
                        // item.Key = nome do candidato
                        // item.Value = total de votos
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e) // Captura erros relacionados a arquivo (ex: caminho inválido)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}