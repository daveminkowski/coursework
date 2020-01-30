/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class Bear extends Animal {

    private boolean isHibernating;

    public void setHibernationStatus(int sleepStatus)
    {
        if (sleepStatus == 1)
        {
            isHibernating = true;
        }
        else
        {
            isHibernating = false;
        }
    }

    public void getHibernationStatus()
    {
       if (isHibernating)
       {
           System.out.println(super.getName() + " is hibernating right now.");
       }
       else
       {
           System.out.println(super.getName() + " is not hibernating right now.");
       }
    }


    @Override
    public void displayDetails(){
        super.displayDetails();
        getHibernationStatus();
        System.out.println("");
    }
}
