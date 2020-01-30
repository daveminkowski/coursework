/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 6 Project
 Date:			06/27/2018
 Description:	This program shows four regions with a central button. Each button click will
                change the color of a random region to a random color.
 ************************************************************************************************/

package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.event.*;
import java.awt.Color;
import java.util.Random;

public class ColorChanger extends JFrame implements ActionListener{

    private JPanel northPanel = new JPanel();
    private JPanel southPanel = new JPanel();
    private JPanel eastPanel = new JPanel();
    private JPanel westPanel = new JPanel();

    private JButton centerButton = new JButton("Click Me!");

    private Container con = getContentPane();
    private Font bigFont = new Font("Arial", Font.BOLD, 16);
    private Dimension nsDimension = new Dimension(0, 50);
    private Dimension ewDimension = new Dimension(100, 0);

    private JPanel regionArray[] = new JPanel[]{northPanel, southPanel, eastPanel, westPanel};

    public ColorChanger()
    {
        super("Color Changer - Dave Minkowski");
        // NORTH PANEL
        con.add(regionArray[0], BorderLayout.NORTH);
        regionArray[0].setPreferredSize(nsDimension);
        regionArray[0].setBackground(Color.BLACK);

        // SOUTH PANEL
        con.add(regionArray[1], BorderLayout.SOUTH);
        regionArray[1].setPreferredSize(nsDimension);
        regionArray[1].setBackground(Color.BLACK);

        // EAST PANEL
        con.add(regionArray[2], BorderLayout.EAST);
        regionArray[2].setPreferredSize(ewDimension);
        regionArray[2].setBackground(Color.BLACK);

        // WEST PANEL
        con.add(regionArray[3], BorderLayout.WEST);
        regionArray[3].setPreferredSize(ewDimension);
        regionArray[3].setBackground(Color.BLACK);

        // CENTER BUTTON
        con.add(centerButton, BorderLayout.CENTER);
        centerButton.setFont(bigFont);
        centerButton.setBackground(Color.WHITE);
        centerButton.setForeground(Color.BLACK);
        centerButton.addActionListener(this);

        setSize(400 , 200);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }
    @Override
    public void actionPerformed(ActionEvent event)
    {
        Object source = event.getSource();
        if (source == centerButton)
        {
            Random colorGenerator = new Random();
            Random region = new Random();
            int red = colorGenerator.nextInt(256);
            int green = colorGenerator.nextInt(256);
            int blue = colorGenerator.nextInt(256);
            Color randomColor = new Color(red, green, blue);

            int regionRandomizer = region.nextInt(regionArray.length);
            regionArray[regionRandomizer].setBackground(randomColor);
            centerButton.setText("Click Me Again!");
        }
    }

    public static void main (String[] args)
    {
        ColorChanger frame = new ColorChanger();
        frame.setVisible(true);
    }
}
