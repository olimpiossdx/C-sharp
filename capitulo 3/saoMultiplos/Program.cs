using System;
/* 
URI Online Judge | 1044
Múltiplos
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", indicando se os valores lidos são múltiplos entre si.

Entrada
A entrada contém valores inteiros.

Saída
A saída deve conter uma das mensagens conforme descrito acima.

Exemplo de Entrada	Exemplo de Saída
6 24

Sao Multiplos

6 25

Nao sao Multiplos
*/
namespace saoMultiplos
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] input = Console.ReadLine().Split(' ');
      short A, B;
      A = short.Parse(input[0]);
      B = short.Parse(input[1]);
      if ((A % B == 0) || (B % A == 0))
      {
        Console.WriteLine("Sao Multiplos");
      }
      else
      {
        Console.WriteLine("Nao sao Multiplos");
      }
    }
  }
}
