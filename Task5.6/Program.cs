using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность");
            int d1 = 0;
            int d2 = 0;
            int sto = 0;
            int str = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Элемент ({0}, {1}) ", +i, +j);

                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    //Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i < n; i++)
                {
                    d1 += array[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(d1);
            for (int i = 0; i > n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    if (i + j == n - 1)
                    {
                        d2 += array[i, j];//не правильно считает
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine(d2);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    str += array[i, j];


                }
                Console.WriteLine(str);
                str = 0;
            }
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    sto += array[j, i];

                }

                Console.WriteLine(sto);
                sto = 0;
            }
            Console.WriteLine();

            if (d1 == d2 == (str == sto))
            {
                Console.WriteLine("Матрица магическая");
            }
            else
                Console.WriteLine("Матрица не магическая");


            Console.ReadKey();
        }
    }
}
