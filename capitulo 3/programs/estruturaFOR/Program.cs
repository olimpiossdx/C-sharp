using System;

namespace estruturaFOR {
  class Program {
    static void Main (string[] args) {
      Console.Write ("Quantos números inteiros você vai digitar: ");
      int n = int.Parse (Console.ReadLine ());
      int soma = 0;
      for (int i = 0; i < n; i++) {
        Console.Write ($"Valor #{i+1}: ");
        soma += int.Parse (Console.ReadLine ());
      }
      Console.WriteLine ($"Soma = {soma}");
    }
  }
}