using System;

namespace operadores {
    class Program {
        static void Main (string[] args) {

            int n1 = 3 + 4 * 2;
            int n2 = (3 + 4) * 2;
            int n3 = 17 % 3;
            int n4 = 17 / 8;
            double n5 = (double) 17 / 8;
            double n6 = 17.0 / 8;

            double a = 1.0, b = -3.0, c = -4.0;
            double delta = (b * b) - 4.0 * c;
            double x1 = (-b + Math.Sqrt (delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt (delta)) / (2.0 * a);

            System.Console.WriteLine (n1);
            System.Console.WriteLine (n2);
            System.Console.WriteLine (n3);
            System.Console.WriteLine (n4);
            System.Console.WriteLine (n5);
            System.Console.WriteLine (n6);
            System.Console.WriteLine (x1);
            System.Console.WriteLine (x2);
            System.Console.WriteLine ();

            //operadores de atribuição
            int d = 10;
            System.Console.WriteLine (d);

            d += 2;
            System.Console.WriteLine (d);

            d *= 3;
            System.Console.WriteLine (d);
            System.Console.WriteLine ();

            string s = "ABC";
            s += "DEF";
            System.Console.WriteLine (s);
            System.Console.WriteLine ();

            // operadores atitméticos / atribuição
            int e = 10;
            e++;
            System.Console.WriteLine (e);
            e--;
            System.Console.WriteLine (e);
            System.Console.WriteLine ();

            int f = e++;
            System.Console.WriteLine (e);
            System.Console.WriteLine (f);
            System.Console.WriteLine ();

            int h = 10;
            int g = ++h;
            System.Console.WriteLine (h);
            System.Console.WriteLine (g);

        }
    }
}