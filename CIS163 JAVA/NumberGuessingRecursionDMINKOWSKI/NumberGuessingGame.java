/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Recursion - Number Guessing Game
Date:			   04/28/2018
Description:	This program that will guess a number between 1-100
               using recursion to find the correct integer. Specifically,
               this program will use a binary search algorith to guess
               the user's number by determining if the guess is higher or
               lower than the number to be guessed, then eliminating all 
               options cannot possibly be the user' number.
*********************************************************************/

import java.util.Scanner; // import scanner util for user input

public class NumberGuessingGame {
   public static int guessCounter = 1;                                     // variable to keep track of the number of guesses - there will always be at least 1 guess, so initialize to 1
   
   // LEFTOVERS FROM LARGER NUMBER GUESS TESTING - theyre class variables so I didn't have to scroll up in jGrasp :)
   //public static int minVal = 0;
   //public static int maxVal = 6459810;
   
   public static void guessInteger(int minimumValue, int maximumValue){    // the method which will process the guessing ranges which are passed from main
      Scanner userInput = new Scanner(System.in);                          // for user input
      int midpointValue = 0;                                               // integer to become the lowpoint or high point for the binary search
      char userAnswer = '-';                                               // variable for my h, l and y answers from the user to guide the guessing.

      midpointValue = (minimumValue + maximumValue) / 2;                   // midpointValue becomes the average of the lowest and highest value based on whether the search must be higher or lower than the user's number
                                                                           // to be guessed. This will be used in the if/else statements later

      System.out.println("Is your number... " + midpointValue + "?");
      System.out.println("Guess Lower - (l)  Guess Higher - (h) That's my number! - (y)");
      userAnswer = userInput.next().charAt(0);                          // user input. the program will guess again if teh user enters l or h here
      System.out.println("");
                        
      if (userAnswer != 'y'){                                           // if the user's input is not y (the program did not guess the right number), increment the guess counter to keep track of how many times
         ++guessCounter;                                                // the program made a guess (but really, how many times the guessInteger method was called);
      }  

      if ((userAnswer != 'l') && (userAnswer != 'h')){                  // the base case (answer is not l or h - the guess is correct)
         System.out.println("Hah! I knew it the whole time!");
         
         if (guessCounter >= 2){                                                    // some extra flair. We could rewrite this whole block and omit the "first try" statement and initialize guessCounter to 0 guesses since
            System.out.println("It only took me " + guessCounter + " guesses.");    // the counter will increment but... the console saying "1 guesses" annoys me. And the program seems smarter this way
         }
         else{
            System.out.println("I guessed it on my first try!");                    // in case the program guesses the user's number correctly on the first try
         }
      } // end  if
      
      else{
         
         if (userAnswer == 'l'){                          // if the user tells the pgortam to guess lower, call the method again but now use the lowest value again
            guessInteger(minimumValue, midpointValue);    // while the new highest value becomes half of the upper limit of the range. In this case, 100 becomes 50, 50 becomes 25, etc. We're guessing in the bottom half of the range)
         } // end inner if
         
         else{
            guessInteger(midpointValue + 1, maximumValue); // since the base case is anything that isnt "l" or "h" and we've established what to do in case the user inputs "l", the last option is for when the program must guess 
         } // end inner else                               // higher. In this case, the MIDPOINT value becomes the lowest point in the number range and the max value of the range remains the same. (guessing in the top half of the range now)
      } // end else

      return;
      
   } // end guessInteger Method
   
   public static void main (String[] args){
      // I added these variables instead of typing 0 and 100 so I could play with the program with different values to see how efficiently the pgoram could guess larger numbers. I decided to leave them here for no reason in particular.
      // when theyre changed, the user prompt changes with it.
      int minVal = 0;
      int maxVal = 100;
      
      
      // giving instructions to the user
      System.out.println("Think of a whole number between " + minVal + " and " + maxVal + ".");
      System.out.println("I will guess the number using a binary search algorithm!");
      System.out.println("Let me know if I guess higher or lower than your number by replying with:");
      System.out.println("l - if i need to guess lower...");
      System.out.println("h - if i need to guess higher...");
      System.out.println("y - if I've guessed correctly.");
      System.out.println("");

      guessInteger(minVal, maxVal); // calling the guessInteger method with a range of (minVal - maxVal). Changing these two variables here changes the entire range of numbers to be guessed from

      return;
     
   }// end main

}// end class