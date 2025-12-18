using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digit_count
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("digit_count : : "+digitcount(n));
            Console.ReadKey();
        }
        static int digitcount(int number)
        {
            if (number < 10)
            {
                return 1;
            }
            else
            {
              return(1 + digitcount(number / 10));
            }
        }
    }
}
