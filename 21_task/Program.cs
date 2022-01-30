using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _21_task
{
    class Program
    {
        static int length;
        static int width;
        static int[,] garden;

        public static void gardener_1()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (garden[i, j] == 0)
                    {
                        garden[i, j] = 1;
                        Thread.Sleep(1);
                    }
                }
            }
        }

        public static void gardener_2()
        {
            for (int i = length - 1; i >= 0; i--)
            {
                for (int j = width - 1; j >= 0; j--)
                {
                    if (garden[j, i] == 0 )
                    {
                        garden[j, i] = 2;
                        Thread.Sleep(1);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите длину участка: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите ширину участка: ");
            width = Convert.ToInt32(Console.ReadLine());

            garden = new int[width, length];

            ThreadStart thread_start = new ThreadStart(gardener_1);
            Thread my_thread = new Thread(thread_start);
            my_thread.Start();
            gardener_2();           

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    Console.Write(garden[i, j] + " ");
                }
                Console.WriteLine();
            }
           
            Console.ReadKey();
        }
    }
}
