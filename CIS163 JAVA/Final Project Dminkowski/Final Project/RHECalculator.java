/********************************************************************************************************
Name:			   David Minkowski
Course:			CIS 163AA - Spring 2018 - Section: 20695
Assignment:		Final Project - RHE Calculator
Date:			   05/08/2018
Description:   This program will compute an employee's variable pay rate 
               using their base hourly pay rate, base shift hours and
               annual salary in a simple conversion equation.
*********************************************************************************************************/

/* ================================= Competencies Demonstrated (I think) ================================

1. Control Structure:
Example: If-Else - lines 229-246

2. String and Character Manipulation:
Example: Converting double values to strings and formatting them for output - lines 231-239

3. Object-Oriented concepts:
Example: Creating label, button, field and gridbagconstraint objects - lines 72-211

4. Basic GUI components:
Example: Creating a gridbaglayout and manipul;ating object placement - lines 123-211

5. Use of Methods:
Example: using actionListener to trigger an event and the main method to show the JFrame - lines 217 and 253-257

======================================================================================================== */

import java.awt.GridBagLayout;            // uses JFrame's setLayout() method to use a GridBagLayout as the layout manager
import java.awt.GridBagConstraints;       // allows us to assign each component a variable which is then assigned location and padding assignments
import java.awt.Insets;                   // padding of each component in the gridbaglayout
import java.awt.event.ActionListener;     // allows us to associate a component to act on an action
import java.awt.event.ActionEvent;        // signals the action to take when our associated actionlistener component is triggered
import javax.swing.JButton;               // JFrame button
import javax.swing.JFrame;                // importing the JFrame (the "window" of the GUI)
import javax.swing.JLabel;                // labels for the GUI
import javax.swing.JTextField;            // text fields for the GUI
import javax.swing.JFormattedTextField;   // formatted text Field - will allow to extract numerical values from fields rather than text strings to parse
import java.text.NumberFormat;            // used in conjuntion with the JFormattedTextField to get the value of the field rather than the text string
import javax.swing.JOptionPane;           // show dialogue option in case of invalid input

public class RHECalculator extends JFrame implements ActionListener {      // extending the Jframe class (custom class) implementing the actionlistener interface

   private JButton calcButton;                  // calculates rates based on input
   
   private JLabel hourlyRateLabel;              // Label for hourly rate
   private JLabel rheLabel;                     // Label for base RHE
   private JLabel annualSalaryLabel;            // Label for annual salary
   private JLabel rhe40Label;                   // Label for RHE 40 conversion
   private JLabel rhe44Label;                   // Label for RHE 44 conversion
   private JLabel rhe52Label;                   // Label for RHE 52 conversion
   private JLabel rhe64Label;                   // Label for RHE 64 conversion
   
   // input fields (editable)
   private JFormattedTextField hourlyRateField; // Formaatted Jtextfield to input hourly rate and use in calculation
   private JTextField rheField;                 // Field to input RHE and use in calculation
   
   // display fields (non-editable)
   private JTextField annualSalaryField;        // Displays annual salary
   private JTextField rhe40Field;               // displays RHE 40 Conversion
   private JTextField rhe44Field;               // displays RHE 40 Conversion
   private JTextField rhe52Field;               // displays RHE 40 Conversion
   private JTextField rhe64Field;               // displays RHE 40 Conversion

