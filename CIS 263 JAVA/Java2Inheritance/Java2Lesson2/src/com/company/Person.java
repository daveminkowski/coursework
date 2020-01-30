package com.company;
import javax.swing.*;

public class Person {

    private String name;
    private String phoneNumber;

    // contructor call which requires input from user
    public Person()
    {
        setName();
        setNumber();
    }

    // pass name and number to constructor
    public Person(String userName, String userPhoneNum)
    {
        name = userName;
        phoneNumber = userPhoneNum;
    }

    // get user input for name
    private void setName()
    {
        name = JOptionPane.showInputDialog(null, "Enter contact's name:");
    }

    // get user input for number
    private void setNumber()
    {

        phoneNumber = JOptionPane.showInputDialog(null, "Enter contact's phone number:");

    }

    public String getName()
    {
        return name;
    }

    public String getNumber()
    {
        return phoneNumber;
    }

    @Override
    public String toString()
    {
        return (getName() + " - " + getNumber() + ".");
    }
}
