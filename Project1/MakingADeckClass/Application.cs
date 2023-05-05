using System;


namespace MakingADeckClass
{
    public class Application : Utility
    {
        public Application()
        {
            Menu();
        }

        public void Menu()
        {
            Print("Menu");
            Print("Apples or Oranges?");
            Print("Higher or Lower?");
            Print("Highest Match");
            Print("Show Credits");
            GetPlayerChoice();
            if (Utility.choice == "apples or oranges")
            {
                LoadSuitGame();
            }
            if (Utility.choice == "higher or lower")
            {
                LoadValueGame();
            }
            if (Utility.choice == "highest match")
            {
                LoadMatchingGame();
            }
            if (Utility.choice == "show credits")
            {
                ShowCredits();
                Console.ReadKey();
            }
            else
            {
                Menu();
            }

            Menu(); //player gets taken back to the menu after ShowCredits is done AND/OR LoadGames are done
        }

        public void LoadSuitGame()
        {
            Game game = new Game();
            Deck deck = new Deck();
            game.ShowInstructions($"A card will be drawn from a shuffled deck and displayed to you. " +
                $"You must then guess if the suit of the next card will be the same as, or different from, the last. " +
                $"For every correct guess, you will gain one point."); 
            Console.ReadKey();
            deck.ApplesOrOranges();
        }

        public void LoadValueGame()
        {
            Game game = new Game();
            Deck deck = new Deck();
            game.ShowInstructions($"A card will be drawn from a shuffled deck and displayed to you. " +
                $"You must then guess whether the next card will have a higher or lower value than the last. " +
                $"For each correct guess, you will gain one point. " +
                $"If the value of the card is the same, but is of a different suit, you will not receive the point.");
            Console.ReadKey();
            deck.HigherOrLower();
        }

        public void LoadMatchingGame()
        {
            Game game = new Game();
            Deck deck = new Deck();
            game.ShowInstructions($"You have 10 rounds to collect cards that have the same suit and the highest values. " +
                $"You can discard one card per turn, and gain one card per turn. At the end of 10 rounds, the game will look at your cards. " +
                $"If you have a set of the same suit that (in total) has a higher value than the dealer's, you win.");
            Console.ReadKey();
            
        }

        public void ShowCredits() 
        {
            Print($"Created by Andrada Iorgulescu with the use of the Game Framework instructions on the Programming 201 Canvas page. " +
                    $"\n Shuffle code adapted from https://stackoverflow.com/questions/273313/randomize-a-listt " +
                    $"\n Card class was built with tutoring help from Karen Spriggs (tutor)." +
                    $"\n PrintDeck and AddCard methods in Deck class were also built with help from Karen Spriggs (tutor).");
        }
    }
}
