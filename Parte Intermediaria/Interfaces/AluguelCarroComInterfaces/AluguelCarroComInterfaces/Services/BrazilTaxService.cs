namespace AluguelCarroComInterfaces.Services 
{
    // A classe BrazilTaxService é uma implementação concreta da interface ITaxService, ou seja, ela fornece uma implementação específica para o método Tax, que calcula o imposto de acordo com as regras do Brasil.
    //Lembrete: Não é uma herança, mas sim uma implementação de interface (mesmo a declaração sendo igual a da herança).
    class BrazilTaxService : ITaxService // declarando a implementação da interface.
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
