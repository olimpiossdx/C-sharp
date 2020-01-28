using System;

namespace estruturaCondicionalIfElse {
    class Program {
        static void Main (string[] args) {

            //condicional simples
            // int x = 10;
            // Console.WriteLine ("Bom dia!");
            // if (x > 5) {
            //     Console.WriteLine ("Boa tarde! ");
            // }

            //     Console.WriteLine ("Boa noite! ");

            //condicional composta

            // Console.WriteLine ("Entre com número inteiro");
            // int x = int.Parse (Console.ReadLine ());
            // if (x % 2 == 0) {
            //     Console.WriteLine ("par");
            // } else {
            //     Console.WriteLine ("impar");
            // }
            //condicional encadeada
            Console.WriteLine ("Qual a hora atual");
            int hora = int.Parse (Console.ReadLine ());

            if (hora < 12) {
                Console.WriteLine ("Bom dia");
            } else if (hora < 18) {
                Console.WriteLine ("Boa tarde");
            } else {
                Console.WriteLine ("Boa noite");
            }

        }
    }
}