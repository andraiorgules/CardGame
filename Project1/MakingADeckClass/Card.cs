using System;


namespace MakingADeckClass
{
    public class Card 
    {
        public int Value;
        public string Suit;


        public void PrintCard()
        {
            if (Value == 10)
            {
                Console.WriteLine($"Jack of {Suit}");
            }
            else
            {
                if (Value == 11)
                {
                    Console.WriteLine($"Queen of {Suit}");
                }
                else
                {
                    if (Value == 12)
                    {
                        Console.WriteLine($"King of {Suit}");
                    }
                    else
                    {
                        if (Value == 13)
                        {
                            Console.WriteLine($"Ace of {Suit}");
                        }
                        else
                        {
                            Console.WriteLine($"{Value} of {Suit}");
                        }
                    }
                }
            }
        }

        public Card(int _Value, string _Suit)
        {
            Value = _Value;
            Suit = _Suit;
        }
    }

    public enum Suits
    {
        Spades,
        Clubs,
        Hearts,
        Diamonds
    }

}
