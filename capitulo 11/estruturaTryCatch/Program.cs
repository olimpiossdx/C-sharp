using System;

/*
  Bloco try: contém o código que representa a execução normal do trecho de código que pode acarretar em uma execução
  Bloco catch: contém o código a ser executado caso uam exceção ocorra. Deve ser especificado o tipo da exceção a ser tratada (upcasting é permitido)
*/
namespace estruturaTryCatch {
  class Program {
    static void Main (string[] args) {
      int n1, n2, result;
      try {
        n1 = int.Parse (Console.ReadLine ());
        n2 = int.Parse (Console.ReadLine ());
        result = n1 / n2;
        Console.WriteLine (result);
      } catch (DivideByZeroException) {
        Console.WriteLine ("Division by zero is not allowed");
        //Console.WriteLine ("Error: " + e.Message);
      } catch (FormatException e) {
        //Console.WriteLine ("Division by zero is not allowed");
        Console.WriteLine ("Format error: " + e.Message);
      }

    }
  }
}