using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[19];
            Random random = new Random();
            int s = 0;
            for (int i = 0; i < 19; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
                if (array[i] % 2 != 0 && array[i]>0 && i % 2==0)
                {
                    s++;  
                }
            }

            Console.WriteLine("Количество нечетных, положительных элементов, стоящих на четных местах = {0}",s);
            Console.ReadKey();
        }//нет уверенности что работает правильно))
    }
}
