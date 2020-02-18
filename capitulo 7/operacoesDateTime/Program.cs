using System;

namespace operacoesDateTime {
  class Program {
    static void Main (string[] args) {
      //Propriedades
      DateTime d = new DateTime (2001, 8, 15, 13, 45, 58, 275);
      Console.WriteLine ($"1) Date: {d}");
      Console.WriteLine ($"2) Day: {d.Day}");
      Console.WriteLine ($"3) DayOfWeek: {d.DayOfWeek}");
      Console.WriteLine ($"4) DayOfYear: {d.DayOfYear}");
      Console.WriteLine ($"5) Hour: {d.Hour}");
      Console.WriteLine ($"6) Kind: {d.Kind}");
      Console.WriteLine ($"7) Millissecond: {d.Millisecond}");
      Console.WriteLine ($"8) Minute: {d.Minute}");
      Console.WriteLine ($"9) Month: {d.Month}");
      Console.WriteLine ($"10) Second: {d.Second}");
      Console.WriteLine ($"11) Ticks: {d.Ticks}");
      Console.WriteLine ($"12) TimeOfDay: {d.TimeOfDay}");
      Console.WriteLine ($"13) Year: {d.Year}\n");

      //Propriedades
      string s1 = d.ToLongDateString ();
      string s2 = d.ToLongTimeString ();
      string s3 = d.ToShortDateString ();
      string s4 = d.ToShortTimeString ();

      string s5 = d.ToString ();
      string s6 = d.ToString ("yyy-MM-dd HH:mm:ss");
      string s7 = d.ToString ("yyy-MM-dd HH:mm:ss.fff");

      Console.WriteLine ($"date.ToLongDateString: {s1}");
      Console.WriteLine ($"date.ToLongTimeString: {s2}");
      Console.WriteLine ($"date.ToShortDateString: {s3}");
      Console.WriteLine ($"ToShortTimeString: {s4}");
      Console.WriteLine ($"date.ToString: {s5}");
      Console.WriteLine ($"ToString ('yyy-MM-dd HH:mm:ss'): {s6}");
      Console.WriteLine ($"ToString ('yyy-MM-dd HH:mm:ss.fff'): {s6}\n");

      //Operações com calculo de datas, vencimentos de boletos entre outros
      DateTime d2 = d.AddHours (2);
      DateTime d3 = d.AddMinutes (3);
      DateTime d4 = d.AddDays (7);

      Console.WriteLine ($"date.AddHours(antes): {d}");
      Console.WriteLine ($"date.AddHours(depois): {d2}\n");

      Console.WriteLine ($"date.AddMinutes(antes): {d}");
      Console.WriteLine ($"date.AddMinutes(depois): {d3}\n");

      Console.WriteLine ($"date.AddDays(antes): {d}");
      Console.WriteLine ($"date.AddDays(depois): {d4}\n");

      Console.WriteLine ($"date.AddHours(antes): {d}");
      Console.WriteLine ($"date.AddHours(depois): {d2}\n");

      DateTime d5 = new DateTime (2000, 10, 15);
      DateTime d6 = new DateTime (2000, 10, 18);

      TimeSpan t = d6.Subtract (d5);

      Console.WriteLine ($"date 5: {d}");
      Console.WriteLine ($"date 6: {d2}");
      Console.WriteLine ($"TimeSpan.Subtract(depois): {t}\n");

    }
  }
}