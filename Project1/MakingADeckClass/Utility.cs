using System;
using System.Collections.Generic;
using System.Linq;


namespace MakingADeckClass
{
    public class Utility 
    {
        public static string choice = "";

        public void GetPlayerChoice()
        {
            Console.WriteLine("Please enter your choice.");
            choice = Console.ReadLine();
            choice = choice.ToLower();
            Print($"You have chosen {choice}");
        }

        public void Pause()
        {
            Console.WriteLine("Paused... Press any key to continue...");
            Console.ReadKey();
        }

        public void Print(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
