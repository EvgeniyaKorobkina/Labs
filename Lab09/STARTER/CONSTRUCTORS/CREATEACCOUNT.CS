
using System;

class CreateAccount
{
<<<<<<< HEAD
    
    static void Write(BankAccount acc)
    {
    Console.WriteLine("Account number is {0}", acc.Number( ));
    Console.WriteLine("Account balance is {0}", acc.Balance( ));
    Console.WriteLine("Account type is {0}", acc.Type( ));
    Console.WriteLine("Transactions:");
    foreach (BankTransaction tran in acc.Transactions( ))
    {
    Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When( ), tran.Amount( ));
    }
    Console.WriteLine( );
    }

=======
    // Test Harness
    static void Main() 
    {

    }
      
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}",  acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
    }
>>>>>>> 542fab7bd76e235e703140b19647acb5c76bde73
}
