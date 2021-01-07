using System;

namespace Task04_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            while (true)
            {
                string nextInput = Console.ReadLine();
                if (nextInput == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    sum += lastSteps;
                    if (sum >= 10000)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{(sum - 10000)} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{(10000 - sum)} more steps to reach goal.");
                        break;
                    } 
                }
                int nextSteps = int.Parse(nextInput);
                sum += nextSteps;
                if (sum >= 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{(sum - 10000)} steps over the goal!");
                    break;
                }
            }
        }
    }
}
