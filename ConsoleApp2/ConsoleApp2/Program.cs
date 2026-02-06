using ConsoleApp2;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("=== ЗАДАНИЕ 2.12: БАНКОВСКИЙ СЧЕТ ===\n");

        Account myAccount = new Account
        {
            owner = "Иванов Иван Иванович",
            number = "1234567890",
            percent = 5.5,
            balance = 10000.50
        };

        Console.WriteLine("ТЕКУЩИЙ СЧЕТ:");
        Console.WriteLine($"Владелец: {myAccount.owner}");
        Console.WriteLine($"Номер: {myAccount.number}");
        Console.WriteLine($"Процент: {myAccount.percent}%");
        Console.WriteLine($"Баланс: {myAccount.balance:F2} руб.");

        Console.WriteLine("\nВЫПОЛНЯЕМ ОПЕРАЦИИ");

        myAccount.Deposit(5000);
        myAccount.Withdraw(2000);
        myAccount.ChangeOwner("Петров Петр Петрович");
        myAccount.AddPercent();

        Console.WriteLine("\nКОНВЕРТАЦИЯ В ВАЛЮТУ");
        myAccount.ToDollars(80);
        myAccount.ToEuros(90);

        Console.WriteLine("\nИТОГОВОЕ СОСТОЯНИЕ");
        Console.WriteLine($"Баланс: {myAccount.balance:F2} руб.");
        myAccount.ShowInWords();

        Console.WriteLine("\nНажмите Enter для выхода...");
        Console.ReadLine();
    }
}