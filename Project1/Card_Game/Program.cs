using System;
//Got help from Duncan, Mack and Grace
namespace Card_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Player1 = new Player();
            int MyInt = Utility.GetInput();
            Console.WriteLine(MyInt);

            Deck deck = new Deck();
            deck.SetUpDeck();
            //Used examples in making a deck
            //string[] Suits = { "Apple", "Oranges" };
            //int deckSize = 52;
            //int suitNumber = 4;
            //for (int i = 1; i <= deckSize / suitNumber; i++);
            //{
             

            //    //Console.WriteLine($"{i} of {Suits[0]}");
            //}
        }


        //public void Blackjack()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void War()
        //{
        //    throw new System.NotImplementedException();
        //}

        //public void CrazyEights()
        //{
        //    throw new System.NotImplementedException();
        //}
    }
}
