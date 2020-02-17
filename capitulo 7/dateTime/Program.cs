using System;
using System.Globalization;

/*
  É um tipo valor (struct)
  Representação interna
  Instanciação: construtores, builders / conversão string -> DateTime
  Formatação: DateTime -> String
*/
namespace dateTime {
  class Program {
    static void Main (string[] args) {
      DateTime d1 = DateTime.Now;
      Console.WriteLine ($"data: ${d1}");
      Console.WriteLine ($"data.ticks: ${d1.Ticks}");

      // construtores
      DateTime d2 = new DateTime (2020, 02, 7);
      DateTime d3 = new DateTime (2020, 02, 7, 20, 45, 3);
      DateTime d4 = new DateTime (2020, 02, 7, 20, 45, 3, 500);

      DateTime d5 = DateTime.Now;
      DateTime d6 = DateTime.Today;
      DateTime d7 = DateTime.UtcNow;

      Console.WriteLine ($"data 2: {d2}");
      Console.WriteLine ($"data 3: {d3}");
      Console.WriteLine ($"data 4: {d4}");

      Console.WriteLine ($"data.now 5: {d5}");
      Console.WriteLine ($"data.today 6: {d4}");
      Console.WriteLine ($"data.utc 7: {d7}");

      // parse com dateTime
      DateTime d8 = DateTime.Parse ("2000-08-15");
      DateTime d9 = DateTime.Parse ("2000-08-15 13:05:58");
      DateTime d10 = DateTime.Parse ("15/08/2000");
      DateTime d11 = DateTime.Parse ("15/08/2000 13:05:58");

      Console.WriteLine ($"data.Parse 8: {d8}");
      Console.WriteLine ($"data.Parse 9: {d9}");
      Console.WriteLine ($"data.Parse 10: {d10}");
      Console.WriteLine ($"data.Parse 11: {d11}");

      // ParaseExact
      DateTime d12 = DateTime.ParseExact ("2000-08-15", "yyy-MM-dd", CultureInfo.InvariantCulture);
      DateTime d13 = DateTime.ParseExact ("15/08/2000", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
      Console.WriteLine ($"data.ParseExact 12: {d12}");
      Console.WriteLine ($"data.ParseExact 13: {d13}");
    }
  }
}