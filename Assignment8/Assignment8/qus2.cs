using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class tennis
    {
        public string name;
        public string country;

        public tennis(string name, string country)
        {
            this.name = name;
            this.country = country;
        }
    }
    internal class qus2
    {
        static void Main()
        {
            List<tennis> list = new List<tennis>()
            {
                new tennis("player1","UK"),
                new tennis("player2","USA"), 
                new tennis("player3","china"),

            };
            List<tennis> list1 = new List<tennis>()
            {
                new tennis("player4","Korea"),
                new tennis("player5","Canada"),
                new tennis("player6","china"),

            };
            var result=from f in list
                       from f1 in list1
                       where f.country !=f1.country
                       select new { op = f.name, op1 = f1.name };
            foreach(var f in result)
            {
                Console.WriteLine($"{f.op}*{f.op1}");
            }

        }
    }
}
