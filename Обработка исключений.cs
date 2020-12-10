﻿using System;

namespace Д27_С4
{
    class Program
    {
        static void Main(string[] args)
        {
            int k2 = 0, k7 = 0, k = 0, n, x; //ввод переменных

            try
            {
                Console.WriteLine("Введите n");

                n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++) //цикл с вводом чисел с последующими вычислениями
                {
                    Console.WriteLine("Введите число");

                    x = int.Parse(Console.ReadLine());

                    if (x % 14 == 0)
                    {
                        k++;
                    }
                    else if (x % 7 == 0)
                    {
                        k7++;
                    }
                    else if (x % 2 == 0)
                    {
                        k2++;
                    }

                }

                double otvet = (n * (n - 1) / 2 - k * (n - k) - k * (k - 1) / 2 - k2 * k7);

                Console.WriteLine($"Количество пар, для которых произведение элементов не кратно 14 = {otvet}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введено нечисловое значение!");
            }

        } 
    }
}
