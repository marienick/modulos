using ConsoleApp233.Entities;
using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010,"Bob Browm", 100.0, 500.0);
            Console.WriteLine(account.Balance);
            // Porém não é possível mudar o valor dobalance aqui, somente na classe ou na subclasse.
        }
    }
}