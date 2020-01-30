/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 5 Project
 Date:			06/21/2018
 Description:	This program chooses a random name from an array of 5 names and displays it with
                each new button press.
 ************************************************************************************************/

package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

public class Name extends JFrame implements ActionListener {

    final int WIDTH = 450;
    final int HEIGHT = 200;

    Random randomName = new Random();

    Font bigFont = new Font("Arial", Font.BOLD, 14);
    Font hugeFont = new Font("Arial", Font.BOLD, 76);

    String[] nameList = new String[] {"Bob", "Sally", "Mike", "Alice", "Tom"};

    JLabel prompt = new JLabel("Click the button to show a name!");
    JButton nameBtn = new JButton("Click Me!");
    JLabel nameDisplay = new JLabel("");


    public Name()
    {
        super ("Name Changer Button");
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setSize(WIDTH, HEIGHT);
        setLayout(new FlowLayout());

        add(prompt);
        prompt.setFont(bigFont);
        add(nameBtn);
        add(nameDisplay);
        nameDisplay.setFont(hugeFont);

        nameBtn.addActionListener(this);
    }

    public static void main (String [] args) {
        Name nameFrame = new Name();
        nameFrame.setVisible(true);
    }

    @Override
    public void actionPerformed(ActionEvent event) {
        int randomizer = randomName.nextInt(nameList.length);
        nameDisplay.setText(nameList[randomizer]);
    }
}
