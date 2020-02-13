namespace aumentoFuncionario {
  class Employee {
    public int _id { get; private set; }
    public string _name { get; private set; }
    public double _salary { get; private set; }
    public Employee (int id, string name, double salary) {
      _id = id;
      _name = name;
      _salary = salary;
    }
    public void IncreaseSalary (double percentage) {
      _salary += (percentage * _salary) / 100;
    }
    public override string ToString () {
      return $"{_id}, {_name}, {_salary}";
    }
  }
}