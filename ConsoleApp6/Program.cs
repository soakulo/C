using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Введите число");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 7)
            {
                Console.WriteLine("Yes");
            }
            else if (number > 10)
            {
                Console.WriteLine("No");
            }
            else if (number ==9)
            {
                Console.WriteLine("Error");
            }
        }
    }
}
