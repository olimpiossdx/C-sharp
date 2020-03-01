using employeeOrOutSourced.Entities;
namespace employeeOrOutSourced.Entities {
  class OutSourceEmployee : Employee {
    public double AdditionalCharge { get; set; }

    public OutSourceEmployee () { }
    public OutSourceEmployee (string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour) {
      AdditionalCharge = additionalCharge;
    }

    public override double Payment () {
      return ((Hours * ValuePerHour) + (AdditionalCharge * 1.1));
    }

    public override string ToString () {
      return ($"{Name} - $ {Payment().ToString("F2")}");
    }
  }
}