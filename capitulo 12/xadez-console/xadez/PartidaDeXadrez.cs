using tabuleiro;
namespace xadrez {
  class PartidaDeXadrez {
    public Tabuleiro Tabuleiro { get; private set; }
    public int Turno { get; private set; }
    public Cor JogadorAtual { get; private set; }
    public bool Terminada { get; private set; }

    public PartidaDeXadrez () {
      Tabuleiro = new Tabuleiro (8, 8);
      Turno = 1;
      JogadorAtual = Cor.Branca;
      ColocarPecas ();
    }

    public void ExecutaMovimento (Posicao origem, Posicao destino) {
      Peca p = Tabuleiro.RetirarPeca (origem);
      p.IncrementarQteMovimentos ();
      Peca pecaCapturada = Tabuleiro.RetirarPeca (destino);
      Tabuleiro.ColocarPeca (p, destino);
    }

    public void RealizaJogada (Posicao origem, Posicao destino) {
      ExecutaMovimento (origem, destino);
      Turno++;
      MudaJogador ();
    }

    public void ValidarPosicaoDeOrigem (Posicao posicao) {
      if (Tabuleiro.Peca (posicao) == null)
        throw new TabuleiroException ("Não existe peça na posição de origem escolhida!");

      if (JogadorAtual != Tabuleiro.Peca (posicao).Cor)
        throw new TabuleiroException ("A peça de origem escolhida não é sua");

      if (!Tabuleiro.Peca (posicao).existeMovimentosPossiveis ())
        throw new TabuleiroException ("Não há movimentos possíveis para a peça de origem escolhida!");
    }

    public void ValidarPosicaoDeDestino (Posicao origem, Posicao destino) {
      if (!Tabuleiro.Peca (origem).PodeMoverPara (destino))
        throw new TabuleiroException ("Posição de destino inválida");
    }

    public void MudaJogador () {
      if (JogadorAtual == Cor.Branca) {
        JogadorAtual = Cor.Preta;
      } else {
        JogadorAtual = Cor.Branca;
      }
    }

    public void ColocarPecas () {
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Branca), new PosicaoXadrez ('c', 1).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Branca), new PosicaoXadrez ('c', 2).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Branca), new PosicaoXadrez ('d', 2).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Branca), new PosicaoXadrez ('e', 2).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Branca), new PosicaoXadrez ('e', 1).toPosicao ());
      Tabuleiro.ColocarPeca (new Rei (Tabuleiro, Cor.Branca), new PosicaoXadrez ('d', 1).toPosicao ());

      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Preta), new PosicaoXadrez ('c', 7).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Preta), new PosicaoXadrez ('c', 8).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Preta), new PosicaoXadrez ('d', 7).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Preta), new PosicaoXadrez ('e', 7).toPosicao ());
      Tabuleiro.ColocarPeca (new Torre (Tabuleiro, Cor.Preta), new PosicaoXadrez ('e', 8).toPosicao ());
      Tabuleiro.ColocarPeca (new Rei (Tabuleiro, Cor.Preta), new PosicaoXadrez ('d', 8).toPosicao ());

    }

  }
}