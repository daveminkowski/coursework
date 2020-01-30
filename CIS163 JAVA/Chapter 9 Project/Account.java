// Created by Dave Minkowski on 11/29/2016

public class Account {

    private double balance;

    public Account() //constructor
    {
        balance = 0;
    }

    public Account(double initialDeposit)
    {
        balance = initialDeposit;
    }

    public double getBalance()
    {
        return balance;
    }
    // returns new balance or throw NegativeAmountException
    public double deposit(double amount) throws NegativeAmountException
    {
        if (amount > 0)
            balance +=amount;
        else
            throw new NegativeAmountException();
        return balance;
    }
// returns new balance or throws NegativeAmountException or InsufficientBalanceException
    public double withdraw(double amount) throws NegativeAmountException, InsufficientBalanceException
    {
        if (amount > balance)
        throw new InsufficientBalanceException();
        else if
            (amount < 0)
            throw new NegativeAmountException();
        else
            balance -= amount;
        return balance;
    }

    public static void main(String[] args)
    {
        Account checking = new Account(20000);
        try {
            checking.deposit(5000);
            checking.withdraw(1600);
            System.out.println("Your new balance is " + checking.getBalance());
        }
        catch (Exception e)
        {
            System.out.println(e.getMessage());
        }

    }
}
