using System;
using System.IO;
/*
  Bloco finally: é um bloco que contém código a ser executado independentemente de ter ocorrido ou não execução.
  Exemplço básico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
*/

namespace blocoFinally {
  class Program {
    static void Main (string[] args) {
      FileStream fs = null;
      try {
        fs = new FileStream (@"data.txt", FileMode.Open);
        StreamReader sr = new StreamReader (fs);
        string line = sr.ReadLine ();
      } catch (FileNotFoundException e) {
        Console.WriteLine (e.Message);
      } finally {
        if (fs != null)
          fs.Close ();
      }

    }
  }
}