import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.LinkedList;
import java.util.Random;

/***********************************************************************************************
 Name:		    David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Final Project 3
 Date:			08/05/2018
 Description:   This program emulates 7 face-down playing cards numbered 1-7 (not in order)
                but randomly distributed on the game board. The user will flip a card, and the
                value of the flipped card dictates the next "slot" of the card they MUST flip next.
                For example, if the user flips the second card in the line and it reveals itself
                as a 7, then the user must then flip the 7th card in line (left to right). The
                game is won when a used flips all 7 cards. This program will also keep track of
                wins and losses as long as the program is never exited (though it can be reset).

 Assignment:    Create an application that plays a card game named Lucky Seven. In real life,
                the game can be played with seven cards, each containing a number from 1 through
                7. The cards are shuffled and dealt number-side down. To start the game, a player
                turns over any card. The exposed number on the card determines the position
                (reading from left to right) of the next card that must be turned over. For example,
                if the player turns over the first card and its number is 7, the next card turned
                must be the seventh card (counting from left to right). If the player turns over a
                card whose number denotes a position that was already turned, the player loses the
                game. If the player succeeds in turning over all seven cards, the player wins.
                Instead of cards, you will use seven buttons on a JPanel. The buttons are labeled 1
                through 7 from left to right. Randomly associate one of the seven values 1 through 7
                with each button. (In other words, the associated value might or might not be
                equivalent to the button’s labeled value.) When the player clicks a button, reveal
                the associated hidden value. If the value represents the position of a button already
                clicked, the player loses. If the revealed number represents an available button,
                force the user to click it; that is, do not take any action until the user clicks the
                correct button. After a player clicks a button, remove the button from play.
                For example, a player might click Button 7, revealing a 4. Then the player clicks
                Button 4, revealing a 2. Then the player clicks Button 2, revealing a 7. The player
                loses because Button 7 was already used. Save the game as JLuckySeven.java.

 Additionally:  •Keep a tally that shows the number of games that the player has won, tied, or lost.
                •Use the drawString() method to display your name, course, section number, and MEID
                in the lower left-hand corner of the applet.
 ************************************************************************************************/

public class JLuckySeven extends GameBoardMaker implements ActionListener {

    private final int NUM_OF_CARDS = 7;

    private JButton[] buttons = new JButton[NUM_OF_CARDS];

    private int nextCard = -7;
    private int winCounter;
    private int lossCounter;

    private LinkedList<Integer> usedNumbers = new LinkedList();
    private LinkedList<Integer> flippedCardValues = new LinkedList();

    //private AboutPanel drawPanel = new AboutPanel();

    public static void main (String[] args) {
        new JLuckySeven();
    }

    public JLuckySeven()
    {
        repaint();
        setSize(WIDE_WIDTH, WIDE_HEIGHT);
        setTitle("Lucky Seven by Dave Minkowski");
        setJMenuBar(mainBar);

        mainBar.add(fileMenu);
        fileMenu.add(aboutLink);
        fileMenu.add(exitLink);
        aboutLink.addActionListener(this);
        exitLink.addActionListener(this);

        add(mainPanel);

        mainPanel.add(topPanel, BorderLayout.NORTH);      // for the title and description
        mainPanel.add(luckyPanel, BorderLayout.CENTER);     // for the game buttons
        mainPanel.add(luckyBottomPanel, BorderLayout.SOUTH);      // for the status text

        topPanel.add(title);
        title.setPreferredSize(buttonDimension);
        title.setFont(bigFont);
        title.setHorizontalAlignment(JLabel.CENTER);
        title.setText("Lucky Seven by Dave Minkowski");
        topPanel.add(description);
        description.setFont(mediumFont);
        description.setHorizontalAlignment(JLabel.CENTER);
        description.setText("Start by picking any card. The number revealed determines the next card you choose. Try to flip all 7.");

        luckyBottomPanel.add(submitButton);
        submitButton.setFont(bigFont);
        submitButton.setBackground(Color.white);
        submitButton.setForeground(Color.black);
        submitButton.setText("Reset Game");
        submitButton.setHorizontalAlignment(JLabel.CENTER);
        submitButton.setEnabled(false);
        submitButton.addActionListener(this);

        luckyBottomPanel.add(winLabel);
        luckyBottomPanel.setPreferredSize(luckyBottomDimension);
        winLabel.setFont(bigFont);
        winLabel.setHorizontalAlignment(JLabel.CENTER);
        winLabel.setText("Wins: 0");

        //luckyBottomPanel.add(drawPanel);

        luckyBottomPanel.add(lossLabel);
        lossLabel.setFont(bigFont);
        lossLabel.setHorizontalAlignment(JLabel.CENTER);
        lossLabel.setText("Losses: 0");

        for (int i = 0; i < NUM_OF_CARDS; i++)
        {
            buttons[i] = new JButton(Integer.toString(i+1));
            buttons[i].setFont(hugeFont);
            buttons[i].addActionListener(this);
            buttons[i].setBackground(Color.white);
            buttons[i].setForeground(Color.black);
            buttons[i].setName(String.valueOf(i));
            luckyPanel.add(buttons[i]);
            buttons[i].setEnabled(true);
        }

        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
    }


