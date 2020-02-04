using System;

namespace circunferenciaVolumeEsfera {
  class Program {
    static double raio;
    static void Main (string[] args) {
   
      Console.Write ("Entre com valor do raio: ");
      raio = double.Parse (Console.ReadLine ());
      Console.WriteLine ($"Circunferência: {Calculadora.Circunferencia(raio):F2}");
      Console.WriteLine ($"Volume: {Calculadora.Volume(raio):F2}");
      Console.WriteLine ($"Valor de Pi: {Calculadora.pi:F2}");
    }
    
  }
}