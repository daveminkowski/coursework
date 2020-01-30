package com.company;

import javax.swing.*;

public class HighBalanceException extends Exception {

    public HighBalanceException() {
        super("Customer balance is high");
    }
}
