namespace tabuleiro {
  abstract class Peca {
    public Posicao Posicao { get; set; }
    public Cor Cor { get; protected set; } // acessível pela classe e subclasses
    public int QteMovimentos { get; set; }
    public Tabuleiro Tabuleiro { get; protected set; }

    public Peca (Tabuleiro tabuleiro, Cor cor) {
      this.Posicao = null;
      this.Tabuleiro = tabuleiro;
      this.Cor = cor;
      this.QteMovimentos = 0;
    }

    public void IncrementarQteMovimentos () {
      QteMovimentos++;
    }

    public bool existeMovimentosPossiveis () {
      bool[, ] mat = MovimentosPossiveis ();
      for (int i = 0; i < Tabuleiro.Linhas; i++)
        for (int j = 0; j < Tabuleiro.Colunas; j++)
          if (mat[i, j])
            return true;

      return false;
    }

    public bool PodeMoverPara (Posicao posicao) {
      return MovimentosPossiveis () [posicao.Linha, posicao.Coluna];
    }

    public abstract bool[, ] MovimentosPossiveis ();
  }
}