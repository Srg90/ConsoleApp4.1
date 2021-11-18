using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Введите целое положительное число");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int sqr = 0;
            for (int i = 1; i <= (2 * n - 1); i += 2)
            {
                sqr += i;
                Console.WriteLine("Квадрат равен {0}", sqr);
            }

            Console.WriteLine();
            Console.WriteLine("Квадрат числа {0} равен {1}", n, sqr);
            Console.ReadKey();

        }
    }
}