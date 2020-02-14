using System;

namespace inferencia {
  class Program {
    static void Main (string[] args) {

      // utiliza-se var para realizar inferência de tipo
      var x = 10;
      var y = 20.0;
      var z = "Maria";

      //    int w = z;

      Console.WriteLine (x);
      Console.WriteLine (y);
      Console.WriteLine (z);

    }
  }
}