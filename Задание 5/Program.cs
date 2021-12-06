using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7];
            double S = 0;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("Введите значение");
                array[i] = Convert.ToInt32(Console.ReadLine());
                S += array[i];
             }
            double S1 = S / 7;
            Console.WriteLine();
            Console.WriteLine(S1);
            Console.ReadKey();

        }
    }
}
