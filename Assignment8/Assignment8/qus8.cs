using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class qus8
    {
        static void Main()
        {
            List<Order> l = new List<Order>()
            {
                new Order(1,"chair",new DateTime(2024,1,1),4),
                new Order(2,"table",new DateTime(2024,6,2),5),
                new Order(1,"pen",new DateTime(2023,5,6),1),
                new Order(1,"pencil",new DateTime(2024,3,1),8),
                new Order(1,"mouse",new DateTime(2023,8,12),6),
            };
            Console.WriteLine();
            Order o = l.OrderByDescending(l => l.quantity).FirstOrDefault();
            Console.WriteLine("name of the item ordered in largest quantity is :" + o.item_name);
            Console.WriteLine();

            //Find if there are any orders placed before Jan of this year.
            int o1 = l.Where(l => l.order_date.Year < 2023).Count();
            if (o1 == 0)
                Console.WriteLine("no order placed before 2024");
            else
                Console.WriteLine("orders are placed before 2024");
            
        }
    }
}
