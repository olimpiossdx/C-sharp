using System;

/*

 URI Online Judge | 1115
Quadrante

Adaptado por Neilor Tonin, URI Brasil
Timelimit: 1

Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
Entrada

A entrada contém vários casos de teste. Cada caso de teste contém 2 valores inteiros.
Saída

Para cada caso de teste mostre em qual quadrante do sistema cartesiano se encontra a coordenada lida, conforme o exemplo.
Exemplo de Entrada

2 2
3 -2
-8 -1
-7 1
0 2
	
Exemplo de Saída

primeiro
quarto
terceiro
segundo
*/
namespace quadrante {
  class Program {
    static void Main (string[] args) {
      string[] input;
      short x, y;
      do {
        input = Console.ReadLine ().Split (' ');

        x = short.Parse (input[0]);
        y = short.Parse (input[1]);

        if (x > 0 && y > 0)
          Console.WriteLine ("primeiro");

        else if (x < 0 && y > 0)
          Console.WriteLine ("segundo");

        else if (x < 0 && y < 0)
          Console.WriteLine ("terceiro");

        else if (x > 0 && y < 0)
          Console.WriteLine ("quarto");

      } while (x != 0 && y != 0);

    }
  }
}