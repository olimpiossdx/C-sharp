using System;
using System.Collections.Generic;
using classesAbstratas.Entities;
/*
  Classes abstratas
  . São classes que não podem ser instanciadas

  . É uma forma de garantir herança total: somente subclasses não abstratas podem ser instanciadas,
    mas nunca a superclasse abstrata
*/
namespace classesAbstratas {
  class Program {
    static void Main (string[] args) {
      //Account acc1 = new Account (1001, "Jujé", 500.00); // erro: calsse abstrata não pode ser iniciada
      double sum = 0.0;
      List<Account> list = new List<Account> ();

      list.Add (new SavingAccount (101, "jujé", 500.0, 0.01));
      list.Add (new BusinessAccount (102, "jujérley", 500.0, 400.0));
      list.Add (new SavingAccount (103, "jujérlia", 500.0, 0.01));
      list.Add (new BusinessAccount (102, "jujérlaia", 500.0, 500.0));

      foreach (Account acc in list)
        sum += acc.Balance;

      Console.WriteLine ($"Total Balance: {sum.ToString("f2")}");

      foreach (Account acc in list)
        acc.Withdraw (10.0);

      foreach (Account acc in list)
        Console.WriteLine ($"Update balance for account {acc.Number}: {acc.Balance.ToString("f2")}");
    }
  }
}