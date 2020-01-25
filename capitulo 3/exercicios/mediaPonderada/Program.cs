using System;
/*
 URI Online Judge | 1079
Médias Ponderadas

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 1

Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem peso 5.
Entrada

O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um caso de teste com três valores com uma casa decimal cada valor.
Saída

Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
Exemplo de Entrada 	

3
6.5 4.3 6.2
5.1 4.2 8.1
8.0 9.0 10.0
	
Exemplo de Saída
5.7
6.3
9.3
*/
namespace mediaPonderada {
  class Program {
    static void Main (string[] args) {
      int n = int.Parse (Console.ReadLine ());
      double p1, p2, p3, resultado;
      short x1, x2, x3;
      x1 = 2;
      x2 = 3;
      x3 = 5;
      string[] input;
      for (int i = 0; i < n; i++) {
        input = Console.ReadLine ().Split (' ');
        p1 = (double) (double.Parse (input[0]));
        p2 = (double) (double.Parse (input[1]));
        p3 = (double) (double.Parse (input[2]));
        resultado = ((p1 * x1) + (p2 * x2) + (p3 * x3)) / (x1 + x2 + x3);
        Console.WriteLine ($"{resultado:F1}");
      }
    }
  }
}