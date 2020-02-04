using System;

namespace exemploComOrientacaoObjeto {
  class Program {
    static void Main (string[] args) {
      Triangulo x, y;
      double areaX, areaY;
      // double p, areaX, areaY;
      x = new Triangulo ();
      y = new Triangulo ();

      Console.WriteLine ("Entre com as medidas do triângulo X:");
      x.A = double.Parse (Console.ReadLine ());
      x.B = double.Parse (Console.ReadLine ());
      x.C = double.Parse (Console.ReadLine ());

      Console.WriteLine ("Entre com as medidas do triângulo Y:");
      y.A = double.Parse (Console.ReadLine ());
      y.B = double.Parse (Console.ReadLine ());
      y.C = double.Parse (Console.ReadLine ());

      // p = (x.A + x.B + x.C) / 2;
      //areaX = Math.Sqrt (p * (p - x.A) * (p - x.B) * (p - x.C));
      areaX = x.Area();

      // p = (y.A + y.B + y.C) / 2;
      // areaY = Math.Sqrt (p * (p - y.A) * (p - y.B) * (p - y.C));
      areaY = y.Area();

      Console.WriteLine ($"Area de X = {areaX:F4}");
      Console.WriteLine ($"Area de Y = {areaY:F4}");

      if (areaX < areaY) {
        Console.WriteLine ("Maior area: Y");
      } else {
        Console.WriteLine ("Maior area: X");
      }

    }
  }
}