/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		User Defined Methods
Date:			   04/01/2018
Description:	This program will use user defined methods to perform 
               redundant tasks of the calculator program.
*********************************************************************/

import java.util.Scanner; // import scanner utility which allows for user input with a keyboard

public class NewCalculator {
   
   // the firstIntegerInput method will function as a user prompt and will save input for the 1st integer value.
   // basically-  this method prompts the user for input, saves the string value of that input, parses it to the integer type, then returns that integer value.
   
   public static int firstIntegerInput(){       // this method is of the integer type and will return an integer value, important for the calculations in the other methods.
   int num1Int = 0;                             // initializing an integer variable to be used within the method (ultimately returning the value of this variable)
   String num1Input = "";                       // initializing a string variable to be used within the method (will be used to parse an integer from the scanner input)
   Scanner num1 = new Scanner(System.in);       // creating a scanner object (num1) for user input
   System.out.println("Please enter Number 1"); // prompt user for input
   num1Input = num1.next();                     // takes input, saves to string variable (num1Input)
   num1Int = Integer.parseInt(num1Input);       // parses the num1Input string variable and saves the value as an integer (num1Int, declared earlier)
   return num1Int;                              // ultimately, the method returns the value of the num1Int variable which will be used in whichever calculations call this method as an argument (parameter?).
   }
   
   // the secondIntegerInput method functions identically to the firstIntegerInput method and is used to get a second number from the user.
   public static int secondIntegerInput(){
   Scanner num2 = new Scanner(System.in);
   int num2Int = 0;
   String num2Input = "";
   System.out.println("Please enter Number 2");
   num2Input = num2.next();
   num2Int = Integer.parseInt(num2Input);
   return num2Int;
   }
   
   // I made 4 separate methods to handle each mathematic function available to this calculator. 
   // There is no return type for any of the arithmetic methods here - the method itself will perform the math and output the answer.
   // The program does not require the method to return a value nor does it use this method as an argument of another.
   // Each method is basically identical. The math performed in each method is unique to each method, but each method uses input from the
   // firstIntegerInput and secondIntegerInput methods above, passed to each method as firstNumber and secondNumber.
   
   // addIntegers adds two integer parameters then outputs a basic message which displays the equation and the answer.
   public static void addIntegers(int firstNumber, int secondNumber){
   int sum = firstNumber + secondNumber; // initializing a sum variable as the result of firstNumber + secondNumber
   System.out.println("The Answer to " + firstNumber + " + " + secondNumber+ " Equals: " + sum);   // Addition.
   return;
   }
   
   // subtractIntegers subtracts two integer parameters then outputs a basic message which displays the equation and the answer.
   public static void subtractIntegers(int firstNumber, int secondNumber){
   int difference = firstNumber - secondNumber; // initializing a differnece variable as the result of firstNumber - secondNumber
   System.out.println("The Answer to " + firstNumber + " - " + secondNumber+ " Equals: " + difference); // Subtraction.
   return;
   }
   
   // multiplyIntegers multiplies two integer parameters then outputs a basic message which displays the equation and the answer.
   public static void multiplyIntegers(int firstNumber, int secondNumber){
   int product = firstNumber * secondNumber; // initializing a product variable as the result of firstNumber * secondNumber
   System.out.println("The Answer to " + firstNumber + " * " + secondNumber+ " Equals: " + product); // Multiplication.
   return;
   }
   
   // divideIntegers divides two integer parameters then outputs a basic message which displays the equation and the answer.
   public static void divideIntegers(int firstNumber, int secondNumber){
   int quotient = firstNumber / secondNumber; // initializing a quotient variable as the result of firstNumber / secondNumber
   int remainder = firstNumber % secondNumber; // initializing a remainder variable as the result of firstNumber % secondNumber (integer math)
   System.out.println("The Answer to " + firstNumber + " / " + secondNumber+ " Equals: " + quotient + " remainder " + remainder); // Division, with remainder.
   return;
   }

   public static void main(String[] args) { 
      String usrInput = "";                  // string variable for user input
      Scanner scnr = new Scanner(System.in); // new scanner object for input
      System.out.println("Please Enter (M)ultiplication, (D)ivision, (A)ddition, or (S)ubtraction");     // user menu to choose which procedure to perform
      usrInput = scnr.next(); // the user's choice is saved as a string variable
      System.out.println(usrInput);
      if (usrInput.equals("M")|| usrInput.equals("m")||  // the user input is matched against this switch statement, allowing for upper or lower case.
          usrInput.equals("D")|| usrInput.equals("d")||
          usrInput.equals("A")|| usrInput.equals("a")||
          usrInput.equals("S")|| usrInput.equals("s")
      )
          { //If Bracket
           switch (usrInput) {//Switch Bracket
            case "M":
            multiplyIntegers(firstIntegerInput(), secondIntegerInput()); // for M or m case, call the multiplyIntegers method with the firstIntegerInput and secondIntegerInput as arguments
            break;
            case "m":
            multiplyIntegers(firstIntegerInput(), secondIntegerInput());
            break;
            case "D":
            divideIntegers(firstIntegerInput(), secondIntegerInput());  // for D or d case, call the divideIntegers method with the firstIntegerInput and secondIntegerInput as arguments
            break;
            case "d":
            divideIntegers(firstIntegerInput(), secondIntegerInput());
            break;
            case "A":
            addIntegers(firstIntegerInput(), secondIntegerInput());  // for A or a case, call the addIntegers method with the firstIntegerInput and secondIntegerInput as arguments
            break;
            case "a":
            addIntegers(firstIntegerInput(), secondIntegerInput());
            break;
            case "S":
            subtractIntegers(firstIntegerInput(), secondIntegerInput());   // for S or s case, call the subtractIntegers method with the firstIntegerInput and secondIntegerInput as arguments
            break;
            case "s":
            subtractIntegers(firstIntegerInput(), secondIntegerInput());
            break;
            default: 
            System.out.println("We are in the case");
             break;
             }}else{
           System.out.println("You may only enter 'M', 'D', 'A', or 'S'"); // display to user when their menu choice isnt M(m), D(d), A(a), or S(s)

          }
          
   }// end main
}// end class
