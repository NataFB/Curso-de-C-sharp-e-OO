namespace ExercicioTrabalhadorHeranca.Entities
{
    class OutsourcedEmployee : Employee
    {
        // Properties and Constructors
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        // Constructor that initializes the base class with the Employee properties and the additional charge
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge)
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }


        //override payment method with the additional charge
        public override double Payment()
        {
            return base.Payment() + 1.1 * AdditionalCharge;
        }

    }
}
