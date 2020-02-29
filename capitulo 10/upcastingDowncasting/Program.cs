using System;
using upcastingDowncasting.Entities;
/*
  ---Upcasting--- (ex: BusinessAccount -> Account)
    Casting da subclasse para superclasse 
    Uso comum: polimorfismo

  ---Downcasting--- (ex: Account -> BusinessAccount)
    Casting da superclase para subclasse
    Palavra as
    Palavra is
    Uso comun: métodos que recebem parâmetros genércos (ex: Equals)
*/
namespace upcastingDowncasting {
  class Program {
    static void Main (string[] args) {
      Account acc = new Account (1001, "bob champs2", 0.0);
      BusinessAccount bacc = new BusinessAccount (1002, "Maria", 0.0, 500.0);

      // Upcasting (é um)
      Account c1 = bacc;
      Account acc1 = acc;
      Account acc2 = new BusinessAccount (1003, "Ranger red", 0.0, 200.0);
      Account acc3 = new SavingAccount (1003, "Ranger red", 0.0, 0.01);

      // Downcasting
      BusinessAccount acc4 = (BusinessAccount) acc2;
      acc4.Loan (100.00);

      // problema em tempo de execução
      //BusinessAccount acc5 = (BusinessAccount) acc3;
      if (acc3 is BusinessAccount) {
        //BusinessAccount acc5 = (BusinessAccount) acc3; or
        BusinessAccount acc5 = acc3 as BusinessAccount;
        acc5.Loan (200.00);
        Console.WriteLine ("Loan!");
      }

      if (acc3 is SavingAccount) {
        // SavingAccount acc5 = (SavingAccount) acc3;
        SavingAccount acc5 = acc3 as SavingAccount;
        acc5.UpdateBalance ();
        Console.WriteLine ("Update");
      }
    }
  }
}