using Aula_124_Enumeração.Entities;
using Aula_124_Enumeração.Entities.Enums;

namespace Aula_124_Enumeração
{
    internal class Program
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

             string txt = OrderStatus.PendingPayment.ToString();//transformando ENUMERADO para STRING

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");//transformando STRING para ENUMERADO
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}