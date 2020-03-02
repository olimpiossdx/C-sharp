namespace classesAbstratas.Entities {
  class SavingAccount : Account {
    public double InterestRate { get; set; } //taxa de juros

    public SavingAccount () { }
    public SavingAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance) {
      InterestRate = interestRate;
    }
    public void UpdateBalance () {
      Balance += Balance * InterestRate;
    }
    public override void Withdraw (double amount) {
      //Balance -= amount + 2.0;
      //aproveitando a palavra base 
      base.Withdraw (amount);
      Balance -= 2.0;
    }
  }
}