namespace VetorExercicioFixacao
{
    internal class Estudante
    {
        public String Nome { get; set; }
        public String Email { get; set; }

        public Estudante(String nome, String email)
        {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}
