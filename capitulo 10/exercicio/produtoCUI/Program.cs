using System;
using System.Collections.Generic;
using produtoCUI.Entities;
/*
  Fazer um progrma para ler os dados de N produtos (N fornecido pelo usuário). Ao final,
  mostrar a etiqueta de preço de cada produto na mesma ordem em que foram digitados.

  Todo produto possui nome e preço. Produtos importados possuem uma taxa alfândega, e
  produtos usados possuem data de fabricação. Estes dados específicos devem ser
  acrescentados na etiqueta de preço conforme exemplo (próxima página). Para produtos
  importados, a taxa de alfândega deve ser acrescentada ao preço final do produto.
  
  Favor implementar o programa conforme projeto ao lado (herança e polimorfismo).
  Exe:
    Enter the number of products: 3
    Product 1 data:
    Common, used or imported (c/u/i)? i
    Name: Tablet
    Price: 260,0
    Customs fee: 20,0
    Product 2 data:
    Common, used or imported (c/u/i)? c
    Name: Notebook
    Price: 1100,0
    Product 3 data:
    Common, used or imported (c/u/i)? u
    Name: Iphone
    Price: 400,0
    Manufacture date (DD/MM/YYY): 15/03/2017

    PRICE TAGS:
    Tablet $ 280,00 (Customs fee: $20)
    Notebook $ 1100,00
    Iphone $ 400,00 (Manufacture date: 01/01/2017)
*/
namespace produtoCUI {
  class Program {
    static void Main (string[] args) {
      int numberProducts;
      string name, opcao;
      double price, customsFee;
      DateTime manufactureDate;
      List<Product> products = new List<Product> ();
           
      Console.Write ("Enter the number of products: ");
      numberProducts = int.Parse (Console.ReadLine ());

      for (int i = 0; i < numberProducts; i++) {
        Console.WriteLine ($"Product #{i+1} data:");

        Console.Write ("Common, used or imported (c/u/i)? ");
        opcao = Console.ReadLine ();

        Console.Write ("Name: ");
        name = Console.ReadLine ();

        Console.Write ("Price: ");
        price = double.Parse (Console.ReadLine ());

        if (opcao == "i") {
          Console.Write ("Customs fee: ");
          customsFee = double.Parse (Console.ReadLine ());
          products.Add (new ImportedProduct (name, price, customsFee));
        } else if (opcao == "c") {
          products.Add (new Product (name, price));
        } else {
          Console.Write ("Manufacture date (DD/MM/YYY): ");
          manufactureDate = DateTime.Parse (Console.ReadLine ());
          products.Add (new UsedProduct (name, price, manufactureDate));
        }
      }

      Console.WriteLine ("\nPRICE TAGS:");
      foreach (Product product in products)
        Console.WriteLine (product.PriceTag ());
    }
  }
}