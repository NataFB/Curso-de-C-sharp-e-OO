namespace ProcessamentoContratoFixacao.Services
{
    interface IOnlinePaymentService
    {
        double PaymentFee (double amount); // Call the paymentFee Method in your implementations
        double Interest(double amount, int months); // Call the Interest Method in yout implementations
    }
}
