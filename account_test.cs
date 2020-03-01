using System;
using NUnit.Framework;

[TestFixture]
public class Tester
{
public class Account
{
    public double Balance { get; private set; }
    public double OverdraftLimit { get; private set; }

    public Account(double overdraftLimit)
    {
        this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
        this.Balance = 0;
    }

    public bool Deposit(double amount)
    {
        if (amount >= 0)
        {
            this.Balance += amount;
            return true;
        }
        return false;
    }

    public bool Withdraw(double amount)
    {
        if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
        {
            this.Balance -= amount;
            return true;
        }
        return false;
    }
}
    private double epsilon = 1e-6;

    [Test]
    public void OverdraftLimit_Negative_Fails()
    {
        Account account = new Account(-20);
        
        Assert.AreEqual(0, account.OverdraftLimit, epsilon);
    }
    
    [Test]
    public void Deposit_Negative_Fails()
    {
        var account = new Account(0);
        
        Assert.AreEqual(false, account.Deposit(-199));
    }
    
    [Test]
    public void Withdraw_Negative_Fails()
    {
        var account = new Account(0);
        
        Assert.AreEqual(false, account.Withdraw(-199));
    }
    
    [Test]
    public void OverdraftLimit_Exceed_Fails()
    {
        var account = new Account(10);
        account.Deposit(20);
        
        Assert.AreEqual(false, account.Withdraw(199));
    }
    
    [Test]
    public void Deposit_Updates_Balance()
    {
        var account = new Account(0);
        
        account.Deposit(10);
        
        Assert.AreEqual(10, account.Balance);
    }
    
    [Test]
    public void Withdraw_Updates_Balance()
    {
        var account = new Account(10);
        
        account.Withdraw(10);
        
        Assert.AreEqual(-10, account.Balance);
    }
}
