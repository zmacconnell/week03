using System;

namespace Week03Game
{
    public class Cards
    {
        public int _points = 0;
        public int _value = 0;
        public Cards()
        {
            
        }


        public void Shuffle()
        {
            Random rnd = new Random();
            _value = rnd.Next(1,13);
        }

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