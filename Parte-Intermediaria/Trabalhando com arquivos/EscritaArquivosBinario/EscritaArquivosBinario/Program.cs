using System.Text.Json; //Importando o serializador de Json

namespace EscritaArquivosBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nota: o BinaryFormatter ficou obsoleto e não é mais recomendado por motivos de segurança.
            // Hoje o mais comum é utilizar JSON ou XML para serialização.

            // Cria um objeto da classe Dados e já inicializa suas propriedades
            Dados d = new Dados
            {
                Numero = 120,
                Nome = "Natanael",
                Ativo = true,
                Itens = new List<string> { "Notebook", "Mouse", "Teclado" }
            };

            d.Itens.Add("Monitor");

            // (-------------------------)
            //ESCREVENDO NO ARQUIVO CRIADO:
            //(-------------------------)

            // Cria um FileStream para trabalhar com o arquivo "meuarquivo.json"
            //FileStream serve tanto para leitura quanto para escrita 
            //FileMode define o modo de como trabalhar com o arquivo
            // OpenOrCreate significa:
            // - se o arquivo existir → abre
            // - se não existir → cria
            using (FileStream stream = new FileStream("meuarquivo.json", FileMode.OpenOrCreate))
            {
                //Passando formatação para o json, deixando ele indentado e melhor de ler (muito utilizado em projetos reais)
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };

                // Serializa (converte) o objeto 'd' para JSON
                // e grava diretamente no arquivo através do stream
                JsonSerializer.Serialize(stream, d, options);
            }



            // (-------------------------)
            //LENDO O ARQUIVO CRIADO:
            //(-------------------------)

            using (FileStream stream = new FileStream("meuarquivo.json", FileMode.Open))
            {
                // Desserializa o JSON do arquivo para um objeto da classe Dados
                Dados dadosLidos = JsonSerializer.Deserialize<Dados>(stream);

                // Mostrando os dados no console
                Console.WriteLine(dadosLidos.Numero);
                Console.WriteLine(dadosLidos.Nome);
                Console.WriteLine(dadosLidos.Ativo);

                // Percorrendo a lista de itens
                foreach (string item in dadosLidos.Itens)
                {
                    Console.WriteLine(item);
                }
            }
            

        } // ao sair do bloco, o 'using' fecha o arquivo automaticamente

        public class Dados
        {
            public int Numero { get; set; }
            public string Nome { get; set; }
            public bool Ativo { get; set; }
            public List<string> Itens { get; set; }
        }
    }
}