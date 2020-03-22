using tabuleiro;

namespace xadrez {
  class Torre : Peca {

    public Torre (Tabuleiro tabuleiro, Cor cor) : base (tabuleiro, cor) { }

    public override string ToString () {
      return "T";
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
      while (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
        if (Tabuleiro.Peca (posicao) != null && Tabuleiro.Peca (posicao).Cor != Cor) {
          break;
        }
        posicao.Linha = posicao.Linha - 1;
      }

      // abaixo
      posicao.DefinirValores (Posicao.Linha + 1, Posicao.Coluna);
      while (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
        if (Tabuleiro.Peca (posicao) != null && Tabuleiro.Peca (posicao).Cor != Cor) {
          break;
        }
        posicao.Linha = posicao.Linha + 1;
      }

      // direita
      posicao.DefinirValores (Posicao.Linha, Posicao.Coluna + 1);
      while (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
        if (Tabuleiro.Peca (posicao) != null && Tabuleiro.Peca (posicao).Cor != Cor) {
          break;
        }
        posicao.Coluna = posicao.Coluna + 1;
      }

      // esquerda
      posicao.DefinirValores (Posicao.Linha, Posicao.Coluna - 1);
      while (Tabuleiro.PosicaoValida (posicao) && podeMover (posicao)) {
        mat[posicao.Linha, posicao.Coluna] = true;
        if (Tabuleiro.Peca (posicao) != null && Tabuleiro.Peca (posicao).Cor != Cor) {
          break;
        }
        posicao.Coluna = posicao.Coluna - 1;
      }

      return mat;
    }
  }
}