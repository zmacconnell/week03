using System;
using System.Collections.Generic;


namespace Week03Game
{
    public class Director
    {
        Cards currentCard = new Cards();
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;
        string playersChoice = "";

        public Director()
        {
            Cards card = new Cards();
        }

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
            string playersChoice = Console.ReadLine();
        }

        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            _score += card._points;
            _totalScore += _score;
        }

        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The card was: {values}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            _isPlaying = (_score > 0);
        }
    }
}