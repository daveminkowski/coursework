import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.ItemEvent;
import java.awt.event.ItemListener;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;

/***********************************************************************************************
 Name:		    David Minkowski
 Course:		CIS 263AA - Summer 2018 - Class: 11755
 Assignment:    Final Project 1
 Date:			08/02/2018
 Description:	This program allows a user to make 5 lottery selections. The submit button will be
                disabled until the user check 5 boxes, then the boxes will be set to disabled.
                A loop will gather the values that the user entered into the checkboxes, compare
                those numbers to 5 randomly generated numbers (out of 50) and notify the user of
                how many matches they've picked.

 Assignment:    In Chapter 5, you created a lottery game application. Create a similar game
                using check boxes. For this game, generate six random numbers, each between 0
                and 30 inclusive. Allow the user to choose six check boxes to play the game.
                (Do not allow the user to choose more than six boxes.) After the player has
                chosen six numbers, display the randomly selected numbers, the player’s numbers,
                and the amount of money the user has won.

 Additionally:  Add a menu bar to the program with a File menu.
                •In the File menu, add a submenu (JMenuItem) called About.
                •When the user clicks on the About menu item, display a JOptionPane message dialog
                that contains your name, your course, the section number, and MEID.
 ************************************************************************************************/

public class Lottery extends GameBoardMaker implements ActionListener, ItemListener {

    public static void main(String[] args) {
        new Lottery();
    }

    private final static int NUM_OF_USER_PICKS = 6;
    private final static int MAX_PICK_POOL = 30;
    private ArrayList<JCheckBox> checkBoxArrayList = new ArrayList<>();

    private int[] winningNumbers = generateWinningNumbers(); // gets winning numbers, generated randomly at runtime (instead of when pressing submit) so I can test the win conditions
    private int lottoSelections = 0;

    private String statusString = "Please select " + (NUM_OF_USER_PICKS - lottoSelections) + " more numbers.";
    private String userChoicesString, winningNumbersString;

    private JCheckBox[] checkBox = new JCheckBox[MAX_PICK_POOL];

    private JMenuItem showLotteryLink = new JMenuItem("Show Winning Numbers?");
    private JMenu showLottery = new JMenu("Cheater Mode");

    Lottery()
    {
        setTitle("Lottery by Dave Minkowski");
        setJMenuBar(mainBar);

        mainBar.add(fileMenu);
        fileMenu.add(aboutLink);
        fileMenu.add(resetLink);
        fileMenu.add(exitLink);
        aboutLink.addActionListener(this);
        resetLink.addActionListener(this);
        exitLink.addActionListener(this);

        mainBar.add(showLottery);
        showLottery.add(showLotteryLink);
        showLotteryLink.addActionListener(this);

        add(mainPanel);

        mainPanel.add(topPanel, BorderLayout.NORTH);      // for the title and description
        mainPanel.add(lottoPanel, BorderLayout.CENTER);   // for the checkboxes
        mainPanel.add(lottoBottomPanel, BorderLayout.SOUTH);      // for the status text and submit button

        topPanel.add(title);
        title.setPreferredSize(nsDimensions);
        title.setFont(bigFont);
        title.setHorizontalAlignment(JLabel.CENTER);
        title.setText("Lottery Picker!");
        topPanel.add(description);
        description.setFont(mediumFont);
        description.setHorizontalAlignment(JLabel.CENTER);
        description.setText("Select 6 lottery numbers then press submit to check if you've won!");

        lottoBottomPanel.add(submitButton);
        submitButton.setPreferredSize(buttonDimension);
        submitButton.addActionListener(this);
        submitButton.setFont(bigFont);
        submitButton.setText("Submit");
        submitButton.setEnabled(false);
        lottoBottomPanel.add(statusLabel);
        statusLabel.setPreferredSize(nsDimensions);
        statusLabel.setFont(bigFont);
        statusLabel.setText(statusString);
        statusLabel.setHorizontalAlignment(JLabel.CENTER);

        for (int i = 0; i < MAX_PICK_POOL; i++)
        {
            checkBox[i] = new JCheckBox(Integer.toString(i+1));
            checkBoxArrayList.add(checkBox[i]);
            checkBox[i].setFont(bigFont);
            checkBox[i].addItemListener(this);
            lottoPanel.add(checkBox[i]);
        }

        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setVisible(true);
    }