   RHECalculator() {
      GridBagConstraints layoutConst = null;                // specify gui component layout

      setTitle("RHE Calculator by Dave Minkowski");         // title of the frame

      // creating all the label objects for the frame
      hourlyRateLabel = new JLabel("My Hourly Rate:");      
      rheLabel = new JLabel("My Base RHE:");
      annualSalaryLabel = new JLabel("Annual Salary:");
      rhe40Label = new JLabel("Base RHE 40 Rate:");
      rhe44Label = new JLabel("Base RHE 44 Rate:");
      rhe52Label = new JLabel("Base RHE 52 Rate:");
      rhe64Label = new JLabel("Base RHE 64 Rate:");

      // creates a calculate button object and associates the actionListener with the button (do stuff when it's pressed)
      calcButton = new JButton("Calculate");
      calcButton.addActionListener(this);
      
      // most of the following field objects are created with a specified width, permission to edit each field and default text, if any.
      
      rheField = new JTextField(8);    // rhefield with a width of 8 columns
      rheField.setEditable(true);      // able to edit the field
      rheField.setText("44");          // default text within the field at runtime
      
      //the set.Text methods can be omitted to leave a blank field, as the annualSalary field shows
      annualSalaryField = new JTextField(8);
      annualSalaryField.setEditable(false);

      rhe40Field = new JTextField(5);
      rhe40Field.setEditable(false);
      rhe40Field.setText("0");
      
      rhe44Field = new JTextField(5);
      rhe44Field.setEditable(false);
      rhe44Field.setText("0");
      
      rhe52Field = new JTextField(5);
      rhe52Field.setEditable(false);
      rhe52Field.setText("0");
      
      rhe64Field = new JTextField(5);
      rhe64Field.setEditable(false);
      rhe64Field.setText("0");
      
      // the hourly rate field is formatted in this fashion so I wouldn't have to parse the string to get the value. It was just another technique to implement.
      hourlyRateField = new JFormattedTextField(NumberFormat.getNumberInstance());
      hourlyRateField.setEditable(true);
      hourlyRateField.setText("0");
      hourlyRateField.setColumns(8);
      
      // use a gridbag layout
      setLayout(new GridBagLayout());
      
      // creating a separate layout constraints object for each GUI component for complete control of the layout.
      // each of the following components is set and moved in the same fashion with each occupying its own space in the 
      // gridbag X,Y layout
      
      layoutConst = new GridBagConstraints();            // gridbag constraints variable created for each component
      layoutConst.insets = new Insets(10, 10, 10, 10);   // specifies top, left, bottom and right padding round the object
      layoutConst.gridx = 1;                             // the position in the gridbag X,Y layout on the 2D plane. In this case, 1,3
      layoutConst.gridy = 3;
      add(calcButton, layoutConst);                      // adding the JFrame component and its corresponding gridbag constraints variable
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 0;
      layoutConst.gridy = 0;
      add(hourlyRateLabel, layoutConst);

      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 1;
      layoutConst.gridy = 0;
      add(hourlyRateField, layoutConst);

      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 0;
      layoutConst.gridy = 1;
      add(rheLabel, layoutConst);

      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 1;
      layoutConst.gridy = 1;
      add(rheField, layoutConst);

      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 0;
      layoutConst.gridy = 2;
      add(annualSalaryLabel, layoutConst);

      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 1;
      layoutConst.gridy = 2;
      add(annualSalaryField, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 3;
      layoutConst.gridy = 0;
      add(rhe40Label, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 4;
      layoutConst.gridy = 0;
      add(rhe40Field, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 3;
      layoutConst.gridy = 1;
      add(rhe44Label, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 4;
      layoutConst.gridy = 1;
      add(rhe44Field, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 3;
      layoutConst.gridy = 2;
      add(rhe52Label, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 4;
      layoutConst.gridy = 2;
      add(rhe52Field, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 10, 10, 5);
      layoutConst.gridx = 3;
      layoutConst.gridy = 3;
      add(rhe64Label, layoutConst);
      
      layoutConst = new GridBagConstraints();
      layoutConst.insets = new Insets(10, 5, 10, 10);
      layoutConst.gridx = 4;
      layoutConst.gridy = 3;
      add(rhe64Field, layoutConst);
   }
   
   // this method is automatically called when an event occurs (like a button or key press). This will react to the action listener we assigned
   // to the calculate button above. 
   
   @Override
   public void actionPerformed(ActionEvent event) {
      
      // declaring variables
      int baseRHE = 0;
      double hourlyRate, annualSalary, rhe40Rate, rhe44Rate, rhe52Rate, rhe64Rate;
      String strAnnualSalary, strRHE40, strRHE44, strRHE52, strRHE64;
      
      // obtaining user input and asigning them to variables
      hourlyRate = ((Number) hourlyRateField.getValue()).doubleValue();       // hourly rate is obtained using getValue since I declared it as a JFormattedTextField
      baseRHE = Integer.parseInt(rheField.getText());                         // baseRHE is obtained by parsing the string into an integer
      
      if (hourlyRate > 0.0) {                                                 // if hourlyRate is a nonzero, non negative number then
         annualSalary = hourlyRate * baseRHE * 52;                            // figure the employee's annual salary
         strAnnualSalary = String.format ("%,.2f", annualSalary);             // from that, we can figure the employee's other RHE rates. Formatted with comma separator and 2 decimal places
         rhe40Rate = (annualSalary/52)/40;
         strRHE40 = String.format ("%.2f", rhe40Rate);                        // formatting the string to 2 decimal places
         rhe44Rate = (annualSalary/52)/44;
         strRHE44 = String.format ("%.2f", rhe44Rate);
         rhe52Rate = (annualSalary/52)/52;
         strRHE52 = String.format ("%.2f", rhe52Rate);
         rhe64Rate = (annualSalary/52)/64;
         strRHE64 = String.format ("%.2f", rhe64Rate);
         
         annualSalaryField.setText("$" + strAnnualSalary);                 // then set the various output fields to their appropriate values.
         rhe40Field.setText("$" + strRHE40);
         rhe44Field.setText("$" + strRHE44);
         rhe52Field.setText("$" + strRHE52);
         rhe64Field.setText("$" + strRHE64);
      }
      else {
         JOptionPane.showMessageDialog(this, "Invalid Hourly Rate.");      // if hourlyRate is negative or 0, display an error message. 
      }
      return;
   }

   public static void main(String[] args) {                                // create the jframe and its components and make it visible
      RHECalculator rheCalcFrame = new RHECalculator();
      rheCalcFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
      rheCalcFrame.pack();
      rheCalcFrame.setVisible(true);

      return;
   }
}