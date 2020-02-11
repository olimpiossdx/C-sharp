using System;

namespace lacoForeach {
  class Program {
    static void Main (string[] args) {
      string[] vect = new string[] { "Maria", "Bob", "Alex" };
      // leitura: para cada string obj contido em vect faça:
      foreach (string obj in vect)
        Console.WriteLine (obj);

    }
  }
}