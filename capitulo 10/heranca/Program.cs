using System;
using heranca.Entities;
/*
  Herança é um tipo de associação que permite que uma lcasse herde dados e comportamentos de outra.
  Definições importantes
  *Vantagens
    * Reuso
    * Polimorfismo
  *Sintaxe  
    * : (estende)
    * base (referência para a superclasse)

*/
namespace heranca {
  class Program {
    static void Main (string[] args) {
      BusinessAccount account = new BusinessAccount (8010, "Bob champs", 100.00, 500.0);
      //account.Balance = 200.00 não é possível pelo modificador de acesso!
      Console.WriteLine (account);
    }
  }
}