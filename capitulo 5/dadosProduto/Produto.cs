using System;

//sugestão de implementação
/*
 * Atributos privados
 * Porpriedades autoimplementadas
 * Construtores
 * Propriedades customizadas
 * Outros métodos da classe
 */

namespace dadosProduto {
  class Produto {
    private string _nome;
    private double Preco { get; private set; }
    private double Quantidade { get; private set; }
    public Produto () {
      Quantidade = 0;
    }
    public Produto (string nome, double preco) : this () {
      _nome = nome;
      Preco = preco;
    }
    public Produto (string nome, double preco, int quantidade) : this (nome, preco) {
      Quantidade = quantidade;
    }

    public string Nome {
      get { return _nome; }
      set {
        if (value != null && value.Length > 3) {
          _nome = value;
        }
      }
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
      return $"{_nome}, $ {Preco:F2}, {Quantidade} unidade(s), Total: $ {ValorTotalEmEstoque():F2}";
    }

  }
}