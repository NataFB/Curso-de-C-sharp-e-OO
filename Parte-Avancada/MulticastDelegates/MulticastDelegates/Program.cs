using MulticastDelegates.Services;
namespace Course
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;
            BinaryNumericOperation op = CalculationService.ShowSum;
            // Com o operador +=, é possível adicionar mais métodos ao delegate, formando uma cadeia de chamadas, ou seja, uma Multicast Delegate.
            op += CalculationService.ShowMax;
            op.Invoke(a, b);
        }
    }
}