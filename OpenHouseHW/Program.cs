using System;

namespace OpenHouseHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my open house!");
            Console.WriteLine();

            Console.WriteLine("Would you like to view the kitchen?");
            string userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("The kitchen has nice, granite counters.");
                Console.WriteLine("The floor is tile.");
                Console.WriteLine("The kitchen has recently been remodeled.");

                Console.WriteLine("Would you like to inspect the refrigerator?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("The fridge is cold, and the freezer is colder.");
                }
            }

            Console.WriteLine("Would you like to view the living room?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("The living room has a 70 inch tv.");
                Console.WriteLine("There is new furnature.");
                Console.WriteLine("There is also a working fireplace.");
            }

            Console.WriteLine("Would you like to view the master bedroom?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("This is the master bedroom, it is one of the two bedrooms in the home.");
                Console.WriteLine("The master includes hardwood floors.");

                Console.WriteLine("It also includes a walk in closet. Would you like to see?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("The closet is very spacious.");
                }
            }

            Console.WriteLine("Would you like to view the bathroom?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("This is the master bath.");
                Console.WriteLine("It includes Jack and Jill sink.");
                Console.WriteLine("There is a jacuzzi tub.");
            }

            Console.WriteLine("Would you like to view the next bedroom?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("This room is slightly smaller, but still large enough to have a King size bed.");
                Console.WriteLine("This bedroom also includes a large window. Would you like to see the view?");
                userResponse = Console.ReadLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("You can see the pool in the backyard.");
                }
            }

            Console.WriteLine("Would you like to view the basement?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.WriteLine("Are you sure?");
                userResponse = Console.ReadLine();
                Console.WriteLine();

                if (userResponse == "yes")
                {
                    Console.WriteLine("Well follow me...");
                    Console.WriteLine();
                    Console.WriteLine("Game Over. Try Again.");
                }
            }





        }
    }
}
