using ProcessamentoContratoFixacao.Entities;

namespace ProcessamentoContratoFixacao.Services
{
    class ContractService
    {

        private IOnlinePaymentService _onlinePaymentService; // calling the interface

        //Constructor to define what Interface Implementation will be 
        public ContractService(IOnlinePaymentService onlinePaymentService) 
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double BasicQuota = contract.TotalValue / months; //Basic amount for month

            // Fees aplication
            for (int i = 1; i <= months; i++) 
            {
                DateTime date = contract.Date.AddMonths(i);
                double updateQuota = BasicQuota + _onlinePaymentService.Interest(BasicQuota, i);
                double TotalQuota = updateQuota + _onlinePaymentService.PaymentFee(updateQuota);
                contract.AddInstallment(new Installment(date, TotalQuota));
            }
        }
    }
}
