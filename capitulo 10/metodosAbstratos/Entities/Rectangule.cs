using metodosAbstratos.Entities.Enums;

namespace metodosAbstratos.Entities {
  class Rectangule : Shape {
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangule () { }
    public Rectangule (Color color, double width, double heigth) : base (color) {
      Width = width;
      Height = heigth;
    }

    public override double Area () {
      return (Width * Height);
    }
  }
}



