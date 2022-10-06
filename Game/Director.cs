using System;
using System.Collections.Generic;


namespace HiLoGame
{
    public class Director
    {
        bool _isPlaying = true;
        int _score = 0;
        int _totalScore = 300;
        string playersChoice = "";
        int currentCard = 0;
        string currentSuit = "";
        int rounds = 0;
        int correctAnswers = 0;
        Deck card = new Deck();

        public Director()
        {
            card.Shuffle();
            currentCard = card._value;
            currentSuit = card._suit;
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        public void StartGame()
        {
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }
        /// <summary>
        /// Gathers inputs from user and prints current card.
        /// </summary>
        public void GetInputs()
        {
            Console.WriteLine($"The card is the {currentCard} of {currentSuit}");
            Console.Write("Higher or lower? ");
            playersChoice = Console.ReadLine();
        }
        /// <summary>
        /// Updates the game.
        /// </summary>

        public void DoUpdates()
        {
            if (!_isPlaying)
            {
                return;
            }

            int previousCard = currentCard;
            card.Shuffle();
            currentCard = card._value;
            currentSuit = card._suit;
            card.Points(playersChoice, currentCard, previousCard);
            _score = card._points;
            _totalScore += _score;
            rounds += card._rounds;
            correctAnswers += card._correctAnswers;
        }
        /// <summary>
        /// Prints outputs for the user, decides if the game is over due to 0 points.
        /// </summary>
        public void DoOutputs()
        {
            if (!_isPlaying)
            {
                return;
            }

            Console.WriteLine($"The card was: {card._value} of {card._suit}");
            Console.WriteLine($"Your points: {_totalScore}\n");
            Console.WriteLine($"Your overall score is: {rounds / correctAnswers}%");
            if (_totalScore < 0)
            {
                _totalScore = 0;
            }
            _isPlaying = (_totalScore > 0);
            if (_isPlaying)
            {
                Console.Write("Play again (y/n)? ");
                string playAgain = Console.ReadLine();
                if (playAgain.ToUpper() == "N")
                {
                    _isPlaying = false;
                }
            }
        }
    }
}