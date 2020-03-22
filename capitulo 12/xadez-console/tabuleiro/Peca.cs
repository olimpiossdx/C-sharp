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

    public abstract bool[, ] MovimentosPossiveis ();
  }
}