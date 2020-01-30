/********************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Inheritance - extending a class
Date:			   04/22/2018
Description:	This program will create a base class (automobile) then
               extend that class to two different classes with methods
               of their own while inheriting methods from the base
               class.
*********************************************************************/

public class SportsCar extends Automobile { // extending the base class: inheriting the methods and protected variables of the base class

   // variables unique to this class
   private String convertibleType;
   private int horsepower;
   
   public void setConvertibleType(String inputConvertibleType){ // setting the string variable for convertible type
   
      convertibleType = inputConvertibleType;  
      return; 
   }
   
   public void setHorsepower(int inputHorsepower){ // setting the int variable for the max horsepower
   
      horsepower = inputHorsepower;
      return; 
   }
   
   @Override // choosing this listfeatures method instead of the base class' listfeatures method (ensuring this derivative class features are listed as well)
   public void listFeatures(){
      super.listModel(); // calling the base class' listModel method which prints the vehicle's model
      System.out.println("Convertible type: " + convertibleType + "."); // then printing the convertible top type
      System.out.println("Stock horsepower: " + horsepower + " hp."); // then printing the max horsepower
      super.listFeatures(); // finally calling the base class' listFeatures method (which prints the speed and color of the vehicle)
      return; 
   }



}// end class