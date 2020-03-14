namespace tabuleiro {
  class Peca {
    public Posicao Posicao { get; set; }
    public Cor Cor { get; protected set; } // acessível pela classe e subclasses
    public int QteMovimentos { get; set; }
    public Tabuleiro Tab { get; protected set; }

    public Peca () { }
    public Peca (Posicao posicao, Tabuleiro tab, Cor cor) {
      this.Posicao = posicao;
      this.Tab = tab;
      this.Cor = cor;
      this.QteMovimentos = 0;
    }
  }
}