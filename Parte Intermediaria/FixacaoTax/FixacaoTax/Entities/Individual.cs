namespace FixacaoTax.Entities
{
    class Individual : Taxpayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        // Override the Tax method to calculate the tax based on the annual income in the case of an individual, with a deduction for health expenditures.
        public override double Tax()
        {

            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExpenditures * 0.5);
            }
            else
            {
                return (AnnualIncome * 0.25) - (HealthExpenditures * 0.5);
            }
        }
    }
}
