using tabuleiro;

namespace xadrez {
  class PosicaoXadez {
    public char Coluna { get; set; }
    public int Linha { get; set; }

    public PosicaoXadez (char coluna, int linha) {
      this.Coluna = coluna;
      this.Linha = linha;
    }
    
    public Posicao toPosicao () {
      return new Posicao (8 - Linha, Coluna - 'a');
    }

    public override string ToString () {
      return ($" {Coluna}{Linha}");
    }
  }
}