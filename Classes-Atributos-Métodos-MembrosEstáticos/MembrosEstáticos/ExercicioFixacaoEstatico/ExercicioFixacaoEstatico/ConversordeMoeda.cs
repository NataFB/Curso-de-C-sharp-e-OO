namespace ExercicioFixacaoEstatico
{
    internal class ConversordeMoeda
    {
        public static double IOF = 0.06;

        public static double ConversorParaReais(double cotacao, double quantidade)
        {
            double valorSemIOF = cotacao * quantidade;
            double valorComIOF = valorSemIOF + (valorSemIOF * IOF);
            return valorComIOF;
        }
    }
}
