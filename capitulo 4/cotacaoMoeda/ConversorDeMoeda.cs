using System;

namespace cotacaoMoeda {
  class ConversorDeMoeda {
    public static double Iof = 6;
    public static double PagoEmReais (double cotacao, double valor) {
      return ((cotacao * valor) * Iof / 100) + (cotacao * valor);
    }
  }
}