namespace HashSetSortedSet2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            PrintCollection(a);
            PrintCollection(b);

            //União de coleções:
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b); //união de c com b (sendo que o c ja contem o conteudo de a), conjunto não aceita repetição!
            PrintCollection(c);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); // faz a interseção dos elementos de d (que contem a) e b
            PrintCollection(d);

            //Diferença
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b); // elementos diferentes, nesse caso elementos de e (que contém a) que são diferentes do b
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }
    }
}