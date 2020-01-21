using System;

namespace castingConversaoImplicita {
    class Program {
        static void Main (string[] args) {

            //float x = 4.5;
            //double y = 4.5;

            double a;
            float b;
            int bb;
            int aa = 5;
            int bbb = 2;

            a = 5.1;
            b = (float) a;
            bb = (int) a;

            double resultado = (double) aa / bbb;

            System.Console.WriteLine (b);
            System.Console.WriteLine (bb);
            System.Console.WriteLine (resultado);

        }
    }
}