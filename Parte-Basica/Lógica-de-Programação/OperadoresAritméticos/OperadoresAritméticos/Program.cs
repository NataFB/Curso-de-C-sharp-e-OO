namespace OperadoresAritmeticos 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2; //ordem de precedencia: primeiro vem a multiplicação e depois a soma
            int n2 = (3 + 4) * 2; //com o uso dos parenteses a soma é feita primeiro
            int n3 = 17 % 3; //o operador % retorna o resto da divisão inteira, nesse caso 17 dividido por 3 é 5 e sobra 2, logo o resultado é 2
            double n4 = 10.0 / 8.0; //para que a resposta seja em doble e pegue casas decimais não se pode colocar o numero como 10/8 apenas e sim deve ter a casa decimal ou se posto com o casting (double)10 / 8
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c; // Math.Pow é usado para calcular potências, nesse caso b elevado a 2, assim só precisa trocar o numero 2.0 para outro valor para calcular outra potência ao inves de fazer b * b ou b * b * b, assim por diante.
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(delta);
            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }
    }
}