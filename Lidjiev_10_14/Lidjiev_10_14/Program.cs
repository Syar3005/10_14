using System;

namespace lidjiev_10_14
{
    class Program
    {

        static int func(int[] array, int n)
        {
            int i, count = 0;
            for (i = 0; i < n; ++i)
            {
                int k = 1;
                do
                {
                    if (array[i] % 5 == 0 && array[i] != 0)
                    {
                        array[i] /= 5;
                        k = 1;
                    }
                    else
                    {
                        k = 0;
                        break;
                    }
                } while (array[i] != 1);
                if (k == 1)
                    count++;
            }
            return count;
        }
        static void Main(string[] args)
        {
            Random rnd = new Random();

            const int n = 100;
            int[] array = new int[n];

            Console.Write("Массив:");
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(1000);
                Console.Write(" " + array[i]);
            }

            Console.WriteLine("\nКол-во чисел, которые являются степенью пятерки " + func(array, n));

        }
    }
}
