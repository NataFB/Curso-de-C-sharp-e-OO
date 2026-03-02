namespace ref_e_out
{
    class Program
    {
        static void Main(string[] args)
        {
            // utilizando ref
            int a = 10;
            Calculadora.Triple(ref a); //Exige que a variável seja iniciada
            Console.WriteLine(a);

            // utilizando out
            int b = 10;
            int quadruple; // iniciando variável de saida
            Calculadora.Quadruple(b, out quadruple);
            Console.WriteLine(quadruple);
            
        }
    }
}