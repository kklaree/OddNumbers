using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers divisible by 5:");

            for (int i = 5; i < 300; i += 10)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
        }
    }
}
