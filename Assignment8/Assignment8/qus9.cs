using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class qus9
    {
        static void Main()
        {


            int[] arr = { 2, 4, 6, 6, 8, 9, 1, 44, 87, 79 };

            var result = from f in arr
                         where f % 2 == 0
                         select f;
            Console.WriteLine("Count: "+result.Count());
            Console.WriteLine("numbers are");
            foreach( var f in result)
            {

                Console.WriteLine(f);
            }
    }
    }
}
