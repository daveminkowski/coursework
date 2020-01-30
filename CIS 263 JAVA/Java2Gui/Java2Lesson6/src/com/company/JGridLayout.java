package com.company;
import java.awt.*;
import javax.swing.*;
import java.awt.Color;

public class JGridLayout extends JFrame{

    private JButton nb = new JButton("North");
    private JButton sb = new JButton("South");
    private JButton eb = new JButton("East");
    private JButton wb = new JButton("West");
    private JButton cb = new JButton("Center");


    public JGridLayout()
    {
        setLayout(new GridLayout(2, 3, 2, 4));
        add(nb);
        add(sb);
        add(eb);
        add(wb);
        add(cb);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle("Hello!");
    }

    public static void main (String[] args) {

        JGridLayout jbl = new JGridLayout();
        jbl.setSize(250, 250);
        jbl.setVisible(true);

    }

}

