using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        public int Value { get; set; }
        public int Suit { get; set; }

        public Card(int value, int suit)
        {
            Value = value;
            Suit = suit;
        }

        public string GetCard()
        {
            string valueStr;
            switch (Value)
            {
                case 1:
                    valueStr = "Ace";
                    break;
                case 2:
                    valueStr = "2";
                    break;
                case 3:
                    valueStr = "3";
                    break;
                case 4:
                    valueStr = "4";
                    break;
                case 5:
                    valueStr = "5";
                    break;
                case 6:
                    valueStr = "6";
                    break;
                case 7:
                    valueStr = "7";
                    break;
                case 8:
                    valueStr = "8";
                    break;
                case 9:
                    valueStr = "9";
                    break;
                case 10:
                    valueStr = "10";
                    break;
                case 11:
                    valueStr = "Jack";
                    break;
                case 12:
                    valueStr = "Queen";
                    break;
                case 13:
                    valueStr = "King";
                    break;
            }

            string suitStr;
            switch (Suit)
            {
                case 1:
                    suitStr = "Spades";
                    break;
                case 2:
                    suitStr = "Clubs";
                    break;
                case 3:
                    suitStr = "Diamonds";
                    break;
                case 4:
                    suitStr = "Hearts";
                    break;
            }

            return valueStr + " of " + suitStr;

        }
    }
}
