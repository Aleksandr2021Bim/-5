using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace многомерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            const int m = 5;
            int[,] array = new int[n,m];
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                   array[i, j] = (i + j) % 2;
                   Console.Write("{0,5 } ", array[i, j]);
                }
               Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
