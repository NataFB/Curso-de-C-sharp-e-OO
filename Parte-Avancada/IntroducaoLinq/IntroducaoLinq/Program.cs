using System.Linq;

namespace IntroducaoLinq
{
    class Program
    {
        //Linq - Language Integrated Query é uma poderosa ferramenta de consulta integrada à linguagem C#. Ele permite que você escreva consultas de forma concisa e expressiva para manipular dados de diversas fontes, como arrays, listas, bancos de dados, XML, etc. O Linq oferece uma sintaxe fluente e fácil de entender, tornando o código mais legível e eficiente.
        static void Main(string[] args)
        {
            //ESPECIFICANDO A FONTE DE DADOS (Data Source)
            //array de números inteiros. Poderia ser uma coleção de objetos, um banco de dados, um arquivo XML, etc.
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //DEFININDO A EXPRESSÃO DE CONSULTA (Query Expression)
            //foi usado var pois o tipo que result retorna é um IEnumerable<int> e não um int. Linq retorna IEnumerable<T> ou IQueryable<T>, dependendo da fonte de dados, e não um tipo específico como int ou string. O tipo exato do resultado pode variar com base na consulta e na fonte de dados, mas geralmente é uma coleção de elementos que correspondem ao tipo dos dados originais. Porém é sempre um mais genérico, como IEnumerable<T> ou IQueryable<T>, que pode ser iterado ou consultado posteriormente.
            var result = numbers
                .Where(x => x % 2 == 0) // O método Where é usado para filtrar da coleção de números, selecionando apenas o que estiver conforme a condição especificada.
                .Select(x => x * 10); // O método Select é usado para projetar os elementos filtrados.

            //EXECUTANDO A CONSULTA (Executing the Query)
            foreach (int x in result) 
            {
                Console.WriteLine(x);
            }
        }
    }
};
