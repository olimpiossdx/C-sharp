using System;
using introducaoPoliformismo.Entities;
/*

  Pilares da OOP (programação orientada a objetos)
  .Ecapsulamento
  .Herança
  .Poliformismo -> recurso que permite que variáveis de um mesmo tipo mais genérfico possam apontar para objetos
   de tipos específicos diferentes, tendo assim comportamentos diferentes conforme cada toipo específico.

   ex:
      //Associação de tipo específico com tipo genérico é feita em tempo de execução(upcasting)
      //O compilador não sabe para qual tipo específico a chamda do método Withdraw está sendo feita (ele só sabe que são duas variáveis do tipo Account)
      
      Account acc1 = new Account (1001, "Jujé", 500.00);
      Account acc2 = new SavingAccount (1000, "Jujéia", 500.00, 0.01);

      acc1.Withdraw (10.0);
      acc2.Withdraw (10.0);

      Console.WriteLine (acc1.Balance);
      Console.WriteLine (acc2.Balance);

*/
namespace introducaoPoliformismo {
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