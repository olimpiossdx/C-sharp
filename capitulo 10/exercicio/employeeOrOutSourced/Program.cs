using System;
using System.Collections.Generic;
using employeeOrOutSourced.Entities;

/* Uma empresa possui funcionários próprios e terceirizados.
   Para cada funcionário, deseja-se registrar nome, horas
   trabalhadas e o vlaor por hora. Funcionários terceirizados
   possuem ainda um despesa adicional.

   O pagamento dos funcionários corresponde ao valor da hora
   multiplicado pelas horas trabalhadas, sendo que os funci-
   onários terceirizados ainda recebem um bônus correspondente
   a 110% de sua despesa adicional.

   Fazer um programa para ler o dados de N funcionários (N
   fornecido pelo usuário) e armazená-los em uma lista. Depois
   de ler os dados, mostrar nome e pagamento de cada funcionário
   na mesma ordem em que foram digitados.

   Construa o programa conform o projeto ao ladoo. Veja exemplo
   na próxima página.
   ex:
    Enter the numbers of employee: 3
    Employee #1
    Outsourced:(y/n) n
    Name: Alex
    Hours: 50
    Value per Hours: 20,0
    Employee #2
    Outsourced:(y/n) y
    Name: Bob
    Hours: 100
    Value per Hours15,0
    Additional charge: 200,0
    Employee #3
    Outsourced:(y/n) n
    Name: Maria
    Hours: 60
    Value per Hours; 20,0

    PAYMENTS
    Alex - $ 1000,00
    Bob - $ 1720,00
    Maria - $ 1200,00
*/

namespace employeeOrOutSourced {
  class Program {
    static void Main (string[] args) {
      int numberEmployees, hours;
      string outsourced, name;
      double valuePerHour, addCharge;
      List<Employee> employees = new List<Employee> ();

      Console.Write ("Enter the numbers of employee: ");
      numberEmployees = int.Parse (Console.ReadLine ());

      for (int i = 0; i < numberEmployees; i++) {
        Console.WriteLine ($"Employee #{i+1}");

        Console.Write ("Outsourced:(y/n) ");
        outsourced = Console.ReadLine ();

        Console.Write ("Name: ");
        name = Console.ReadLine ();

        Console.Write ("Hours: ");
        hours = int.Parse (Console.ReadLine ());

        Console.Write ("Value per Hours: ");
        valuePerHour = double.Parse (Console.ReadLine ());

        if (outsourced == "y") {
          Console.Write ("Additional charge: ");
          addCharge = double.Parse (Console.ReadLine ());
          employees.Add (new OutSourceEmployee (name, hours, valuePerHour, addCharge));
        } else {
          employees.Add (new Employee (name, hours, valuePerHour));
        }
      }

      Console.WriteLine ("\nPAYMENTS");
      foreach (Employee employee in employees)
        Console.WriteLine (employee.ToString ());
    }
  }
}