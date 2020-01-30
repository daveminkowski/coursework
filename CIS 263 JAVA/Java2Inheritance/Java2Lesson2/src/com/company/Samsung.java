package com.company;

public class Samsung implements Phone {

    public Samsung()
    {

    }

    public void call(Person obj)
    {
        System.out.println("Call " + obj.getName() + " at " + obj.getNumber() + " on Samsung.");
    }

    public void text()
    {
        System.out.println("Text Samsung");
    }

    public void end()
    {
        System.out.println("End Samsung");
    }
}
