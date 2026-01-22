using System.Globalization;


namespace ExercicioFixacao3
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double notaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Resultado()
        {
            if (notaFinal() >= 60.0)
            {
                return "APROVADO";
            }
            else
            {
                double falta = 60.0 - notaFinal();
                return "REPROVADO\nFALTARAM " + falta.ToString("F2", CultureInfo.InvariantCulture) + " PONTOS";
            }

        }
    }
}
