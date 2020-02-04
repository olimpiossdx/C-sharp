using System;

namespace primitivos {
  class Program {
    static void Main (string[] args) {
      sbyte x = 100;
      byte n1 = 126;
      int n2 = 2147483647;
      long n3 = 2147483648L;

      bool uia = false;
      char genero = 'F'; // char utiliza (aspas simples) ' '
      char letra = '\u0041'; //unicode A
      float n4 = 4.5f;
      double n5 = 4.5d; // utiliza o padrão de formatação de saída padrão de acordo com computador; 4,5
      string nome = "zueira string"; // string utiliza (aspas duplas )" "
      object obj1 = "zueira object"; // objeto genérico (aceita qualquer coisa)
      object obj2 = 4.5f;

      int min = int.MinValue;
      int max = int.MaxValue;
      sbyte n6 = sbyte.MaxValue;
      decimal n7 = decimal.MaxValue;

      //Restrições e coanveões para nomes 
      //Camel case (parâmetros de métodos, variáveis dentro de métodos)
      //Pascal case: (namespace, classe, properties e métodos)
      //Padrão: (atribusto "internos" da classe)

      // atalho para escrever console.writeLine cw
      Console.WriteLine ("sbyte " + x);
      Console.WriteLine ("byte " + n1);
      Console.WriteLine ("nome " + nome);
      Console.WriteLine ("obj1 " + obj1);
      System.Console.WriteLine ("int " + n2);
      System.Console.WriteLine ("long " + n3);
      System.Console.WriteLine ("bool " + uia);
      System.Console.WriteLine ("genero " + genero);
      System.Console.WriteLine ("letra " + letra);
      System.Console.WriteLine ("float " + n4);
      System.Console.WriteLine ("double " + n5);
      System.Console.WriteLine ("objeto 1" + obj1);
      System.Console.WriteLine ("min [int] " + min);
      System.Console.WriteLine ("max [max] " + max);
      System.Console.WriteLine ("sbyte[max] " + obj2);
      System.Console.WriteLine ("decimal[max] " + n7);
    }
  }
}