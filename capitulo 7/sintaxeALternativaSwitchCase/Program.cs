using System;

namespace sintaxeALternativaSwitchCase {
  class Program {
    static void Main (string[] args) {
      Console.WriteLine ("Dia da semana");
      int x = int.Parse (Console.ReadLine ());
      string day;

      Console.WriteLine ($"Com If");
      if (x == 1) {
        day = "Sunday";
      } else if (x == 2) {
        day = "Monday";
      } else if (x == 3) {
        day = "Tuesday";
      } else if (x == 4) {
        day = "Wednesday";
      } else if (x == 5) {
        day = "Friday";
      } else if (x == 6) {
        day = "Saturday";
      } else {
        day = "Invalida value";
      }
      Console.WriteLine ($"Day: {day}");

      Console.WriteLine ($"\nCom switch-case");
      switch (x) {
        case 1:
          day = "Sunday";
          break;
        case 2:
          day = "Monday";
          break;
        case 3:
          day = "Tuesday";
          break;
        case 4:
          day = "Wednesday";
          break;
        case 5:
          day = "Friday";
          break;
        case 6:
          day = "Saturday";
          break;
        default:
          day = "Invalida value";
          break;
      }
      Console.WriteLine ($"Day: {day}");

    }
  }
}