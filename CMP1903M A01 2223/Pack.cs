using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack;

        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for ( int i = 1; i <= 4; i++)
            {
                for ( int j = 1; j <= 13; j++)
                {
                    pack.Add(new Card(i, j));
                }
            }
            Console.WriteLine("Pack made");
        }

        public static Card dealCard()
        {
            //Deals one card
            if (pack.Count > 0)
            {
                Card card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            else 
            {
                return null;
            }

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List <Card> list = new List<Card>();
            for ( int i = 0; i < amount; i++ )
            {
                Card card = dealCard();
                if (card != null )
                {
                    cards.Add(card);
                }
                else
                {
                    break;
                }
            }
            return cards;
        }
    }

    public List<Card> GetPack()
    {
        return pack;
    }
}
