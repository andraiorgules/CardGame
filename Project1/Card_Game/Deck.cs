using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Got help from Mcdonald Duncan

namespace Card_Game
{
    class Deck
    {
        //int deckSize = 52;
        //int suitNumber = 4;
        //Used examples in making a deck on Canvas
        List<Card> Cards = new List<Card>();
        public string[] Suits = { "Diamond", "Hearts","Clubs","Spades" };
        public int deckSize = 52;
        public int suitNumber = 4;
        public void SetUpDeck()
        {

            //foreach (string suit in Suits)
            //{
            //    for (int i = 1; i <= deckSize / suitNumber; i++)
            //    {

            //        Cards.Add(new Card() { Value = i, Suit = suit });
            //        //Console.WriteLine($"{i} of {Suits[0]}");
            //    }
            //}
            for(int i = 0; i < suitNumber; i++)
            {
                string suit = Suits[i];//i reading as 4??

                for (int s = 1; s <= deckSize / suitNumber; s++)
                {

                    Cards.Add(new Card() { Value = s, Suit = suit });
                }
            }

            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.Suit} {card.Value}\n");
            }
            
        }



        List<Card> shuffleCards = new List<Card>();
    public void Shuffle()
        {
            Random random = new Random();
            
            

            for(int i = 1; i <= Cards.Count; i++)
            {
                int shuffleIndex = random.Next(Cards.Count) - 1;
                shuffleCards.Add(Cards[shuffleIndex]);
                Cards.Remove(Cards[shuffleIndex]);
            }
            //Make sure player can guess card when being draw
            //Make sure to give them a point if they guess right

        }

        public void Dealer()
        {
            //if (Carddealer = Deck)
            //return deck(Carddealer)
        }
    }
}
