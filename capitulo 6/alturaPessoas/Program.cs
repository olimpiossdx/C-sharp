using System;

// Fazer um programa  para ler  um número  inteiro N e altura  de N pessoas.
// Armazene as N alturas em um vetor. Em seguida, mostrar a altura média dessas pessoas.

namespace alturaPessoas {
  class Program {
    static void Main (string[] args) {
      Console.Write ("Entre com número da quantidade de alturas a serem lidas: ");
      int n = int.Parse (Console.ReadLine ());
      double[] vector = new double[n];
      double sum = 0.0;

      for (int i = 0; i < n; i++)
        vector[i] = double.Parse (Console.ReadLine ());

      for (int i = 0; i < n; i++)
        sum += vector[i];

      Console.WriteLine ($"AVERAGE HEIGHT: {sum/n:f2}");

    }
  }
}