using System;

/*
URI Online Judge | 1038
Lanche
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, calcule e mostre o valor da conta a pagar.
  Codigo   ESPECIFICAÇÃO        PREÇO
    1       Cachorro quente     R$ 4.00
    2       X-Salda             R$ 2.50
    3       X-Banco             R$ 5.5
    4       Torrada simples     R$ 2.00
    5       Refrigerante        R$ 1.50


Entrada
O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.

Saída
O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.

Exemplo de Entrada	Exemplo de Saída
3 2

Total: R$ 10.00

4 3

Total: R$ 6.00

2 3

Total: R$ 13.50
*/
namespace lanche
{
  class Program
  {
    static void Main(string[] args)
    {
      string[] input = Console.ReadLine().Split(' ');
      string item;
      short quantidade;
      item = input[0];
      quantidade = short.Parse(input[1]);
      switch (item)
      {
        case "1":
          Console.WriteLine($"Total: R$ {quantidade * 4.00:F2}");
          break;
        case "2":
          Console.WriteLine($"Total: R$ {quantidade * 4.50:F2}");
          break;
        case "3":
          Console.WriteLine($"Total: R$ {quantidade * 5.00:F2}");
          break;
        case "4":
          Console.WriteLine($"Total: R$ {quantidade * 2.00:F2}");
          break;
        case "5":
          Console.WriteLine($"Total: R$ {quantidade * 1.50:F2}");
          break;
        default:
          return;
      }

    }
  }
}
