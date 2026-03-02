namespace FixacaoTax.Entities
{
    // Abstract class that represents a taxpayer, with properties for name and annual income, and a method to calculate tax.
    abstract class Taxpayer
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public Taxpayer() 
        {
        }

        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        // Abstract method to calculate tax, which will be implemented in the derived classes (Individual and Company).
        abstract public double Tax();
    }
}
