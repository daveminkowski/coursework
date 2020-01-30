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

public class InheritanceAssignment {

   public static void main (String[] args) {
      
     // creating a fordPinto object which sets the model, max speed and base color option available for all classes by setting the variables
     // in the automobile class. The listModel method is only called on the pinto because of the extra line added to the listFeatures method in
     // the autmobile class which is called by each of its inherited classes.       
      
      Automobile fordPinto = new Automobile();
      fordPinto.setFeatures("Ford Pinto", 83, "Pea Green");
      fordPinto.listModel();
      fordPinto.listFeatures();
      
      // the SportsCar class porsche911 object uses the setFeatures method in the autmobile class just as the pinto did, but also sets two additional
      // variables unique to the sportscar class. It then calls the listFeatures override method (in the sportscar class) to list the features of the car
      SportsCar porsche911 = new SportsCar();
      porsche911.setFeatures("Porsche 911 GT3", 193, "Electric Blue");
      porsche911.setHorsepower(520);
      porsche911.setConvertibleType("Hardtop");
      porsche911.listFeatures();
      
      // the fordf150 instantiation of the pickuptruck class works identically to the porsche object above, but I chose to set each variable individually, 
      // just because. There is a constructor in the fordf150 class which would allow me to set both variables (just like the automobile class) but I wanted to
      // do this one differently for no particular reason.
      PickupTruck fordF150 = new PickupTruck();
      fordF150.setModel("Ford F150");
      fordF150.setTowWeight(12200);
      fordF150.setHaulCapacity(3220);
      fordF150.setCarColor("Black");
      fordF150.setMaxSpeed(110);
      fordF150.listFeatures();
      
      return;

   }// end main

}// end class