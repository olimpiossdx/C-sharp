using System;
using impostDeRenda.Entities;
namespace impostoDeRenda.Entities {
  class Individual : Person {
    public double Health { get; set; }

    public Individual () { }
    public Individual (string name, double anualIncome, double health) : base (name, anualIncome) {
      Health = health;
    }
    public override double Tax () {
      if (AnualIncome <= 20000.00) {
        return (AnualIncome * 0.15);
      } else if (AnualIncome >= 20000.00 && Health != 0) {
        return ((AnualIncome * 0.25) - (Health * 0.50));
      } else {
        return (AnualIncome * 0.25);
      }
    }
  }
}