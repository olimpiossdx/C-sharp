﻿using System;

namespace dadosProduto {
  class Program {
    static void Main (string[] args) {
      string nome;
      double preco;
      int quantidade;
      Produto p;

      Console.WriteLine ("Entre os dados do produto");

      Console.Write ("Nome: ");
      nome = Console.ReadLine ();

      Console.Write ("Preço: ");
      preco = double.Parse (Console.ReadLine ());

      Console.Write ("Quantidade no estoque: ");
      quantidade = int.Parse (Console.ReadLine ());
      
      p = new Produto (nome, preco, quantidade);

      Console.WriteLine ($"dados do Produto: {p.ToString()}");

      Console.Write ("Digite número de produtos a ser adicionado ao estoque: ");
      p.AdicionarProdutos (int.Parse (Console.ReadLine ()));

      Console.WriteLine ($"Dados atualizados: {p.ToString()}");

      Console.Write ("Digite número de produtos  a ser removido do estoque: ");
      p.RemoverProdutos (int.Parse (Console.ReadLine ()));

      Console.WriteLine ($"Dados atualizados: {p.ToString()}");

    }
  }
}