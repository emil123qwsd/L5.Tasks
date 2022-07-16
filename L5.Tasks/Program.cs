using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L5.Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int s = 0;
            int k = 0;
            Console.WriteLine("Введите {0} чисел", n);
            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

                    s += array[i];
                    k++;
                
            }
            Console.WriteLine("Среднее значение: {0}",((double)s) / k);
            Console.ReadKey();
        }
    }
}
