
/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 8 Project
 Date:			    07/14/2018
 Description:	    This program plays a basic version of blackjack against an Random() generated
                    dealer with options to hit, stay and reset (deal) the game.
 ************************************************************************************************/

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class Blackjack extends JFrame implements ActionListener {

    private Player player = new Player("Player");
    private Player dealer = new Player("Dealer");

    private Deck theDeck;

    JButton hitButton = new JButton("Hit Me!");
    JButton stayButton = new JButton("Stay");
    JButton dealButton = new JButton("Reset");

    JLabel status = new JLabel("");

    Font bigFont = new Font("Arial", Font.BOLD, 40);
    Dimension buttonSize = new Dimension(150, 50);

    public Blackjack()
    {
        // frame properties
        setTitle("Project 8: Blackjack by Dave Minkowski");
        setResizable(false);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
        setSize(600, 200);

        //  button controls
        // Stay Button
        stayButton.addActionListener(this);
        stayButton.setEnabled(false);
        setLayout(new BorderLayout());
        add(stayButton, BorderLayout.WEST);
        stayButton.setPreferredSize(buttonSize);
        stayButton.setFont(bigFont);
        // Hit Button
        hitButton.setEnabled(false);
        add(hitButton, BorderLayout.CENTER);
        hitButton.setPreferredSize(buttonSize);
        hitButton.addActionListener(this);
        hitButton.setFont(bigFont);
        // ResetButton
        dealButton.addActionListener(this);
        add(dealButton, BorderLayout.EAST);
        dealButton.setPreferredSize(buttonSize);
        dealButton.setFont(bigFont);

        add(status, BorderLayout.SOUTH);
        status.setFont(bigFont);


    }

    private void deal()
    {
        theDeck = new Deck(true);
        player.dealCard(theDeck.dealNextCard());
        dealer.dealCard(theDeck.dealNextCard());
        player.dealCard(theDeck.dealNextCard());
        dealer.dealCard(theDeck.dealNextCard());
        System.out.println("Cards have been dealt!");
        System.out.println(" ");

        dealer.showHand(false);
        player.showHand(true);
        status.setText("Value of your hand: " + player.getHandValue());
        repaint();
    }
    private void hit (Player player)
    {
        player.dealCard(theDeck.dealNextCard());
        player.showHand(true);
        dealer.showHand(false);
        status.setText("Value of your hand: " + player.getHandValue());
        repaint();
    }

    private void checkWinner()
    {
        player.showHand(true);
        dealer.showHand(true);
        if (player.getHandValue() > dealer.getHandValue() && player.getHandValue() <= 21 || dealer.getHandValue() > 21)
        {
            System.out.println("YOU WIN!");
            status.setText("YOU WIN!!");
            System.out.println("\n");
        }
        else
        {
            System.out.println("DEALER WINS!");
            status.setText("Dealer Wins :(");
            System.out.println( "\n");
        }
    }

    public void actionPerformed(ActionEvent e)
    {
        if (e.getSource() == hitButton)
        {
            hit(player);
            if (player.getHandValue() > 21)
            {
                status.setText("Value of your hand: " + player.getHandValue());
                checkWinner();
                hitButton.setEnabled(false);
                stayButton.setEnabled(false);
                dealButton.setEnabled(true);
                repaint();
            }
        }
        else if (e.getSource() == stayButton)
        {
            while(dealer.getHandValue() < 17)
                hit(dealer);
            status.setText("Value of your hand: " + player.getHandValue());
            checkWinner();
            hitButton.setEnabled(false);
            stayButton.setEnabled(false);
            dealButton.setEnabled(true);
            repaint();

        }
        else if (e.getSource() == dealButton)
        {
            System.out.println("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            player.discardHand();
            dealer.discardHand();
            deal();
            hitButton.setEnabled(true);
            stayButton.setEnabled(true);
            repaint();
        }

    }

    public static void main(String[] args)
    {
        new Blackjack();
    }

    public void paintComponent(Graphics g)
    {
        super.paintComponents(g);
    }
}
