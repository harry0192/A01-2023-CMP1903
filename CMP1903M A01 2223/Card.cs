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
            string valueStri;
            switch (Value)
            {
                case 1:
                    valueStri = "Ace";
                    break;
                case 2:
                    valueStri = "2";
                    break;
                case 3:
                    valueStri = "3";
                    break;
                case 4:
                    valueStri = "4";
                    break;
                case 5:
                    valueStri = "5";
                    break;
                case 6:
                    valueStri = "6";
                    break;
                case 7:
                    valueStri = "7";
                    break;
                case 8:
                    valueStri = "8";
                    break;
                case 9:
                    valueStri = "9";
                    break;
                case 10:
                    valueStri = "10";
                    break;
                case 11:
                    valueStri = "Jack";
                    break;
                case 12:
                    valueStri = "Queen";
                    break;
                case 13:
                    valueStri = "King";
                    break;
                default:
                    valueStri = " ";
                    break;
            }

            string suitStri;
            switch (Suit)
            {
                case 1:
                    suitStri = "Spades";
                    break;
                case 2:
                    suitStri = "Clubs";
                    break;
                case 3:
                    suitStri = "Diamonds";
                    break;
                case 4:
                    suitStri = "Hearts";
                    break;
                default:
                    suitStri = " ";
                    break;
            }

            return valueStri + " of " + suitStri;
        }

        
    }
}
