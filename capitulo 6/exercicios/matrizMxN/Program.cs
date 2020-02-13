using System;

/*
  Faxer um programa para ler dois números inteiros M e n, e depois ler uma matriz de M linhas por N colunas contendo números inteiros podendo haver repetições.
  Em seguida, ler um número inteiro X que pertece à matriz. Para cada ocorrẽncia de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver,
  conforme exemplo.
*/

namespace matrizMxN {
  class Program {
    static void Main (string[] args) {
      string[] values = Console.ReadLine ().Split (' ');
      int m, n, number;

      m = int.Parse (values[0]);
      n = int.Parse (values[1]);

      int[, ] mat = new int[m, n];

      for (int i = 0; i < m; i++) {
        string[] valuesRead = Console.ReadLine ().Split (' ');
        for (int j = 0; j < n; j++)
          mat[i, j] = int.Parse (valuesRead[j]);
      }

      number = int.Parse (Console.ReadLine ());

      for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
          if (mat[i, j] == number) {
            Console.WriteLine ($"Position {i}, {j}:");
            if (j - 1 >= 0 && j - 1 < n) {
              Console.WriteLine ($"Left: {mat[i,j-1]}");
            }
            if (j + 1 < n) {
              Console.WriteLine ($"Right: {mat[i,j+1]}");
            }
            if (i + 1 < m) {
              Console.WriteLine ($"Down: {mat[i+1,j]}");
            }
            if (i - 1 >= 0 && i - 1 < m) {
              Console.WriteLine ($"Up: {mat[i-1,j]}");
            }
          }
        }
      }

    }
  }
}