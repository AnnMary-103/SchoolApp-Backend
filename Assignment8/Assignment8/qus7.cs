using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class qus7
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
            int result = (from f in l
                         where f.quantity > 0
                         select f).Count();
            if(result!=0)
            {
                Console.WriteLine("No quantities in the Order collection is >0.");
            }
            else
            { Console.WriteLine("quantities in the Order collection is > 0"); }


            //Get the name of the item that was ordered in largest quantity in a single order. 
            Console.WriteLine();
            var result1= from f in l
                         orderby f.quantity descending
                         select f;
            var output= result1.FirstOrDefault();
            Console.WriteLine("name of the item ordered in largest quantity is :"+output.item_name);
            Console.WriteLine();

            //Find if there are any orders placed before Jan of this year.

            var result2= from f in l
                         where f.order_date.Year < 2024
                         select f;
            if( result2!=null )
            {
                
                Console.WriteLine("Orders are placed");
            }
            else { Console.WriteLine("no orders are placed"); }

        }
    }
}
