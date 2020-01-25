using System;
/*
 URI Online Judge | 1067
Números Ímpares

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 1

Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
Entrada

O arquivo de entrada contém 1 valor inteiro qualquer.
Saída

Imprima todos os valores ímpares de 1 até X, inclusive X, se for o caso.
Exemplo de Entrada 
8

Exemplo de Saída
1
3
5
7
*/

namespace imparesfor {
  class Program {
    static void Main (string[] args) {
      int number = int.Parse (Console.ReadLine ());
      for (int x = 1; x <= number; x++)
        if (x % 2 != 0) Console.WriteLine (x);
    }
  }
}