using System;
using System.Collections.Generic;


namespace Week03Game
{
    public class Director
    {
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;
        string playersChoice = "";
        int currentCard = 0;
        Cards card = new Cards();

        public Director()
        {
            card.Shuffle();
            currentCard = card._value;
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
            playersChoice = Console.ReadLine();
        }

        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            int previousCard = currentCard;
            card.Shuffle();
            currentCard = card._value;
            card.Points(playersChoice, currentCard, previousCard);
            _score = card._points;
            _totalScore += _score;
        }

        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The card was: {card._value}");
            Console.WriteLine($"Your score is: {_totalScore}\n");
            if (_totalScore < 0)
            {
                _totalScore = 0;
            }
            _isPlaying = (_totalScore > 0);
        }
    }
}