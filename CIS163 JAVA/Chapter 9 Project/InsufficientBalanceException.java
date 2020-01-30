// Created by Dave Minkowski on 11/29/2016

public class InsufficientBalanceException extends Exception {

    public InsufficientBalanceException()
    {
        super("Insufficient balance for withdrawal.");
    }

}
