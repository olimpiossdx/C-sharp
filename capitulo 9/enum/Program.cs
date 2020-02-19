using System;

/*
   Tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
   Nota: enum é um tipo valor
   vantagem: melhro semântoica, código mais legível e auxiluado pelo compilador  
*/
namespace Enumerado {
  class Program {
    static void Main (string[] args) {
      Order order = new Order {
        Id = 1080,
        Moment = DateTime.Now,
        Status = OrderStatus.PendingPayment
      };

      string txt = OrderStatus.PendingPayment.ToString ();
      OrderStatus os = Enum.Parse<OrderStatus> ("Delivered");

      Console.WriteLine (txt);
      Console.WriteLine (order);
      Console.WriteLine (os);

    }
  }
}