using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Game
{
   static class Utility
    {
        public static int GetInput()
        {
            int number = 0;
            string Input = Console.ReadLine();
            try
            {
                number = Int16.Parse(Input);

            }
            catch
            {
                Console.WriteLine("Please enter a number");
                GetInput();
            }
            return number;
        }

        //A method that clears the screen
    }
}
