using tabuleiro;

namespace xadrez {
  class Rei : Peca {

    public Rei (Tabuleiro tabuleiro, Cor cor) : base (tabuleiro, cor) { }

    public override string ToString () {
      return "R";
    }

    private bool podeMover (Posicao pos) {
      Peca p = Tabuleiro.Peca (pos);
      return p == null || p.Cor != Cor;
    }

    public override bool[, ] MovimentosPossiveis () {
      bool[, ] mat = new bool[Tabuleiro.Linhas, Tabuleiro.Colunas];
      Posicao posicao = new Posicao (0, 0);

      // acima
      posicao.DefinirValores (Posicao.Linha - 1, Posicao.Coluna);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      // Ne
      posicao.DefinirValores (Posicao.Linha - 1, Posicao.Coluna + 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      // direita
      posicao.DefinirValores (Posicao.Linha, Posicao.Coluna + 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      //se
      posicao.DefinirValores (Posicao.Linha + 1, Posicao.Coluna + 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      //abaixo
      posicao.DefinirValores (Posicao.Linha + 1, Posicao.Coluna);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      //so
      posicao.DefinirValores (Posicao.Linha + 1, Posicao.Coluna - 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      //esquerda
      posicao.DefinirValores (Posicao.Linha, Posicao.Coluna - 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      //so
      posicao.DefinirValores (Posicao.Linha - 1, Posicao.Coluna - 1);
      if (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
      }

      return mat;
    }
  }
}