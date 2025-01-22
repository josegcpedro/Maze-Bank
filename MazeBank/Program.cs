﻿using System;
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
        }
        else
        {
            Menu(account);
        }
    }
    static void Menu(Account account)
    {
        Console.WriteLine($"Bienvenue {account.Name} que voulez vous faire?");
        Console.WriteLine("1.Retirer de l'argent");
        Console.WriteLine("2.Ajouter de l'argent");
        Console.WriteLine("3.Voir solde bancaire");
        Console.WriteLine("4.Envoyer de l'argent");
        Console.WriteLine("5.Quitter");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                //Withdraw(account);
                break;
            case "2":
                AddMoneyToAccount(account);
                break;
            case "3":
                VerifyMoneyAccount(account);
                break;
            case "4":
                //SendMoney();
                break;
            case "5":
                return;
        }
    }


    static void AddMoneyToAccount(Account account){
        Console.WriteLine("Combien d'argent voulez vous ajouter?");
        string input = Console.ReadLine();
        if (decimal.TryParse(input, out decimal wantedMoneyToAdd)){
            account.Balance += wantedMoneyToAdd;
            Console.WriteLine($"Votre nouveau solde est de {account.Balance}");
        }
    }
    static void VerifyMoneyAccount(Account account)
    {
        Console.WriteLine($"Voici votre solde: {account.Balance}");
    }

}

public class Account
{

    public string Name { get; set; }
    public string Password { get; set; }
    public decimal Balance { get; set; }

}