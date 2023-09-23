using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb1, numb2, numb3, result;
            Console.WriteLine("Введите первое число");
            numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            numb3 = Convert.ToInt32(Console.ReadLine());
            if (numb1 > numb2)
            {
                result = numb1;
                if (result < numb3)
                {
                    result = numb3;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
            else if (numb1 < numb2)
            {
                result = numb2;
                if (result <numb3)
                {
                    result = numb3;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(result);
                }

            }

        }
    }
}
