using System;

namespace operacoesDateTimespan {
  class Program {
    static void Main (string[] args) {

      TimeSpan t1 = TimeSpan.MaxValue;
      TimeSpan t2 = TimeSpan.MinValue;
      TimeSpan t3 = TimeSpan.Zero;

      Console.WriteLine ($"timeSpan.MaxValue: {t1}");
      Console.WriteLine ($"TimeSpan.MinValue: {t2}");
      Console.WriteLine ($"timeSpan.Zero: {t3}\n");

      TimeSpan t4 = new TimeSpan (2, 3, 5, 7, 11);

      Console.WriteLine ($"timeSpan: {t4}");
      Console.WriteLine ($"t4.Days: {t4.Days}");
      Console.WriteLine ($"t4.Hours: {t4.Minutes}");
      Console.WriteLine ($"t5.Minutes: {t4.Milliseconds}");
      Console.WriteLine ($"t6.Miloseconds: {t4.Seconds}");
      Console.WriteLine ($"t4.Ticks: {t4.Ticks}\n");

      Console.WriteLine ($"t4.TotalDays: {t4.TotalDays}");
      Console.WriteLine ($"t4.TotalHours: {t4.TotalHours}");
      Console.WriteLine ($"t4.TotalMinutes: {t4.TotalMinutes}");
      Console.WriteLine ($"t4.TotalSeconds: {t4.TotalSeconds}");
      Console.WriteLine ($"t4.TotalMilliseconds: {t4.TotalMilliseconds}");

      //Operações 
      TimeSpan t5 = new TimeSpan (1, 30, 10);
      TimeSpan t6 = new TimeSpan (0, 10, 5);

      TimeSpan sum = t5.Add (t6);
      TimeSpan dif = t5.Subtract (t6);
      TimeSpan mult = t6.Multiply (2.0);
      TimeSpan div = t6.Divide (2.0);

      Console.WriteLine ($"t5: {t5}");
      Console.WriteLine ($"t6: {t6}");
      Console.WriteLine ($"Add: {sum}");
      Console.WriteLine ($"Subtract: {dif}");
      Console.WriteLine ($"Multiply: {mult}");
      Console.WriteLine ($"Divide: {div}");
    }
  }
}