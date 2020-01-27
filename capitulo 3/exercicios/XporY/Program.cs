using System;
/*

 URI Online Judge | 1116
Dividindo X por Y

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 2

Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.
Entrada

A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.
Saída

Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
Exemplo de Entrada 	Exemplo de Saída

3
3 -2
-8 0
0 8
	

-1.5
divisao impossivel
0.0

*/
namespace XporY {
  class Program {
    static void Main (string[] args) {
      short n = short.Parse (Console.ReadLine ());
      int x, y;
      string[] input;
      for (int i = 0; i < n; i++) {
        input = Console.ReadLine ().Split(' ');
        x = int.Parse (input[0]);
        y = int.Parse (input[1]);
        if (y == 0) {
          Console.WriteLine ("divisao impossivel");
        } else {
          Console.WriteLine ($"{(double)x/y:F1}");
        }
      }
    }
  }
}