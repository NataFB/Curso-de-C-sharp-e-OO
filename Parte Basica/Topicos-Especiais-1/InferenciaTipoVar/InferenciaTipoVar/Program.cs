namespace InferenciaTipoVar
{
    class Program
    {
        static void Main(string[] args)
        {
            //O var é uma comodidade para caso tenha uma declaração muito grande e complexo, facilita mas DEVE SER EVITADO pois geram brechas para erros!

            //O tipo da variavel vai ser inferido conforme a sua iniciação. Tipo var: tipo variável.
            var x = 10;
            var y = 20.0;
            var z = "Maria";

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}