using System.Collections.Generic;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            // o Add por padrão adiciona no final da lista.
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            //o Insert você pode escolher a posição que quer inserir
            list.Insert(2, "Marco"); // (Posição, Valor)

            // acessa diretamente uma informação diretamente
            Console.WriteLine(list[2]);
            Console.WriteLine();

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count); //Count mostra o tamanho da lista

            //Encontra a primeira ocorrência do parâmetro
            string s1 = list.Find(x => x[0] == 'A'); // Espera um Predicado como argumento (Um tipo de função lambda), uma função que pega um valor e vai retornar True or False dependendo
                                                     // da lógica implementada na função
            Console.WriteLine("First A: " + s1);
            
            //Encontra a ultima ocorrência do parâmetro
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            //Encontra a primeira posição da ocorrência do parâmetro
            int pos1 = list.FindIndex(x => x[0] ==  'A');
            Console.WriteLine("Firs position A: " + pos1);

            //Encontra a ultima posição da ocorrência do parâmetro
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position A: " + pos2);

            Console.WriteLine("------------------------------------------------");
            
            //Criando uma lista que recebe a lista anterior com um filtro de parâmetro e armazena os resultados nessa nova lista (nesse caso: ocorrências que tem tamanho igual a 5)
            List<string> list2 = list.FindAll(x => x.Length == 5);
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------");

            // Remove itens da lista, espera como parâmetro uma string (pois a lista é de string), caso não encontre apenas não faz nada
            list.Remove("Alex");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //Remove todos os itens da lista que tenham a lógica do parâmetro passado
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();

            //Remove item pela posição
            list.RemoveAt(0);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------");
            // Recolocando os nomes
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Insert(2, "Marco");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("------------------------------------------------");
            // Remove elementos a partir de uma posição (Posição de inicio, Quantidade a remover)
            list.RemoveRange(2, 2);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}