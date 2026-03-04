namespace ConjuntosFixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //iniciando conjunto dos cursos:
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            //Adicionando curso A:
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseA.Add(code);
            }

            //Mesma coisa para o B:
            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseB.Add(code);
            }

            //Mesma coisa para o C:
            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int code = int.Parse(Console.ReadLine());
                courseC.Add(code);
            }

            //Unindo todos os conjuntos em um só:
            HashSet<int> courses = new HashSet<int>();
            courses.UnionWith(courseA);
            courses.UnionWith(courseB);
            courses.UnionWith(courseC);
            Console.WriteLine("Total students: " + courses.Count);
        }
    }
}