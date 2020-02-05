using System;

namespace dadosProduto {
  class Produto {
    private string _nome;
    private double _preco;
    private double _quantidade;
    public Produto () {
      Quantidade = 0;
    }
    public Produto (string nome, double preco) : this () {
      _nome = nome;
      _preco = preco;
    }
    public Produto (string nome, double preco, int quantidade) : this (nome, preco) {
      _quantidade = quantidade;
    }

    public GetNome () {
      return _nome;
    }
    public SetNome (string nome) {
      if (nome != null && nome.Length > 3) {
        _nome = nome;
      }
    }
    public GetPreco () {
      return _preco;
    }

    public GetQuantidade () {
      return _quantidade;
    }

    public double ValorTotalEmEstoque () {
      return _quantidade * Preco;
    }
    public void AdicionarProdutos (int quantidade) {
      _quantidade += quantidade;
    }
    public void RemoverProdutos (int quantidade) {
      _quantidade -= quantidade;
    }
    public override string ToString () {
      return $"{_nome}, $ {_preco:F2}, {_quantidade} unidade(s), Total: $ {ValorTotalEmEstoque():F2}";
    }

  }
}