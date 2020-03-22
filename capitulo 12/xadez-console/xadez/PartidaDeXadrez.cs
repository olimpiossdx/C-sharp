using System.Collections.Generic;
using tabuleiro;
namespace xadrez {
  class PartidaDeXadrez {
    public Tabuleiro Tabuleiro { get; private set; }
    public int Turno { get; private set; }
    public Cor JogadorAtual { get; private set; }
    public bool Terminada { get; private set; }
    private HashSet<Peca> Pecas;
    private HashSet<Peca> Capturadas;

    public PartidaDeXadrez () {
      Tabuleiro = new Tabuleiro (8, 8);
      Turno = 1;
      JogadorAtual = Cor.Branca;
      Pecas = new HashSet<Peca> ();
      Capturadas = new HashSet<Peca> ();
      ColocarPecas ();
    }

    public void ExecutaMovimento (Posicao origem, Posicao destino) {
      Peca p = Tabuleiro.RetirarPeca (origem);
      p.IncrementarQteMovimentos ();
      Peca pecaCapturada = Tabuleiro.RetirarPeca (destino);
      Tabuleiro.ColocarPeca (p, destino);
      if (pecaCapturada != null)
        Capturadas.Add (pecaCapturada);
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

    public HashSet<Peca> PecasCapturadas (Cor cor) {
      HashSet<Peca> capturadasCor = new HashSet<Peca> ();
      foreach (Peca x in Capturadas) {
        if (x.Cor == cor)
          capturadasCor.Add (x);
      }
      return capturadasCor;
    }

    public HashSet<Peca> PecasEmJogo (Cor cor) {
      HashSet<Peca> capturadasCor = new HashSet<Peca> ();
      foreach (Peca x in Capturadas) {
        if (x.Cor == cor)
          capturadasCor.Add (x);
      }
      capturadasCor.ExceptWith (PecasCapturadas (cor));
      return capturadasCor;
    }

    public void ColocarNovaPeca (char coluna, int linha, Peca peca) {
      Tabuleiro.ColocarPeca (peca, new PosicaoXadrez (coluna, linha).toPosicao ());
      Pecas.Add (peca);
    }

    public void ColocarPecas () {

      ColocarNovaPeca ('c', 1, new Torre (Tabuleiro, Cor.Branca));
      ColocarNovaPeca ('c', 2, new Torre (Tabuleiro, Cor.Branca));
      ColocarNovaPeca ('d', 2, new Torre (Tabuleiro, Cor.Branca));
      ColocarNovaPeca ('e', 2, new Torre (Tabuleiro, Cor.Branca));
      ColocarNovaPeca ('e', 1, new Torre (Tabuleiro, Cor.Branca));
      ColocarNovaPeca ('d', 1, new Rei (Tabuleiro, Cor.Branca));

      ColocarNovaPeca ('c', 7, new Torre (Tabuleiro, Cor.Preta));
      ColocarNovaPeca ('c', 8, new Torre (Tabuleiro, Cor.Preta));
      ColocarNovaPeca ('d', 7, new Torre (Tabuleiro, Cor.Preta));
      ColocarNovaPeca ('e', 7, new Torre (Tabuleiro, Cor.Preta));
      ColocarNovaPeca ('e', 8, new Torre (Tabuleiro, Cor.Preta));
      ColocarNovaPeca ('d', 8, new Rei (Tabuleiro, Cor.Preta));
    }

  }
}