namespace OperadorDeCoalescenciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            // Usando o operador de coalescência nula (??)
            double a = x ?? 5.0; // Utiliza o operador de coalescência nula para atribuir 5.0 se x for null.
            double b = y ?? 5.0; // Utiliza o operador de coalescência nula para atribuir o valor de y se não for null.

            System.Console.WriteLine(a); // Saída: 5.0
            System.Console.WriteLine(b); // Saída: 10.0
        }
    }
}
