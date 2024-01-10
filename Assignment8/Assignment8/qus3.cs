using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Order
    {
        public int order_id;
        public string item_name;
        public DateTime order_date;
        public int quantity;

        public Order(int order_id, string item_name, DateTime order_date, int quantity)
        {
            this.order_id = order_id;
            this.item_name = item_name;
            this.order_date = order_date;
            this.quantity = quantity;
        }
    }
    internal class qus3
    {
        static void Main()
        {
            List<Order> list = new List<Order>()
            {
                new Order(1,"chair",new DateTime(2024,1,1),4),
                new Order(2,"table",new DateTime(2024,1,2),5),
                new Order(1,"pen",new DateTime(2024,1,6),1),
                new Order(1,"pencil",new DateTime(2024,1,1),8),
                new Order(1,"mouse",new DateTime(2024,1,12),6),
                new Order(1,"chair",new DateTime(2024,1,12),12),
            };
            Console.WriteLine("2)");
            Console.WriteLine("in terms of date:");
            var result= from l in list
                        orderby l.order_date descending
                        select l;
            foreach(var i in result)
            {
                Console.WriteLine($"Order Id:{i.order_id} Item Name:{i.item_name} Order date:{i.order_date} Quatity:{i.quantity}");
            }
            Console.WriteLine("in terms of quantity:");
            var result1 = from l in list
                         orderby l.quantity descending
                         select l;
            foreach (var i in result1)
            {
                Console.WriteLine($"Order Id:{i.order_id} Item Name:{i.item_name} Order date:{i.order_date} Quatity:{i.quantity}");
            }



        }
    }
}
