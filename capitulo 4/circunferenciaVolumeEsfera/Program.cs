using System;

namespace circunferenciaVolumeEsfera {
  class Program {
    static double raio;
    static double pi = 3.14;
    static void Main (string[] args) {
      Console.Write ("Entre com valor do raio: ");
      raio = double.Parse (Console.ReadLine ());
      Console.WriteLine ($"Circunferência: {Circunferencia(raio):F2}");
      Console.WriteLine ($"Volume: {Volume(raio):F2}");
      Console.WriteLine ($"Valor de Pi: {Math.PI:F2}");
    }
    static double Circunferencia (double r) {
      return 2 * pi * r;
    }
    static double Volume (double r) {
      return ((4.0 / 3.0) * pi * r * r * r);
    }
  }
}