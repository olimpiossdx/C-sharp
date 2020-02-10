using System;

namespace boxUnboxing {
  class Program {
    static void Main (string[] args) {
      int x = 20;
      //Box -> processo de conversão de um tipo valor para um objeto tipo referência
      Object obj = x;

      //Unboxing -> processo de conversão de um objeto tipo referência para um objeto tipo valor compatível
      int y = (int) obj;
    }
  }
}