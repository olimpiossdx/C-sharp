namespace aluguelEstudantes {
  class Estudante {
    private string _nome { get; }
    private string _email { get; }

    public Estudante () { }
    public Estudante (string nome, string email) {
      _nome = nome;
      _email = email;
    }

    public override string ToString () {
      return $"{_nome}, {_email}";
    }
  }
}