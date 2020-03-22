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

          try {
            Console.Clear ();
            Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro);
            Console.WriteLine ($"\nTurno {partidaDeXadrez.Turno}");
            Console.WriteLine ($"Aguardando jogada: {partidaDeXadrez.JogadorAtual}");

            Console.Write ("\nOrigem: ");
            origem = Tela.LerPosicaoXadrez ().toPosicao ();

            partidaDeXadrez.ValidarPosicaoDeOrigem (origem);

            posicoesPossiveis = partidaDeXadrez.Tabuleiro.Peca (origem).MovimentosPossiveis ();

            Console.Clear ();
            Tela.imprimirTabuleiro (partidaDeXadrez.Tabuleiro, posicoesPossiveis);

            Console.Write ("\nDestino: ");
            destino = Tela.LerPosicaoXadrez ().toPosicao ();
            partidaDeXadrez.ValidarPosicaoDeDestino (origem, destino);

            partidaDeXadrez.RealizaJogada (origem, destino);
          } catch (TabuleiroException e) {
            Console.WriteLine (e.Message);
            Console.ReadLine ();

          }

        }

      } catch (TabuleiroException e) {

        Console.WriteLine (e.Message);
      }

      Console.WriteLine ();
    }
  }
}