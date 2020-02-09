namespace aluguelEstudantes {
  class Aluguel {
    private Estudante _estudante { get; set; }
    public short _quarto { get; private set; }

    public Aluguel () {
      _quarto = -1;
      _estudante = new Estudante ();
    }
    public Aluguel (short quarto, Estudante estudante) {
      _quarto = quarto;
      _estudante = estudante;
    }
    public Aluguel (short aluguel, string nome, string email) {
      _quarto = aluguel;
      _estudante = new Estudante (nome, email);
    }

    public override string ToString () {
      return$"{_quarto}: {_estudante.ToString()}";
    }
  }
}