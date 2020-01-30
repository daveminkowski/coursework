/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 5 Project
 Date:			06/21/2018
 Description:	This program displays a phone number associated with a contact and will display
                the phone number of the corresponding contact button.
 ************************************************************************************************/

package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class PhoneBook extends JFrame implements ActionListener {

    final int WIDTH = 450;
    final int HEIGHT = 180;

    Font bigFont = new Font("Arial", Font.BOLD, 16);

    String[] nameList = new String[] {"Bob", "Sally", "Mike", "Alice", "Tom"};
    String[] numberList = new String[] {"(480) 555-1212", "(480) 777-9876", "(602) 333-4321", "(623) 555-9988", "(480) 987-6543"};

    JLabel prompt = new JLabel("Click a name to show the contact's phone number:");
    JButton bob = new JButton(nameList[0]);
    JButton sally = new JButton(nameList[1]);
    JButton mike = new JButton(nameList[2]);
    JButton alice = new JButton(nameList[3]);
    JButton tom = new JButton(nameList[4]);


    JTextField numberDisplay= new JTextField(12);


    public PhoneBook()
    {
        super ("Phonebook");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(WIDTH, HEIGHT);
        setLayout(new FlowLayout());

        add(prompt);
        prompt.setFont(bigFont);
        add(bob);
        add(sally);
        add(mike);
        add(alice);
        add(tom);
        add(numberDisplay);

        bob.addActionListener(this);
        sally.addActionListener(this);
        mike.addActionListener(this);
        alice.addActionListener(this);
        tom.addActionListener(this);
    }

    public static void main (String [] args) {
        PhoneBook nameFrame = new PhoneBook();
        nameFrame.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent event) {

        Object source = event.getSource();
        if (source == bob)
            numberDisplay.setText(numberList[0]);
        else if (source == sally)
            numberDisplay.setText(numberList[1]);
        else if (source == mike)
            numberDisplay.setText(numberList[2]);
        else if (source == alice)
            numberDisplay.setText(numberList[3]);
        else if (source == tom)
            numberDisplay.setText(numberList[4]);

    }
}
