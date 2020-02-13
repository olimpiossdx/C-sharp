using System;

/*
Fazer um programa para ler um número inteiro N e uma matriz de ordem N contendo números inteiros.
Em seguida, mostrar a diagonal princiap e a quantidade de valores negativos da matriz.
*/
namespace matrizQuadrda {
  class Program {
    static void Main (string[] args) {

      int negative = 0, n = int.Parse (Console.ReadLine ());

      int[, ] mat = new int[n, n];

      for (int i = 0; i < n; i++) {
        String[] values = Console.ReadLine ().Split (' ');
        for (int j = 0; j < n; j++) {
          mat[i, j] = int.Parse (values[j]);
          if (mat[i, j] < 0) negative++;
        }
      }

      Console.WriteLine ("Main diagonal:");
      for (int i = 0; i < n; i++)
        Console.Write ($" {mat[i,i]}");

      Console.WriteLine ($"\nNegative numbers: {negative}");

    }
  }
}