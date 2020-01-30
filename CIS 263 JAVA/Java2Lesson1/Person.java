/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Person {

    private int age;
    private String name;

    public int getAge()
    {
        return age;
    }

    public String getName()
    {
        return name;
    }

    public void setAge(int inputAge)
    {
        age = inputAge;
    }

    public void setName(String inputName)
    {
        name = inputName;
    }

    public void displayDetails(){
        System.out.println("This is " + getName() + ".");
        System.out.println(this.name + "'s age is " + getAge() + ".");
    }

}
