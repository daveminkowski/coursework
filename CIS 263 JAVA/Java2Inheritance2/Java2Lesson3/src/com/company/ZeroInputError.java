/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 3 Project
 Date:			06/09/2018
 Description:	This program divides two integers and throws a custom divide by zero exception if
                the denominator is zero.
 ************************************************************************************************/

package com.company;

public class ZeroInputError extends Exception {

    public ZeroInputError() {
        super("Error! Cannot divide by zero!");
    }


}