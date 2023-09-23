using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one, two, tree;
            bool truth;
            Console.WriteLine("Введите первое число");
            one = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            two=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            tree = Convert.ToInt32(Console.ReadLine());

            if (one+two > tree)
            {
                if (two + tree > one)
                {
                    if (one + tree > two)
                    {
                        truth = true;
                        Console.WriteLine(truth);
                    }
                    else
                    {
                        truth = false;
                        Console.WriteLine(truth);
                    }
                }
                else
                {
                    truth = false;
                    Console.WriteLine(truth);
                }
            }
            else
            {
                truth = false;
                Console.WriteLine(truth);
            }
        }
    }
}
