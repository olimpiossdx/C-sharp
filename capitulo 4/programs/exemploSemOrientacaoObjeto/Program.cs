using System;

namespace exemploSemOrientacaoObjeto {
  class Program {
    static void Main (string[] args) {
      double Xa, Xb, Xc, Xp;
      double Ye, Yf, Yg, Yp;
      double areaX, areaY;

      Console.WriteLine ("Entre com as medidas do triângulo X:");
      Xa = double.Parse (Console.ReadLine ());
      Xb = double.Parse (Console.ReadLine ());
      Xc = double.Parse (Console.ReadLine ());
      Xp = (Xa + Xb + Xc) / 2;

      Console.WriteLine ("Entre com as medidas do triângulo Y:");
      Ye = double.Parse (Console.ReadLine ());
      Yf = double.Parse (Console.ReadLine ());
      Yg = double.Parse (Console.ReadLine ());
      Yp = (Ye + Yf + Yg) / 2;

      areaX = Math.Sqrt (Xp * (Xp - Xa) * (Xp - Xb) * (Xp - Xc));
      areaY = Math.Sqrt (Yp * (Yp - Ye) * (Yp - Yf) * (Yp - Yg));

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