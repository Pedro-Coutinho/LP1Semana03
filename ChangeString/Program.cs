using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a string");
            string inputString = Console.ReadLine();
            Console.WriteLine("\nGive me a character");
            char inputChar;
            char.TryParse(Console.ReadLine(), out inputChar);

            string newString = "";
            foreach (char c in inputString)
            {
                if (c != inputChar)
                    newString = newString + c;
            }

            Console.WriteLine(newString);
        }
    }
}
