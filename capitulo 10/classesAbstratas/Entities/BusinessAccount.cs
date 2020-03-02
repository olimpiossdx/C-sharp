namespace classesAbstratas.Entities {
  class BusinessAccount : Account {
    public double LoanLimit { get; set; } //limite para empréstimo

    public BusinessAccount () { }
    public BusinessAccount (int number, string holder, double balance, double loanLimit) : base (number, holder, balance) {
      LoanLimit = loanLimit;
    }
    public void Loan (double amount) { //empréstimo
      if (amount <= LoanLimit)
        Balance += amount; 
    }
  }
}