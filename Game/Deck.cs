using System;
using System.Collections.Generic;

namespace HiLoGame
{
    /// <summary>
    /// Creates a 'deck of cards' that can be shuffles and return a value between 1 and 13.
    /// 
    /// Shuffle returns value between 1 and 13. 
    /// Points returns how many points earned from correct or incorrect guess. 
    /// </summary>
    public class Deck
    {
        public int _points = 0;
        public int _value = 0;
        public string _suit = "";
        public float _rounds = 0;
        public float _correctAnswers = 0;
        public Deck()
        {
            
        }

        /// <summary>
        /// Shuffles and draws a new card, _value between 1 and 13
        /// </summary>
        public void Shuffle()
        {
            Random rnd = new Random();
            _value = rnd.Next(1,13);
            var suits = new List<string>{"Diamonds","Hearts","Spades","Clubs"};
            int index = rnd.Next(suits.Count);
            _suit = (suits[index]);
        }

        /// <summary>
        /// Calculates points based on playersChoice, currentCard, and previousCard
        /// </summary>
        public void Points(string playersChoice, int currentCard, int previousCard)
        {
            if (currentCard < previousCard && playersChoice.ToUpper() == "L")
            {
                _points = 100;
                _correctAnswers += 1;
            }
            else if (currentCard > previousCard && playersChoice.ToUpper() == "H")
            {
                _points = 100;
                _correctAnswers += 1;
            }
            else
            {
                _points = -75;
            }
            _rounds += 1;
        }
    }
}