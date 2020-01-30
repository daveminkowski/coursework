/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class AnimalDemo {

    public static void main(String[] args){

        Bear yogi = new Bear();
        yogi.setAge(25);
        yogi.setName("Grizzly Bear");
        yogi.setFood("Omnivore");
        yogi.setSize("5-10 feet tall/up to 1300 pounds.");
        yogi.setHibernationStatus(0);

        Shark jaws = new Shark();
        jaws.setAge(70);
        jaws.setName("Great White Shark");
        jaws.setFood("Carnivore");
        jaws.setSize("11-21 feet long/up to 2400 pounds.");
        jaws.setWaterStatus(1);

        yogi.displayDetails();
        jaws.displayDetails();
    }
}
