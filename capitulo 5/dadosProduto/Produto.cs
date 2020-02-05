using System;

namespace dadosProduto {
  class Produto {
    public string Nome;
    public double Preco;
    public double Quantidade;
    public Produto () {
      Quantidade = 0;
    }
    public Produto (string nome, double preco) : this () {
      Nome = nome;
      Preco = preco;
    }
    public Produto (string nome, double preco, int quantidade) : this (nome, preco) {
      Quantidade = quantidade;
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