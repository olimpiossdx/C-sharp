namespace tabuleiro {
  class Tabuleiro {
    public int Linhas { get; set; }
    public int Colunas { get; set; }
    private Peca[, ] Pecas;

    public Tabuleiro (int linhas, int colunas) {
      this.Linhas = linhas;
      this.Colunas = colunas;
      this.Pecas = new Peca[linhas, colunas];
    }

    public Peca Peca (int linha, int coluna) {
      return Pecas[linha, coluna];
    }

    public void colocarPeca (Peca peca, Posicao posicao) {
      Pecas[posicao.Linha, posicao.Coluna] = peca;
      peca.Posicao = posicao;
    }
  }
}