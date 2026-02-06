using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class Account
    {
        public string owner;
        public string number;
        public double percent;
        public double balance;

        public void ChangeOwner(string newOwner)
        {
            owner = newOwner;
            Console.WriteLine($"Новый владелец: {owner}");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Снято: {amount} руб.");
            }
            else
            {
                Console.WriteLine("Ошибка: Недостаточно средств!");
            }
        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Внесено: {amount} руб.");
        }

        public void AddPercent()
        {
            double interest = balance * percent / 100;
            balance += interest;
            Console.WriteLine($"Начислено процентов: {interest:F2} руб.");
        }

        public void ToDollars(double rate = 75.0)
        {
            double dollars = balance / rate;
            Console.WriteLine($"{balance} руб. = {dollars:F2} $");
        }

        public void ToEuros(double rate = 85.0)
        {
            double euros = balance / rate;
            Console.WriteLine($"{balance} руб. = {euros:F2} Е");
        }

        public void ShowInWords()
        {
            int rubles = (int)balance;
            int kopecks = (int)((balance - rubles) * 100);
            Console.WriteLine($"{rubles} рублей {kopecks:00} копеек");
        }
    }
}
