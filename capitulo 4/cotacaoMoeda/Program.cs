using System;

namespace cotacaoMoeda {
    class Program {
        static void Main (string[] args) {
            double cotacao, qtdDolar;

            Console.Write ("Qual é a cotação do dólar? ");
            cotacao = double.Parse (Console.ReadLine ());
            Console.Write ($"Quantos dólares você vai comprar? ");
            qtdDolar = double.Parse (Console.ReadLine ());

            Console.WriteLine ($"Valor a ser pago em reais = {ConversorDeMoeda.PagoEmReais(cotacao,qtdDolar):F2}");

        }
    }
}