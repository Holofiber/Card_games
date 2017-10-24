using System;

namespace SoliterBusinessLogic
{
    public class Card
    {
        public Rank Rank { get; private set; }

        public  Suit Suit { get; private set; }

        public Card(Rank rank, Suit suit)
        {
            this.Suit = suit;
            this.Rank = rank;

        }

        public static Card AceOfHearts => new Card(Rank.Ace, Suit.Hearts);
        public static Card AceOfDiamonds => new Card(Rank.Ace, Suit.Diamonds);
        public static Card AceOfClovers => new Card(Rank.Ace, Suit.Clovers);
        public static Card AceOfPikes => new Card(Rank.Ace, Suit.Pikes);

        public static Card TwoOfHearts => new Card(Rank.Ace, Suit.Hearts);
        public static Card TwoOfDiamonds => new Card(Rank.Ace, Suit.Diamonds);
        public static Card TwoOfClovers => new Card(Rank.Ace, Suit.Clovers);
        public static Card TwoOfPikes => new Card(Rank.Ace, Suit.Pikes);

        public static Card ThreeOfHearts => new Card(Rank.Ace, Suit.Hearts);
        public static Card ThreeOfDiamonds => new Card(Rank.Ace, Suit.Diamonds);
        public static Card ThreeOfClovers => new Card(Rank.Ace, Suit.Clovers);
        public static Card ThreeOfPikes => new Card(Rank.Ace, Suit.Pikes);

        public static Card FourOfHearts => new Card(Rank.Ace, Suit.Hearts);
        public static Card FourOfDiamonds => new Card(Rank.Ace, Suit.Diamonds);
        public static Card FourOfClovers => new Card(Rank.Ace, Suit.Clovers);
        public static Card FourOfPikes => new Card(Rank.Ace, Suit.Pikes);

        public static Card FiveOfHearts => new Card(Rank.Ace, Suit.Hearts);
        public static Card FiveOfDiamonds => new Card(Rank.Ace, Suit.Diamonds);
        public static Card FiveOfClovers => new Card(Rank.Ace, Suit.Clovers);
        public static Card FiveOfPikes => new Card(Rank.Ace, Suit.Pikes);











        public static Card KingOfHearts => new Card(Rank.King, Suit.Hearts);
        public static Card KingOfClovers => new Card(Rank.King, Suit.Clovers);


        //public override string ToString()
        //{
        //    return $"{Rank} of {Suit}";
        //}
        
        public override string ToString()
        {
            string suitLetter = null;

            switch (Suit)
            {
                case Suit.Clovers:
                    suitLetter = "♣";
                    break;

                case Suit.Diamonds:
                    suitLetter = "♦";
                    break;

                case Suit.Hearts:
                    suitLetter = "♥";
                    break;

                case Suit.Pikes:
                    suitLetter = "♠";
                    break;
            }

            return $"{Rank}{suitLetter}" ;
        }
    }
}
