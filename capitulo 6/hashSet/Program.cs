using System;
using System.Collections.Generic;
namespace hashSet {
  class Program {
    static void Main (string[] args) {

      HashSet<int> A = new HashSet<int> ();
      HashSet<int> B = new HashSet<int> ();

      A.Add (3);
      A.Add (5);
      A.Add (8);
      A.Add (9);

      B.Add (3);
      B.Add (4);
      B.Add (5);

      //Não aceita inserção de itens repetidos 
      B.Add (4);

      foreach (int item in A)
        Console.WriteLine (item);

      foreach (int item in B)
        Console.WriteLine (item);

      //diferença de conjuntos
      A.ExceptWith (B);

      //união de conjuntos
      A.UnionWith (B);

      //intersecção de conjuntos 
      A.IntersectWith (B);

      B.Remove (4);

      Console.WriteLine ("Digite um valor inteiro:");
      int N = int.Parse (Console.ReadLine ());

      if (B.Contains (N)) {
        Console.WriteLine ($"{N} pertence ao conjunto B");
      } else {
        Console.WriteLine ($"{N} não pertence ao conjunto B");
      }
    }
  }
}