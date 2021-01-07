using System;

namespace Task02_Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxBadGrades = int.Parse(Console.ReadLine());
            int badGrades = 0;
            double sum = 0;
            int numberOfTasks = 0;
            string nextTask = " ";
            string lastTask = " ";
            while (true)
            {
                nextTask = Console.ReadLine();
                if (nextTask == "Enough")
                {
                    break;
                }
                int nextGrade = int.Parse(Console.ReadLine());
                numberOfTasks += 1;
                sum += nextGrade;
                lastTask = nextTask;
                if (nextGrade <= 4)
                {
                    badGrades += 1;
                }
                if (badGrades == maxBadGrades)
                {
                    Console.WriteLine($"You need a break, {badGrades} poor grades.");
                    break;
                }
                
            }
            if (nextTask == "Enough")
            {
                Console.WriteLine($"Average score: {(sum / numberOfTasks):F2}");
                Console.WriteLine($"Number of problems: {numberOfTasks}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
