using Course.Services;

namespace Course
{
    // Define o delegate para operações numéricas binárias
    // Delegate é um tipo que representa referências a métodos com uma lista de parâmetros e um tipo de retorno específico, permitindo que métodos sejam passados como argumentos ou atribuídos a variáveis. Com TypeSafety, o compilador garante que os métodos referenciados pelo delegate tenham a mesma assinatura (mesmo número e tipo de parâmetros e tipo de retorno) do delegate, evitando erros em tempo de execução.
    //Nesse caso só pode ser referenciado métodos que recebam dois parâmetros do tipo double e retornem um double.
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            // Referenciando o método Max da classe CalculationService usando o delegate BinaryNumericOperation
            BinaryNumericOperation op = CalculationService.Max;
            double result = op(a,b);
            Console.WriteLine(result);
        }
    }
}