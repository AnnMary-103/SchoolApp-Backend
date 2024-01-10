using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment8
{
  
    internal class qus6
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

            };
            List<Item> list1 = new List<Item>()
            {
                new Item("chair",234,4),
                new Item("table",867,5),
                new Item("pen",546,1),
                new Item("pencil",787,8),
                new Item("mouse",67,6)
            };
            var result = from l in list
                         join l1 in list1
                         on l.item_name equals l1.name
                         select new { id = l.order_id, name = l.item_name, date = l.order_date, total = l1.price * l.quantity };



            var res1 = from i in result
                       orderby i.date descending
                       group i by i.date.Month;

            foreach (var i in res1)
            {
                Console.WriteLine("order month " + i.Key);
                foreach (var j in i)
                {
                    Console.WriteLine($"order id:{j.id} Item name:{j.name} order date:{j.date} total price:{j.total}");
                }
            }

        }


    }
}

