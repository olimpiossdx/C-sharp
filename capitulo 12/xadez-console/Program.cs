using System;
using tabuleiro;
using xadrez;
namespace xadez_console {
  class Program {
    static void Main (string[] args) {
      PosicaoXadez posicao = new PosicaoXadez ('c', 1);
      Console.WriteLine (posicao.ToString());
      Console.WriteLine (posicao.toPosicao());
      // try {
      //   Tabuleiro tab = new Tabuleiro (8, 8);

      //   tab.ColocarPeca (new Torre (tab, Cor.Preta), new Posicao (0, 0));
      //   tab.ColocarPeca (new Torre (tab, Cor.Preta), new Posicao (1, 3));
      //   tab.ColocarPeca (new Rei (tab, Cor.Preta), new Posicao (2, 4));

      //   Tela.imprimirTabuleiro (tab);

      // } catch (TabuleiroException e) {

      //   Console.WriteLine (e.Message);
      // }

      Console.WriteLine ();
    }
  }
}