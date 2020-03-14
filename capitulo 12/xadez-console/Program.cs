using System;
using tabuleiro;

namespace xadez_console {
  class Program {
    static void Main (string[] args) {
      Tabuleiro tab = new Tabuleiro (8, 8);
      Console.WriteLine ($"Tabuleiro: {tab}");
    }
  }
}