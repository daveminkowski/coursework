/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:	Lesson 3 Project
 Date:			06/09/2018
 Description:	This program divides two integers and throws a custom divide by zero exception if
                the denominator is zero.
 ************************************************************************************************/

package com.company;
import java.util.Scanner;

public class Calculator {

    public static void main(String[] args) {

        try
        {
            int numerator, denominator, result;
            Scanner input = new Scanner(System.in);

            System.out.println("Enter numerator >> ");
            numerator = input.nextInt();

            System.out.println("Enter denominator >> ");
            denominator = input.nextInt();

            if (denominator == 0)
            {
                throw new ZeroInputError();
            }

            result = numerator / denominator;
            System.out.println("Result is " + result);
        }

        catch (ZeroInputError exception)
        {
            System.out.println(exception);
        }

        System.out.println("End of program");
    }
}
