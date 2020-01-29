using System;

namespace escopoeinicializacao {
    class Program {
        static void Main (string[] args) {
            // variavel precisa ser inicializada
            int x = 10;
            Console.WriteLine (x);

            // erro por causa de declração da variável fora do escopo princial da aplicação; Desconto pertence ao escopo do if()
            double preco = double.Parse (Console.ReadLine ());
            double desconto = 0;
            if (preco > 100.0) {
                //double desconto = preco * 0.1;
                desconto = preco * 0.1;
            }
            Console.WriteLine (desconto);
        }
    }
}