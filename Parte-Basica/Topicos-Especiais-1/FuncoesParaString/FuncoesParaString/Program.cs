namespace FuncoesParaString
{
    class Program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGHIJ ABC abc DEFG   ";


            string s1 = original.ToUpper(); // Tudo Maiúsculo
            string s2 = original.ToLower(); // Tudo Minúsculo
            string s3 = original.Trim(); // Apaga espaços em branco antes e depois da frase
            int n1 = original.IndexOf("bc"); // Busca primeira ocorrência, retorna posição da ocorrência
            int n2 = original.LastIndexOf("bc"); // Busca Ultima ocorrência, retorna posição da ocorrência
            string s4 = original.Substring(3); // Dando indice inicial. Gera Uma string da posição em diante, cortando antes do indice
            string s5 = original.Substring(3, 5); // Da o inicio e quantidade de caracteres que irá cortar. Corta e gera uma nova string com os caracteres cortados.
            string s6 = original.Replace('a', 'x'); // Troca todas as ocorrências por outra. (troca a por x)
            string s7 = original.Replace("abc", "xy");// Troca todas as ocorrências por outra. (troca abc por xy)
            bool b1 = String.IsNullOrEmpty(original); // Confere se é vazia ou não
            bool b2 = String.IsNullOrWhiteSpace(original); // Confere se é vazia ou é só espaço em branco.


            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);
        }
    }
}