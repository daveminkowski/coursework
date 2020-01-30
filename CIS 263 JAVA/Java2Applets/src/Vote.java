/***********************************************************************************************
 Name:			    David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 9 Project
 Date:			    07/16/2018
 Description:	    This applet has 3 buttons allowing the user to vote on one of 2 candidates
                    and a third allowing the user to see the results of the election as votes are
                    tallied.
 ************************************************************************************************/

import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import javax.swing.JApplet;

public class Vote extends JApplet{

    int count1 = 0;
    int count2 = 0;
    int totalCount = 0;

    public void init()
    {
        setSize(300, 200);
        setLayout(new GridLayout(5, 1, 0, 3));
        Font bigfont = new Font("Arial", Font.BOLD, 20);

        JButton buttonVote1 = new JButton("Vote for Candidate 1");
        add(buttonVote1);
        buttonVote1.setFont(bigfont);

        JButton buttonVote2 = new JButton("Vote for Candidate 2");
        add(buttonVote2);
        buttonVote2.setFont(bigfont);

        JButton buttonSeeResults = new JButton("See Results");
        add(buttonSeeResults);
        buttonSeeResults.setFont(bigfont);
        buttonSeeResults.setEnabled(false);

        JLabel notify   = new JLabel("", SwingConstants.CENTER);
        notify.setFont(bigfont);
        add(notify);

        JLabel keepCount = new JLabel("Total Votes: 0", SwingConstants.CENTER);
        keepCount.setFont(bigfont);
        add(keepCount);

        buttonVote1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                count1++;
                totalCount++;
                buttonSeeResults.setEnabled(true);
                notify.setText("You voted for Candidate 1!");

                String counter = Integer.toString(totalCount);
                keepCount.setText("Total Votes: " + counter);
            }
        });
        buttonVote2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                count2++;
                totalCount++;
                buttonSeeResults.setEnabled(true);
                notify.setText("You voted for Candidate 2!");

                String counter = Integer.toString(totalCount);
                keepCount.setText("Total Votes: " + counter);
            }
        });
        buttonSeeResults.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String title = "Results of the election:";
                String message = "Candidate 1 has received " + count1 + " total vote(s). \nCandidate 2 has received " + count2 + " total vote(s).";
                count2++;
                JOptionPane.showMessageDialog(null, message, title, JOptionPane.INFORMATION_MESSAGE);
            }
        });

    }
}
