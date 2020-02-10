using System;

namespace calculadoraMRef {
  class Program {
    static void Main (string[] args) {

      //sem utilizar ref
      int a = 10;
      CalculadoraSemRef.Triple (a);
      Console.WriteLine ($"a; {a}");

      //Utilizando ref: variável deve ser iniciada
      int b = 20;
      CalculadoraComMRef.Triple (ref b);
      Console.WriteLine ($"b: {b}");

      //Com out: variável não precisa ser iniciada
      int c = 30;
      int triple;
      CalculadoraMOut.Triple (c, out triple);
      Console.WriteLine ($"triple: {triple}");
    }
  }
}