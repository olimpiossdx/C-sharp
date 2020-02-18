using System;
/*
 Tipo enumerado especial que define três valores possíveis para localidade da data:
 local
 UTC 
 Unspecifed
 
 Boa prática
   Armazenar em formato UTC
   Instanciar e msotar em formato local 
*/
namespace dataTimeKind {
  class Program {
    static void Main (string[] args) {
      DateTime d1 = new DateTime (2000, 8, 15, 13, 5, 58, DateTimeKind.Local);
      DateTime d2 = new DateTime (2000, 8, 15, 13, 5, 58, DateTimeKind.Utc);
      DateTime d3 = new DateTime (2000, 8, 15, 13, 5, 58);

      Console.WriteLine ($"data 1:{d1}");
      Console.WriteLine ($"data 2:{d2}");
      Console.WriteLine ($"data 3:{d3}\n");

      Console.WriteLine ($"data 1:{d1}");
      Console.WriteLine ($"data.Kind 1:{d1.Kind}");
      Console.WriteLine ($"data.ToLocalTime 1:{d1.ToLocalTime()}");
      Console.WriteLine ($"data.ToUniversalTime 1:{d1.ToUniversalTime()}\n");

      Console.WriteLine ($"data 2:{d2}");
      Console.WriteLine ($"data.Kind 2:{d2.Kind}");
      Console.WriteLine ($"data.ToLocalTime 2:{d2.ToLocalTime()}");
      Console.WriteLine ($"data.ToUniversalTime 2:{d2.ToUniversalTime()}\n");

      Console.WriteLine ($"data 3:{d3}");
      Console.WriteLine ($"data.Kind 3:{d3.Kind}");
      Console.WriteLine ($"data.ToLocalTime 3:{d3.ToLocalTime()}");
      Console.WriteLine ($"data.ToUniversalTime 3:{d3.ToUniversalTime()}\n");

      //Padrão ISO 8601
      DateTime d4 = DateTime.Parse ("2000-08-15 13:05:58");
      DateTime d5 = DateTime.Parse ("2000-08-15T13:05:58z"); //ISO 8601

      Console.WriteLine ($"data 4: ${d4}");
      Console.WriteLine ($"data 5(ISO): {d5}\n");

      Console.WriteLine ($"data 4:{d4}");
      Console.WriteLine ($"data.Kind 4:{d4.Kind}");
      Console.WriteLine ($"data.ToLocalTime 4:{d4.ToLocalTime()}");
      Console.WriteLine ($"data.ToUniversalTime 4:{d4.ToUniversalTime()}\n");

      Console.WriteLine ($"data 5:{d5}");
      Console.WriteLine ($"data.Kind 5:{d5.Kind}");
      Console.WriteLine ($"data.ToLocalTime 5:{d5.ToLocalTime()}");
      Console.WriteLine ($"data.ToUniversalTime 5:{d5.ToUniversalTime()}\n");

      Console.WriteLine ($"data.ToLocalTime 5:{d5.ToString("yyy-MM-ddTHH:mm:ssZ")}"); // cuidado(errado)
      Console.WriteLine ($"data.ToUniversalTime 5:{d5.ToUniversalTime().ToString("yyy-MM-ddTHH:mm:ssZ")}\n"); // jeito certo!

    }
  }
}