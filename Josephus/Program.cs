using System;
using System.Collections.Generic;

namespace Josephus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of people");
            var numberOfPeople = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the killing interval.  You monster.");
            var killingInterval = Int32.Parse(Console.ReadLine());
            var people = new List<int>();
            var killCounter = 0;
            for (var i = 1; i <= numberOfPeople; i++)
            {
                people.Add(i);
            }

            void killTheNumbers()
            {
                    for (var i = 0; i < killingInterval; i++)
                    {
                        killCounter++;
                        if (killCounter > people.Count)
                        {
                            killCounter = 1;
                        }
                    }
                people.RemoveAt(killCounter - 1);
                killCounter--;
                if (people.Count > 1)
                {
                    killTheNumbers();
                } else
                {
                    Console.WriteLine($"The last man (or woman) standing is number {people[0]}");
                }
            }

            killTheNumbers();
            Console.ReadLine();
        }
    }
}
