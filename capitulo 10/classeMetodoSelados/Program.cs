using System;
using classeMetodoSelados.Entities;
/*
  . Palavra chave: sealed

  . Classe: evita a classe seja herdade
    * Nota: ainda é possível extender a funcionadade de uma classe selada usando "extension methods"
      ....
        namespace classeMetodoSelados{
            sealed class SavingsAccount{
      ....

  . Método: evita que um método sobreposto possa ser sobreposto novamente.
    * Só pode ser aplicado a métodos sobrepostos
*/
namespace classeMetodoSelados {
  class Program {
    static void Main (string[] args) {
      Account acc1 = new Account (1001, "Jujé", 500.00);
      Account acc2 = new SavingAccount (1000, "Jujéia", 500.00, 0.01);

      acc1.Withdraw (10.0);
      acc2.Withdraw (10.0);

      Console.WriteLine (acc1.Balance);
      Console.WriteLine (acc2.Balance);

    }
  }
}