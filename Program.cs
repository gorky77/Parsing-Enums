using System;

namespace DayOfWeekEnumApp
{
    // Create an enum for the days of the week
    public enum DaysOfTheWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.WriteLine("Please enter the current day of the week:");

                // Read the input and convert it to the enum type
                string userInput = Console.ReadLine();
                DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);

                // Output the entered day
                Console.WriteLine("You entered: " + day);
            }
            catch (Exception)
            {
                // If an error occurs, print an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
