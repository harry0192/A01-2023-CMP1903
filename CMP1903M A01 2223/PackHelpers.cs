using System;

internal static class PackHelpers
{

    public static bool ShuffleCardPack(int typeOfShuffle)
    {
        //Shuffles the pack based on the type of shuffle
        if (typeOfShuffle == 1)
        {
            Console.WriteLine("Doing the Fisher-Yates Shuffle...");

            return true;
        }
        else if (typeOfShuffle == 2)
        {
            Console.WriteLine("Doing the Riffle Shuffle...");
            return true;
        }
        else if (typeOfShuffle == 3)
        {
            Console.WriteLine("No Shuffle...");
            return true;
        }
    }
}