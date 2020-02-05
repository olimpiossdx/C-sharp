using System;

namespace dadosProduto {
  class Produto {
    public string Nome;
    public double Preco;
    public double Quantidade;
    public Produto () { }
    public Produto (string nome, double preco) {
      Nome = nome;
      Preco = preco;
    }

    public double ValorTotalEmEstoque () {
      return Quantidade * Preco;
    }
    public void AdicionarProdutos (int quantidade) {
      Quantidade += quantidade;
    }
    public void RemoverProdutos (int quantidade) {
      Quantidade -= quantidade;
    }
    public override string ToString () {
      return $"{Nome}, $ {Preco:F2}, {Quantidade} unidade(s), Total: $ {ValorTotalEmEstoque():F2}";
    }

  }
}