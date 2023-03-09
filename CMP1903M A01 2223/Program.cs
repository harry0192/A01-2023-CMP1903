using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            Console.WriteLine("Welcome");
            Console.WriteLine("The deck has ", pack.GetPack().Count, " cards \n");
            

            bool run = true;
            while (run)
            {
                bool valid = false;
                int shuffleType = 0;
                while (!valid)
                {
                    Console.WriteLine("Choose type of shuffle:");
                    Console.WriteLine("Fisher-Yates Shuffle(1), ");
                    Console.Write("Riffle Shuffle(2), ");
                    Console.Write("No Shuffle(3), ");
                    Console.Write("Quit(4)");
                    Console.Write('\n');
                    shuffleType = int.Parse(Console.ReadLine());
                    if (shuffleType >= 1 && shuffleType <= 4)
                    {
                        valid = true;
                    } 
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }

                }
                

                if (shuffleType == 1)
                {
                    Console.WriteLine("Fisher-Yates Shuffle");
                    run = true;

                }
                else if (shuffleType == 2)
                {
                    Console.WriteLine("Riffle Shuffle");
                    run = true;

                }
                else if (shuffleType == 3)
                {
                    Console.WriteLine("No shuffle");
                    run = true;
                }
                else if (shuffleType == 4)
                {
                    Console.WriteLine("Quiting");
                    run = false;
                }

                if (shuffleType != 4)
                {
                    int choice;
                    Console.WriteLine("Deal 1 or 5 cards?");
                    choice = int.Parse(Console.ReadLine());
                    if (choice == 1)
                    {
                        Card dealtCard = pack.dealCard();
                        Console.WriteLine("Card dealt is: ", dealtCard.GetCard());
                    }
                    else if (choice == 5)
                    {
                        List<Card> dealtCards = pack.dealCard(5);
                        
                        
                        
                    }
                    
                }
                

            } 
        }
    }
}
