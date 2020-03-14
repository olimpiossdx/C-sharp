using System;
using contaBancaria.Entities;
using contaBancaria.Entities.Exceptions;

/*
Fazer um programa para ler os dados de uma conta bancária e depois realizar um
saque nesta conta bancária, mostrando o novo saldo. Um saque não pode ocorrer
ou se não houver saldo na conta, ou se o valor do saque for superior ao limite de
saque da conta.

Exemplo:

Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 100.00
New balance: 400.00


Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 400.00
Withdraw error: The amount exceeds withdraw limit


Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 500.00
Withdraw limit: 300.00
Enter amount for withdraw: 800.00
Withdraw error: The amount exceeds withdraw limit


Enter account data
Number: 8021
Holder: Bob Brown
Initial balance: 200.00
Withdraw limit: 300.00
Enter amount for withdraw: 250.00
Withdraw error: Not enough balance
*/

namespace contaBancaria {
	class Program {
		static void Main (string[] args) {
			int number;
			string holder;
			double balance, withdrawLimit, amount;
			Account account;

			try {

				Console.WriteLine ("Enter account data");

				Console.Write ("Number: ");
				number = int.Parse (Console.ReadLine ());

				Console.Write ("Holder: ");
				holder = Console.ReadLine ();

				Console.Write ("Initial balance: ");
				balance = double.Parse (Console.ReadLine ());

				Console.Write ("Withdraw limit: ");
				withdrawLimit = double.Parse (Console.ReadLine ());

				account = new Account (number, holder, balance, withdrawLimit);

				Console.Write ("\nEnter amount for withdraw: ");
				amount = double.Parse (Console.ReadLine ());

				account.Withdraw (amount);

				Console.WriteLine ($"\n{account.ToString()}");

			} catch (DomainException e) {

				Console.WriteLine ($"Withdraw error: {e.Message}");
			}
		}
	}
}