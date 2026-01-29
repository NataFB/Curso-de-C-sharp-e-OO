namespace ref_e_out
{
    internal class Calculadora
    {
        // Utilizando ref
        public static void Triple(ref int x) // ref faz com que o parâmetro x seja uma referencia a váriavel e possibilitando assim a modificação dela
        {
            x = x * 3;
        }

        // Utilizando out
        public static void Quadruple(int origin, out int result) // out passa o parâmetro de origem e retorna a saida em outro parâmetro de saida (out)
        {
            result = origin * 4;
        }
    }
}
