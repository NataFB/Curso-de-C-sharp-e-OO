using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class program
    {
        static void Main(string[] args)
        {
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Expresão ternária: ( condição ) ? valor_se_verdadeiro : valor_se_falso
            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            // O código acima da expresão ternaria equivale a lógica if-else comentada abaixo

            /* double desconto;
             if (preco < 20.0)
             {
                 desconto = preco * 0.1;
             }
             else
             {
                 desconto = preco * 0.05;
             }
            */

            Console.WriteLine(desconto);
        }
    }
}