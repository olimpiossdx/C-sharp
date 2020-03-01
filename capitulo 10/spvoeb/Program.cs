using System;
using spvoeb.Entities;
/*
  Sobreposição ou sobrescrita
  . É a implementação de um métodod de uma superclasse na subclasse.
  . Para que um método comum (não abstrato) possa ser sobreposto, deve
    ser incluído nele o prefixo "virtual"
  . Ao sobrescrever um método, devemos incluir o prefixo "override"

  Palavra base
  . É possível chamar a implementaçção da superclasse usando a palavra base.

  Exemplo: suponha que a regra para saque para conta poupança seja realizar o saque
  normalmente da superclasse (Account), e depois descontar mais 2.0.

  pulbic override void Withdraw (double amount){
    base.Withdraw(amount);
    Balance -=2.0;
  }
*/

namespace spvoeb {
  class Program {
    static void Main (string[] args) {
      // Console.WriteLine ("Hello World!");
      Account acc1 = new Account (1001, "Jujé", 500.00);
      Account acc2 = new SavingAccount (1000, "Jujéia", 500.00, 0.01);

      acc1.Withdraw (10.0);
      acc2.Withdraw (10.0);

      Console.WriteLine (acc1.Balance);
      Console.WriteLine (acc2.Balance);

    }
  }
}