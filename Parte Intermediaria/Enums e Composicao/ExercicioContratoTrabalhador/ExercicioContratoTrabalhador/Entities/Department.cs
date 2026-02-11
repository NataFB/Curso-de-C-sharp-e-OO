namespace ExercicioContratoTrabalhador.Entities
{
    class Department
    {
        //Classe Departamento com propriedade Nome
        public String Name { get; set; }

        public Department()
        {
        }

        public Department(String name)
        {
            Name = name;
        }
    }
}
