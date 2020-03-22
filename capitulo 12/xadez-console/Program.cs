using System;
using tabuleiro;
using xadrez;
namespace xadez_console {
  class Program {
    static void Main (string[] args) {

      try {
        PartidaDeXadrez partidaDeXadrez = new PartidaDeXadrez ();
        Posicao origem, destino;
        bool[, ] posicoesPossiveis;
        while (!partidaDeXadrez.Terminada) {

          Console.Clear ();
          Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro);

          Console.Write ("\nOrigem: ");
          origem = Tela.LerPosicaoXadrez ().toPosicao ();

          posicoesPossiveis = partidaDeXadrez.Tabuleiro.Peca (origem).MovimentosPossiveis ();

          Console.Clear ();
          Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro, posicoesPossiveis);

          Console.Write ("\nDestino: ");
          destino = Tela.LerPosicaoXadrez ().toPosicao ();

          partidaDeXadrez.ExecutaMovimento (origem, destino);
        
        }

      } catch (TabuleiroException e) {

        Console.WriteLine (e.Message);
      }

      Console.WriteLine ();
    }
  }
}