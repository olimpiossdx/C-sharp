using System;

namespace nullable {
  class Program {
    static void Main (string[] args) {
      double? x = null;
      double? y = 10.0;

      Console.WriteLine ($"x.GetValueOrDefault(): {x.GetValueOrDefault()}");
      Console.WriteLine ($"y.GetValueOrDefault(): {y.GetValueOrDefault()}");

      Console.WriteLine ($"\nx.HasValue(): {x.HasValue}");
      Console.WriteLine ($"y.HasValue(): {y.HasValue}");

      if (x.HasValue)
        Console.WriteLine ($"\nx.Value(): {x.Value}");
      else
        Console.WriteLine ("X is null");

      if (y.HasValue)
        Console.WriteLine ($"\ny.Value(): {x.Value}");
      else
        Console.WriteLine ("y is null");

      //utilizando com operador de Coalesência nulla
      double x2 = null, y2 = 200.0, a, b;

      a = x ?? 10.0;
      b = y2 ?? 10.0;
      Console.WriteLine ($"operador de coalesência = a{a}");
      Console.WriteLine ($"operador de coalesência = b{b}");
    }
  }
}