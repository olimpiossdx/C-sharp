using System;
using metodosAbstratos.Entities.Enums;

namespace metodosAbstratos.Entities {
  class Circule : Shape {
    public double Radius { get; set; }

    public Circule () { }
    public Circule (Color color, double radius) : base (color) {
      Radius = radius;
    }

    public override double Area () {
      return (Math.PI * Radius * Radius);
    }
  }
}