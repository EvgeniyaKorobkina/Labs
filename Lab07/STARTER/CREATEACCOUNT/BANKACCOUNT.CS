
<<<<<<< HEAD
class BankAccount
{
public void Populate(long number, decimal balance)
     
        public long Number( )
            {
            return accNo;
            }


        public decimal Balance( )
            {
            return accBal;
            }

        public AccountType Type( )
            {
            return accType;
            }

        public string Type( )
            {
            return accType.ToString( );
            }

//{
//accNo = number;
//accBal = balance;
//accType = AccountType.Checking;
//}
private long accNo;
private decimal accBal;
private AccountType accType;

=======
class BankAccount 
{
    public void Populate(decimal balance)
    {
        accNo = NextNumber;
        accBal = balance;
        accType = AccountType.Checking;
    }
    
    public long Number()
    {
        return accNo;
    }
    
    public decimal Balance()
    {   
        return accBal;
    }
    
    public string Type()
    {
        return accType.ToString();
    }
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
>>>>>>> 542fab7bd76e235e703140b19647acb5c76bde73
}
