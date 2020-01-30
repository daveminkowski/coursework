/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Making Change With Loops
Date:			   02/23/2018
Description:	This program will ask for a cost in cents (1-99)
               and return the correct change from a dollar using as 
               few coins as possible.
*********************************************************************/

import java.util.Scanner;  // import the scanner utility to allow for user input for values
import java.text.NumberFormat;   // import the number format utility to format my double values as currency.

public class ChangeMakerLoops{

   public static void main(String[] args) {
   
      int halfDollars = 50, quarters = 25, dimes = 10, nickels = 5, pennies = 1;   // setting default coin variable values
      
      int changeDue; // variable which will hold the value of the total change due and from which the change maker will base its calculations.
      
      System.out.println("Please enter as cost in cents (1-99) to compute your exact change from a dollar."); // prompting for user input (1-99)
      
      Scanner getChange = new Scanner(System.in); // creating a new scanner object to allow for input
      
      int cost = getChange.nextInt(); // the variable getChange will be set by the value captured by the scanner object.
      
      String echoCost = ("You were charged " + cost + " cents."); // echoing back the total cost.
      
      changeDue = 100 - cost;
      
      System.out.println("Your change is " + changeDue + " cents. The smallest number of coins to make this exact change is:"); // echoing back the total change due.
      
      // checking for half dollars since it is the largest denomination adn the most we can give back as change is 1 of these, we don't need to adjust any counters for it
      if (changeDue >= 50){
         System.out.println("1 half dollar");
         changeDue = changeDue - 50;
         }
      
      // checking if the change will include quarters.  Since we are using half dollars as well, we don't need to make the quarterCounter here but I did it anyway.
      int quarterCounter = 0;
      while (changeDue >= 25){
         changeDue = changeDue - 25; // adjusting the amount of change due to determine if we must reiterate or leave the loop
         ++quarterCounter;
         }
      
      if (quarterCounter >= 1)   // will only display if necessary (will never be > 1 if we use half dollars)
      System.out.println(quarterCounter + " quarter");
      
      // checking change for the number of possible dimes
      int dimeCounter = 0;
      while (changeDue >= 10){
         changeDue = changeDue - 10; // adjusting the amount of change due to determine if we must reiterate or leave the loop
         ++dimeCounter;
         }
      if (dimeCounter >= 1)   
      System.out.println(dimeCounter + " dime(s)");
      
      // checking change for necessary number of nickels, again, we will never need more than 1 since 2 nickels = 1 dime, but I added the counter anyway
      int nickelCounter = 0;  
      while (changeDue >= 5){
         changeDue = changeDue - 5; // adjusting the amount of change due to determine if we must reiterate or leave the loop
         ++nickelCounter;
         }
      if (nickelCounter >= 1)   
      System.out.println(nickelCounter + " nickel");
  
      // finally, checking for pennies due. The most this can be is 4, since 5 pennies = 1 nickel
      int pennyCounter = 0;       
      while (changeDue >= 1){
         changeDue = changeDue - 1; // adjusting the amount of change due to determine if we must reiterate or leave the loop
         ++pennyCounter;
         }
      if (pennyCounter >= 1)   
      System.out.println(pennyCounter + " penny(ies)");
         

   }
}