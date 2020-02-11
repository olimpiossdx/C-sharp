using System;

namespace lacoForeach {
  class Program {
    static void Main (string[] args) {
      string[] vect = new string[] { "Maria", "Bob", "Alex" };
      // leitura: para cada string obj contido em vect faça:
      foreach (string obj in vect)
        Console.WriteLine (obj);

      //começo de interação por i, iniciando pela posição 0 até o tamanho de   vect
      for (int i = 0; i < vect.Length; i++) {
        Console.WriteLine (vect[i]);
      }

    }
  }
}