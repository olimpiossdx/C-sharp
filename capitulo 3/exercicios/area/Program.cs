using System;
/*
Área
Adaptado por Neilor Tonin, URI  Brasil

Timelimit: 1
Escreva um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
Entrada
O arquivo de entrada contém três valores com um dígito após o ponto decimal.

Saída
O arquivo de saída deverá conter 5 linhas de dados. Cada linha corresponde a uma das áreas descritas acima, sempre com mensagem correspondente e um espaço entre os dois pontos e o valor. O valor calculado deve ser apresentado com 3 dígitos após o ponto decimal.

*/
namespace area {
  class Program {
    static double AreaTrianguloRetangulo (double A, double B, double C) {
      return (A * C) / 2;
    }
    static double areaCirculo (double A, double B, double C) {
      return C * C * 3.14159;
    }
    static double areaTrapezio (double A, double B, double C) {
      return ((A + B) * C) / 2;
    }
    static double areaQuadrado (double A, double B, double C) {
      return B * B;
    }
    static double areaRetangulo (double A, double B, double C) {
      return A * B;
    }

    static void Main (string[] args) {
      string[] vetInput;
      double A, B, C;
      vetInput = Console.ReadLine ().Split (' ');

      A = double.Parse (vetInput[0]);
      B = double.Parse (vetInput[1]);
      C = double.Parse (vetInput[2]);
      Console.WriteLine ($"TRIANGULO: {AreaTrianguloRetangulo(A, B, C):F3}\nCIRCULO: {areaCirculo(A, B, C):F3}\nTRAPEZIO: {areaTrapezio(A, B, C):F3}\nQUADRADO: {areaQuadrado(A, B, C):F3}\nRETANGULO: {areaRetangulo(A, B, C):F3}");
    }
  }
}