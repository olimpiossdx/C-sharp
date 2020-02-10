using System;

namespace calculadoramp {
  /*calculadora utilizando vetor*/
  class Program {
    static void Main (string[] args) {
      int s1 = Calculadora.Sum (2, 3);
      int s2 = Calculadora.Sum (2, 3, 8);
      int s3 = Calculadora.Sum (2, 3, 8, 9);
      int result = CalculadoraVect.Sum (new int[] { 10, 20, 30, 40 });

      // utilizando parâmetros variáveis
      int result2 = CalculadoraMParams.Sum (10, 20, 30, 40);

    }
  }
}