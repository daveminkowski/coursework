package com.company;

public class iPhone implements Phone {

    public iPhone()
    {

    }

    public void call(Person obj)
    {
        System.out.println("Call " + obj.getName() + " at " + obj.getNumber() + " on iPhone.");
    }

    public void text()
    {
        System.out.println("Text iPhone");
    }

    public void end()
    {
        System.out.println("End iPhone");
    }



}
