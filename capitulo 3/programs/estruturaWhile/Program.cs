using System;

namespace estruturaWhile {
  class Program {
    static void Main (string[] args) {
      Console.Write ("Digite um número: ");
      double number = double.Parse (Console.ReadLine ());
      while (number >= 0) {
        Console.WriteLine ($"{Math.Sqrt(number):F3}");
        Console.Write ("Digite um número: ");
        number = double.Parse (Console.ReadLine ());
      }
      Console.WriteLine ("Número negativo!");
    }
  }
}