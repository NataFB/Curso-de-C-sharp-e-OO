namespace AluguelCarroComInterfaces.Services
{
    interface ITaxService
    {
        // A interface define o contrato para o serviço de imposto, ou seja, qualquer classe que implementar essa interface deve fornecer uma implementação para o método Tax, que recebe um valor e retorna o valor do imposto correspondente.
        double Tax(double amount);
    }
}
