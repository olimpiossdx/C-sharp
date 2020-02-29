/*
  Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
  sumário do pedido conforme exemplo (próxima página). Nota:  o instante do pedido deve ser
  o instante do sistema: DateTime.Now
*/
using System;
using pedido.Entities;
using pedido.Entities.Enums;
namespace pedido {
  class Program {
    static void Main (string[] args) {
      Client c1;
      Order order;
      OrderStatus status;
      OrderItem orderItem;
      Product product;
      string name, email;
      double price;
      DateTime birthDate;
      int manyItems, quantity;

      Console.WriteLine ("Enter cliente data:");
      Console.Write ("Name: ");
      name = Console.ReadLine ();
      Console.Write ("Email: ");
      email = Console.ReadLine ();
      Console.Write ("Birth date (DD/MM/YYY): ");
      birthDate = DateTime.Parse (Console.ReadLine ());

      Console.Write ("Status: ");
      status = Enum.Parse<OrderStatus> (Console.ReadLine ());

      c1 = new Client (name, email, birthDate);
      order = new Order (status, c1);

      Console.Write ("How many items to this order? ");
      manyItems = int.Parse (Console.ReadLine ());

      for (int i = 0; i < manyItems; i++) {
        Console.WriteLine ($"Enter #{i+1} item data:");

        Console.Write ("Product name: ");
        name = Console.ReadLine ();
        Console.Write ("Product price: ");
        price = double.Parse (Console.ReadLine ());
        Console.Write ("Quantity: ");
        quantity = int.Parse (Console.ReadLine ());
        product = new Product (name, price);
        orderItem = new OrderItem (quantity, price, product);
        order.AddItem(orderItem);
      }

      Console.WriteLine ("\n" + order.ToString ());
    }
  }
}