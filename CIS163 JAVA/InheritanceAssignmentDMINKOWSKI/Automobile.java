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

public class Automobile {
   
   // protected variables are usable by all derivatives of this class, so these variables would be things that are common to both the derived and base classes
   
   protected int maxSpeed = 0;
   protected String vehicleColor = "red";
   protected String vehicleModel = "";
   
   public void setMaxSpeed(int inputSpeed){ // set accessor to set the int variable for maximum speed
      
      maxSpeed = inputSpeed;
      return;
   }
   
   public void setCarColor(String inputColor){ // set accessor to set the String variable for the base car color
      
      vehicleColor = inputColor;
      return;
   }
   
   public void setModel(String inputModel){ // set accessor to set the String variable for the model
      
      vehicleModel = inputModel;
      return;
   }
   
   // this method is a combination of the three above and would be the quickest way to input all the data we needed to enter. In a real life scenario, 
   // I'd have included partial and default constructors to allow certain defaults to make input even faster
   public void setFeatures(String inputModel, int inputSpeed, String inputColor){
      vehicleModel = inputModel;
      maxSpeed = inputSpeed;
      vehicleColor = inputColor;
      return;
   }
   // this listFeatures method lists the max speed and color of the vehicle and is called by the derivate classes using in their own 
   // listFeatures methods using super keyword
   public void listFeatures(){
      System.out.println("Vehicle maximum speed: " + maxSpeed + " mph.");
      System.out.println("Base color option: " + vehicleColor + ".");
      System.out.println("");
      return; 
   }
   
   // prints the model of the vehicle. Would have been included in the listfeatures method, but I wanted a single line space between vehicle printouts so I chose to
   // use this on its own. It's called by the derivative classes using the super keyword
   public void listModel(){
      System.out.println("Features listed for a " + vehicleModel + ":");
   }


}// end class