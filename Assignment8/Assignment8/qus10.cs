using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment8
{
    class item
    {
        public string name;
        public int quantity;

        public item(string name, int quantity)
        {
            this.name = name;
            this.quantity = quantity;
        }
    }
    internal class qus10
    {
        static void Main()
        {
            List<Order> l = new List<Order>()
            {
                new Order(1,"chair",new DateTime(2024,1,1),4),
                new Order(2,"table",new DateTime(2024,6,2),5),
                new Order(3,"chair",new DateTime(2023,5,6),1),
                new Order(4,"table",new DateTime(2024,3,1),8),
              
            };
          
            var result=(from f in l
                       group f by f.item_name into od
                       let op=od.Sum(f=>f.quantity)
                       orderby op descending
                       select new { op1 = op, name=od.Key }).FirstOrDefault();

           
            
                Console.WriteLine("The item that has overall maximum orders: " + result.name + "qty :" +result.op1);

            
            
            
            

        }
    }
}
