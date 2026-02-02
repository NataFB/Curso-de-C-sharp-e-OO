namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "Alex", "Bob" };

            // Método com o for normal:
      
             for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine("--------------------------------------------------------------");

            // Método com o foreach:

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }

            

        }
    }
}