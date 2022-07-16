using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
               
            }
            int min = array[0];
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine("Максимальное значение {0}", max);
            Console.WriteLine("Минимальное значение {0}", min);
            Console.WriteLine("Сумма максимального и минимального значения равна {0}", min+max);
            Console.ReadKey();
        }
    }
}
