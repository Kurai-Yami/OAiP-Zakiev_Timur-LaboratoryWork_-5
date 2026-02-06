using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class MoneyTask
    {
        public int first;
        public int second;

        public void Read()
        {
            bool ok = false;

            while (!ok)
            {
                Console.Write("Введите номинал (1,2,5,10,50,100,500,1000,5000): ");
                first = int.Parse(Console.ReadLine());

                int[] valid = { 1, 2, 5, 10, 50, 100, 500, 1000, 5000 };

                foreach (int n in valid)
                {
                    if (first == n)
                    {
                        ok = true;
                        break;
                    }
                }
                if (!ok)
                    Console.WriteLine("Неверный номинал! Попробуйте снова.");
            }
            Console.Write("Введите количество купюр: ");
            second = int.Parse(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"Номинал: {first}");
            Console.WriteLine($"Количество: {second}");
        }
        public int summa()
        {
            return first * second;
        }
    }
}
