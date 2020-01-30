/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 6 Project
 Date:			07/03/2018
 Description:	This program uses a 6x6 gridlayout and show hit indicators mimicking the classic
                board game Battleship.
 ************************************************************************************************/

package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Battleship extends JFrame implements ActionListener {

    // MODIFY THESE GRID LOCATIONS TO SET THE SIX HIT MARKERS
    private final int A = 2;
    private final int B = 8;
    private final int C = 14;
    private final int D = 20;
    private final int E = 26;
    private final int F = 32;

    private final int ROWS = 6;
    private final int COLS = 6;
    private final int GAP = 2;
    private final int NUM = ROWS * COLS;                   // max number of buttons based on rows x columns
    private int x;                                         // used when looping to number individual buttons in the array ie: button[23]

    private JPanel background = new JPanel(new GridLayout(ROWS, COLS, GAP, GAP));
    private JButton[] button = new JButton[NUM];
    private Color color1 = Color.WHITE;
    private Color color2 = Color.BLUE;

    private Font bigFont = new Font("Arial", Font.BOLD, 36);

    public static void main (String[] args)
    {
        Battleship battleFrame = new Battleship();
        final int SIZE = 600;
        battleFrame.setSize(SIZE, SIZE);
        battleFrame.setVisible(true);
    } // END MAIN

    public Battleship()
    {
        super("Battleship by Dave Minkowski");
        add(background);
        background.setBackground(color1);

        for (x = 0; x < NUM; ++x)               // iterate through x squares in an 6 X 6 grid
        {
            button[x] = new JButton();
            button[x].addActionListener(this);
            background.add(button[x]);
            button[x].setBackground(color2);
        }
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    } // END BATTLESHIP()

    public void actionPerformed(ActionEvent event)
    {
        Object source = event.getSource();
        if (source == button[A])
        {
            button[A].setBackground(Color.RED);
            button[A].setForeground(Color.BLACK);
            button[A].setFont(bigFont);
            button[A].setText("X");
            button[A].setEnabled(false);
        }
        else if (source == button[B])
        {
            button[B].setBackground(Color.RED);
            button[B].setForeground(Color.BLACK);
            button[B].setFont(bigFont);
            button[B].setText("X");
            button[B].setEnabled(false);
        }
        else if (source == button[C])
        {
            button[C].setBackground(Color.RED);
            button[C].setForeground(Color.BLACK);
            button[C].setFont(bigFont);
            button[C].setText("X");
            button[C].setEnabled(false);
        }
        else if (source == button[D])
        {
            button[D].setBackground(Color.RED);
            button[D].setForeground(Color.BLACK);
            button[D].setFont(bigFont);
            button[D].setText("X");
            button[D].setEnabled(false);
        }
        else if (source == button[E])
        {
            button[E].setBackground(Color.RED);
            button[E].setForeground(Color.BLACK);
            button[E].setFont(bigFont);
            button[E].setText("X");
            button[E].setEnabled(false);
        }
        else if (source == button[F])
        {
            button[F].setBackground(Color.RED);
            button[F].setForeground(Color.BLACK);
            button[F].setFont(bigFont);
            button[F].setText("X");
            button[F].setEnabled(false);
        }
        else
        {
            JButton buttonMiss = (JButton)event.getSource();
            buttonMiss.setBackground(Color.lightGray);
            buttonMiss.setForeground(Color.BLACK);
            buttonMiss.setFont(bigFont);
            buttonMiss.setText("0");
            buttonMiss.setEnabled(false);
        }
        if (!button[A].isEnabled() && !button[B].isEnabled() && !button[C].isEnabled() && !button[D].isEnabled() && !button[E].isEnabled() && !button[F].isEnabled())
        {
            int result = JOptionPane.showConfirmDialog(null,"You won! Play again?", "Congratulations!", JOptionPane.YES_NO_OPTION);
            if (result == JOptionPane.YES_OPTION)
            {
                for (x = 0; x < NUM; ++x)
                {
                    button[x].setEnabled(true);
                    button[x].setBackground(color2);
                    button[x].setForeground(color2);
                    button[x].setText("");
                }
            }
            else
                System.exit(0);
        }
    } // END ACTION PEFORMED
} // END CLASS
