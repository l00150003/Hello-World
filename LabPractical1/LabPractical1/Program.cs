using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPractical1
{
    class Program
    {
        static void Main(string[] args)
        {
            string myNumber = "";
            Console.WriteLine($"Please enter number ");
            myNumber = Console.ReadLine();
            Console.WriteLine($"The number you entered was {myNumber}");
            Console.ReadKey();
        }
    }
}
