/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Camaro extends Car{

    private int speed;

    public Camaro(){

    }

    public Camaro(String inputCarMake, String inputCarModel, int inputCarSpeed){
        super.carMake = inputCarMake;
        super.carModel = inputCarModel;
        speed = inputCarSpeed;
    }

    public int getSpeed() {
        return speed;
    }

    public void setSpeed(int inputSpeed) {
        speed = inputSpeed;
    }


    public void displaySpeed() {
        System.out.println("The " + getModel() + " has a top speed of " + getSpeed() + " mph.");
    }

    @Override
    public void displayDetails(){
        super.displayDetails();
        displaySpeed();
    }
}
