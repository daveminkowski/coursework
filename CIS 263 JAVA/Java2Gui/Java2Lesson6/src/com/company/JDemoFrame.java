package com.company;

import java.awt.*;
import javax.swing.*;

public class JDemoFrame {

    public static void main (String [] args) {

        JFrame aFrame = new JFrame("This is a frame."); // set frame header
        final int WIDTH = 500; // constants for size
        final int HEIGHT = 250;
        aFrame.setSize(WIDTH, HEIGHT); // set size with variables or declare size here
        aFrame.setVisible(true);    // JFrame is invisible by default, set to visible here

        aFrame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE); // override default behavior to stay opn when frame is closed

        JLabel greeting = new JLabel("Good Day");   // create a label called greeting with the text "good day"
        aFrame.add(greeting);   // add the label to the JFrame object

        greeting.setText("Howdy"); // to later change the text of the label
        Font headlineFont = new Font("Arial", Font.BOLD, 36); // create a font object, monospaced bold size 36
        greeting.setFont(headlineFont); // set the font of the greeting label

    }
}
