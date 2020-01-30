/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Create a Car Class
Date:			   04/08/2018
Description:	This is a program called CarClass with different fields that
               will output properties of the created car class object.
*********************************************************************/

public class CarClass{

	public static void main(String[] args){
   
   Car car1 = new Car();                      // creates a car object with the default constructor

   Car car2 = new Car(2015, "Ford", "F150");  // creates a car object with the year, make and model constructor parameters (the second constructor)
   
   Car car3 = new Car(2015, "Ford", "F150", "Slate Gray", 160);   // creates a car object with all parameters (the third constructor)
   
   System.out.println("An example of the car class with the default constructor:"); // calling the print methods to display the paramters set - default constructor
   car1.printYearMakeModel();
   car2.printColorSpeed();
   System.out.println("");
   System.out.println("An example of the car class with the year, make and model constructors set:"); // calling the print methods to display the paramters set - year/make/model constructor
   car2.printYearMakeModel();
   car2.printColorSpeed();
   System.out.println("");
   System.out.println("Finally, an example with all values set:"); // calling the print methods to display the paramters set - third constructor
   car3.printYearMakeModel();
   car3.printColorSpeed();
   System.out.println("");

   }  // end main
	
 } // end program 