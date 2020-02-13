using System;
using System.Collections.Generic;

namespace aumentoFuncionario {
  class Program {
    static void Main (string[] args) {
      short registered;
      int id, index;
      double increase;;

      List<Employee> employees = new List<Employee> ();
      Employee emp1;

      Console.Write ("How many employee will be registered? ");
      registered = short.Parse (Console.ReadLine ());

      for (int i = 0; i < registered; i++) {
        string name;
        double salary;

        Console.WriteLine ($"Employee #{i+1}:");
        Console.Write ("Id: ");
        id = int.Parse (Console.ReadLine ());

        Console.Write ("Name: ");
        name = Console.ReadLine ();

        Console.Write ("Salary: ");
        salary = double.Parse (Console.ReadLine ());

        employees.Add (new Employee (id, name, salary));

        Console.WriteLine ();
      }

      Console.Write ("Enter the employee id that will have salary increase: ");
      id = int.Parse (Console.ReadLine ());
      emp1 = employees.Find (f => f._id == id);
      index = employees.FindIndex (f => f._id == id);

      if (emp1 != null) {
        Console.Write ("Enter the percentage: ");
        increase = short.Parse (Console.ReadLine ());
        emp1.IncreaseSalary (increase);
        employees.RemoveAt (index);
        employees.Insert (index, emp1);
      } else {
        Console.WriteLine ("This id does not exists!");
      }

      Console.WriteLine ("\nUpdated list of employees:");
      foreach (Employee employee in employees) {
        Console.WriteLine (employee.ToString ());
      }
    }
  }
}