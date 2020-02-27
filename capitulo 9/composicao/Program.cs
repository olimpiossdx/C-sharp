using System;
using composicao.Entities;
using composicao.Entities.Enums;

/*
 Ler os dados de um trabalho com N contratos (N fornecido pelo usuário). 
 Depois, solicitar do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo:
 
 ------------------------------------------------------------------------------------------------------------
 tipo de associação que permite que um objeto contenha outro.
Relação "tem-um" ou "tem-vários"

vantagens
.Organização: divisão de responsabilidades
.Coesão
.FLexibilidade
.Reuso
*/
namespace composicao {
  class Program {
    static void Main (string[] args) {
      short qtdContracts, hoursDuration; 
      int year, month;
      string name;
      Departament departament;
      double baseSalary;
      DateTime dateIncome;
      WorkerLevel workerLevel;
      Worker worker = new Worker ();

      Console.Write ("Enter departament's name: ");
      departament = new Departament (Console.ReadLine ());
      Console.WriteLine ("Enter worker data: ");
      Console.Write ("Name: ");
      name = Console.ReadLine ();
      Console.Write ("Level (junior/MidLevel/Senior): ");
      workerLevel = Enum.Parse<WorkerLevel> (Console.ReadLine ());
      Console.Write ("Base salary: ");
      baseSalary = double.Parse (Console.ReadLine ());

      worker = new Worker (name, workerLevel, baseSalary, departament);

      Console.Write ("\nHow many contracts to this worker? ");
      qtdContracts = short.Parse (Console.ReadLine ());
      for (int i = 0; i < qtdContracts; i++) {
        Console.WriteLine ($"Enter #{i+1} contract data: ");
        Console.Write ("Date (DD/MM/YY): ");
        dateIncome = DateTime.Parse (Console.ReadLine ());
        Console.Write ("Value por hour: ");
        baseSalary = double.Parse (Console.ReadLine ());
        Console.Write ("Duration (hours): ");
        hoursDuration = short.Parse (Console.ReadLine ());
        worker.AddContract (new HourContract (dateIncome, baseSalary, hoursDuration));
      }

      Console.Write ("\nEnter month and year to calculate income (MM/YYY): ");
      dateIncome = DateTime.Parse (Console.ReadLine ());
      year = int.Parse (dateIncome.Year.ToString());
      month = int.Parse (dateIncome.Month.ToString());
      Console.WriteLine ($"Name: {worker.Name}");
      Console.WriteLine ($"Departament: {worker.Departament}");
      Console.WriteLine ($"Income for {dateIncome.ToString()} {worker.Income(year,month).ToString("F2")}");

    }
  }
}