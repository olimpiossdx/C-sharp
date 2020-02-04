using System;

namespace dadosProduto {
  class Produto {
    public string Nome { get; set; }
    public double Preco { get; set; }
    public double Quantidade { get; set; }

    public double ValorTotalEmEstoque () {
      return Quantidade * Preco;
    }
    public void AdicionarProdutos (int quantidade) {
      Quantidade += quantidade;
    }
    public void RemoverProdutos (int quantidade) {
      Quantidade -= quantidade;
    }
    public override string ToString(){
      return $"{Nome}, $ {Preco:F2}, {Quantidade} unidade(s), Total: $ {ValorTotalEmEstoque():F2}";
    }
  
  }
}