    public int[] getUserLottoPicks()
    {
        int[] lottoPicks = new int[NUM_OF_USER_PICKS];
        int pickMax = NUM_OF_USER_PICKS;
        for (int i = 0; i < MAX_PICK_POOL; ++i) {
            if (checkBox[i].isSelected()) {
                --pickMax;
                lottoPicks[pickMax] = Integer.parseInt(checkBox[i].getText());
                checkBox[i].setSelected(false);
            }
        }

        Arrays.sort(lottoPicks);
        userChoicesString = Arrays.toString(lottoPicks);
        return lottoPicks;
    }

    private int[] generateWinningNumbers()
    {
        Integer[] numberList = new Integer[MAX_PICK_POOL];   // will be the randomized range of numbers to pick from
        int[] lottery = new int[NUM_OF_USER_PICKS];                // will hold the winning numbers

        //fill initial array from 1 - the max pick value (30 for this project)
        for (int i = 0; i < MAX_PICK_POOL; i++) {
            numberList[i] = (i + 1);
        }
        // shuffle the array of numbers
        Collections.shuffle(Arrays.asList(numberList));

        // set the first (j) elements of the shuffled array to the first (j) elements of the lottery array
        for (int j = 0; j < NUM_OF_USER_PICKS; j++) {
            lottery[j] = numberList[j];
        }

        Arrays.sort(lottery);
        winningNumbersString = Arrays.toString(lottery);
        return lottery;
    }

    private int compareArrays(int[] winningNumbers, int[] userNumbers)
    {

        int sameNum = 0;

        for (int i = 0; i < NUM_OF_USER_PICKS; i++) {

            for (int x = 0; x < NUM_OF_USER_PICKS; x++) {

                if (winningNumbers[i] == userNumbers[x]) {
                    sameNum++;
                }
            }
        }
        return sameNum;
    }

    public void winConditions()
    {
        int numOfMatchingPicks = compareArrays(winningNumbers, getUserLottoPicks());
        String prize;

        submitButton.setText("Your Picks: " + userChoicesString);
        description.setText("Winning Numbers: " + winningNumbersString);
        description.setFont(bigFont);
        description.setForeground(Color.red);
        switch (numOfMatchingPicks)
        {
            case 6:  prize = "6 Matches!!! YOU WIN $1,000,000!!!";
                statusLabel.setText(prize);
                break;
            case 5:  prize = "5 Matches!!! YOU WIN $50,000!!";
                statusLabel.setText(prize);
                break;
            case 4:  prize = "4 Matches!!! YOU WIN $10,000!!";
                statusLabel.setText(prize);
                break;
            case 3:  prize = "3 Matches!!! YOU WIN $100!!";
                statusLabel.setText(prize);
                break;
            case 2:  prize = "2 Matches... But no cash prize :(";
                statusLabel.setText(prize);
                break;
            case 1:  prize = "1 Match... But no cash prize :(";
                statusLabel.setText(prize);
                break;
            case 0:  prize = "No matching numbers - better luck next time!";
                statusLabel.setText(prize);
                break;
            default: prize = "Program logic should never reach this point.";
        }
        submitButton.setEnabled(false);
    }

    @Override
    public void actionPerformed(ActionEvent event)
    {
        Object source = event.getSource();

        if (source == submitButton)
        {
            winConditions();
        }

        else if (source == aboutLink)
        {
            JOptionPane.showMessageDialog(null, aboutString);
        }
        else if (source == resetLink)
        {
              this.dispose();
              new Lottery();
        }
        else if (source == exitLink)
        {
            System.exit(0);
        }
        else if (source == showLotteryLink) {
            JOptionPane.showMessageDialog(null, "The winning numbers are...\n" + winningNumbersString);
        }
    }

    @Override
    public void itemStateChanged(ItemEvent e)
    {
        Object source = e.getItemSelectable();

        for (int i = 0; i < MAX_PICK_POOL; i++)
        {
            if (source == checkBox[i])
            {
                int selected = e.getStateChange();
                if (selected == ItemEvent.SELECTED)
                {
                    if (lottoSelections == NUM_OF_USER_PICKS - 1)
                    {
                        submitButton.setEnabled(true);
                        lottoSelections++;
                        statusString = "Press submit to see if you've won!";
                        statusLabel.setText(statusString);
                        for (int j = 0; j < MAX_PICK_POOL; j++)
                        {
                            checkBox[j].setEnabled(false);
                        }
                    }
                    else {
                        lottoSelections++;
                        statusString = "Please select " + (NUM_OF_USER_PICKS - lottoSelections) + " more numbers.";
                        statusLabel.setText(statusString);
                    }
                }
                else {
                    lottoSelections--;
                    statusString = "Please select " + (NUM_OF_USER_PICKS - lottoSelections) + " more numbers.";
                    statusLabel.setText(statusString);
                }
            }

        }
    }

}
