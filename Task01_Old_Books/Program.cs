using System;

namespace Exersice05
{
    class Program
    {
        static void Main(string[] args)
        {
            string lookedBook = Console.ReadLine();
            int n = 0;
            string nextBook = " ";
            while (nextBook != lookedBook)
            {
                nextBook = Console.ReadLine();
                if (nextBook == "No More Books")
                {
                    break;
                }
                n += 1;
            }
            if (nextBook == "No More Books")
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {n} books.");
            }
            else
            {
                Console.WriteLine($"You checked {n - 1} books and found it.");
            }
        }
    }
}
