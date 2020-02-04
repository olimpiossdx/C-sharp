using System;

namespace dadosProduto {
  class Program {
    static void Main (string[] args) {

      Produto p = new Produto ();

      Console.WriteLine ("Entre os dados do produto");

      Console.Write ("Nome: ");
      p.Nome = Console.ReadLine ();

      Console.Write ("Preço: ");
      p.Preco = double.Parse (Console.ReadLine ());

      Console.Write ("Quantidade no estoque: ");
      p.Quantidade = int.Parse (Console.ReadLine ());

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