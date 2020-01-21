using System;
using System.Globalization;

namespace saidaPadrao {
  class Program {
    static void Main (string[] args) {
      Console.Write ("[wirte]Bom dia!");
      System.Console.WriteLine ("[WriteLine]Boa tarde !");
      System.Console.WriteLine ("Boa noite!");
      System.Console.WriteLine ("------------------------------");
      
      //impressãor de variáveis
      char genero = 'f';
      int idade = 32;
      double salado = 10.35784;
      string nome = "Maria";
      System.Console.WriteLine ("genero " + genero);
      System.Console.WriteLine ("idade " + idade);
      System.Console.WriteLine ("saldo " + salado);
      System.Console.WriteLine ("nome " + nome);
      System.Console.WriteLine ("salado[formatado com 2 casas(F2)] " + salado.ToString ("f2"));
      System.Console.WriteLine ("salado[formatado com 2 casas(F4)] " + salado.ToString ("F4"));
      //formatação sem utilizar padrão do pc, utilizando Globalization;
      System.Console.WriteLine ("salado[formatado com 2 casas(F4)] " + salado.ToString ("F4", CultureInfo.InvariantCulture));

      //placeholders, concatenação e interpolação

      int idade1 = 32;
      double saldo2 = 10.35784;
      string nome1 = "jujé";

      //placeholders
      System.Console.WriteLine ("\nplaceholders");
      System.Console.WriteLine ("{0} tem {1} anos e tem saldo igual a {2} reais", nome1, idade1, saldo2);
      System.Console.WriteLine ("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome1, idade1, saldo2);

      //interpolção, apareceu depois de c#6 
      System.Console.WriteLine ("\nInterpolação");
      System.Console.WriteLine ($"{nome1} tem {idade1} e tem saldo igual a {saldo2:F2} reais");
      
      //Concatenação
      System.Console.WriteLine (nome1 + " tem " + idade1 + " e tem saldo igual " + saldo2.ToString ("F2") + " reais");
    }
  }
}