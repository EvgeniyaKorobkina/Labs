
using System;

class CreateAccount
    {
    static void Main( )
        {
        BankAccount berts = NewBankAccount( );
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithdraw(berts);
        Write(berts);

        BankAccount freds = NewBankAccount( );
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithdraw(freds);
        Write(freds);
        }

    
    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();
        
        //Console.Write("Enter the account number   : ");
        //long number = long.Parse(Console.ReadLine());        
       // long number = BankAccount.NextNumber( );
       created.Populate(balance);

        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());
        
        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;
        created.Populate(number, balance);
        //return created
       } 
    public static void TestDeposit(BankAccount acc)
{
Console.Write("Enter amount to deposit: ");
decimal amount = decimal.Parse(Console.ReadLine());
acc.Deposit(amount);
}

  public static void TestWithdraw(BankAccount acc)
{
Console.Write("Enter amount to withdraw: ");
decimal amount = decimal.Parse(Console.ReadLine());
if (!acc.Withdraw(amount)) {
Console.WriteLine("Insufficient funds.");
}
}
      
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}", toWrite.Number( ));
        Console.WriteLine("Account balance is {0}", toWrite.Balance( ));
        Console.WriteLine("Account type is {0}", toWrite.Type( ));

    }
}

