/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

package com.company;

public class PersonDemo {

    public static void main(String[] args){

        Student dave = new Student();
        dave.setName("Dave");
        dave.setStudentId(225217);
        dave.setAge(36);

        dave.displayDetails();
    }

}
