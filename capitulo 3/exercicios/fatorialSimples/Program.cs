using System;

/*

 URI Online Judge | 1153
Fatorial Simples

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 1

Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Entrada

A entrada contém um valor inteiro N (0 < N < 13).
Saída

A saída contém um valor inteiro, correspondente ao fatorial de N.
Exemplo de Entrada 	
4
	
Exemplo de Saída
24
*/
namespace fatorialSimples {
  class Program {
    static void Main (string[] args) {
      short n = short.Parse (Console.ReadLine ());
      int resultado = 1;
      for (int i = 0; i < n; i++)
        resultado = resultado * (n - i);
      if (n == 0) resultado = resultado * n;
      Console.WriteLine ($"{resultado}");
    }
  }
}