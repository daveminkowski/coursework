package com.company;

import javax.swing.*;
import java.awt.*;
import java.awt.Color;

public class Checkerboard extends JFrame {

    private final int ROWS = 8;
    private final int COLS = 8;
    private final int GAP = 2;
    private final int NUM = ROWS * COLS;
    private int x;

    private JPanel pane = new JPanel(new GridLayout(ROWS, COLS, GAP, GAP));
    private JPanel[] panel = new JPanel[NUM];

    private Color color1 = Color.WHITE;
    private Color color2 = Color.BLUE;
    private Color tempColor;

    public Checkerboard()
    {
        add(pane);
        pane.setBackground(Color.black);

        for (x = 0; x < NUM; ++x)               // iterate through x squares in an 8 x 8 grid
        {
            panel[x] = new JPanel();
            pane.add(panel[x]);
            if (x % COLS == 0)                  // if current x is evenly divisible by 8 (every row of 8)
            {
                tempColor = color1;             // swap the colors so they can alternate each row
                color1 = color2;
                color2 = tempColor;
            }
            if (x % 2 == 0)                     // if current x is even
                panel[x].setBackground(color1); // set background to CURRENT color 1
            else
                panel[x].setBackground(color2); // or else, set the background to CURRENT color2
        }

        setDefaultCloseOperation(EXIT_ON_CLOSE);
    }

    public static void main (String[] args)
    {
        Checkerboard frame = new Checkerboard();
        final int SIZE = 300;
        frame.setSize(SIZE, SIZE);
        frame.setVisible(true);
    }
}
