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

public class PickupTruck extends Automobile { // extending the base class: inheriting the methods and protected variables of the base class

   // variables unique to this class
   private int maxTowWeight; 
   private int maxHaulCapacity;

   public void setTowWeight(int inputMaxTow){ // set max tow weight int variable
   
      maxTowWeight = inputMaxTow;   
      return; 
   }
   
   public void setHaulCapacity(int inputMaxHaul){ // set max haul capacity int variable
   
      maxHaulCapacity = inputMaxHaul;   
      return; 
   }
   
   public void setTowHaulPackage(int inputMaxTow, int inputMaxHaul){ // combining each of the methods above
      maxTowWeight = inputMaxTow;
      maxHaulCapacity = inputMaxHaul;
   }
   
   @Override // choosing this listfeatures method instead of the base class' listfeatures method (ensuring this derivative class features are listed as well)
   public void listFeatures(){
      super.listModel();   // calling the base class' listModel method which prints the vehicle's model
      System.out.println("Maximum tow weight: " + maxTowWeight + " pounds."); // then printing the max tow weight
      System.out.println("Maximum hauling capacity: " + maxHaulCapacity + " pounds."); // then printing the max hauling capacity
      super.listFeatures(); // finally calling the base class' listFeatures method (which prints the speed and color of the vehicle)
      return; 
   }
   
}// end class