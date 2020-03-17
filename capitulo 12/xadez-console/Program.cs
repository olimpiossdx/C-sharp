using System;
using tabuleiro;
using xadrez;
namespace xadez_console {
  class Program {
    static void Main (string[] args) {

      try {
        PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez ();
        Posicao origem, destino;

        Console.Clear ();
        Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro);

        Console.Write ("\nOrigem: ");
        origem = Tela.LerPosicaoXadrez ().toPosicao ();
        Console.Write ("Destino: ");
        destino = Tela.LerPosicaoXadrez ().toPosicao ();

        partidaDeXadrez.ExecutaMovimento (origem, destino);
        Console.WriteLine();
        Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro);

      } catch (TabuleiroException e) {

        Console.WriteLine (e.Message);
      }

      Console.WriteLine ();
    }
  }
}