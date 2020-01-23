using System;

/*
 * Fazer um programa para ler um número inteiro e dizer se este número é par ou impar
*/
namespace isParImpar
{
  class Program
  {
    static void Main(string[] args)
    {
      double isParImpar = double.Parse(Console.ReadLine());
      if (isParImpar % 2 == 0)
      {
        Console.WriteLine("PAR");
      }
      else
      {
        Console.WriteLine("IMPAR");
      }
    }
  }
}
