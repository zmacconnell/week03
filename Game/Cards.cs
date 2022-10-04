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


        public int Shuffle(string playersChoice, int previousCard)
        {
            Random rnd = new Random();
            _value = rnd.Next(1,13);
            if (_value < previousCard && playersChoice == "l")
            {
                _points = 100;
            }
            else if (_value > previousCard && playersChoice == "h")
            {
                _points = 100;
            }
            else
            {
                _points = -75;
            }
            return _value;
        }
    }
}