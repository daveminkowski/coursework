
/***********************************************************************************************
 Name:			David Minkowski
 Course:			CIS 263AA - Summer 2018 - Class: 11755
 Assignment:		Lesson 1 Project
 Date:			05/22/2018
 Description:	This program outputs basic info to the console while exhibiting fundamentals of
 user created classes and inheritance
 ************************************************************************************************/

import java.util.Random;

public class Deck {

    // an array of card objects in the deck. Top card of the deck is the first index of the array
    // "an array of cards is a deck"
    private Card[] deck;
    // private ArrayList<Card> deck2; look into array lists?

    // an int to hold the count of cards REMAINING in the deck once a card has been drawn
    private int numberOfCardsInDeck = 52;

    // allow for multiple decks to be used?
    private final int NUM_OF_DECKS = 1;

    // boolean to determine if we want the deck shuffled when the deck constructor is called
    // add int NUM_OF_DECKS to constructor?

    public Deck() // default constructor
    {
        // for constructor that uses multiple decks parameter:
        // this (1, false)
        this(false);
    }

    public Deck(boolean shuffleDeck)
    {
        // to allow for multiple decks to be used:
        // this.totalNumOfCards = NUM_OF_DECKS * NUM_OF_CARDS_IN_DECK
        // each item in the array is a Card... total number of Card objects  = NUM_OF_CARDS_IN_DECK (52)
        this.deck = new Card[numberOfCardsInDeck]; // or new Card[this.totalNumOfCards] for multiple decks?

        int deckIndex = 0;
        // iterate through num of decks
        for (int d = 0; d < NUM_OF_DECKS; d++)
        {
            // iterate through each SUIT
            for (int s = 0; s < 4; s++)
            {
                // iterate through each RANK
                for (int r = 1; r <= 13; r++ )
                {
                    // add a card to the deck with a suit and a rank, index the enum at Suit[s] and passing the value of both suit and rank to the Card class constructor
                    // which takes parameters (Suit aSuit and int aRank)
                    this.deck[deckIndex] = new Card(Suit.values()[s], r);
                    deckIndex++;
                }
            }
        }
        // if shuffle boolean is true, shuffle the deck
        if (shuffleDeck)
        {
            this.shuffleDeck();
        }
    }

    public void shuffleDeck()
    {
        Random cardRandomizer = new Random();

        // card swap
        Card tempCard;
        int tempValue;

        for (int i = 0; i < this.numberOfCardsInDeck; i++)
        {
            tempValue = cardRandomizer.nextInt(this.numberOfCardsInDeck);
            tempCard = this.deck[i];
            this.deck[i] = this.deck[tempValue];
            this.deck[tempValue] = tempCard;
        }
    }

    // deal top card of the deck
    public Card dealNextCard()
    {
        // top card is the first card in the array of card objects
        Card topCard = this.deck[0];

        // iterate through all the remaining cards in the deck and shift them in the array (simulating removal)
        for (int i = 1; i < this.numberOfCardsInDeck; i++)
        {
            // set the value of the deck[index-1] to the value of the current index of i ---> deck[0] is assigned the valued of deck[1], deck[1] gets the value of deck[2]
            // the card that was at deck[0] (which is now the value of topCard) is assigned a new value
            this.deck[i-1] = this.deck[i];
        }
        // give null value to the last index in the array, since all other values were "moved over" by 1
        this.deck[this.numberOfCardsInDeck-1] = null;
        // then decrement the number of cards in the deck so that when this step repeats again, the array is 1 int smaller each time, ensuring removal.
        this.numberOfCardsInDeck--;
        // then return the value stored in topCard.
        return topCard;
    }

}
