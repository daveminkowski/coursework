import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.Random;

/***********************************************************************************************
 Name:		    David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Final Project 2
 Date:			08/02/2018
 Description:   This program moves a symbol (representing a mouse) across a layout of 48 JButtons
                which act responsively to user clicking, notifying the user if they've "caught"
                the symbol at the right time. This game keeps track of successful and unsuccessful
                attempts, includes a difficulty adjustment and randomization of movement for the
                mouse "sprite".

 Assignment:    Create a game that helps new mouse users improve their hand-eye coordination.
                Within a JFrame, display an array of 48 JPanels in a GridLayout using eight rows
                and six columns. Randomly display an X on one of the panels. When the user clicks
                the correct panel (the one displaying the X), remove the X and display it on a
                different panel. After the user has successfully hit the correct panel 10 times,
                display a congratulatory message that includes the user’s percentage (hits divided
                by clicks). Save the file as JCatchTheMouse.java.

 Additionally:  •Use 48 JButtons instead of an array of 48 JPanels.
                •Once the user clicks on the tenth correct button, display your name, course, section
                number, and MEID by using a JOptionPane message dialog.
 ************************************************************************************************/

public class JCatchTheMouse extends GameBoardMaker implements ActionListener {

    private final String EMPTY_TILE = "O";
    private final String THAT_DANG_MOUSE = "8►";                    // I used a more visible symbol rather than an X, but this is an easy fix if mandatory
    private final int NUM_OF_BUTTONS = 48;
    private final int MAX_CATCHES = 10;

    private int MOVEMENT_DELAY;                                     // tune this for movement speed (milliseconds between each move)
    private int catches = 0;
    private int escapes = 0;

    private JButton[] buttons = new JButton[NUM_OF_BUTTONS];
    private Timer timer;

    private JMenu difficultyMenu = new JMenu("Change Difficulty");
    private JMenuItem easyMode = new JMenuItem("1. Easy mode");
    private JMenuItem normalMode = new JMenuItem("2. Normal mode (Default)");
    private JMenuItem hardMode = new JMenuItem("3. Hard mode");
    private JMenuItem insaneMode = new JMenuItem("4 It's OK, I'm actually a cat!");

    public static void main(String[] args) {
        new JCatchTheMouse(1000);
    }

    private JCatchTheMouse(int difficulty)
    {
        setMouseSpeed(difficulty);
        setTitle("Catch the Mouse by Dave Minkowski");
        setJMenuBar(mainBar);

        mainBar.add(fileMenu);
        fileMenu.add(aboutLink);
        fileMenu.add(resetLink);
        fileMenu.add(exitLink);
        aboutLink.addActionListener(this);
        resetLink.addActionListener(this);
        exitLink.addActionListener(this);

        mainBar.add(difficultyMenu);
        difficultyMenu.add(easyMode);
        difficultyMenu.add(normalMode);
        difficultyMenu.add(hardMode);
        difficultyMenu.add(insaneMode);
        easyMode.addActionListener(this);
        normalMode.addActionListener(this);
        hardMode.addActionListener(this);
        insaneMode.addActionListener(this);

        add(mainPanel);

        mainPanel.add(topPanel, BorderLayout.NORTH);      // for the title and description
        mainPanel.add(mousePanel, BorderLayout.CENTER);     // for the game buttons
        mainPanel.add(mouseGameBottomPanel, BorderLayout.SOUTH);      // for the status text

        topPanel.add(title);
        title.setPreferredSize(nsDimensions);
        title.setFont(bigFont);
        title.setHorizontalAlignment(JLabel.CENTER);
        title.setText("Catch The Mouse! 8►");
        topPanel.add(description);
        description.setFont(mediumFont);
        description.setHorizontalAlignment(JLabel.CENTER);
        description.setText("Click on him before he gets away again!");


        mouseGameBottomPanel.add(statusLabel);
        statusLabel.setPreferredSize(nsDimensions);
        statusLabel.setFont(bigFont);
        statusLabel.setHorizontalAlignment(JLabel.CENTER);
        statusLabel.setText("Try to catch him " + MAX_CATCHES + " times!");

        for (int i = 0; i < NUM_OF_BUTTONS; i++)
        {
            buttons[i] = new JButton(EMPTY_TILE);
            buttons[i].setFont(bigFont);
            buttons[i].addActionListener(this);
            buttons[i].setBackground(Color.WHITE);
            buttons[i].setForeground(Color.BLACK);
            buttons[i].setBorder(BorderFactory.createEmptyBorder(0,0,0,0));
            mousePanel.add(buttons[i]);
        }

        timer = new Timer(MOVEMENT_DELAY, this);
        timer.setInitialDelay(MOVEMENT_DELAY);
        timer.start();

        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
    }

