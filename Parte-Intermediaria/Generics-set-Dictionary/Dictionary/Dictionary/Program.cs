namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria um dicionário onde: A chave (Key) é do tipo string. O valor (Value) também é do tipo string
            //Dictionary não garante ordem dos elementos. Não possuem posição são indexados pelo objeto chave.
            //Chave  →  Valor
            Dictionary<string, string> cookies = new Dictionary<string, string>();


            // Adicionando elementos usando o indexador []
            // Pode também utilizatar o Add() para adicionar: cookies.Add("city", "São Paulo"); Add() lança exceção se a chave já existir
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "123456789";
            // cookies["chave"] = valor → Sobrescreve se já existir. Dictionary NÃO permite chaves duplicadas.
            cookies["phone"] = "987654321";

            // Acessando valores pela chave
            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email"); // Remove um elemento com base na chave

            // Verifica se a chave existe antes de acessar. Boa prática para evitar exceção
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no email key");
            }

            // Mostra a quantidade de elementos no Dictionary
            Console.WriteLine("Size: " + cookies.Count);

            // Percorrendo o Dictionary. Cada item é um KeyValuePair<TKey, TValue>
            Console.WriteLine("All Cookies:");
            foreach (KeyValuePair<string, string> item in cookies) //pode uar o var no lugar do KeyValuePair
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}