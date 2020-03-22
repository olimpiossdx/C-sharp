using System;
using System.Collections.Generic;
using tabuleiro;
using xadrez;

namespace xadez_console {
  class Tela {

    public static void ImprimirPartida (PartidaDeXadrez partida) {
      imprimirTabuleiro (partida.Tabuleiro);
      Console.WriteLine ();
      ImprimiPecasCapturadas (partida);
      Console.WriteLine ($"\nTurno {partida.Turno}");
      Console.WriteLine ($"Aguardando jogada: {partida.JogadorAtual}");
    }

    public static void ImprimiPecasCapturadas (PartidaDeXadrez partida) {
      Console.WriteLine ("Peças capturadas");
      Console.Write ("Brancas: ");
      ImprimirConjunto (partida.PecasCapturadas (Cor.Branca));
      Console.Write ("Pretas: ");
      ConsoleColor tmp = Console.ForegroundColor;
      Console.ForegroundColor = ConsoleColor.Yellow;
      ImprimirConjunto (partida.PecasCapturadas (Cor.Preta));
      Console.ForegroundColor = tmp;
      Console.WriteLine ();
    }

    public static void ImprimirConjunto (HashSet<Peca> conjunto) {
      Console.Write ("[");

      foreach (var x in conjunto) {
        Console.Write ($"{x} ");
      }

      Console.WriteLine ("]");
    }

    public static void imprimirTabuleiro (Tabuleiro tab) {
      for (int i = 0; i < tab.Linhas; i++) {
        Console.Write (8 - i + " ");
        for (int j = 0; j < tab.Colunas; j++) {
          imprimePeca (tab.Peca (i, j));
        }
        Console.WriteLine ();
      }
      Console.WriteLine ("  a b c d e f g h");
    }

    public static void imprimirTabuleiro (Tabuleiro tab, bool[, ] possicoesPossiveis) {
      ConsoleColor fundoOriginal = Console.BackgroundColor;
      ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

      for (int i = 0; i < tab.Linhas; i++) {
        Console.Write (8 - i + " ");
        for (int j = 0; j < tab.Colunas; j++) {

          if (possicoesPossiveis[i, j]) {
            Console.BackgroundColor = fundoAlterado;
          } else {
            Console.BackgroundColor = fundoOriginal;
          }

          imprimePeca (tab.Peca (i, j));
          Console.BackgroundColor = fundoOriginal;
        }
        Console.WriteLine ();
      }
      Console.WriteLine ("  a b c d e f g h");
      Console.BackgroundColor = fundoOriginal;
    }

    public static PosicaoXadrez LerPosicaoXadrez () {
      string s = Console.ReadLine ();
      char coluna = s[0];
      int linha = int.Parse (s[1] + "");
      return new PosicaoXadrez (coluna, linha);
    }

    public static void imprimePeca (Peca peca) {

      if (peca == null) {
        Console.Write ("- ");
      } else {
        if (peca.Cor == Cor.Branca) {
          Console.Write (peca);
        } else {
          ConsoleColor aux = Console.ForegroundColor;
          Console.ForegroundColor = ConsoleColor.Yellow;
          Console.Write (peca);
          Console.ForegroundColor = aux;
        }
        Console.Write (" ");
      }
    }
  }
}