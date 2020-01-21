using System;

namespace exerciciocomposto {
  class Program {
    static void Main (string[] args) {
      string nome, quarto;
      float preco;
      string[] nia;
      string nome2, idade, altura;

      System.Console.WriteLine ("Entre com seu nome completo:");
      nome = Console.ReadLine ();
      System.Console.WriteLine ("Quantos quartos tem na sua casa?");
      quarto = Console.ReadLine ();
      System.Console.WriteLine ("Entre com o preço de um produto");
      preco = float.Parse (Console.ReadLine ());
      System.Console.WriteLine ("Entre seu último nome, idade e altura (mesma linha)");
      nia = Console.ReadLine ().Split (' ');
      nome2 = nia[0];
      idade = nia[1];
      altura = nia[2];

      System.Console.WriteLine ("Você digitou:");
      System.Console.WriteLine (nome + "\n" + quarto + "\n" + preco + "\n" + nome2 + "\n" + idade + "\n" + altura);

    }
  }
}