    // uses randomizer to dictate mouse movement on the buttons
    private void mouseMovement()
    {
        timer.restart();
        int index = randomizeMouseMovement();

        for (int i = 0; i < NUM_OF_BUTTONS; ++i)
        {
            buttons[i].setText(EMPTY_TILE);
            if (i == index)
            {
                buttons[i].setText(THAT_DANG_MOUSE);
                buttons[i].setBackground(Color.WHITE);
                buttons[i].setForeground(Color.BLACK);
            }
        }
    }

    private int setMouseSpeed(int delayInMilliseconds)
    {
        MOVEMENT_DELAY = delayInMilliseconds;
        return MOVEMENT_DELAY;
    }

    // random number generator for the mouse movement
    private int randomizeMouseMovement()
    {
        Random rng = new Random();
        return rng.nextInt(NUM_OF_BUTTONS);
    }

    private void resetGame()
    {
        catches = 0;
        escapes = 0;
        mouseMovement();
    }

    @Override
    public void actionPerformed(ActionEvent event)
    {
        Object source = event.getSource();

        if (source == aboutLink)
        {
            JOptionPane.showMessageDialog(null, aboutString);
        }
        else if(source == resetLink)
        {
            this.dispose();
            new JCatchTheMouse(1000);
        }
        else if (source == exitLink)
        {
            System.exit(0);
        }
        else if (source == timer)
        {
            mouseMovement();
        }
        else if(source == easyMode)
        {
            this.dispose();
            new JCatchTheMouse(1500);
        }
        else if (source == normalMode)
        {
            this.dispose();
            new JCatchTheMouse(1000);
        }
        else if (source == hardMode)
        {
            this.dispose();
            new JCatchTheMouse(500);
        }
        else if (source == insaneMode)
        {
            this.dispose();
            new JCatchTheMouse(250);
        }
        else
        {
            JButton button = (JButton)event.getSource();
            int percentAccuracy;
            boolean caughtTheMouse = false;

            if (button.getText().equals(THAT_DANG_MOUSE))
            {
                catches++;
                statusLabel.setText("You caught the mouse " + catches + " times!");
                for (int i = 0; i < NUM_OF_BUTTONS; i++)
                {
                    buttons[i].setBackground(Color.WHITE);
                    buttons[i].setForeground(Color.BLACK);
                }
                caughtTheMouse = true;
            }
            else
            {
                button.setBackground(Color.RED);
                button.setForeground(Color.WHITE);
                escapes++;
            }

            if (catches == MAX_CATCHES)
            {
                percentAccuracy = (int) Math.round(catches / (double) (escapes + catches) * 100);
                JOptionPane.showMessageDialog(null, "Good Job! \nYou clicked with " + percentAccuracy + "% accuracy!\nThe mouse escaped your grasp " + escapes + " times.\n" +
                        "\n\n                                        Catch the Mouse!" +
                        "\n\n" + aboutString + "\n\n");
                resetGame();
                statusLabel.setText("Try to catch him " + MAX_CATCHES + " times!");
            }
            else if (caughtTheMouse == true)
            {
                button.setBackground(Color.GREEN);
                button.setForeground(Color.WHITE);
                mouseMovement();
            }
        }

    }
}
