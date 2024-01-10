namespace Assignment8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr= { 899, 205, 86,776,9,1,879 };
            
            //Find  the cube of the numbers that are greater than 100 but less than 1000 using LINQ.
            var result= from i in arr
                        where i>100 && i<1000
                        select i*i*i;
            Console.WriteLine("1)");
            foreach(int i in result)
            {
                
                Console.WriteLine(i);
            }


            
            
        }
    }
}
