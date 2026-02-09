namespace ExercicioTrabalhadorHeranca.Entities
{
    class Employee
    {
        // Properties and Constructors
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        // Methods
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }
    }
}
