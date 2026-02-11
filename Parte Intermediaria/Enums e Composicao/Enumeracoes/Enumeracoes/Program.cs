using Enumeracoes.Entities;
using Enumeracoes.Entities.Enums;

namespace Enumeracoes
{
    class Program
    {
        static void Main(string[] args) 
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // Convertendo valor tipo enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// Recebe uma string e converte para enum

            Console.WriteLine(txt);
            Console.WriteLine(os);
        }
    }
}