using System;

namespace expressaoCondicionalTernaria {
  class Program {
    static void Main (string[] args) {
      double preco, desconto;

      Console.WriteLine ("estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição\n(condição ) ? valor_se_verdadeiro : valor_se_falso\n");
      //estrutura opcional ao if-else quando se deseja decidir um valor com base em uma condição
      // (condição ) ? valor_se_verdadeiro : valor_se_falso
      Console.WriteLine ($"(2>4)? 50:80 =>{((2 > 4)?50:80)}");
      Console.WriteLine ($"(10!=3)? 'Maria':'Alex' =>{((10 != 3)?"Maria":"Alex")}\n");

      Console.Write ("utilizando if-else\nInforme o preço para seu desconto: ");
      preco = double.Parse (Console.ReadLine ());
      if (preco < 20.0) {
        desconto = preco * 0.1;
      } else {
        desconto = preco * 0.05;
      }
      Console.WriteLine ($"desconto: {desconto}\n");

      Console.Write ("utilizando expressão ternária\nInforme o preço para seu desconto: ");
      desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
      Console.WriteLine ($"desconto: {desconto}");
    }
  }
}