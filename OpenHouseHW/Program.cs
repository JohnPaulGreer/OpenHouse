using System;

namespace OpenHouseHW
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my open house!");
            Console.WriteLine();

            if (UI.UserAnswersYes("Would you like to view the kitchen?"))
            {
                Console.WriteLine("The kitchen has nice, granite counters.");
                Console.WriteLine("The floor is tile.");

                if (UI.UserAnswersYes("Would you like to inspect the refrigerator?"))
                {
                    Console.WriteLine("The fridge is cold, and the freezer is colder.");
                }
            }

            if (UI.UserAnswersYes("Would you like to view the living room?"))
            {
                Console.WriteLine("The living room has a 70 inch tv.");
                Console.WriteLine("There is new furnature.");
                Console.WriteLine("There is also a working fireplace.");
            }

            if (UI.UserAnswersYes("Would you like to view the master bedroom?"))
            {
                Console.WriteLine("This is the master bedroom, it is one of the two bedrooms in the home.");
                Console.WriteLine("The master includes hardwood floors.");

                if (UI.UserAnswersYes("It also includes a walk in closet. Would you like to see?"))
                {
                    Console.WriteLine("The closet is very spacious.");
                }
            }

            if (UI.UserAnswersYes("Would you like to view the bathroom?"))
            {
                Console.WriteLine("This is the master bath.");
                Console.WriteLine("It includes Jack and Jill sink.");
                Console.WriteLine("There is a jacuzzi tub.");
            }

            if (UI.UserAnswersYes("Would you like to view the next bedroom?"))
            {
                Console.WriteLine("This room is slightly smaller, but still large enough to have a King size bed.");
                
                if (UI.UserAnswersYes("This bedroom also includes a large window. Would you like to see the view?"))
                {
                    Console.WriteLine("You can see the pool in the backyard.");
                }
            }

            if (UI.UserAnswersYes("Would you like to view the basement?"))
            {
                Console.WriteLine("Are you sure?");
                
                if (UI.UserAnswersYes("Are you sure?"))
                {
                    Console.WriteLine("Well follow me...");
                    Console.WriteLine();
                    Console.WriteLine("Game Over. Try Again.");
                }
            }
        }
    }
}
