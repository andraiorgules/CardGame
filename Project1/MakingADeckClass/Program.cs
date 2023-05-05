using System;
using System.Collections.Generic;
/*
 * Card Games
 * Andrada Iorgulescu, March 6, 2022
 * Credits
 * - Shuffle code adapted from https://stackoverflow.com/questions/273313/randomize-a-listt  
   - Card class was built with tutoring help from Karen Spriggs (tutor).
   - PrintDeck and AddCard methods in Deck class were also built with help from Karen Spriggs (tutor).
 */


namespace MakingADeckClass
{
    class Program 
    {
        static void Main(string[] args)
        {
            string Title = "Card Games";
            Console.WriteLine(Title);

            new Application();


            //new Deck();
            Console.ReadKey();
        }
    }
}
