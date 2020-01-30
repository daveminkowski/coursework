/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Car {

    protected String carMake;
    protected String carModel;

    public String getMake() {
        return carMake;
    }

    public String getModel() {
        return carModel;
    }

    public void setMake(String inputMake) {
        carMake = inputMake;
    }

    public void setModel(String inputModel) {
        carModel = inputModel;
    }

    public Car(){

    }

    public Car(String inputCarMake, String inputCarModel){
        carMake = inputCarMake;
        carModel = inputCarModel;
    }

    public void displayDetails(){
        System.out.println("");
        System.out.println("This vehicle is a " + getMake() + " " + getModel() + ".");
    }
}
