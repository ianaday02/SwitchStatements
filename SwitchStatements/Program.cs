using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a good one! I like it");
                    break;
                case "science":
                    Console.WriteLine("That's nice, I have always found Science a bit challenging though");
                    break;
                case "english":
                    Console.WriteLine("English is definitely an important one to learn");
                    break;
                case "history":
                    Console.WriteLine("Cool! History is challenging to me");
                    break;
                case "computer science":
                    Console.WriteLine("My type of person! I love Computer Science");
                    break;
                default:
                    Console.WriteLine($"That's interesting, {favSubject} is good to know");
                    break;
            }
        }
    }
}

