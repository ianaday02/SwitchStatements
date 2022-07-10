using System;

namespace SwitchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");

            var favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Math is a good one! I like it");
                    break;
                case "Science":
                    Console.WriteLine("That's nice, I have always found Science a bit challenging though");
                    break;
                case "English":
                    Console.WriteLine("English is definitely an important one to learn");
                    break;
                case "History":
                    Console.WriteLine("Cool! History is challenging to me");
                    break;
                case "Computer science":
                    Console.WriteLine("My type of person! I love Computer Science");
                    break;
                default:
                    Console.WriteLine($"That's interesting, {favSubject} is good to know");
                    break;
            }
        }
    }
}

