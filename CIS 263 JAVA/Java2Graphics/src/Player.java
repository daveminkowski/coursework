public class Player {

    private String name;
    // create an array of cards which will become your hand where the maximum amount of cards in your hand can be eleven - four aces, four 2's, four 3's = 21
    private final int MAX_HAND_SIZE = 11;
    private Card[] hand = new Card[MAX_HAND_SIZE];

    // num of cards in hand
    private int handSize;

    public Player(String playerName)
    {
        this.name = playerName;
        this.discardHand();
    }

    public void discardHand()
    {
        for (int i = 0; i < MAX_HAND_SIZE; i++)
        {
            this.hand[i] = null;
        }
        this.handSize = 0;
    }

    // deal a card if the players hand has fewer than the max num of cards and its value is less than or equal to 21
    public boolean dealCard(Card topCard)
    {
        // print error if we have max num of cards
        if (this.handSize == MAX_HAND_SIZE)
        {
            System.err.printf("%s's hand is full! Cannot deal any more cards to %s.", this.name);
            System.exit(1);
        }

        // add new card, increase counter
        this.hand[this.handSize] = topCard;
        this.handSize++;

        return (this.getHandValue() <= 21);
    }

    // get the sum of the value of the player's hand (ace = 11, face cards = 10, numeric cards = their value
    public int getHandValue()
    {
        int handSum = 0;
        int cardRank;
        int acesInHand = 0;

        //iterate through the cards in the player's hand
        for (int i = 0; i < this.handSize; i++)
        {
            // get rank(value) of current card
            cardRank = this.hand[i].getCardRank();

            // is the card an ace?
            if (cardRank == 1)
            {
                acesInHand++;
                handSum += 11;
            }
            // is the card a face card?
            else if (cardRank > 10)
            {
                handSum += 10;
            }
            else
            {
                handSum += cardRank;
            }
        }

        // if we have aces and sum is > 21, set some of the aces (or all fo them to a rank of 1)

        while (handSum > 21 && acesInHand > 0)
        {
            handSum -= 10;
            acesInHand--;
        }

        return handSum;
    }

    public void showHand(boolean showFirstCard)
    {
        System.out.printf("%s's cards:\n", this.name);
        for (int i = 0; i < this.handSize; i++)
        {
            if (i == 0 && !showFirstCard)
            {
                System.out.printf("  [hidden]");
            }
            else {
                System.out.printf("   %s\n", this.hand[i].toString());
            }
        }
    }
}
