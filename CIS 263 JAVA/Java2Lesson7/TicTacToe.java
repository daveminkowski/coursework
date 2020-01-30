/***********************************************************************************************
 Name:			David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Lesson 6 Project
 Date:			07/03/2018
 Description:	This program uses a 3x3 gridlayout to simulate a user playing AI in a game of
                Tic-Tac-Toe.
 ************************************************************************************************/

package com.company;
import javax.swing.*;
import java.awt.*;
import java.awt.Color;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

public class TicTacToe extends JFrame implements ActionListener {

    private final int ROWS = 3;
    private final int COLS = 3;
    private final int GAP = 3;
    private final int NUM = ROWS * COLS;                   // max number of buttons based on rows x columns
    private int x;                                         // used when looping to number individual buttons in the array ie: button[23]

    private JPanel background = new JPanel(new GridLayout(ROWS, COLS, GAP, GAP));
    private JButton[] button = new JButton[NUM];
    private Color color1 = Color.yellow;
    private int moveCounter = 0;
    private Random rng = new Random();
    private boolean gameOver = false;

    private Font bigFont = new Font("Arial", Font.BOLD, 108);

    public static void main (String[] args)
    {
        TicTacToe ticFrame = new TicTacToe();
        final int SIZE = 600;
        ticFrame.setSize(SIZE, SIZE);
        ticFrame.setVisible(true);
    } // END MAIN

    public void TieGameTrigger()
    {
        int result = JOptionPane.showConfirmDialog(null,"No moves remain which can result in a win... Play again?", "Game Over", JOptionPane.YES_NO_OPTION);
        if (result == JOptionPane.YES_OPTION)
        {
            for (x = 0; x < NUM; ++x)
            {
                button[x].setEnabled(true);
                button[x].setBackground(color1);
                button[x].setForeground(color1);
                button[x].setText("");
            }
            moveCounter = 0;
        }
        else
            System.exit(0);
    }

    public void PlayerWinCondition()
    {
        if ((       button[0].getText() == "X" && button[1].getText() == "X" && button[2].getText() == "X") || (button[3].getText() == "X" && button[4].getText() == "X" && button[5].getText() == "X")
                || (button[6].getText() == "X" && button[7].getText() == "X" && button[8].getText() == "X") || (button[0].getText() == "X" && button[3].getText() == "X" && button[6].getText() == "X")
                || (button[1].getText() == "X" && button[4].getText() == "X" && button[7].getText() == "X") || (button[2].getText() == "X" && button[5].getText() == "X" && button[8].getText() == "X")
                || (button[0].getText() == "X" && button[4].getText() == "X" && button[8].getText() == "X") || (button[2].getText() == "X" && button[4].getText() == "X" && button[6].getText() == "X"))
        {
            gameOver = true;
            int result = JOptionPane.showConfirmDialog(null,"You Win! Play again? This time the O's will go first!", "Winner Winner Chicken Dinner!", JOptionPane.YES_NO_OPTION);
            if (result == JOptionPane.YES_OPTION)
            {
                for (x = 0; x < NUM; ++x)
                {
                    button[x].setEnabled(true);
                    button[x].setBackground(color1);
                    button[x].setText("");
                    gameOver = true;
                    moveCounter = 1;
                }
            }
            else
                System.exit(0);
        }
    }

    public void CPUWinCondition()
    {
        if ((       button[0].getText() == "O" && button[1].getText() == "O" && button[2].getText() == "O") || (button[3].getText() == "O" && button[4].getText() == "O" && button[5].getText() == "O")
                || (button[6].getText() == "O" && button[7].getText() == "O" && button[8].getText() == "O") || (button[0].getText() == "O" && button[3].getText() == "O" && button[6].getText() == "O")
                || (button[1].getText() == "O" && button[4].getText() == "O" && button[7].getText() == "O") || (button[2].getText() == "O" && button[5].getText() == "O" && button[8].getText() == "O")
                || (button[0].getText() == "O" && button[4].getText() == "O" && button[8].getText() == "O") || (button[2].getText() == "O" && button[4].getText() == "O" && button[6].getText() == "O"))
        {
            int result = JOptionPane.showConfirmDialog(null,"You Lose! Play again?", "Better Luck Next Time!", JOptionPane.YES_NO_OPTION);
            if (result == JOptionPane.YES_OPTION)
            {
                for (x = 0; x < NUM; ++x)
                {
                    button[x].setEnabled(true);
                    button[x].setBackground(color1);
                    button[x].setText("");
                    gameOver = true;
                    moveCounter = 1;
                }
            }
            else
                System.exit(0);
        }
    }

    public TicTacToe()
    {
        super("Tic Tac Toe by Dave Minkowski");
        add(background);
        background.setBackground(color1);

        for (x = 0; x < NUM; ++x)               // iterate through x squares in an 6 X 6 grid
        {
            button[x] = new JButton();
            button[x].addActionListener(this);
            background.add(button[x]);
            button[x].setBackground(color1);
        }
        setDefaultCloseOperation(EXIT_ON_CLOSE);
    } // END TICTACTOE

    public boolean isAvailable(int buttonNum)
    {
        if (button[buttonNum].isEnabled())
            return true;
        else
            return false;
    }

    public void actionPerformed(ActionEvent event) {
        JButton userClick = (JButton) event.getSource();
        userClick.setFont(bigFont);
        userClick.setText("X");
        userClick.setEnabled(false);
        PlayerWinCondition();
        do {
            ++moveCounter;
            System.out.println("MOVE COUNTER " + moveCounter);

            int cpuChoice = rng.nextInt(button.length);
            if (!isAvailable(cpuChoice)) {
                if (moveCounter < button.length ) {
                    do {
                        rng = new Random();
                        cpuChoice = rng.nextInt(button.length);
                    }
                    while (!isAvailable(cpuChoice));
                    if (isAvailable(cpuChoice)) {
                        button[cpuChoice].setFont(bigFont);
                        button[cpuChoice].setText("O");
                        button[cpuChoice].setEnabled(false);
                        CPUWinCondition();
                        if (gameOver == false)
                            ++moveCounter;
                        System.out.println("MOVE COUNTER " + moveCounter);
                    }
                }
                else
                    TieGameTrigger();
            }
            else
                {
                    if (moveCounter < button.length)
                    {
                        button[cpuChoice].setFont(bigFont);
                        button[cpuChoice].setText("O");
                        button[cpuChoice].setEnabled(false);
                        CPUWinCondition();
                        if (gameOver == false)
                            ++moveCounter;
                        System.out.println("MOVE COUNTER " + moveCounter);
                    }
                    else
                        TieGameTrigger();
                }
        }
        while (gameOver = false);

    } // END ACTION PERFORMED
} // END CLASS
