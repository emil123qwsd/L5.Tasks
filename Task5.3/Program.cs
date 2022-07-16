using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            const int k = n/2;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < k - 1; i++)
            {
                for (int j = i + 1; j < k; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            for (int i = 5; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 5; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();

        }
    }
}
