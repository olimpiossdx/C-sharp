using System;
using System.Collections.Generic;
using impostDeRenda.Entities;
using impostoDeRenda.Entities;
/*

Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais
podem ser pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
bem como o total de imposto arrecadado.

Os dados de pessoa física são: nome, renda anual e gastos com saúde. Os dados de pessoa jurídica
são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as seguintes:

Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto. Pessoas com
renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto
fica: (50000 * 25%) - (2000 * 50%) = 11500.00

Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10
funcionários, ela paga 14% de imposto.
Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica:
400000 * 14% = 56000.00
exemplo de entrada:

Enter the number if tax payers: 3
Tax payer #1 data: 
Individual or company (i/c)? i
Name: Alex
Anual income: 50000.0
Health expenditures: 2000.0
Tax payer #2 data: 
Individual or company (i/c)? c
Name: SoftTech
Anual income: 400000.0
Number of employees: 5
Tax payer #3 data: 
Individual or company (i/c)? i
Name: Bob
Anual income: 120000.0
Health expenditures: 1000.0

TAXES PAID:
Alex: $ 115000
SoftTech: $ 560000
Bob: $ 295000

TOTAL TAXES:$ 97000.00
*/

namespace impostoDeRenda {
  class Program {
    static void Main (string[] args) {
      int payers, employees;
      string name;
      string taxes;
      double taxesValue, anualIncome, totalTaxes = 0.0;
      List<Person> contribuintes = new List<Person> ();

      Console.Write ("Enter the number if tax payers: ");
      payers = int.Parse (Console.ReadLine ());

      for (int i = 0; i < payers; i++) {

        Console.WriteLine ($"Tax payer #{i+1} data: ");

        Console.Write ("Individual or company (i/c)? ");
        taxes = Console.ReadLine ();

        Console.Write ("Name: ");
        name = Console.ReadLine ();

        if (taxes.ToString () == "c") {
          Console.Write ("Anual income: ");
          anualIncome = double.Parse (Console.ReadLine ());

          Console.Write ("Number of employees: ");
          employees = int.Parse (Console.ReadLine ());

          contribuintes.Add (new Company (name, anualIncome, employees));

        } else {

          Console.Write ("Anual income: ");
          anualIncome = double.Parse (Console.ReadLine ());

          Console.Write ("Health expenditures: ");
          taxesValue = double.Parse (Console.ReadLine ());

          contribuintes.Add (new Individual (name, anualIncome, taxesValue));
        }
      }

      Console.WriteLine ("\nTAXES PAID:");
      foreach (Person person in contribuintes) {
        totalTaxes += person.Tax ();
        Console.WriteLine (person.ToString ());
      }
      Console.WriteLine ($"\nTOTAL TAXES:$ {totalTaxes.ToString("F2")}");
    }
  }
}