
/***********************************************************************************************
 Name:			David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

public class Card {

    // one of the suits form enum Suit
    private Suit cardSuit;

    // numeric representation of card rank..ace = 1, jack-king are 11-13 (for the switch statement)
    private int cardRank;

    public Card(Suit aSuit, int aRank)
    {
        // this. emphasizes access fo class (Card) properties. Could be written without .this
        this.cardRank = aRank;
        this.cardSuit = aSuit;

        if (aRank >= 1 && aRank <=13)
        {
            this.cardRank = aRank;
        }
        else
        {
            System.err.println(aRank + " is an invalid Rank");
            System.exit(1);
        }
    }

    public int getCardRank()
    {
        return cardRank;
    }

    public String toString()
    {
        String rankString = "";

        // array of card ranks
        String[] ranks = {"A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"};

        switch(this.cardRank)
        {
            case 1:
                rankString = ranks[0];
                break;
            case 2:
                rankString = ranks[1];
                break;
            case 3:
                rankString = ranks[2];
                break;
            case 4:
                rankString = ranks[3];
                break;
            case 5:
                rankString = ranks[4];
                break;
            case 6:
                rankString = ranks[5];
                break;
            case 7:
                rankString = ranks[6];
                break;
            case 8:
                rankString = ranks[7];
                break;
            case 9:
                rankString = ranks[8];
                break;
            case 10:
                rankString = ranks[9];
                break;
            case 11:
                rankString = ranks[10];
                break;
            case 12:
                rankString = ranks[11];
                break;
            case 13:
                rankString = ranks[12];
                break;

        }
        return rankString + " of " + cardSuit.toString();
    }

}
