using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
    public class Application
    {
        Game game = new Game();

        public Application()
        {
            //Game game = new Game();

        }
        public void LoadGame()
        {
            //this will create an instance of a specific game
            //build out a switch case simiarly to menu, check with game was selected load that game
            //potentially make Blackjack and War seprate classed and child calsses of the Game class so...
            //To load the game you could do War war = new War();
        }
        public void Menu()
        {

            //code to handle displaying options to the player and allowing the player to choose one
            Console.WriteLine("1:Play Blackjack\n2:Play War\n3:Show Credits\n");
            int input = Utility.GetInput();
            if (input <= 3 && input >= 1)
            {
                switch (input)
                {
                    case 1:
                        game.Blackjack();
                        break;
                    case 2:
                        game.War();
                        break;
                    case 3:
                        ShowCredits();
                        break;

                }
                
            }
            else
            {
                Console.WriteLine("Please enter 1 2 or 3");
            }
            

        }
        public void ShowCredits()
        {
            //show the player the application's credits
            //such as name and any help gotten from either tutors or stackoverflow
        }
    }
}
