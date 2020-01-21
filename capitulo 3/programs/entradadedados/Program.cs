using System;
using System.Globalization;

namespace entradadedados {
  class Program {
    static void Main (string[] args) {
      //Entrada de dados parte 1
      //obs: Console.ReadLine() realiza leitura na fora de string;
      // string frase = Console.ReadLine ();
      // string x = Console.ReadLine ();
      // string y = Console.ReadLine ();
      // string z = Console.ReadLine ();
      // string[] v = Console.ReadLine ().Split (' ');
      // string a = v[0];
      // string b = v[1];
      // string c = v[2];

      // System.Console.WriteLine ("Você digitou: \n" + frase);
      // System.Console.WriteLine (x);
      // System.Console.WriteLine (y);
      // System.Console.WriteLine (z);
      // System.Console.WriteLine (a);
      // System.Console.WriteLine (b);
      // System.Console.WriteLine (c);

      //Entrada de dados parte 2

      //int n1 = Console.Read ();
      // or
      int n1 = int.Parse (Console.ReadLine ());
      char ch = char.Parse (Console.ReadLine ());
      double n2 = double.Parse (Console.ReadLine ());
      // utilize use System.Globalization e depois CultureInfo.InvariantCulture, para digitar 4.5
      //double n2 = double.Parse (Console.ReadLine (),CultureInfo.InvarianteCulture);

      string[] vet = Console.ReadLine ().Split (' ');
      string nome = vet[0];
      char sexo = char.Parse (vet[1]);
      int idade = int.Parse (vet[2]);
      double altura = double.Parse (vet[3], CultureInfo.InvariantCulture);

      System.Console.WriteLine ("Você digitou:");
      System.Console.WriteLine (n1);
      System.Console.WriteLine (ch);
      System.Console.WriteLine (n2);
      System.Console.WriteLine(nome);
      System.Console.WriteLine(sexo);
      System.Console.WriteLine(idade);
      System.Console.WriteLine(altura);

    }
  }
}