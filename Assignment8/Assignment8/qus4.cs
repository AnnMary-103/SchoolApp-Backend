using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
   
    internal class qus4
    {
        static void Main()
        {
            List<Order> list = new List<Order>()
            {
                new Order(1,"chair",new DateTime(2024,1,1),4),
                new Order(2,"table",new DateTime(2024,6,2),5),
                new Order(1,"pen",new DateTime(2024,5,6),1),
                new Order(1,"pencil",new DateTime(2024,3,1),8),
                new Order(1,"mouse",new DateTime(2024,8,12),6),
                new Order(1,"chair",new DateTime(2024,2,12),12),
            };
            Console.WriteLine("4)");
            Console.WriteLine("in terms of date:");
            var result = from l in list
                         orderby l.order_date descending
                         group l by l.order_date.Month;

            foreach (var i in result)
            {
                Console.WriteLine("order month " + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine(j.item_name);
                }
            }
        }
    }
}
