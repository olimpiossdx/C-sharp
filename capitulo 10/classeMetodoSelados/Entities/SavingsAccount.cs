namespace classeMetodoSelados.Entities {
  class SavingAccount : Account {
    public double InterestRate { get; set; } //taxa de juros

    public SavingAccount () { }
    public SavingAccount (int number, string holder, double balance, double interestRate) : base (number, holder, balance) {
      InterestRate = interestRate;
    }
    public void UpdateBalance () {
      Balance += Balance * InterestRate;
    }

    public sealed override void Withdraw (double amount) { // permite que este método não seja sobreescrito ou sobreposto novamente
      //Balance -= amount + 2.0;
      //aproveitando a palavra base 
      base.Withdraw (amount);
      Balance -= 2.0;
    }
  }
}