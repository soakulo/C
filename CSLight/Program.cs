using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int result;
            Console.WriteLine("Ведите число:");
            numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ведите второе число:");
            numberTwo = Convert.ToInt32(Console.ReadLine());
            result = numberOne + numberTwo;
            Console.WriteLine($"Результат: {result}");
        }
    }
}
