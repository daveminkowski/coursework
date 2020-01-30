/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 3 Project
 Date:			06/09/2018
 Description:	This project accepts input from the user to select an array value, then displays
                the name stored in that array index OR prints a message if the array index is out
                of the bounds of the array.
 ************************************************************************************************/

package com.company;
import java.util.*;

public class ThrowArrayException {

    public static void main (String[] args){

        String[] nameArray = {"Dave", "David", "Davey", "John", "Johnny", "Johnathan", "James", "Jim", "Jimmy", "Jimbo"};

        try
        {
            int indexInput;
            Scanner userInput = new Scanner(System.in);
            System.out.println("Enter an array index from 0 - 9:");
            indexInput = userInput.nextInt();
            System.out.println("You chose index " + indexInput + ". The name stored there is " + nameArray[indexInput] + ".");
        }

        catch (IndexOutOfBoundsException exception)
        {
            System.out.println("Operation Unsuccessful. Index out of bounds.");
        }


    }
}
