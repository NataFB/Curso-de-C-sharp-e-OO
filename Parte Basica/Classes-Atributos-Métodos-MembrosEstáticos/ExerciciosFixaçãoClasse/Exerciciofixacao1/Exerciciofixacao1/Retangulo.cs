using System.Globalization;
namespace Exerciciofixacao1
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        override public string ToString()
        {
            return "AREA = " + Area().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                   "PERIMETRO = " + Perimetro().ToString("F2", CultureInfo.InvariantCulture) + "\n" +
                   "DIAGONAL = " + Diagonal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
