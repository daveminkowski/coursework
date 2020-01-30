/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Animal {

    private int age;
    private String name;
    private String size;
    private String food;

    public int getAge()
    {
        return age;
    }

    public String getName()
    {
        return name;
    }

    public String getSize()
    {
        return size;
    }

    public String getFood()
    {
        return food;
    }

    public void setAge(int inputAge)
    {
        age = inputAge;
    }

    public void setName(String inputName)
    {
        name = inputName;
    }

    public void setSize(String inputSize)
    {
        size = inputSize;
    }

    public void setFood(String inputFood)
    {
        food = inputFood;
    }

    public void displayDetails(){
        System.out.println("Species: " + getName() + ".");
        System.out.println("Lifespan: Around " + getAge() + " years.");
        System.out.println("Size Range: " + getSize());
        System.out.println("Diet: " + getFood());
    }
}
