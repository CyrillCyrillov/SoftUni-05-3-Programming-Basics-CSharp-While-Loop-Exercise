using System;
using System.Diagnostics.CodeAnalysis;

namespace Task06_Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOne = int.Parse(Console.ReadLine());
            int sizeTwo = int.Parse(Console.ReadLine());
            int cakeSize = sizeOne * sizeTwo;
            string nextPieces = " ";
            int sum = 0;
            while (nextPieces != "STOP")
            {
                nextPieces = Console.ReadLine();
                if (nextPieces != "STOP")
                {
                    int nextPiecesDigit = int.Parse(nextPieces);
                    sum += nextPiecesDigit;
                }
                if (sum > cakeSize)
                {
                    Console.WriteLine($"No more cake left! You need {(sum - cakeSize)} pieces more.");
                    break;
                }
            }
            if (nextPieces == "STOP")
            {
                Console.WriteLine($"{(cakeSize - sum)} pieces are left.");
            }
        }
    }
}
