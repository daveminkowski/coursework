/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class SmartCar extends Car {

    private boolean isCharging;

    public SmartCar(){

    }

    public SmartCar(String inputCarMake, String inputCarModel, int chargeStatus){
        super.carMake = inputCarMake;
        super.carModel = inputCarModel;

        if (chargeStatus == 1)
        {
            isCharging = true;
        }
        else
        {
            isCharging = false;
        }
    }

    public void setChargingStatus(int chargeStatus)
    {
        if (chargeStatus == 1)
        {
            isCharging = true;
        }
        else
        {
            isCharging = false;
        }
    }

    public void getChargingStatus()
    {
        if (isCharging)
        {
            System.out.println("The " + super.getModel() + " is charging right now.");
        }
        else
        {
            System.out.println("The " + super.getModel() + " is fully charged.");
        }
    }

    @Override
    public void displayDetails(){
        super.displayDetails();
        getChargingStatus();
    }
}
