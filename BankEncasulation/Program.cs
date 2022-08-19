using BankEncapsulation;

BankAccount myAccount = new BankAccount();

Console.WriteLine("How much would you like to deposit?");
var amountToDeposit = double.Parse(Console.ReadLine());

myAccount.Deposit(amountToDeposit);

Console.WriteLine(myAccount.GetBalance());