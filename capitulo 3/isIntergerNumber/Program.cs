using System;

/*Fazer um program apra ler um número inteiro, e depois dizer se este número é negativo ou não*/
namespace isIntergerNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      int number = int.Parse(Console.ReadLine());
      if (number < 0)
      {
        Console.WriteLine("NEGATIVO");
      }
      else
      {
        Console.WriteLine("NAO NEGATIVO");

      }
    }
  }
}
