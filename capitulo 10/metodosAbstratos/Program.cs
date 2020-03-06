using System;
using System.Collections.Generic;
using metodosAbstratos.Entities;
using metodosAbstratos.Entities.Enums;

/*
  Métodos abstratos
  . São métodos que não possuem implementação
  . Métodos precisam ser abstratos quando a classe é genérica demais para contar sua implementação
  . Se uma classe possuir pelo menos um método abstrato,
    então esta classe também é abstrata
  . Notação UML: itálico

  exe: Fazer um progrma para ler os dados de N figuras (N fornecido pelo usuário), e depois mostrar
  as áreas destas figuras na mesma ordme em que foram digitadas.

      Enter the number os shapes: 2
      Shape #1 data:
      Rectangule or Circule (r/c)? r
      Color (Black/Blue/Red): Black
      Width: 4.0
      Height: 5.0
      Shape #2 data:
      Rectangule or Circule (r/c)? c
      Color (Black/Blue/Red): Red
      Radius: 3.0
      
      SHAPE AREAS:
      20.00
      28.27
*/

namespace metodosAbstratos {
  class Program {
    static void Main (string[] args) {
      int numberShapes;
      string shape;
      Color color;
      double width, height, radius;
      List<Shape> shapes = new List<Shape> ();

      Console.Write ("Enter the number os shapes: ");
      numberShapes = int.Parse (Console.ReadLine ());
      for (int i = 0; i < numberShapes; i++) {

        Console.WriteLine ($"Shape #{i+1} data:");

        Console.Write ("Rectangule or Circule (r/c)? ");
        shape = Console.ReadLine ();

        Console.Write ("Color (Black/Blue/Red)? ");
        color = Enum.Parse<Color> (Console.ReadLine ());

        if (shape == "r") {

          Console.Write ("Width: ");
          width = double.Parse (Console.ReadLine ());

          Console.Write ("Height: ");
          height = double.Parse (Console.ReadLine ());

          shapes.Add (new Rectangule (color, width, height));

        } else {
          Console.Write ("Radius: ");
          radius = double.Parse (Console.ReadLine ());

          shapes.Add (new Circule (color, radius));
        }
      }
      Console.WriteLine ("\nSHAPE AREAS:");
      foreach (Shape itemShape in shapes)
        Console.WriteLine (itemShape.Area ().ToString ("F2"));

    }
  }
}