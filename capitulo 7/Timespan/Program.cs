using System;

/*
	Representa uma DURAÇÃO
	valor do tipo (struct)
	Rpresentação interna -> um objeto TimeSpan itnernamente armazena um duração na forma de ticks (100 nanosegundos)
	instanciação:construtures, fields, métodos From, Parse
*/

namespace Timespan {
	class Program {
		static void Main (string[] args) {
			TimeSpan t1 = new TimeSpan (0, 1, 30);

			Console.WriteLine ($"TimeSpan: {t1}");
			Console.WriteLine ($"TimeSpan.Ticks:  {t1.Ticks}");

			//construtores
			TimeSpan t2 = new TimeSpan ();
			TimeSpan t3 = new TimeSpan (9000000L);
			TimeSpan t4 = new TimeSpan (2, 11, 21);
			TimeSpan t5 = new TimeSpan (2, 11, 21);
			TimeSpan t6 = new TimeSpan (1, 2, 11, 21);
			TimeSpan t7 = new TimeSpan (1, 2, 11, 21, 321);

			Console.WriteLine ($"TimeSpan t2: {t2}");
			Console.WriteLine ($"TimeSpan t3: {t3}");
			Console.WriteLine ($"TimeSpan t4: {t4}");
			Console.WriteLine ($"TimeSpan t5: {t5}");
			Console.WriteLine ($"TimeSpan t6: {t6}");
			Console.WriteLine ($"TimeSpan t7: {t7}");

			//instanciar utilizando métodos from
			TimeSpan t8 = TimeSpan.FromDays (1.5);
			TimeSpan t9 = TimeSpan.FromHours (1.5);
			TimeSpan t10 = TimeSpan.FromHours (1.5);
			TimeSpan t11 = TimeSpan.FromMilliseconds (1);
			TimeSpan t12 = TimeSpan.FromMinutes (1.5);
			TimeSpan t13 = TimeSpan.FromSeconds (1.5);
			TimeSpan t14 = TimeSpan.FromTicks (900000000L);

			Console.WriteLine ($"TimeSpan t08: {t8}");
			Console.WriteLine ($"TimeSpan t09: {t9}");
			Console.WriteLine ($"TimeSpan t10: {t10}");
			Console.WriteLine ($"TimeSpan t11: {t11}");
			Console.WriteLine ($"TimeSpan t12: {t12}");
			Console.WriteLine ($"TimeSpan t15: {t13}");
			Console.WriteLine ($"TimeSpan t14: {t14}");
		}
	}
}