namespace NullableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // double x = null; Dessa forma irá gerar um erro de compilação

            Nullable< double> y = null; // Dessa forma é permitido atribuir null, pois o tipo Nullable<double> é um tipo anulável (nullable)

            double? x = null; // o ? substitui o uso de Nullable<Tipo>

            double? z = 10.0;

            Console.WriteLine(x.GetValueOrDefault()); // Pega o valor de x ou se for null retorna o valor padrão do tipo double, que é 0
            Console.WriteLine(z.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // Verifica se a variável tem um valor atribuído (não é null)
            Console.WriteLine(z.HasValue);

           // Console.WriteLine(x.Value); // Acessa o valor armazenado na variável. Se for null, lança um erro: InvalidOperationException

            if (x.HasValue)
            {
                Console.WriteLine("x tem um valor atribuído.");
            }
            else
            {
                Console.WriteLine("x é null.");
            }
           
            if (z.HasValue)
            {
                Console.WriteLine("z tem um valor atribuído.");
            }
            else
            {
                Console.WriteLine("z é null.");
            }
        }
    }
}