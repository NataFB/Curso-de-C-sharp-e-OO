namespace HashSetSortedSet
{
    class Program
    {
        static void Main(string[] args) 
        {
            HashSet<string> set = new HashSet<string>(); //instanciando

            //adicionando:
            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook")); //set.Contains verifica se tem na lista e retorna true or false

            foreach (string p in set)
            {
                Console.WriteLine(p);
            }
        }
    }
}