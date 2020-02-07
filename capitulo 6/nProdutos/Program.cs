using System;

namespace nProdutos {
  class Program {
    static void Main (string[] args) {
      int n;
      Produto[] produtos;
      double soma = 0.0;

      Console.Write ("informe a quantidade de produtos a serem lidos: ");
      n = int.Parse (Console.ReadLine ());

      produtos = new Produto[n];

      for (int i = 0; i < n; i++)
        produtos[i] = new Produto { Nome = Console.ReadLine (), Preco = double.Parse (Console.ReadLine ()) };

      for (int i = 0; i < n; i++)
        soma += produtos[i].Preco;
        
      Console.WriteLine ($"AVERAGE HEIGHT: {soma/n}");
    }
  }
}