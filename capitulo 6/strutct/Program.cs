using System;

// Valores padrão atribuidos ao tipo estruturado utilizando new na struct
// números: 0 
// bool: false
// char: caractere  código 0
// objeto: null

namespace strutct {
  class Program {
    static void Main (string[] args) {
      Point p, p2;
      p.x = 10;
      p.y = 20;
      p2 = new Point ();

      Console.WriteLine ($"p: {p}");
      Console.WriteLine ($"p2: {p2}");
    }
  }
}