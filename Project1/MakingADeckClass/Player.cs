using System;
using System.Collections.Generic;

namespace MakingADeckClass
{
    public class Player
    {
        public string Name { get; set; }
        public Queue<Card> Deck { get; set; }

        public int score;

        public Player()
        {
        }
    }
}
