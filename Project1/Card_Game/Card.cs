using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    class Card
    {


        public int Value;
        public string Suit;

        public int CardValue
        {
            get => default;
            set
            {
            }
        }

        public int PlayerValue
        {
            get => default;
            set
            {
            }
        }

        public void CardNumber()
        {
            throw new System.NotImplementedException();
        }

        public void PlayerNumber()
        {
            throw new System.NotImplementedException();
        }

        public void PlayersName()
        {
            throw new System.NotImplementedException();
        }
    }
}
