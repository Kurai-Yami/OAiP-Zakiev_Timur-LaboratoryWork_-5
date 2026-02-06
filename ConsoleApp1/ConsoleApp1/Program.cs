using ConsoleApp1;
using System;

class TestProgram
{
    static void Main()
    {
        MoneyTask task = new MoneyTask();
        task.Read();
        task.Display();
        int total = task.summa();
        Console.WriteLine($"Сумма: {total} рублей");
        Console.WriteLine("\nГотово! Нажмите Enter...");
        Console.ReadLine();
    }
}