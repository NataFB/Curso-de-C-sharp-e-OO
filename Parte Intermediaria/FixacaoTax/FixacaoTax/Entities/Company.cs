namespace FixacaoTax.Entities
{
    class Company : Taxpayer
    {
        public int NumberOfEmployes { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployes) : base(name, annualIncome)
        {
            NumberOfEmployes = numberOfEmployes;
        }

        // Override the Tax method to calculate the tax based on the number of employees and annual income.
        public override double Tax()
        {
            if (NumberOfEmployes > 10)
            {
                return AnnualIncome * 0.14;
            }
            else
            {
                return AnnualIncome * 0.16;
            }
        }
    }
}
