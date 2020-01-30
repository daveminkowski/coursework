/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
                user created classes and inheritance
 ************************************************************************************************/
package com.company;

public class CarDemo {

    public static void main(String[] args){

        Car f150 = new Car("Ford", "F150");
        f150.displayDetails();

        Car camaro = new Camaro("Chevy", "Camaro", 124);
        camaro.displayDetails();

        Camaro camaro2 = new Camaro();
        camaro2.setMake("Chevrolet");
        camaro2.setModel("Camaro SS");
        camaro2.setSpeed(155);
        camaro2.displayDetails();

        Car smartCar = new SmartCar("Smart", "Fortwo", 0);
        smartCar.displayDetails();

        SmartCar smartCar2 = new SmartCar();
        smartCar2.setMake("Smart");
        smartCar2.setModel("Limited");
        smartCar2.setChargingStatus(1);
        smartCar2.displayDetails();
    }
}
