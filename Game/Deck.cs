using System;

namespace Week03Game
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
        }

        /// <summary>
        /// Calculates points based on playersChoice, currentCard, and previousCard
        /// </summary>
        public void Points(string playersChoice, int currentCard, int previousCard)
        {
            if (currentCard < previousCard && playersChoice.ToLower() == "L")
            {
                _points = 100;
            }
            else if (currentCard > previousCard && playersChoice.ToUpper() == "H")
            {
                _points = 100;
            }
            else
            {
                _points = -75;
            }
        }
    }
}