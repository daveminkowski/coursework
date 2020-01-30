/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Movie Ticket Prices
Date:			   02/18/2018
Description:	This program determines a user's eligibility to see a 
               movie as well as the ticket price based on their age.
*********************************************************************/

import java.util.Scanner;  // import the scanner utility to allow for user input for values
import java.text.NumberFormat;   // import the number format utility to format my double values as currency.

public class MovieTicketPrices{

   public static void main(String[] args) {
   
      double ticketPrice = 15.00;   // setting a default ticket price
      final double DISCOUNT_RATE_SENIOR = 10.00;   // setting the value of the senior discount, as a constant (but it doesn't need to be)
      NumberFormat currencyFormat = NumberFormat.getCurrencyInstance(); // admittedly, I don't know every operation of this utility, I didn't know how to properly format my decimal values and had to research this a bit
      
      System.out.println("How old are you? You must be at least 16 to see this film. Senior citizens receive a discount!"); // prompting for user input (age)
      
      Scanner getAge = new Scanner(System.in); // creating a new scanner object to allow for input
      int userAge = getAge.nextInt(); // the variable userAge will be set by the next value captured by the getAge scanner object
      
      // these next few strings could have been handled a number of different ways, but thy contain the possible "answers"
      // to the user's input age. They allow for the if/else statements below to output these strings which can be edited without fiddling with the branching.
      
      String stateAge = ("You are " + userAge + " years old."); // echoing back the user's age
      String seniorCustomer = (" You're eligible for our Senior Discount! Your ticket price is only "); // response to a senior customer (65+)
      String adultCustomer = (" You can see this movie! Your ticket price is "); // response to all customers aged 16-64
      String juvenileCustomer = (" I'm sorry, but you're too young to see this movie."); // response for all customers aged < 16

      if (userAge >= 65){ // if user input is 65 or greater
         ticketPrice = ticketPrice - DISCOUNT_RATE_SENIOR; // the senior discount is applied to the base ticket price
         System.out.println(stateAge + seniorCustomer + currencyFormat.format(ticketPrice) + "."); // repeat the senior citizen's age, give the seniorCustomer string as response and show their ticket price (formatted as curency... base price - discount)
         }
      else if (userAge >= 16) // if user is not 65 or older but is older than 16
         System.out.println(stateAge + adultCustomer + currencyFormat.format(ticketPrice) + "."); // repeat the customer's age, give the adultCustomer response string and show their ticket price (formatted as curency) (base price)

      else // for all other cases (anyone aged 16 or younger)
         System.out.println(stateAge + juvenileCustomer); // repeat the customer's age, give  the juvenileCustomer response string. In this case, it is to say they cannot view the movie.

   }
}