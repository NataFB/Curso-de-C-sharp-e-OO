using System;
using System.Globalization;

namespace ExercicioProposto6
{
    class Program
    {
        static void Main(string[] args)
        {
           double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;

            Console.WriteLine("Digite os valores de cada lado do triangulo (na mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2.0;
            circulo = 3.14159 * Math.Pow(C, 2);
            trapezio = ((A + B) * C) / 2.0;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }

}