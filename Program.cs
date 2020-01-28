using System;

namespace Lab3_1
{
    class Program
    {

        static string[] names = new string[]
           {
                "Alpha", "Bravo", "Charlie", "Delta", "Echo",
                "Foxtrot", "Gulf", "Helo", "India", "Juliet"
           };

        static string[] food = new string[]
        {
                "Almond Joy", "Butterfinger", "Chocolate", "Dots", "EXTRA",
                "Fundip", "Gummies", "Hot Tamales", "Ice Breaker", "Jaawbreaker"
        };

        static string[] previous = new string[]
        {
                "Accountant", "Banker", "Carpet Cleaner", "Dance Teacher", "Economist",
                "Firefighter", "Games Programmer", "Helicopter Pilot", "Illustrator", "Judge"
        };
        static void Main(string[] args)
        {
            GetInput();
        }

        private static void GetInput()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine((i + 1) + "\t" + names[i]);
            }
            Console.Write("Please enter a number for the student you wish to view. [1-10]");
            string input = Console.ReadLine();
            Verify(input);
        }

        private static void Verify(string input)
        {
            bool worked = int.TryParse(input, out int output);

            if (worked && output <= names.Length && output >= 1)
            {
                Select(names[output - 1], food[output - 1], previous[output - 1]);
            }
            else
            {
                Console.WriteLine("That student does not exist.  Please try again.");
                GetInput();
            }

            
        }


        private static void Select(string name, string food, string previous)
        {
            Console.WriteLine("What would you like to see about " + name + "?  'Food' or 'Previous Job'?");
            string input = Console.ReadLine().ToLower();
            if (input == "food")
            {
                Console.WriteLine(name + " likes " + food);
                Console.WriteLine("");
                Proceed();
            }
            else if (input == "previous job")
            {
                Console.WriteLine(name + " used to be a(n) " + previous);
                Console.WriteLine("");
                Proceed();
            }
            else
            {
                Console.WriteLine("That option does not exist.  Please try again.");
                Select(name, food, previous);
            }
        }
        private static void Proceed()
        {
            Console.Write("Would you like to go again?  Y/N:  ");
            string response = Console.ReadLine();
            response = response.ToLower();
            if (response == "y")
            {
                Console.Clear();
                GetInput();
            }
            else if (response == "n")
            {
                System.Environment.Exit(0);

            }

            else
            {
                Console.WriteLine("That input was invalid.  Please try again.");
                Proceed();
            }
        }
    }
}
