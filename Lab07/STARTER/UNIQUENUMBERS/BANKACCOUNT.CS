
class BankAccount 
{
<<<<<<< HEAD
    public void Populate(decimal balance)
    {
        accNo = NextNumber;
=======
    public void Populate(long number, decimal balance)
    {
        accNo = number;
>>>>>>> 542fab7bd76e235e703140b19647acb5c76bde73
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
<<<<<<< HEAD
    {   
=======
    {
>>>>>>> 542fab7bd76e235e703140b19647acb5c76bde73
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
<<<<<<< HEAD
    public static long NextNumber( )
    {
    return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
    accBal += amount;
    return accBal;
    }

    public bool Withdraw(decimal amount)
{
bool sufficientFunds = accBal >= amount;
if (sufficientFunds) {
accBal -= amount;
}
return sufficientFunds;
}


    private static long NextNumber( )
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo;
=======
    
    private long accNo;
    private decimal accBal;
    private AccountType accType;
>>>>>>> 542fab7bd76e235e703140b19647acb5c76bde73
}
