using System;
using System.Collections.Generic;
using System.Linq;

class Program
{

    static void Main()
    {
        Login();
    }

    static void Login()
    {
        List<Account> accounts = new List<Account>
    {
        new Account { Name = "Jose", Password = "1234", Balance = 1000},
        new Account { Name = "Keito", Password = "gerber", Balance = 10},
        new Account { Name = "Gabriel", Password = "swispace", Balance = 2000}
    };
        Console.WriteLine("Bienvenue dans la Maze Bank!");
        Console.WriteLine("Veuillez vous vous identifier");
        string attemptPassword = Console.ReadLine();

        Account account = accounts.FirstOrDefault(acc => acc.Password == attemptPassword);

        if (account == null)
        {
            Console.WriteLine("Compte pas trouvé. Système de securité activé!");
        } else {
            Menu(account);
        }

        static void Menu(Account account){
            Console.WriteLine($"Bienvenue {account.Name}");
        }








    }
}

public class Account
{

    public string Name { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }

}