using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            Console.WriteLine("Welcome");
            Console.WriteLine();

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
                    

                }
                shuffleType = Console.Read();

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

            } 
        }
    }
}
