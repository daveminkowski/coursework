/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Create a Car Class
Date:			   04/08/2018
Description:	This is a class called Car that holds several properties
               about the car object called from CarClass.java
*********************************************************************/

public class Car{

private int year;
private int topSpeed;
private String make;
private String model;
private String color;

public Car(){        // default constructor - creates a car object with all values set to default.
   year = 0;
   topSpeed = 0;
   make = "";        // each of these values can be omitted while recahing the same result in the print method
   model = "";
   color = "";
}

public Car(int mfgYear, String mfgMake, String mfgModel){      // a constructor with 3 common values assigned - year, make and model.

   year = mfgYear;   // the year argument passed to the contructor here "comes in" as mfgYear but saves its value as the int variable 'year'. When the print method is called, it outputs the int
   make = mfgMake;   // value saved to 'year'
   model = mfgModel;
}

public Car(int mfgYear, String mfgMake, String mfgModel, String mfgColor, int mfgTopSpeed){ // another constructor with all 5 parameters defined. The main method in the CarClas will pass 5 arguments to this constructor
   year = mfgYear;
   topSpeed = mfgTopSpeed;                                                                  // which will be read out by the print function.
   make = mfgMake;
   model = mfgModel;
   color = mfgColor;
}

public void printYearMakeModel(){
   System.out.println(" The vehicle is a " + year + " " + make + " " + model + ".");   // print the year, make and model
   return;
}
public void printColorSpeed(){
   System.out.println(" This vehicle's color is " + color + " and has top speed of " + topSpeed + " mph."); // as a separate function, print the speed and color of the vehicle. These two print fuinctions can be merged
   return;                                                                                                  // into one, but I wanted to show what happens when 3 parameters are passed but a method looks for the paramaters that were
}                                                                                                           // not stated, such as in the new car2 object and car2.printColorSpeed();



}  // end class