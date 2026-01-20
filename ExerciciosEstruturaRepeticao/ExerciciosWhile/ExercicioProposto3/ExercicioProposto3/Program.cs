namespace ExercicioProposto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Com qual combustivel gostaria de abastecer:");
            Console.WriteLine("1 - Álcool");
            Console.WriteLine("2 - Gasolina");
            Console.WriteLine("3 - Diesel");
            Console.WriteLine("4 - Fim");
            int opcao = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (opcao != 4)
            {
                if(opcao == 1) 
                {
                    alcool++;
                }
                else if (opcao == 2) 
                {
                    gasolina++;
                }
                else if(opcao == 3) 
                {
                    diesel++;
                }
                else
                {
                    Console.WriteLine("Código inválido. Digite um novo código: ");
                }
                opcao = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Álcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}