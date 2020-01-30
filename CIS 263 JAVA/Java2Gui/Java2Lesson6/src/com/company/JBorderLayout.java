package com.company;
import java.awt.*;
import javax.swing.*;
import java.awt.Color;

public class JBorderLayout extends JFrame{

    private JButton nb = new JButton("North");
    private JButton sb = new JButton("South");
    private JButton eb = new JButton("East");
    private JButton wb = new JButton("West");
    private JButton cb = new JButton("Center");


    public JBorderLayout()
    {
        setLayout(new BorderLayout());
        add(nb, BorderLayout.NORTH);
        add(sb, BorderLayout.SOUTH);
        add(eb, BorderLayout.EAST);
        add(wb, BorderLayout.WEST);
        add(cb, BorderLayout.CENTER);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setTitle("Hello!");
    }

    public static void main (String[] args) {

        JBorderLayout jbl = new JBorderLayout();
        jbl.setSize(250, 250);
        jbl.setVisible(true);

    }

}

