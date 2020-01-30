/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Shark extends Animal{

    private boolean isInWater;

    public void setWaterStatus(int swimStatus)
    {
        if (swimStatus == 1)
        {
            isInWater = true;
        }
        else
        {
            isInWater = false;
        }
    }

    public void getWaterStatus()
    {
        if (isInWater)
        {
            System.out.println(super.getName() + " is in the water!");
        }
        else
        {
            System.out.println(super.getName() + " is NOT in the water.");
        }
    }


    @Override
    public void displayDetails(){
        super.displayDetails();
        getWaterStatus();
        System.out.println("");
    }
}
