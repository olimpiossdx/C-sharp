using impostDeRenda.Entities;
namespace impostoDeRenda.Entities {
  class Company : Person {
    public int Employees { get; set; }
    public Company () { }
    public Company (string name, double anualIncome, int employees) : base (name, anualIncome) {
      Employees = employees;
    }

    public override double Tax () {
      if (Employees > 10) {
        return AnualIncome * 0.14;
      } else {
        return AnualIncome * 0.16;
      }
    }
  }
}