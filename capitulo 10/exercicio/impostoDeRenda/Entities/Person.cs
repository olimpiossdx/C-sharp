namespace impostDeRenda.Entities {
  abstract class Person {
    public string Name { get; set; }
    public double AnualIncome { get; set; }
    public Person () { }
    public Person (string name, double anualIncome) {
      Name = name;
      AnualIncome = anualIncome;
    }
    public abstract double Tax ();

    public override string ToString () {
      return ($"{Name}: $ {Tax()}");
    }
  }
}