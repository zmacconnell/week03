using System;
using System.Collections.Generic;


namespace Week03Game
{
    public class Director
    {
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        public void GetInputs()
        {
            Console.WriteLine($"The card is {currentCard}");
            Console.Write("Higher or lower? ");
            string playerChoice = Console.ReadLine();
        }
    }

}