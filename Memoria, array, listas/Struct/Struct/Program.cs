namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            Point p1, p;
           // Console.WriteLine(p1); erro: Variavel 'p1' usada antes de ser atribuída
            p1.X = 10;
            p1.Y = 20;
            Console.WriteLine(p1); // vai retornar 10 e 20 para os campos X e Y
            p = new Point(); // vai retornar 0 para os campos X e Y
            Console.WriteLine(p);
        }
    }
}