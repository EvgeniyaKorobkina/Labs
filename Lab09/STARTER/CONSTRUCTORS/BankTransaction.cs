using System;
using System.Collections;

class BankTransaction
{
    private readonly decimal amount;
    private readonly DateTime when;

    public decimal Amount()
    {
        return amount;
    }

    public DateTime When()
    {
        return when;
    }
    public BankTransaction(decimal tranAmount)
    {
        amount = tranAmount;
        when = DateTime.Now;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal;
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
        }
        return sufficientFunds;
    }


    private Queue tranQueue = new Queue();
}