    private void resetGame()
    {
        nextCard = -7;
        title.setText("Lucky Seven by Dave Minkowski");
        title.setForeground(Color.black);
        description.setText("Start by picking any card. The number revealed determines the next card you choose. Try to flip all 7.");
        submitButton.setEnabled(false);

        for (int i = 0; i < NUM_OF_CARDS; i++)
        {
            luckyPanel.remove(buttons[i]);
            buttons[i] = new JButton(Integer.toString(i+1));
            buttons[i].setFont(hugeFont);
            buttons[i].addActionListener(this);
            buttons[i].setBackground(Color.white);
            buttons[i].setForeground(Color.black);
            buttons[i].setName(String.valueOf(i));
            luckyPanel.add(buttons[i]);
            buttons[i].setEnabled(true);
        }

        while (!usedNumbers.isEmpty()) {
            usedNumbers.removeFirst();
        }
        while (!flippedCardValues.isEmpty()) {
            flippedCardValues.removeFirst();
        }
    }

    @Override
    public void actionPerformed(ActionEvent event) {
        Object source = event.getSource();

        if (source == aboutLink) {
            JOptionPane.showMessageDialog(null, aboutString);
        }
        if (source == submitButton) {
            resetGame();
        }
        if (source  == exitLink) {
            System.exit(0);
        }

        if (source == buttons[0] || source == buttons[1] || source == buttons[2] || source == buttons[3] || source == buttons[4] || source == buttons[5] || source == buttons[6])
        {
            JButton flippedCard = (JButton) event.getSource();                   // to identify an un-"flipped" card...
            int flippedCardNumber = Integer.parseInt(flippedCard.getName());    // which will be used to get the "hidden" number of the card

            if (flippedCard.isEnabled() && (nextCard == -7 || nextCard == flippedCardNumber))   // if the button is enabled --- AND --- it's the first turn OR nextCard has been assigned a value (later in the loop)
            {
                flippedCardValues.add(flippedCardNumber);                       // add the NAME (position in the row/array, NOT the face value) of the clicked button to a list

                int randomCardNum;
                while (true)                                                 // infinite loop only breaks when...
                {
                    // generate a random card
                    randomCardNum = new Random().nextInt(NUM_OF_CARDS);
                    // if the LinkedList does not contain the random value...
                    if (!usedNumbers.contains(randomCardNum)) {
                        usedNumbers.add(randomCardNum);                     // ... a number is added to the LinkedList
                        break;                                              // ... and breaks the loop
                    } else {
                        continue;                                           // if the LinkedList contains the number, then keep looping
                    }
                }

                nextCard = randomCardNum;                                   // the value of nextCard is the number of the only card that will "work" when clicked

                if (flippedCardValues.contains(randomCardNum))                  // check each click if the NAME of the flipped card exists in the LinkedList
                {
                    title.setFont(hugeFont);
                    title.setText("YOU LOSE");
                    title.setForeground(Color.RED);// if the list contains that digit, you lose
                    for (int i = 0; i < NUM_OF_CARDS; i++)
                    {
                        buttons[i].setEnabled(false);
                        buttons[i].setBackground(Color.RED);
                    }
                    lossCounter++;
                    lossLabel.setText("Losses: " + lossCounter);
                    if (lossCounter < 2)
                    description.setText("That's only your first loss... Play Again?");
                    else description.setText("Nice Try. That's " + lossCounter + " losses so far. Play again?");
                    submitButton.setEnabled(true);

                }

                if (usedNumbers.size() == NUM_OF_CARDS)                     // if you successfully flip all the cards, you win
                {
                    title.setText("YOU WIN!");
                    for (int i = 0; i < NUM_OF_CARDS; i++)
                    {
                        buttons[i].setBackground(Color.YELLOW);
                    }
                    title.setForeground(Color.BLUE);
                    title.setFont(hugeFont);
                    winCounter++;
                    winLabel.setText("Wins: " + winCounter);
                    if (winCounter < 2)
                        description.setText("Nice work, but that's only your first win... Play Again?");
                    else description.setText("Well done ! That's " + winCounter + " wins so far ! Play Again?");
                    submitButton.setEnabled(true);
                }
                else
                    flippedCard.setText(Integer.toString(randomCardNum + 1)); // assign the value to the newly "exposed" side of the card

                flippedCard.setBackground(Color.GREEN);
                flippedCard.setEnabled(false);    // disable the button once it's clicked
            }
        }
    }
}
