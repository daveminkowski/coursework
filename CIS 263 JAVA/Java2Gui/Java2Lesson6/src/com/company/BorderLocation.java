/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 6 Project
 Date:			06/27/2018
 Description:	This program shows five buttons which, when clicked, display their corresponding
                region within the BorderLayout.
 ************************************************************************************************/

package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class BorderLocation extends JFrame implements ActionListener{

    private JButton northButton = new JButton();
    private JButton southButton = new JButton();
    private JButton eastButton = new JButton();
    private JButton westButton = new JButton();
    private JButton centerButton = new JButton();

    private Container con = getContentPane();
    Font bigFont = new Font("Arial", Font.BOLD, 16);
    Dimension nsDimension = new Dimension(0, 50);
    Dimension ewDimension = new Dimension(100, 0);

    public BorderLocation()
    {
        super("Border Location - Dave Minkowski");
        // NORTH BUTTON
        con.add(northButton, BorderLayout.NORTH);
        northButton.setFont(bigFont);
        northButton.setPreferredSize(nsDimension);
        northButton.addActionListener(this);

        // SOUTH BUTTON
        con.add(southButton, BorderLayout.SOUTH);
        southButton.setFont(bigFont);
        southButton.setPreferredSize(nsDimension);
        southButton.addActionListener(this);

        // EAST BUTTON
        con.add(eastButton, BorderLayout.EAST);
        eastButton.setFont(bigFont);
        eastButton.setPreferredSize(ewDimension);
        eastButton.addActionListener(this);

        // WEST BUTTON
        con.add(westButton, BorderLayout.WEST);
        westButton.setFont(bigFont);
        westButton.setPreferredSize(ewDimension);
        westButton.addActionListener(this);

        // CENTER BUTTON
        con.add(centerButton, BorderLayout.CENTER);
        centerButton.setFont(bigFont);
        centerButton.addActionListener(this);

        setSize(400 , 200);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }
    @Override
    public void actionPerformed(ActionEvent event)
    {
        Object source = event.getSource();
        if (source == northButton)
        {
            northButton.setText("North");
            southButton.setText("");
            eastButton.setText("");
            westButton.setText("");
            centerButton.setText("");
        }
        else if (source == southButton)
        {
            northButton.setText("");
            southButton.setText("South");
            eastButton.setText("");
            westButton.setText("");
            centerButton.setText("");
        }
        else if (source == eastButton)
        {
            northButton.setText("");
            southButton.setText("");
            eastButton.setText("East");
            westButton.setText("");
            centerButton.setText("");
        }
        else if (source == westButton)
        {
            northButton.setText("");
            southButton.setText("");
            eastButton.setText("");
            westButton.setText("West");
            centerButton.setText("");
        }
        else if (source == centerButton)
        {
            northButton.setText("");
            southButton.setText("");
            eastButton.setText("");
            westButton.setText("");
            centerButton.setText("Center");
        }
    }
    public static void main (String[] args)
    {
        BorderLocation frame = new BorderLocation();
        frame.setVisible(true);
    }
}
