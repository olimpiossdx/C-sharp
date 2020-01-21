using System;
using System.Globalization;
namespace exfixacao_1 {
  class Program {
    static void Main (string[] args) {
      string produto1 = "Computador";
      string produto2 = "Mesa de escritório";
      byte idade = 30;
      int codigo = 5290;
      char genero = 'M';

      double preco1 = 2100.0;
      double preco2 = 650.50;
      double media = 53.234567;

      System.Console.WriteLine ("Produtos");
      System.Console.WriteLine ($"{produto1}, cujo preco é $ {preco1}");
      System.Console.WriteLine ($"{produto2}, cujo preço é $ {preco2}");
      System.Console.WriteLine ($"\nRegistro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
      System.Console.WriteLine ($"Medida com oito casas deciamsi: {media.ToString("F8")}");
      System.Console.WriteLine($"Arredondado (três casa deciamis): {media.ToString("F3")}");
      System.Console.WriteLine($"Separador decimal invariant culture: {media.ToString("F3",CultureInfo.InvariantCulture)}");
    }
  }
}