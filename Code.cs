using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Enter the first integer:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second integer:");
            y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your integers were "+x+" and "+y);
            y = y + x;
            x = y - x;
            y = y - x;
            Console.WriteLine("After the switching your integers are "+x+" and "+y);
            Console.ReadKey();
        }
    }
}
