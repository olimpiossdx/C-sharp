using System;
using System.Collections.Generic;
namespace listas {
  class Program {
    static void Main (string[] args) {

      // acesso sequêncial aos elementos
      List<string> list = new List<string> { "Maria", "Alex", "Champs" };
      // adiciona ao final da lista
      list.Add ("Bob");
      list.Add ("Anna");

      //adiciona na posição da lista
      list.Insert (2, "Marco");

      foreach (Object obj in list) {
        Console.WriteLine (obj);
      }

      Console.WriteLine ("----------------------");
      // dado F -> onde f[0] é iual ao caracter 'A'
      string f = list.Find (f => f[0] == 'A');
      Console.WriteLine ($"[First]Elemento encontrado: {f}");
      Console.WriteLine ($"Tamanho da lista: {list.Count}");

      // dado f -> onde f[0] é igual ao caracter 'A'
      string f2 = list.FindLast (f => f[0] == 'A');
      Console.WriteLine ($"[Last]Elemento encontrado: {f2}");

      int pos1 = list.FindIndex (fi => fi[0] == 'A');
      Console.WriteLine ($"First position 'A': {pos1}");

      int pos2 = list.FindLastIndex (fli => fli[0] == 'A');
      Console.WriteLine ($"Last position 'A': {pos2}");

      Console.WriteLine ("----------------------");
      List<string> list2 = list.FindAll (x => x.Length == 5);

      foreach (Object obj in list2) {
        Console.WriteLine (obj);
      }

      Console.WriteLine ("----------------------");
      list.Remove ("Alex");
      foreach (Object obj in list) {
        Console.WriteLine (obj);
      }

      Console.WriteLine ("----------------------");
      list.RemoveAll (x => x[0] == 'U');
      foreach (Object obj in list) {
        Console.WriteLine (obj);
      }

      //remover um elemento pela posição
      Console.WriteLine ("-----------RemoveAt-----------");
      list.RemoveAt (2);
      foreach (Object obj in list) {
        Console.WriteLine (obj);
      }

      //remover elementos de uma faixa
      Console.WriteLine ("-----------RemoveRange-----------");
      list.RemoveRange (1, 1);
      foreach (Object obj in list) {
        Console.WriteLine (obj);
      }

    }
  }
}