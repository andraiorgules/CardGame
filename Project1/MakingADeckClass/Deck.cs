using System;
using System.Collections.Generic;
using System.Linq;

namespace MakingADeckClass
{
    public class Deck : Utility
    {
        List<Card> Cards = new List<Card>();
        int deckSize = 52;
        Random random = new Random();
        private int currentCard;


        public Deck()
        {
            AddCard();
            Shuffle(Cards);
        }

        public void PrintDeck()
        {
            foreach (Card C in Cards)
            {
                C.PrintCard();
            }
        }

        public void AddCard()
        {
            for (int i = 1; i <= 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    string suit = "";

                    if (j == 0)
                    {
                        suit = "Spades";
                    }

                    if (j == 1)
                    {
                        suit = "Clubs";
                    }

                    if (j == 2)
                    {
                        suit = "Hearts";
                    }

                    if (j == 3)
                    {
                        suit = "Diamonds";
                    }

                    Cards.Add(new Card(i, suit));
                }
            }
        }

        public void DrawCard() 
        {
            Card drawnCard = Cards[Cards.Count - 1];
            Console.WriteLine($"{drawnCard.Value} {drawnCard.Suit}");
        }

        public void RemoveCard()
        {
            Card drawnCard = Cards[Cards.Count - 1];

            if (Cards.Contains(drawnCard))
            {
                Cards.Remove(drawnCard);
            }
        }

        public void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public void ApplesOrOranges() //needs to be played with 26 cards and 2 suits
        {
            Player player = new Player();
            bool keepPlaying = true;
            while (keepPlaying)
            {
                ApplesOrOranges1Round(player);
                Print("Continue? Press 1 for yes, enter anything else for no.");
                string input = Console.ReadLine();
                keepPlaying = (input == "1");
            }
        }

        public void ApplesOrOranges1Round(Player player)
        {
            Print($"{player.score}");
            Print("The first card drawn is:");
            DrawCard();
            RemoveCard();
            Print("Will the next card be the same suit or a different one? Enter 1 for same, 2 for different:");
            GetPlayerChoice();
            Print("Next card drawn is:");
            DrawCard();
            RemoveCard();

            if (Cards[0].Suit == Cards[1].Suit)
            {
                if (Utility.choice == "1")
                {
                    Print("You guessed correct and gained a point!");
                    player.score++;
                    Print($"Score:{player.score}");
                }
                if (Utility.choice == "2")
                {
                    Print("You did not gain a point.");
                    Print($"Score:{player.score}");
                }
            }
            if (Cards[0].Suit != Cards[1].Suit)
            {
                if (Utility.choice == "1")
                {
                    Print("You did not gain a point.");
                    Print($"Score:{player.score}");
                }
                if (Utility.choice == "2")
                {
                    Print("You guessed correct and gained a point!");
                    player.score++;
                    Print($"Score:{player.score}");
                }
            }
        }

        public void HigherOrLower()
        {
            Player player = new Player();
            bool keepPlaying = true;
            while (keepPlaying)
            {
                HigherOrLower1Round(player);
                Print("Continue? Press 1 for yes, enter anything else for no.");
                string input = Console.ReadLine();
                keepPlaying = (input == "1");
            }
        }

        public void HigherOrLower1Round(Player player)
        {
            Print($"{player.score}");
            Print("The first card drawn is:");
            DrawCard();
            RemoveCard();
            Print("Will the next card be a higher or lower value? Enter 1 for higher, 2 for lower:");
            GetPlayerChoice();
            Print("Next card drawn is:");
            DrawCard();
            RemoveCard();

            if (Cards[0].Value < Cards[1].Value)
            {
                if (Utility.choice == "1")
                {
                    Print("You did not gain a point.");
                    Print($"Score:{player.score}");
                }
                if (Utility.choice == "2")
                {
                    Print("You guessed correct and gained a point!");
                    player.score++;
                    Print($"Score:{player.score}");
                }
            }
            if (Cards[0].Value > Cards[1].Value)
            {
                if (Utility.choice == "1")
                {
                    Print("You guessed correct and gained a point!");
                    player.score++;
                    Print($"Score:{player.score}");
                }
                if (Utility.choice == "2")
                {
                    Print("You did not gain a point.");
                    Print($"Score:{player.score}");
                }
            }
        }

        public void HighestMatch()
        {
            Player player = new Player();
            bool keepPlaying = true;
            while (keepPlaying)
            {
                HighestMatch1Round(player);
                Print("Continue? Press 1 for yes, enter anything else for no.");
                string input = Console.ReadLine();
                keepPlaying = (input == "1");
            }
        }

        public void HighestMatch1Round(Player player)
        {
            //draw 4 cards for player's hand
            //draw 4 cards for NPC's hand
            //print player's hand of cards
            //DO NOT print NPC's hand of cards
            //ask if they want to compare their hand to NPC's hand or swap a card
            //allow them to swap cards 10 times before forcing them to compare to NPC
            //when comparing player's hand to NPC's hand -> check which cards have the same suit + add their values together (do for both player and NPC's hands)
            //if there are no 2 cards of the same suit -> use the value of the highest card when comparing
            //
        }

    }
}

