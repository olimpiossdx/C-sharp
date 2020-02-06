using System;

namespace contaBancaria {
  class ContaBancaria {
    public string Titular { get; private set; }
    public string Conta { get; private set; }
    public double Saldo { get; set; }

    public ContaBancaria (string titular, string conta) {
      Titular = titular;
      Conta = conta;
    }
    public ContaBancaria (string titular, string conta, double saldo) {
      Titular = titular;
      Conta = conta;
      Saldo = saldo;
    }
    public void Deposito (double saldo) {
      Saldo += saldo;
    }
    public void Saque (double saldo) {
      Saldo += -saldo - 5.00;
    }

    public override string ToString () {
      return $"Conta: {Conta}, Titular: {Titular}, Saldo: $ {Saldo:F2}";
    }
  }
}