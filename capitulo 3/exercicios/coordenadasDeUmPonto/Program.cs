using System;
/*
 URI Online Judge | 1041
Coordenadas de um Ponto

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 1

Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

      Q2 | Q1
      Q3   Q4 

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.
Entrada

A entrada contem as coordenadas de um ponto.
Saída

A saída deve apresentar o quadrante em que o ponto se encontra.
Exemplo de Entrada 	Exemplo de Saída

4.5 -2.2
	

Q4

0.1 0.1
	

Q1

0.0 0.0
	

Origem
*/

namespace coordenadasDeUmPonto {
  class Program {
    static void Main (string[] args) {
      double x, y;
      string[] input = Console.ReadLine ().Split (' ');
      x = double.Parse (input[0]);
      y = double.Parse (input[1]);

      if (x < 0 && y > 0) {
        Console.WriteLine ("Q2");
      } else if (x > 0 && y > 0) {
        Console.WriteLine ("Q1");
      } else if (x < 0 && y < 0) {
        Console.WriteLine ("Q3");
      } else if (x > 0 && y < 0) {
        Console.WriteLine ("Q4");
      } else if (x == 0.0 && y == 0.0) {
        Console.WriteLine ("Origem");
      } else if (x == 0 && y > 0) {
        Console.WriteLine ("Eixo Y");
      } else if (y == 0 && x > 0) {
        Console.WriteLine ("Eixo X");
      } else if (x == 0 && y < 0) {
        Console.WriteLine ("Eixo Y");
      } else if (y == 0 && x < 0) {
        Console.WriteLine ("Eixo X");
      }
    }
  }
}